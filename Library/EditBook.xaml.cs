using System.ComponentModel;
using Library.Factory.Models;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для EditBook.xaml
    /// </summary>
    public partial class EditBook : Window
    {
        BookList parent;
        Book currentBook;

        public Book CurrentBook {
            get 
            { 
                return currentBook;
            } 
            set
            { 
                currentBook = value;
                this.UpdateForm();
            } 
        }

        public EditBook(BookList parent)
        {
            this.parent = parent;

            InitializeComponent();

            cbUserList.ItemsSource = Factory.Factories.UsersFactory.GeList();
        }

      
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            

            UpdateBook();

            Factory.Factories.BooksFactory.UpdateBook(currentBook);
            parent.InitializeDataGrid();

            this.Hide();
        }

        public void UpdateForm()
        {
            cbUserList.ItemsSource = Factory.Factories.UsersFactory.GeList();
            var refreh = Factory.Factories.BooksFactory.GetBookById(currentBook.Id);
            txtBookName.Text = refreh.Name;
            txtAuthorName.Text = refreh.AuthorName;
            txtSerialnumber.Text = refreh.Serial;
            txtYear.Text = refreh.Year;
            if (refreh.User != null)
            {
                cbUserList.SelectedValue = refreh.User.Id;
            }
        }

        private void UpdateBook()
        {
            currentBook.User = (User)cbUserList.SelectedItem;
            currentBook.Name = txtBookName.Text;
            currentBook.AuthorName = txtAuthorName.Text;
            currentBook.Serial = txtSerialnumber.Text;
            currentBook.Modify = DateTime.Now;
            currentBook.Year = txtYear.Text;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;

            this.Hide();
        }

        private void cbUserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

            
    }
}
