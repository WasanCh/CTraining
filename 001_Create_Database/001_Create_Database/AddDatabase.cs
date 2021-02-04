using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace _001_Create_Database
{
    class AddDatabase
    {
        public static void InitializeDatabase()
        {
            
            using (SqliteConnection db =
               new SqliteConnection("Filename=TestFirstDatabase_DB.db"))
            {
                db.Open();


                String tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS MyTable_TB (Primary_Key INTEGER PRIMARY KEY, " +
                    "Text_Entry NVARCHAR(2048) NULL)";

                SqliteCommand createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();
            }
        }
    }
}
