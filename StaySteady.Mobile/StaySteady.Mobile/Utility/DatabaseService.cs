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

            _sqlLite.CreateTable<StaySteadyTableModel>();

            // if no data exists in the table, insert data for DailyActivity
            if (_sqlLite.Table<StaySteadyTableModel>().Count() == 0)
            {
                var newRow = new StaySteadyTableModel();
                newRow.Name = "Linda"; // The reports (except summary) are displayed for the first user only
                newRow.StabilityRate = "55";
                newRow.LastUpdate = "20/05/2016 12:13:33";
                newRow.Age = "80";
                newRow.Temperature = "36";
                newRow.HeartRateMin = "60";
                newRow.HeartRateMax = "120";
                newRow.Observations = "Previous Falls";
                _sqlLite.Insert(newRow);

                newRow = new StaySteadyTableModel();
                newRow.Name = "Saul";
                newRow.StabilityRate = "60";
                newRow.LastUpdate = "22/05/2016 12:55:01";
                newRow.Age = "75";
                newRow.Temperature = "36.2";
                newRow.HeartRateMin = "80";
                newRow.HeartRateMax = "130";
                newRow.Observations = "All Good";
                _sqlLite.Insert(newRow);

                newRow = new StaySteadyTableModel();
                newRow.Name = "Kim";
                newRow.StabilityRate = "15";
                newRow.LastUpdate = "21/05/2016 12:40:13";
                newRow.Age = "85";
                newRow.Temperature = "36.1";
                newRow.HeartRateMin = "55";
                newRow.HeartRateMax = "110";
                newRow.Observations = "Previous Falls";
                _sqlLite.Insert(newRow);

                newRow = new StaySteadyTableModel();
                newRow.Name = "Amy";
                newRow.StabilityRate = "12";
                newRow.LastUpdate = "23/05/2016 12:35:13";
                newRow.Age = "65";
                newRow.Temperature = "36.1";
                newRow.HeartRateMin = "65";
                newRow.HeartRateMax = "130";
                newRow.Observations = "Previous Falls";
                _sqlLite.Insert(newRow);

            }


        }

    }
}
