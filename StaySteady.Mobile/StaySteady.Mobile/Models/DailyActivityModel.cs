using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Annotations;
using StaySteady.Mobile.Utility;
using SQLite;

namespace StaySteady.Mobile.Models
{
    public class DailyActivityModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        int imyStability;
        private String _myName;
        private String _myStabilityRate;
        private String _name0, _name1, _name2;
        private String _stability0, _stability1, _stability2;

        public String MyStabilityRate
        {
            get { return _myStabilityRate; }
            set { _myStabilityRate = "Your current stability rate is " + value + "%";
                int.TryParse(value, out imyStability);
                OnPropertyChanged("MyStabilityRate"); }
        }

        public String MyName
        {
            get { return _myName; }
            set {
                if (imyStability > 50)
                    _myName = value + ", You are doing great !";
                else if (imyStability <= 50)
                    _myName = value + ", Watch your step !";
                OnPropertyChanged("MyName"); }
        }

        public String UserName0
        {
            get { return _name0; }
            set { _name0 = value; OnPropertyChanged("UserName0"); }
        }

        public String UserName1
        {
            get { return _name1; }
            set { _name1 = value; OnPropertyChanged("UserName1"); }
        }
        public String UserName2
        {
            get { return _name2; }
            set { _name2 = value; OnPropertyChanged("UserName2"); }
        }

        public String Stability0
        {
            get { return _stability0; }
            set { _stability0 = value + "%"; OnPropertyChanged("Stability0"); }
        }
        public String Stability1
        {
            get { return _stability1; }
            set { _stability1 = value + "%"; OnPropertyChanged("Stability1"); }
        }
        public String Stability2
        {
            get { return _stability2; }
            set { _stability2 = value + "%"; OnPropertyChanged("Stability2"); }
        }

        public DailyActivityModel()
        {
            SQLiteConnection db = DatabaseService.GetInstance().SqLiteConnection;
            StaySteadyTableModel table = db.Get<StaySteadyTableModel>(1);
            MyStabilityRate = table.StabilityRate;
            MyName = table.Name;
            int i = 0;
            var sorted = db.Query<StaySteadyTableModel>("SELECT * FROM StaySteady ORDER by StabilityRate DESC");
            foreach (var row in sorted)
            {
                if (i == 0)
                {
                    UserName0 = row.Name;
                    Stability0 = row.StabilityRate;
                }
                else if (i == 1)
                {
                    UserName1 = row.Name;
                    Stability1 = row.StabilityRate;
                }
                else if (i == 2)
                {
                    UserName2 = row.Name;
                    Stability2 = row.StabilityRate;
                }
                else break;
                i++;
            }
            
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
