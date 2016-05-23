using System;
using System.Collections.Generic;
using System.Text;
using Foundation;
using StaySteady.Mobile.Utility;
using UIKit;

namespace StaySteady.Mobile.iOS.Utility
{
    class PhoneDialer:IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}
