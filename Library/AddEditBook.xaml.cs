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
using System.Windows.Shapes;
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Логика взаимодействия для AddEditBook.xaml
    /// </summary>
    public partial class AddEditBook : Window
    {
        public AddEditBook()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //add new book
            //Book newBook = new Book 
            //{
            //    Name = txtBookName.Text
            //};
            Book newBook = new Book();
            newBook.Name = txtBookName.Text;

            Factory.Factories.BooksFactory.AddBook(newBook);

            ((BookList)this.Owner).InitializeDataGrid();

            this.Hide();
        }
    }
}
