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
            HotelEntities hotel = new HotelEntities();//creating an instance of my framework
            ObjectParameter arg3 = new ObjectParameter("GET_EXISTING_USERNAME", typeof(String));//creating an objectParameter to store the arguements from the db
            ObjectParameter arg4 = new ObjectParameter("GET_EXISTING_PASSWORD", typeof(String));
            ObjectParameter arg5 = new ObjectParameter("GET_FAILED_ATTEMPTS", typeof(Int16));
            ObjectParameter arg6 = new ObjectParameter("GET_BLOCKTIME", typeof(DateTime));

            
        
            
                hotel.ADMIN_LOGIN_CHECK(txtUsername.Text, txtPassword.Text, arg3, arg4, arg5, arg6);//calling my store procedure and passing in the parameters

            MessageBox.Show(arg4.Value.ToString()); //displaying the data from the database to the user
            //proves that the procedure is in fact returning the coreect data from the database
            


            if (txtPassword.Text == arg4.Value.ToString())//if the entered password is equal to the correct password show message
            {
                MessageBox.Show("You have succceddfully Logged in " + arg3.Value.ToString());//again this arg3 value is comming directly from db
                //proves that procedure is successfully working
            
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
            HotelEntities hotel = new HotelEntities();//instance of framework
            hotel.ADD_ROOM_RATE(txtRoomType.Text.ToUpper(), txtDescription.Text.ToUpper(), Convert.ToDecimal(txtRate.Text));//calling procedure and adding relevant parameters

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HotelEntities hotel = new HotelEntities();//instance of framework
            ObjectParameter arguement2 = new ObjectParameter("o_cust_id", typeof(Int16));//creating object parametrs to store the outputs of the procedure
            ObjectParameter arguement3 = new ObjectParameter("O_forename", typeof(String));
            ObjectParameter arguement4 = new ObjectParameter("O_surname", typeof(String));
            ObjectParameter arguement5 = new ObjectParameter("O_DOB", typeof(String));
            ObjectParameter arguement6 = new ObjectParameter("O_EMAIL", typeof(String));
            ObjectParameter arguement7 = new ObjectParameter("O_mobile_no", typeof(String));
            ObjectParameter arguement8 = new ObjectParameter("O_Loyalty", typeof(String));

            hotel.SP_SEARCH_EXISTING_CUSTOMER("Peter", arguement2, arguement3, arguement4, arguement5, arguement6, arguement7,arguement8);//calling the procedure and using
            //the object parameters to store the values coming back from the database

            MessageBox.Show(arguement2.Value.ToString());//displaying a value coming back from the databse
       
            

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
            HotelReservation_SYS.RoomRates_View_DataSet roomRates_View_DataSet = ((HotelReservation_SYS.RoomRates_View_DataSet)(this.FindResource("roomRates_View_DataSet")));
            // Load data into the table ROOMRATESVIEW. You can modify this code as needed.
            HotelReservation_SYS.RoomRates_View_DataSetTableAdapters.ROOMRATESVIEWTableAdapter roomRates_View_DataSetROOMRATESVIEWTableAdapter = new HotelReservation_SYS.RoomRates_View_DataSetTableAdapters.ROOMRATESVIEWTableAdapter();
            roomRates_View_DataSetROOMRATESVIEWTableAdapter.Fill(roomRates_View_DataSet.ROOMRATESVIEW);
            System.Windows.Data.CollectionViewSource rOOMRATESVIEWViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("rOOMRATESVIEWViewSource")));
            rOOMRATESVIEWViewSource.View.MoveCurrentToFirst();
            HotelReservation_SYS.CustomersDataSet customersDataSet = ((HotelReservation_SYS.CustomersDataSet)(this.FindResource("customersDataSet")));
            // Load data into the table CUSTOMERS. You can modify this code as needed.
            HotelReservation_SYS.CustomersDataSetTableAdapters.CUSTOMERSTableAdapter customersDataSetCUSTOMERSTableAdapter = new HotelReservation_SYS.CustomersDataSetTableAdapters.CUSTOMERSTableAdapter();
            customersDataSetCUSTOMERSTableAdapter.Fill(customersDataSet.CUSTOMERS);
            System.Windows.Data.CollectionViewSource cUSTOMERSViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("cUSTOMERSViewSource")));
            cUSTOMERSViewSource.View.MoveCurrentToFirst();
        }
    }
}
