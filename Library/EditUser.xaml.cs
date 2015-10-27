using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

        public User CurrentUser 
        {
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
            currentUser = Factory.Factories.UsersFactory.GetUserById(currentUser.Id);
            txtEditName.Text = currentUser.Name;
            txtEditSecond.Text = currentUser.SecondName;
            txtEditPhone.Text = currentUser.PhoneNumber;
            txtEditAdress.Text = currentUser.Adress;

            DgUserBook.ItemsSource = currentUser.BookList;
            DgBookAvalabel.ItemsSource = Factory.Factories.BooksFactory.GetBooksAvailable();
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnAddInUserBook_Click(object sender, RoutedEventArgs e)
        {
            List<Book> newUserBooks = new List<Book>();
            List<Book> newAvailable = new List<Book>();

            for (int i = 0; i < DgUserBook.Items.Count; i++)
            {
                if (((Book)DgUserBook.Items[i]).IsChecked)
                {
                    newAvailable.Add((Book)DgUserBook.Items[i]);
                }
                else
                {
                    newUserBooks.Add((Book)DgUserBook.Items[i]);
                }
            }
        }

    }
}
