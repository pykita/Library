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
using Library.Factory.Models;

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BookList : Window
    {
        private AddEditBook addEditBook;

        public BookList()
        {
            InitializeComponent();

            InitializeDataGrid();

            addEditBook = new AddEditBook();
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            addEditBook.Show();
            addEditBook.Owner = this;
        }

        public void InitializeDataGrid()
        {
            DgBooks.ItemsSource = Factory.Factories.BooksFactory.GetList();
        }
    }
}
