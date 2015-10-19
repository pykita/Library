using System.Windows;
using System.Windows.Controls;
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Interaction logic for UserList.xaml
    /// </summary>
    public partial class UserList : Window
    {
        private AddUser addUserForm;

        private EditUser editUserForm;

        private Menu parent;

        public UserList(Menu parent)
        {
            this.parent = parent;

            InitializeComponent();

            InitializeDataGrid();

            addUserForm = new AddUser(this);
            editUserForm = new EditUser(this);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addUserForm.Show();
        }

        public void InitializeDataGrid()
        {
            DgUser.ItemsSource = Factory.Factories.UsersFactory.GeList();
        }

        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            var userToEdit = (User)((Button)e.Source).DataContext;
            editUserForm.CurrentUser = userToEdit;
            editUserForm.Show();
        }


        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {

            var userToDelete = (User)((Button)e.Source).DataContext;
            Factory.Factories.UsersFactory.DeleteUser(userToDelete);
            InitializeDataGrid();
        }
    }
}
