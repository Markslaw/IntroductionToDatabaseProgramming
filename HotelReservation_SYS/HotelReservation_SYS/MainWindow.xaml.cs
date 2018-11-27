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
using System.Data.Entity.Core.Objects;

namespace HotelReservation_SYS
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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            HotelEntities hotel = new HotelEntities();
            ObjectParameter arg3 = new ObjectParameter("GET_EXISTING_USERNAME", typeof(String));
            ObjectParameter arg4 = new ObjectParameter("GET_EXISTING_PASSWORD", typeof(String));
            ObjectParameter arg5 = new ObjectParameter("GET_FAILED_ATTEMPTS", typeof(Int16));
            ObjectParameter arg6 = new ObjectParameter("GET_BLOCKTIME", typeof(DateTime));

            
        
            
                hotel.ADMIN_LOGIN_CHECK(txtUsername.Text, txtPassword.Text, arg3, arg4, arg5, arg6);

            MessageBox.Show(arg4.Value.ToString());
            


            if (txtPassword.Text == arg4.Value.ToString())
            {
                MessageBox.Show("You have succceddfully Logged in " + arg3.Value.ToString());
            }
           
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HotelEntities hotel = new HotelEntities();
            hotel.ADD_ROOM_RATE(txtRoomType.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDecimal(txtRate.Text));

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HotelEntities hotel = new HotelEntities();
            ObjectParameter arguement2 = new ObjectParameter("o_cust_id", typeof(Int16));
            ObjectParameter arguement3 = new ObjectParameter("O_forename", typeof(String));
            ObjectParameter arguement4 = new ObjectParameter("O_surname", typeof(String));
            ObjectParameter arguement5 = new ObjectParameter("O_DOB", typeof(String));
            ObjectParameter arguement6 = new ObjectParameter("O_EMAIL", typeof(String));
            ObjectParameter arguement7 = new ObjectParameter("O_mobile_no", typeof(String));
            ObjectParameter arguement8 = new ObjectParameter("O_Loyalty", typeof(String));

            hotel.SP_SEARCH_EXISTING_CUSTOMER("Peter", arguement2, arguement3, arguement4, arguement5, arguement6, arguement7,arguement8);

            MessageBox.Show(arguement2.Value.ToString());
       
            

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAddRoomRate_Click(object sender, RoutedEventArgs e)
        {
           // HotelEntities bla = new HotelEntities();
           // bla.SIMPLERIIMRATEs.ToString();
           // cmbResultset.
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            HotelReservation_SYS.AdminsDataSet adminsDataSet = ((HotelReservation_SYS.AdminsDataSet)(this.FindResource("adminsDataSet")));
            // Load data into the table ADMINS. You can modify this code as needed.
            HotelReservation_SYS.AdminsDataSetTableAdapters.ADMINSTableAdapter adminsDataSetADMINSTableAdapter = new HotelReservation_SYS.AdminsDataSetTableAdapters.ADMINSTableAdapter();
            adminsDataSetADMINSTableAdapter.Fill(adminsDataSet.ADMINS);
            System.Windows.Data.CollectionViewSource aDMINSViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("aDMINSViewSource")));
            aDMINSViewSource.View.MoveCurrentToFirst();
        }
    }
}
