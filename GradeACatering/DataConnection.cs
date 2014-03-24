using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace GradeACatering
{
    class DataConnection
    {
        /*
         * ==================================================================================================
         * 
         *  Important Note!  On my machine this OLEDB connector ONLY worked when compiling for x64 platforms. 
         *  The program complained that no connector existed when building for Any CPU or x86.       - Dustin
         * 
         * ==================================================================================================
         */
        private OleDbConnection conn; // = new OleDbConnection();
        private string connstr;
        public DataConnection()
        {
            connstr = "Provider = Microsoft.Ace.OLEDB.15.0;" + //may need to use version checking to make sure this doesn't hamstring anything.
                      "Data Source = GradeACatering.accdb;"; //defaults, will make these changeable later.
            //conn.ConnectionString = connstr;
            conn = new OleDbConnection(connstr);
        }
       
        public void OpenDBConnection()
        {
            conn.Open();
        }

        public void CloseDBConnection()
        {
            conn.Close();
        }

        //functions to read and write things to the database will go here.

        public string AddFoodStuff(FoodStuff fs)
        {
            //insert a foodstuff entry in the Foodstuffs table
            return "work in progress";
            //return success or failure message
        }

        public string AddRecipeItem(Recipe r)
        {
            //insert a recipe entry in the Recipes table
            return "work in progress";
            //return success or failure message
        }

        public List<Recipe> ListOfIngredients(string makesID)
        {
            //find all recipe elements that go into the foodstuff with this ID
            return null;
        }

        public List<FoodStuff> ListRecipesBy(string filter, string value)
        {
            //return a list of foodstuffs filtered based on this value
            //i.e. the list of ingredients contains a particular ingredient.
            return null;
        }
        /*
         * ===============================================================================
         * Test methods targeting the Test table in the database, remove prior to release
         * ===============================================================================
         */
        public string TestConnection()
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

        public List<string> TestSelectAll()
        {
            string query = "Select * from Testing";
            OleDbCommand cmd = new OleDbCommand(query, conn);

            List<string> resultset = new List<string>();

            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                resultset.Add(reader.GetString(0) + " " + reader.GetString(1));
            }
            return resultset;
        }

        public string TestInsert(string inID, string inValue)
        {
            try
            {
                string query = "insert into Testing(testID, testvalue) values (?,?)";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar, inID.Length).Value = inID;
                cmd.Parameters.Add("?", OleDbType.VarChar, inValue.Length).Value = inValue;
                conn.Open();

                int rowsAdded = cmd.ExecuteNonQuery();

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
