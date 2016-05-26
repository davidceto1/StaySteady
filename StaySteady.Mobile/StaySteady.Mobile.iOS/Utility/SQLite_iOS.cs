using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using StaySteady.Mobile.iOS.Utility;
using StaySteady.Mobile.Utility;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace StaySteady.Mobile.iOS.Utility
{
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLite.SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}
