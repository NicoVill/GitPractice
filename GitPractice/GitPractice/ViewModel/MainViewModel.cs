using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitPractice.ViewModel
{
    class MainViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChangedEvent(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name;
        public string Name {
            get
            { return name; }

            set
            { name = value;
                RaisePropertyChangedEvent("Name");
            }
        }

        private string email;
        public string Email
        {
            get
            { return email; }

            set
            {
                email = value;
                RaisePropertyChangedEvent("Email");
            }
        }

        private string country;
        public string Country
        {
            get
            { return country; }

            set
            {
                country = value;
                RaisePropertyChangedEvent("Country");
            }
        }

        ObservableCollection<Model.Person> persons;
        public ObservableCollection<Model.Person> Persons{ get { return persons; } set { persons = value; } }
        public MainViewModel()
        {
            persons = new ObservableCollection<Model.Person>();
            persons.Add(new Model.Person() { Name = "Nicolaj", Email = "123@mail.now", Country = "Denmark" });
            persons.Add(new Model.Person() { Name = "Sandre", Email = "123@mail.now", Country = "Serbia" });
            persons.Add(new Model.Person() { Name = "Chris", Email = "123@mail.now", Country = "Sweden" });


        }
    }
}
