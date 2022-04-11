using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using maramMVVM.Model;
using Firebase.Database.Query;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace maramMVVM.Services
{
    public class DBservices
    {
        FirebaseClient person;
        public DBservices()
        {
            person = new FirebaseClient("https://book-b395a-default-rtdb.firebaseio.com/");


        }

        public ObservableCollection<TempletPageModel> getPerson()
        {
            var PersonData = person.Child("booktmplet").AsObservable<TempletPageModel>().AsObservableCollection();
            return PersonData;
        }
        public async Task Addperson(string Textname)
        {
            TempletPageModel c = new TempletPageModel() { text = Textname };
            await person.Child("booktmplet").PostAsync(c);
        }

    }
}
