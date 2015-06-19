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
