using ReactiveUI.XamForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalendarXamarin
{
    public partial class MainPage : ReactiveContentPage<ViewModel>
    {
        public MainPage(ViewModel viewModel)
        {
            ViewModel = viewModel;
            InitializeComponent();
        }
    }
}
