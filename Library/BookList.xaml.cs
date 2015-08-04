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
        private AddBook addBookForm;

        private EditBook editBookForm;

       Menu parent;

        public BookList(Menu parent)
        {
            this.parent = parent;

            InitializeComponent();

            InitializeDataGrid();

            addBookForm = new AddBook(this);
            editBookForm = new EditBook(this);
           
        }

        private void btnAddBook_Click(object sender, RoutedEventArgs e)
        {
            addBookForm.Show();
        }


        private void EditBook_Click(object sender, RoutedEventArgs e)
        {
            var bookToEdit = (Book)((Button)e.Source).DataContext;
            editBookForm.CurrentBook = bookToEdit;
            editBookForm.Show();
        }


        private void DeleteBook_Click(object sender, RoutedEventArgs e)
        {

            var bookToDelete = (Book)((Button)e.Source).DataContext;
            Factory.Factories.BooksFactory.DeleteBook(bookToDelete);
            InitializeDataGrid();
        }

        public void InitializeDataGrid()
        {
            DgBooks.ItemsSource = Factory.Factories.BooksFactory.GetList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;

            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Show();
            this.Hide();
        }
    }
}
