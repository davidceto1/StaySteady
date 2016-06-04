using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using StaySteady.Mobile.Models;
using StaySteady.Mobile.Utility;

namespace StaySteady.Mobile.ViewModels
{
    class ExerciseViewModel : ViewModelBase
    {


        public ExerciseViewModel()
        {
            Model = new ExerciseModel();
        }
        public ExerciseModel Model { get; set; }
    }
}
