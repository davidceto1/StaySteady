using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using StaySteady.Mobile.Annotations;

namespace StaySteady.Mobile.Models
{
    public class FallDetectedModel : INotifyPropertyChanged
    {
        private int _countDownInteger;

        public int CountDownInteger
        {
            get { return _countDownInteger; }
            set { _countDownInteger = value; OnPropertyChanged(nameof(CountDownString)); }
        }

        public string CountDownString {
            get { return "" + CountDownInteger; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
