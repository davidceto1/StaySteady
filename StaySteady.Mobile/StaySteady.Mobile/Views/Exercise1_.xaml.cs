using StaySteady.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace StaySteady.Mobile.Views
{
    public partial class Exercise1_ : ContentPage
    {
        ExerciseViewModel _viewModel;
        public Exercise1_()
        {
            Title = "Exercise 1";
            Icon = "icon.png";
            InitializeComponent();
            _viewModel = new ExerciseViewModel();
            this.BindingContext = _viewModel;

        }
    }
}
