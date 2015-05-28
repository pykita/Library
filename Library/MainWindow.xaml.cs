﻿using System;
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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void btnHelloWorld_Click(object sender, RoutedEventArgs e)
        {
            Factory.Factories.BooksFactory.AddBook(new Book { Name = "Harry Potter and phylosophy stone" });
            Factory.Factories.BooksFactory.AddBook(new Book { Name = "Harry Potter and chamber of secrets" });

            var items = Factory.Factories.BooksFactory.GetList();
        }
    }
}
