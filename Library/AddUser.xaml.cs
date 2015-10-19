using System;
using System.ComponentModel;
using System.Windows;
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        private UserList parent;

        public AddUser(UserList parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User();
            newUser.Name = UserName.Text;
            newUser.SecondName = UserSecondName.Text;
            newUser.PhoneNumber = UserPhoneNumber.Text;
            newUser.Adress = UserAdress.Text;
            newUser.RegistretionDate = DateTime.Now;

            Factory.Factories.UsersFactory.AddUser(newUser);
            parent.InitializeDataGrid();
            this.Hide();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
    }
}
