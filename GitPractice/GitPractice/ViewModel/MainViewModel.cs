using System;
using System.Collections.Generic;
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
        public MainViewModel()
        {

        }
    }
}
