using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaySteady.Mobile.Models
{
    public class FallDetectedModel
    {
        public int CountDownInteger { get; set; }

        public string CountDownString {
            get { return "" + CountDownInteger; }
        }
    }
}
