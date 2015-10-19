using System;
using System.ComponentModel;
using System.Windows;
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для AddEditBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        BookList parent;

        public AddBook(BookList parent)
        {
            this.parent = parent;

            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Book newBook = new Book();
            newBook.Name = txtBookName.Text;
            newBook.AuthorName = txtBookAuthor.Text;
            newBook.CreatedDate = DateTime.Now;
            newBook.Serial = txtSerialnumber.Text;
            newBook.Modify = DateTime.Now;
            newBook.Year = txtBookYear.Text;

            Factory.Factories.BooksFactory.AddBook(newBook);

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
