using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace GradeACatering
{
    static class DataConnection
    {
        /*
         * ==================================================================================================
         * 
         *  Important Note!  On my machine this OLEDB connector ONLY worked when compiling for x64 platforms. 
         *  The program complained that no connector existed when building for Any CPU or x86.       - Dustin
         * 
         * ==================================================================================================
         */
       
        private static string connstr= "Provider = Microsoft.Ace.OLEDB.15.0;" + //may need to use version checking to make sure this doesn't hamstring anything.
                                       "Data Source = GradeACatering.accdb;"; //defaults, we can make these changeable later if needed
        private static OleDbConnection conn = new OleDbConnection(connstr);

        //use these functions to open and close the database, don't call conn.Open() or .Close() directly.
        public static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        public static void CloseConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Close();
        }
        /*
         * static class needs no constructor
         public DataConnection()
         {
             connstr = "Provider = Microsoft.Ace.OLEDB.15.0;" + //may need to use version checking to make sure this doesn't hamstring anything.
                        "Data Source = GradeACatering.accdb;"; //defaults, will make these changeable later.
             //conn.ConnectionString = connstr;
             conn = new OleDbConnection(connstr);
         }*/

        //functions to read and write things to the database will go here.

        public static string AddFoodStuff(FoodStuff fs, List<Recipe> ingredients)
        {
            //insert a foodstuff entry in the Foodstuff table
            //will use comma-delineated string for the tags
            try
            {
                string query = "insert into Foodstuff(FoodstuffID, Name, Directions, PrepTime, CookTime, Cost, Servings, Tags) values(?,?,?,?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.ID;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Name;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Directions;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.PrepTime;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.CookTime;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Cost;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Servings;
                //Comma-and-space delineated list of the tags.
                //When tokenizing or splitting tags, use ", " for the demarcation.
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.GetTags();

                DataConnection.OpenConnection();

                cmd.ExecuteNonQuery();

                foreach (Recipe r in ingredients)
                    AddRecipeItem(r);

                return "Item plus ingredients added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                DataConnection.CloseConnection();
            }
        }

        public static void UpdateFoodstuff(string fsID, int column, string newValue)
        {
            //need some way of identifying the column without passing in the name itself which might change.
            //an enum won't work since that's just a bit of code associated with an integer.

            //TODO:
            //verify the record exists, if it does then update the designated column with the new value.
            
        }

        public static string AddRecipeItem(Recipe r)
        {
            //insert a single recipe entry in the RecipeMaterials table
            try
            {
                string query = "insert into RecipeMaterials(Makes, MadeOf, Quantity, Unit) Values(?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Makes;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.MadeOf;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.FractionAmount();
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Unit;

                DataConnection.OpenConnection();

                cmd.ExecuteNonQuery();
                
                return "Item added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                DataConnection.CloseConnection();
            }
            
        }

        public static string AddRecipeItem(List<Recipe> rlist)
        {
            //functionally very similar to the individual insertion but can do more than one at a time.
           
            //MS Access does not allow compound insert queries without some really weird SQL involving unions
            //so repeatedly calling the loop below will do an insert, then clear the parameter list, refill it with
            //the next item in the list, run the insert again with the new parameters, and repeat (as necessary)
            try
            {
                /*
                 * these are unnecessary if the second option in the Foreach is used (read comments for details)
                 * In fact this entire try-catch statement might be unnecessary.
                 * 
                string query = "insert into RecipeMaterials(Makes, MadeOf, Quantity, Unit) Values(?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(query,conn);
                DataConnection.OpenConnection();
                 */
                foreach (Recipe r in rlist)
                {
                    //in hindsight I could just as easily called AddRecipeItem(Recipe r) for each element...
                    //this involves fewer steps so might be a tiny bit faster, though.
                    /*
                     * not using AddRecipeItem(Recipe r)
                     * 
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Makes;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.MadeOf;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.FractionAmount();
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Unit;
                    cmd.ExecuteNonQuery();
                    */

                    /*
                     * Using AddRecipeItem(Recipe r)
                     * to see if it has any noticeable performance impact.
                     */ 
                    AddRecipeItem(r);
                    //*/
                }      
                
                if(rlist.Count == 1)
                    return rlist.Count.ToString() + "item added.";
                else
                    return rlist.Count.ToString() + "items added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                DataConnection.CloseConnection();
            }
        }

        public static List<Recipe> ListOfIngredients(string makesID = "")
        {
            //find all recipe elements that go into the foodstuff with this ID
            //if no id given, returns contents of entire BillofMaterials table
            string query = "select * from RecipeMaterials";
            if (makesID != "")
            {
                query += " where Makes contains ?";
            }
            OleDbCommand cmd = new OleDbCommand(query, conn);
            if(makesID != "")
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = makesID;

            DataConnection.OpenConnection();
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Recipe> resultRMs = new List<Recipe>();
            while(reader.Read())
            {
                resultRMs.Add(new Recipe(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3)));
            }
            DataConnection.CloseConnection();
            return resultRMs;
        }

        public static List<FoodStuff> ListRecipesBy(string filter, string value)
        {
            //return a list of foodstuffs filtered based on the given filter's value
            //i.e. the tag list contains a particular tag.
            //like Update method(s) we need a means of identifying the column (the filter) without resorting to the actual name of it...
            return null;
        }
        /*
         * ===============================================================================
         * Test methods targeting the Test table in the database, remove prior to release
         * ===============================================================================
         */
        public static string TestConnection()
        {
            try
            {
                DataConnection.OpenConnection();
                DataConnection.CloseConnection();
                return "Connection seems okay...";
            }
            catch (Exception ex)
            {
                return "Error: " + ex.ToString();
            }
        }

        public static List<string> TestSelectAll()
        {
            //this isn't quite as neat as the equivalent code in VB.
            string query = "Select * from Testing";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            List<string> resultset = new List<string>();

            DataConnection.OpenConnection();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                resultset.Add(reader.GetString(0) + " " + reader.GetString(1));
            }
            DataConnection.CloseConnection(); 
            return resultset;
        }

        public static string TestInsert(string inID, string inValue)
        {
            try
            {
                string query = "insert into Testing(testID, testvalue) values (?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                //parameterized queries need their parameters added in the order they're used in the query
                //first is the placeholder character in the query string above
                //next is the data type, for string data varchar probably works for most purposes
                //next is the size of the parameter, for strings this is the length property
                //set it equal to the variable you want to use in the query.
                cmd.Parameters.Add("?", OleDbType.VarChar, inID.Length).Value = inID;
                cmd.Parameters.Add("?", OleDbType.VarChar, inValue.Length).Value = inValue;
                DataConnection.OpenConnection();

                int rowsAdded = cmd.ExecuteNonQuery(); //for insertions
               
                return rowsAdded.ToString() + " rows added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                DataConnection.CloseConnection();
            }
                
        }



        // ===============================================================================
    }
}
