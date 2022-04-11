using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using maramMVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace maramMVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TempletPageView : ContentPage
    {
        public TempletPageView()
        {
            InitializeComponent();
            BindingContext=new TempletPageViewModel();
        }
    }
}