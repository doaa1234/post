using System;
using System.Collections.Generic;
using System.Text;
using maramMVVM.Model;
using Xamarin.Forms;
using System.Threading.Tasks;
using maramMVVM.Services;
using Firebase.Database;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MvvmHelpers;
using maramMVVM.View;

namespace maramMVVM.ViewModel
{
    public class TempletPageViewModel : BaseViewModel
    {
        public string text { get; set; }

        public Command AddtextCommand { get; }
        private DBservices Services;
       
        private ObservableCollection<TempletPageModel> _booktemplet = new ObservableCollection<TempletPageModel>();


        public ObservableCollection<TempletPageModel> booktemplet
        {
            get { return _booktemplet; }
            set
            {
                _booktemplet = value;
                OnPropertyChanged();
            }
        }

        public TempletPageViewModel()
        {
            Services = new DBservices();
            booktemplet = Services.getPerson();
            AddtextCommand = new Command(async () =>
              await AddTextAsync(text));
        }

        private async Task AddTextAsync(string text)
        {
           await Services.Addperson(text);
            await Application.Current.MainPage.DisplayAlert("Hey",text+"   ,Welcome in templetbook ","Ok");
         //   await Application.Current.MainPage.Navigation.PushAsync(new TempletPageView());
        }



    }
}
