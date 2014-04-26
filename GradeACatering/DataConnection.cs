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

        // TODO
        // Allow editing of the path to the database file.
        // Function to call the CompactRepair method on the database.
        // See: http://www.codeproject.com/Articles/7775/Compact-and-Repair-Access-Database-using-C-and-lat

       
        private static string connstr= "Provider = Microsoft.Ace.OLEDB.15.0;" + //may need to use version checking to make sure this doesn't hamstring anything.
                                       "Data Source = GradeACatering.accdb;"; //defaults, we can make these changeable later if needed, looks in root directory currently.
        private static OleDbConnection conn = new OleDbConnection(connstr);

        //use these functions to open and close the database, don't call conn.Open() or .Close() directly.
        private static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }

        private static void CloseConnection()
        {
            if (conn.State != System.Data.ConnectionState.Open)
                conn.Close();
        }
        
        //functions to read from, update in, and add to the database

        //
        //========================================================
        public static string AddFoodStuff(FoodStuff fs)
        {
            //insert a foodstuff entry in the Foodstuff table
            //will use comma-delineated string for the tags
            //now contains the ingredients itself, don't need to handle them separately
            try
            {
                //this needs to be rewritten to only insert fields and parameters for the items that the user is inserting, so the
                //database will auto-default to NULL for the rest.
                string query = "insert into Foodstuff(FoodstuffID, Name"; //these two must always be there

                DataConnection.OpenConnection();
                OleDbDataReader rdItemCount = new OleDbCommand("Select Count(Name) from Foodstuff", conn).ExecuteReader();
                rdItemCount.Read();
                DataConnection.CloseConnection();

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;

                //if statements for each value to add, and its associated parameter                           
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.ID;// +Convert.ToInt32(rdItemCount[0]).ToString("0000#");
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Name;
                int intParameterCount = 2;
                if (fs.Directions != "")
                {
                    query += ", Directions";
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Directions;
                    intParameterCount++;
                }
                if (fs.PrepTime > -1) //use -1, items may still have 0 prep time
                {
                    query += ", PrepTime";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.PrepTime;
                    intParameterCount++;
                }
                if (fs.CookTime > -1)
                {
                    query += ", CookTime";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.CookTime;
                    intParameterCount++;
                }
                if (fs.Cost > 0.0) //unlikely anything is going to be free
                {
                    query += ", Cost";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Cost;
                    intParameterCount++;
                }
                if (fs.Servings > 0)
                {
                    query += ", Servings";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Servings;
                    intParameterCount++;
                }
                if (fs.GetTags() != "")
                {
                    query += ", Tags";
                    //Comma-and-space delineated list of the tags.
                    //When tokenizing or splitting tags, use ", " for the demarcation.
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.GetTags();
                    intParameterCount++;
                }
                query += ") Values(?";
                for (int i = 0; i < intParameterCount - 1; i++)
                {
                    query += ",?";
                }
                query += ")";

                cmd.CommandText = query;
                DataConnection.OpenConnection();

                cmd.ExecuteNonQuery();

                foreach (Recipe r in fs.ReturnIngredientsList())
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

        //========================================================
        //

        //public static string AddFoodStuff(FoodStuff fs, List<Recipe> ingredients)
        //{
        //    //insert a foodstuff entry in the Foodstuff table
        //    //will use comma-delineated string for the tags
        //    try
        //    {
        //        //this needs to be rewritten to only insert fields and parameters for the items that the user is inserting, so the
        //        //database will auto-default to NULL for the rest.
        //        string query = "insert into Foodstuff(FoodstuffID, Name"; //these two must always be there

        //        DataConnection.OpenConnection();
        //        OleDbDataReader rdItemCount = new OleDbCommand("Select Count(Name) from Foodstuff", conn).ExecuteReader();
        //        rdItemCount.Read();
        //        DataConnection.CloseConnection();

        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.Connection = conn;    
                
        //        //if statements for each value to add, and its associated parameter                           
        //        cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.ID;// +Convert.ToInt32(rdItemCount[0]).ToString("0000#");
        //        cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Name;
        //        int intParameterCount = 2;
        //        if (fs.Directions != "")
        //        {
        //            query += ", Directions";
        //            cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Directions;
        //            intParameterCount++;
        //        }
        //        if (fs.PrepTime > -1) //use -1, items may still have 0 prep time
        //        {
        //            query += ", PrepTime";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.PrepTime;
        //            intParameterCount++;
        //        }
        //        if (fs.CookTime > -1)
        //        {
        //            query += ", CookTime";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.CookTime;
        //            intParameterCount++;
        //        }
        //        if (fs.Cost > 0.0) //unlikely anything is going to be free
        //        {
        //            query += ", Cost";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Cost;
        //            intParameterCount++;
        //        }
        //        if (fs.Servings > 0)
        //        {
        //            query += ", Servings";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Servings;
        //            intParameterCount++;
        //        }
        //        if (fs.GetTags() != "")
        //        {
        //            query += ", Tags";
        //            //Comma-and-space delineated list of the tags.
        //            //When tokenizing or splitting tags, use ", " for the demarcation.
        //            cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.GetTags();
        //            intParameterCount++;
        //        }
        //        query += ") Values(?";
        //        for (int i = 0; i < intParameterCount-1; i++)
        //        {
        //            query += ",?";
        //        }
        //        query += ")";

        //        cmd.CommandText = query;
        //        DataConnection.OpenConnection();

        //        cmd.ExecuteNonQuery();

        //        foreach (Recipe r in ingredients)
        //            AddRecipeItem(r);

        //        return "Item plus ingredients added.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }
        //    finally
        //    {
        //        DataConnection.CloseConnection();
        //    }
        //}

        //public static string AddFoodStuff(FoodStuff fs, Recipe r)
        //{
        //    //same as other but for just adding single Recipe elements instead of from a list.
        //    //insert a foodstuff entry in the Foodstuff table
        //    //will use comma-delineated string for the tags
        //    try
        //    {
        //        //this needs to be rewritten to only insert fields and parameters for the items that the user is inserting, so the
        //        //database will auto-default to NULL for the rest.
        //        string query = "insert into Foodstuff(FoodstuffID, Name"; //these two must always be there

        //        OleDbDataReader rdItemCount = new OleDbCommand("Select Count(Name) from Foodstuff", conn).ExecuteReader();
        //        rdItemCount.Read();

        //        OleDbCommand cmd = new OleDbCommand();
        //        cmd.Connection = conn;
        //        //fs.ID += Convert.ToInt32(rdItemCount[0]).ToString("0000#");
        //        //if statements for each value to add, and its associated parameter                           
        //        cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.ID;// +Convert.ToInt32(rdItemCount[0]).ToString("0000#");
        //        cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Name;
        //        int intParameterCount = 2;
        //        if (fs.Directions != "")
        //        {
        //            query += ", Directions";
        //            cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.Directions;
        //            intParameterCount++;
        //        }
        //        if (fs.PrepTime > -1) //use -1, items may still have 0 prep time
        //        {
        //            query += ", PrepTime";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.PrepTime;
        //            intParameterCount++;
        //        }
        //        if (fs.CookTime > -1)
        //        {
        //            query += ", CookTime";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.CookTime;
        //            intParameterCount++;
        //        }
        //        if (fs.Cost > 0.0) //unlikely anything is going to be free
        //        {
        //            query += ", Cost";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Cost;
        //            intParameterCount++;
        //        }
        //        if (fs.Servings > 0)
        //        {
        //            query += ", Servings";
        //            cmd.Parameters.Add("?", OleDbType.Numeric).Value = fs.Servings;
        //            intParameterCount++;
        //        }
        //        if (fs.GetTags() != "")
        //        {
        //            query += ", Tags";
        //            //Comma-and-space delineated list of the tags.
        //            //When tokenizing or splitting tags, use ", " for the demarcation.
        //            cmd.Parameters.Add("?", OleDbType.VarChar).Value = fs.GetTags();
        //            intParameterCount++;
        //        }
        //        query += ") Values(?";
        //        for (int i = 1; i < intParameterCount; i++) //counter is one-based
        //        {
        //            query += ",?";
        //        }
        //        query += ")";

        //        cmd.CommandText = query;
        //        AddRecipeItem(r);
        //        DataConnection.OpenConnection();

        //        cmd.ExecuteNonQuery();


        //        return "Item plus ingredients added.";
        //    }
        //    catch (Exception ex)
        //    {
        //        return ex.ToString();
        //    }
        //    finally
        //    {
        //        DataConnection.CloseConnection();
        //    }
        //}

        public static void UpdateFoodstuff(string fsID, FoodStuff updatedFS)
        {
            //need some way of identifying the column without passing in the name itself which might change.
            //an enum won't work since that's just a bit of code associated with an integer.

            //TODO:
            //verify the record exists, if it does then update the designated column with the new value.
            
            //Potentially ugly hack to make this work is to just update every field regardless of whether they were
            //altered or not, overwriting with the same values for unaltered fields.
            //it might be slower but would save the headache of trying to pick and choose the fields we need to write to.
            try
            {
                //this needs to be rewritten to only insert fields and parameters for the items that the user is inserting, so the
                //database will auto-default to NULL for the rest.
                string query = "update foodstuff set "; //these two must always be there

                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = conn;
                //fs.ID += Convert.ToInt32(rdItemCount[0]).ToString("0000#");
                //if statements for each value to add, and its associated parameter   
                query += "FoodstuffID = ?";        
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = updatedFS.ID;// +Convert.ToInt32(rdItemCount[0]).ToString("0000#");
                query += ",Name = ? ";
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = updatedFS.Name;
                int intParameterCount = 2;
                if (updatedFS.Directions != "")
                {
                    query += ", Directions = ?";
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = updatedFS.Directions;
                    intParameterCount++;
                }
                if (updatedFS.PrepTime > -1) //use -1, items may still have 0 prep time
                {
                    query += ", PrepTime = ?";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = updatedFS.PrepTime;
                    intParameterCount++;
                }
                if (updatedFS.CookTime > -1)
                {
                    query += ", CookTime = ? ";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = updatedFS.CookTime;
                    intParameterCount++;
                }
                if (updatedFS.Cost > 0.0) //unlikely anything is going to be free
                {
                    query += ", Cost = ? ";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = updatedFS.Cost;
                    intParameterCount++;
                }
                if (updatedFS.Servings > 0)
                {
                    query += ", Servings = ?";
                    cmd.Parameters.Add("?", OleDbType.Numeric).Value = updatedFS.Servings;
                    intParameterCount++;
                }
                if (updatedFS.GetTags() != "")
                {
                    query += ", Tags = ? ";
                    //Comma-and-space delineated list of the tags.
                    //When tokenizing or splitting tags, use ", " for the demarcation.
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = updatedFS.GetTags();
                    intParameterCount++;
                }
                query += "where FoodstuffID = " + updatedFS.ID;

                cmd.CommandText = query;
                DataConnection.OpenConnection();

                cmd.ExecuteNonQuery();
                
                //return "Item plus ingredients added.";
            }
            catch (Exception ex)
            {
                //return ex.ToString();
            }
            finally
            {
                DataConnection.CloseConnection();
            }
        }

        public static string AddRecipeItem(Recipe r)
        {
            //insert a single recipe entry in the RecipeMaterials table
            //since adding a bulk of Recipe items (such as from a complex recipe) would be most easily done by a
            //compound insert which Access conveniently does not support, this just needs to be called multiple times for
            //each of the recipes in the Foodstuff's list to add.
            try
            {
                //refactoring to build in only those parameters we actually need.
                OleDbCommand cmd = new OleDbCommand();
                string query = "insert into RecipeMaterials(Makes, MadeOf";
                   
                

                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Makes;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.MadeOf;
                int intParameterCounter = 2;
                if(r.FractionAmount() != "")
                {
                    query += " , Quantity";
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.FractionAmount();
                    intParameterCounter++;
                }
                if(r.Unit != "")
                {
                    query += ", Unit";
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = r.Unit;
                    intParameterCounter++;
                }
                query += ") Values(?";

                for (int i = 1; i < intParameterCounter; i++) //counter is one-based
			    {
			          query += ",?";
			    }
                query += ")";
                cmd.CommandText = query;
                cmd.Connection = conn;

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

        public static List<Recipe> ListOfIngredients(string makesID = "")
        {
            //find all recipe elements that go into the foodstuff with this ID
            //if no id given, returns contents of entire BillofMaterials table
            List<Recipe> resultRMs = new List<Recipe>();
            
            try
            {
                string query = "select * from RecipeMaterials";
                if (makesID != "")
                {
                    query += " where Makes like ?";
                }
                OleDbCommand cmd = new OleDbCommand(query, conn);
                if (makesID != "")
                    cmd.Parameters.Add("?", OleDbType.VarChar).Value = makesID;

                DataConnection.OpenConnection();
                OleDbDataReader reader = cmd.ExecuteReader();
               
                
                while (reader.Read())
                {
                    string[] results=new string[4];
                    results[0] = reader.GetString(0);
                    results[1] = reader.GetString(1);
                   
                    if (reader[2] == DBNull.Value)
                        results[2] = "";
                    else
                        results[2] = reader.GetString(2);

                    if (reader[3] == DBNull.Value)
                        results[3] = "";
                    else
                        results[3] = reader.GetString(3);

                    resultRMs.Add(new Recipe(results[0],results[1],results[2],results[3]));
                }
                reader.Close();
            }
            catch (Exception ex)
            { }
            finally
            {
                DataConnection.CloseConnection();
            }
            return resultRMs;
        }

        public static List<FoodStuff> ListAllFoodstuffs()
        {
            //displays all foodstuffs that are not atomic items (that is, base ingredients)
            //this is determined by the RecipeMaterials entries:  items where the Makes and MadeOf fields are identical
            //are atomic items.  These are the ones we DO NOT want this function to return.
            List<FoodStuff> lstFoods = new List<FoodStuff>();
            try
            {              
                string query = "Select * from Foodstuff where FoodstuffID in (select Makes from RecipeMaterials where Makes <> MadeOf)"; //Not equals for Access is <> not !=
                OleDbCommand cmd = new OleDbCommand(query, conn);
                DataConnection.OpenConnection();
                OleDbDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    List<Recipe> lstMats = DataConnection.ListOfIngredients(reader.GetString(0));

                    FoodStuff fs = new FoodStuff(reader.GetString(0),
                                               reader.GetString(1),
                                               reader.GetString(2),
                                               reader.GetInt32(3),
                                               reader.GetInt32(4),
                                               reader.GetDouble(5),
                                               reader.GetInt32(6),
                                               null,
                                               lstMats);
                    //tokenize the tags from their long string stored in the database.

                    if (!(reader[7] is System.DBNull))
                    {
                        string[] strTagList = reader.GetString(7).Split(',');
                        if (strTagList.Length > 0)
                        {
                            foreach (string t in strTagList)
                                fs.AddTag(t);
                        }
                    } 
                    lstFoods.Add(fs);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //don't do anything, apparently can't post messageboxes out of this thing
                ex.ToString();
            }
            finally
             {
                DataConnection.CloseConnection();
            }
            return lstFoods;
        }

        public static List<FoodStuff> ListAllIngredients()
        {
            //displays all foodstuffs that ARE atomic items (that is, base ingredients)
            //this is determined by the RecipeMaterials entries:  items where the Makes and MadeOf fields are different
            //are the ones we DO want this function to return.
            List<FoodStuff> lstFoods = new List<FoodStuff>();
            try
            {
                string query = "Select * from Foodstuff where FoodstuffID in (select Makes from RecipeMaterials where Makes = MadeOf)"; //Not equals for Access is <> not !=
                OleDbCommand cmd = new OleDbCommand(query, conn);
                DataConnection.OpenConnection();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    FoodStuff fs = new FoodStuff(reader.GetString(0),
                                               reader.GetString(1));
                    lstFoods.Add(fs);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                //don't do anything, apparently can't post messageboxes out of this thing
            }
            finally
            {
                DataConnection.CloseConnection();
            }
            return lstFoods;
        }

        public static List<FoodStuff> FindFoodstuffsNamed(string inName)
        {
            //return a list of foodstuffs whose names contain the passed in value
            //does not distinguish between base ingredients and final items.
             List<FoodStuff> lstFoods = new List<FoodStuff>();
             try
             {
                 string query = "Select * from Foodstuff where Name like ?";
                 OleDbCommand cmd = new OleDbCommand(query, conn);
                 cmd.Parameters.Add("?", OleDbType.VarChar).Value = inName;
                 OleDbDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     List<Recipe> lstMats = DataConnection.ListOfIngredients(reader.GetString(0));
                     FoodStuff fs = new FoodStuff(reader.GetString(0),
                                                  reader.GetString(1),
                                                  reader.IsDBNull(2) ? "" : reader.GetString(2),
                                                  reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                                                  reader.IsDBNull(4) ? -1 : reader.GetInt32(4),
                                                  reader.IsDBNull(5) ? -1.0 : reader.GetDouble(5),
                                                  reader.IsDBNull(6) ? -1 : reader.GetInt32(6),
                                                  null,
                                                  lstMats);


                     //tokenize the tags from their long string stored in the database.

                     string[] strTagList = reader.IsDBNull(7) ? new string[0] : reader.GetString(7).Split(',');

                     foreach (string t in strTagList)
                         fs.AddTag(t);


                     lstFoods.Add(fs);
                 }
                 reader.Close();
             }
             catch (Exception ex)
             {

             }
            finally
            {
               
                DataConnection.CloseConnection();
            }
            
            return lstFoods;
        }

        public static List<FoodStuff> FindFoodstuffsTagged(string tag)
        {
            List<FoodStuff> FoodstuffsFound = new List<FoodStuff>();

            try
            {
                //loop through each foodstuff's parsed tag string


            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                DataConnection.CloseConnection();
            }

            return FoodstuffsFound;
        }

        public static FoodStuff GetFoodstuffWithID(string fsID)
        {
            //really simple, match the foodstuff ID passed in with the ID in the table and return it.
            FoodStuff fs=new FoodStuff();
            try
            {
                string query = "Select * from Foodstuff where FoodstuffID like ?";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = fsID;
                OleDbDataReader reader = cmd.ExecuteReader();


                reader.Read();
                string id = reader.IsDBNull(0) ? "":reader.GetString(0);
                List<Recipe> lstMats = DataConnection.ListOfIngredients(reader.GetString(0));

                fs = new FoodStuff(reader.GetString(0),
                                   reader.GetString(1),
                                   reader.IsDBNull(2) ? "" : reader.GetString(2),
                                   reader.IsDBNull(3) ? -1 : reader.GetInt32(3),
                                   reader.IsDBNull(4) ? -1: reader.GetInt32(4),
                                   reader.IsDBNull(5) ? -1.0 : reader.GetDouble(5),
                                   reader.IsDBNull(6) ? -1 : reader.GetInt32(6),
                                   null,
                                   lstMats);

                  
                //tokenize the tags from their long string stored in the database.

                string[] strTagList = reader.IsDBNull(7) ? new string[0] : reader.GetString(7).Split(',');

                if (strTagList.Length != 0)
                {
                    foreach (string t in strTagList)
                        fs.AddTag(t);
                }
                reader.Close();
               
            }
            catch (Exception ex)
            {

            }
            finally
            {
                DataConnection.CloseConnection();
                
            }
            return fs;
        }

        public static int NumFoodstuffs()
        {
            //returns a count of the number of items in the Foodstuff table
            try
            {
                string query = "Select Count(FoodstuffID) from Foodstuff";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                DataConnection.OpenConnection();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader.GetInt32(0);
            }
            catch (Exception ex)
            { return -1; }
            finally
            { DataConnection.CloseConnection(); }

        }

        public static int NumRecipeMaterials()
        {
            //returns a count of the number of items in the RecipeMaterials table
            try
            {
                string query = "Select Count(Makes) from RecipeMaterials";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                DataConnection.OpenConnection();
                OleDbDataReader reader = cmd.ExecuteReader();
                reader.Read();
                return reader.GetInt32(0);
                reader.Close();
            }
            catch (Exception ex)
            { return -1; }
            finally
            { DataConnection.CloseConnection();}

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
            reader.Close();
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
