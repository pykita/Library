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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        private BookList enterBookListForm;
        private UserList enterUserListForm;


        public Menu()
        {
            InitializeComponent();

            enterBookListForm = new BookList(this);
            enterUserListForm = new UserList(this);


        }

        private void EnterBookList_Click(object sender, RoutedEventArgs e)
        {
            enterBookListForm.Show();
            this.Hide();
        }

        private void EnterUserList_Click(object sender, RoutedEventArgs e)
        {
            enterUserListForm.Show();
            this.Hide();
        }

        

        
    }
}
