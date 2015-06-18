using Library.Factory.Models;
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
            txtBookName.Text = currentBook.Name;
        }

        private void UpdateBook()
        {
            currentBook.Name = txtBookName.Text;
        }
    }
}
