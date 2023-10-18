using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using PaulLibrary.Model;

namespace PaulLibrary.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private User selectedUser;
        private Book selectedBook;
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Book> Books { get; set; }


        public User SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public Book SelectedBook
        {
            get { return selectedBook; }
            set
            {
                selectedBook = value;
                OnPropertyChanged("SelectedBook");
            }
        }

        public ApplicationViewModel()
        {
            Users = new ObservableCollection<User>
            {
                new User{ UserName = "Андрей Науменко" },
                new User{ UserName = "Килла тагиловский" },
                new User{ UserName = "Свита Решаловский" },
                new User{ UserName = "Глухарь Резервовский" },
                new User{ UserName = "Штурман Лесной" },
            };
            Books = new ObservableCollection<Book>
            {
                new Book{Title = "Война и мир"},
                new Book{Title = "Стихи пушкина"},
                new Book{Title = "Стальная крыса"},
                new Book{Title = "Искусство войны"},
                new Book{Title = "Понедельник начинается в субботу"},
            };

        }
        private RelayCommand addbook;

        public RelayCommand AddBook
        {
            get
            {
                return addbook ?? (addbook = new RelayCommand(obj =>
                {
                    selectedUser.UserBook.Add(selectedBook);

                }, (obj) => selectedBook != null));
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }

}
