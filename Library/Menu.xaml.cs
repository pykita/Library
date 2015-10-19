using System.Windows;

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
