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
    public class ExerciseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private String _myStabilityRate;

        public String MyStabilityRate
        {
            get { return _myStabilityRate; }
            set
            {
                _myStabilityRate = "Stability Rate " + value + "%";
                OnPropertyChanged("MyStabilityRate");
            }
        }

        public ExerciseModel()
        {
            SQLiteConnection db = DatabaseService.GetInstance().SqLiteConnection;
            StaySteadyTableModel table = db.Get<StaySteadyTableModel>(1);
            MyStabilityRate = table.StabilityRate;           
        }


        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
