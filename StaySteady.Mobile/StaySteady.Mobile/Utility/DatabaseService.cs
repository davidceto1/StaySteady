using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using StaySteady.Mobile.Models;
using Xamarin.Forms;

namespace StaySteady.Mobile.Utility
{
    public class DatabaseService
    {
        private static DatabaseService _instance;
        private SQLiteConnection _sqlLite;

        private DatabaseService()
        {
            _sqlLite = DependencyService.Get<ISQLite>().GetConnection();
        }

        public static DatabaseService GetInstance()
        {
            return _instance ?? (_instance = new DatabaseService());
        } 

        public SQLiteConnection SqLiteConnection {
            get { return _sqlLite; }
        }

        public bool TableExists(string tableName)
        {
            var algo = _sqlLite.GetTableInfo(tableName);
            return true;
        }

        public void InitializeDB()
        {
            _sqlLite.CreateTable<AddReminderModel>();            
            _sqlLite.CreateTable<TestModel>();     

            _sqlLite.CreateTable<DailyActivityModelTable>();

            // if no data exists in the table, insert data for DailyActivity
            if (_sqlLite.Table<DailyActivityModelTable>().Count() == 0)
            {
                var newRow = new DailyActivityModelTable();
                newRow.Name = "Linda"; // The activity is displayed for the first user 
                newRow.StabilityRate = "55";
                _sqlLite.Insert(newRow);
                newRow = new DailyActivityModelTable();
                newRow.Name = "Saul";
                newRow.StabilityRate = "60";
                _sqlLite.Insert(newRow);
                newRow = new DailyActivityModelTable();
                newRow.Name = "Kim";
                newRow.StabilityRate = "20";
                _sqlLite.Insert(newRow);
            }

        }

    }
}
