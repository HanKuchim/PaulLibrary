using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PaulLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Book> books;
        public MainWindow()
        {
            InitializeComponent();
            
            List<User> users = new List<User>()
            {
                new User(0, "Андрей Науменко"),
                new User(1, "Килла тагиловский"),
                new User(2, "Свита Решаловский"),
                new User(3, "Глухарь Резервовский"),
                new User(4, "Штурман Лесной"),
            };
            UserListView.ItemsSource = users;

            books = new List<Book>()
            {
                new Book(0, "Война и мир"),
                new Book(1, "Стихи пушкина"),
                new Book(2, "Стальная крыса"),
                new Book(3, "Искусство войны"),
                new Book(4, "Понедельник начинается в субботу"),
            };

            BookListView.ItemsSource = books;

           

            UserComboBox.ItemsSource = users;
            UserComboBox.SelectedIndex = 0;

            BookComboBox.ItemsSource = books;
            BookComboBox.SelectedIndex = 0;
        }

        private void UserListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = UserListView.SelectedItem as User;
            TextUserId.Text = Convert.ToString(item.UserId);
            TextUserName.Text = item.UserName;
        }


        private void BookListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = BookListView.SelectedItem as Book;
            TextBookId.Text = Convert.ToString(item.BookId);
            TextTitle.Text = item.Title;
        }

        private void UsersBookView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void UserComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (UserComboBox.SelectedItem is User user)
            {
                SelectedUser.Text = (string)(user.UserName);
                UserBookList.ItemsSource = (UserComboBox.SelectedItem as User).UserBook;
            }
        }

        private void BookComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BookComboBox.SelectedItem is Book book)
            {
                SelectedBook.Text = book.Title;

            }
        }


        private void GiveBook(object sender, RoutedEventArgs e)
        {
            if((UserComboBox.SelectedItem as User) != null && (BookComboBox.SelectedItem as Book)!= null) (UserComboBox.SelectedItem as User).UserBook.Add(BookComboBox.SelectedItem as Book);
            UserBookList.Items.Refresh();

        }


    }
}
