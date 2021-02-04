using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace _001_Create_Database
{
    class ShowDataOnTable
    {

        public static List<String> GetData()
        {
            List<String> entries = new List<string>();

           
            using (SqliteConnection db =
               new SqliteConnection("Filename=TestFirstDatabase_DB.db"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ("SELECT Text_Entry from MyTable_TB", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    entries.Add(query.GetString(0));
                }

                db.Close();
            }

            return entries;
        }

    }
}
