using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PaulLibrary.Model
{
    class User : INotifyPropertyChanged
    {
        private int userId;
        private string userName;


        public ObservableCollection<Book> userBook = new ObservableCollection<Book>();

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
                OnPropertyChanged("UserName");
            }
        }

        public ObservableCollection<Book> UserBook
        {
            get
            {
                return userBook;

            }
            set
            {
                userBook = value;
                OnPropertyChanged("UserBook");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return $"{UserName}";
        }
    }
}
