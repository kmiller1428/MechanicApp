// Mechanic on wheels app.
// made for invoicing different jobs
//keeps customer and invoice records
//developed by Kevin Miller


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
using System.IO;


namespace MechanicApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //the constants are initial values I got from my mechanic friend
        //not set in stone. seem kind of high when the total is calculated. 
        decimal hours;
        decimal parts;
        decimal total;
        int rate = 45;
        decimal partsCharge = 0.1m;
        Customer cust = new Customer ();

        

        public MainWindow()
        {
            InitializeComponent();
        }
        // calculates total based on hours and cost of parts 
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            hours = Convert.ToDecimal(txtbHours.Text);
            parts = Convert.ToDecimal(txtbParts.Text);
            partsCharge = Convert.ToDecimal(txtbUpcharge.Text);
            rate = Convert.ToInt32(txtbRate.Text);
            

            total =  (hours * rate) + (parts*partsCharge +parts);
            txtbTotal.Text = String.Format( "{0:C}",total);
            

        }
        //searches for customer based on phone number
        private void btnSearchCust_Click(object sender, RoutedEventArgs e)
        {
            String phone = txtbPhone.Text;
            


            cust = cust.findCustomer(phone);

            txtbCust.Text = cust.name + "\n" + cust.phone + "\n" + cust.address;

        }
        // saves all the information needed for a full invoice to the invoice.txt file
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            FileManager.append = true;
            StreamWriter writer = new StreamWriter(FileManager.Open("Invoice.txt"));

            

                writer.WriteLine(cust.name);
                writer.WriteLine(cust.phone);
                writer.WriteLine(cust.address);
                writer.WriteLine(txtbHours.Text);
                writer.WriteLine(txtbParts.Text);
                writer.WriteLine(txtbTotal.Text);
                writer.WriteLine(DateTime.Now.ToString("M/d/yyyy"));
                writer.WriteLine(" ");
                writer.Close();
            
        }
        //opens the add customer form to add a customer to the customer file
        private void btnAddCust_Click(object sender, RoutedEventArgs e)
        {
            var addCust = new addCust();
            addCust.Show();
        
        }
    }
}
