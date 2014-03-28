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
                string query = "insert into Foodstuff values(?,?,?,?,?,?,?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.ID;
                //and the rest of them....
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                foreach (Recipe r in ingredients)
                    AddRecipeItem(r);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            
            return "work in progress";
            //return success or failure message
        }

        public static string AddRecipeItem(Recipe r)
        {
            //insert a recipe entry in the BillOfMaterials table
            try
            {
                string query = "insert into BillOfMaterials(Makes, MadeOf, Quantity) Values(?,?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Makes;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.MadeOf;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.FractionAmount()+ " " + r.Unit;

                conn.Open();
                cmd.ExecuteNonQuery();
                
                return "Item added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            
        }

        public static string AddRecipeItem(List<Recipe> rlist)
        {
            //functionally very similar to the individual insertion but can do more than one at a time.
           
            try
            {
                string query = "insert into BillOfMaterials(Makes, MadeOf, Quantity) Values";
                //Values(?,?,?)";
                OleDbCommand cmd = new OleDbCommand();
                foreach (Recipe r in rlist)
                {
                    query += "(?,?,?)";
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Makes;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.MadeOf;
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.FractionAmount() + " " + r.Unit;
                }
                conn.Open();
                cmd.ExecuteNonQuery();

                return "Item added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
            
            
        }

        public static List<Recipe> ListOfIngredients(string makesID = "")
        {
            //find all recipe elements that go into the foodstuff with this ID
            //if no id given, returns contents of entire BillofMaterials table
            string query = "select * from BillofMaterials";
            if (makesID != "")
            {
                query += " where Makes = ?";
            }
            OleDbCommand cmd = new OleDbCommand(query, conn);
            if(makesID != "")
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = makesID;

            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            List<Recipe> resultBOMs = new List<Recipe>();
            while(reader.Read())
            {
                resultBOMs.Add(new Recipe(reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3)));
            }
            conn.Close();
            return resultBOMs;
        }

        public static List<FoodStuff> ListRecipesBy(string filter, string value)
        {
            //return a list of foodstuffs filtered based on the given filter's value
            //i.e. the tag list contains a particular tag.
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
                conn.Open();
                conn.Close();
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

            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                resultset.Add(reader.GetString(0) + " " + reader.GetString(1));
            }
            conn.Close();
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
                conn.Open();

                int rowsAdded = cmd.ExecuteNonQuery(); //for insertions
                conn.Close();
                return rowsAdded.ToString() + " rows added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                conn.Close();
            }
                
        }



        // ===============================================================================
    }
}
