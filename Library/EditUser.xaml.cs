using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        private UserList parent;
        private User currentUser;

        public User CurrentUser {
   
        get
        {
            return currentUser;
        }
    

        set
        {
            currentUser = value;
            this.UpdateForm();
        } 
    }

    public EditUser(UserList parent)
    {
            this.parent = parent;

            InitializeComponent();
        }

        private void btnEditUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUser();

            Factory.Factories.UsersFactory.UpdateUser(currentUser);
            parent.InitializeDataGrid();

            this.Hide();
        }

        public void UpdateForm()
        {
            txtEditName.Text = currentUser.Name;
            txtEditSecond.Text = currentUser.SecondName;
            txtEditPhone.Text = currentUser.PhoneNumber;
            txtEditAdress.Text = currentUser.Adress;
        }

        private void UpdateUser()
        {
            currentUser.Name = txtEditName.Text;
            currentUser.SecondName = txtEditSecond.Text;
            currentUser.PhoneNumber = txtEditPhone.Text;
            currentUser.Adress = txtEditAdress.Text;

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }
    }
}
