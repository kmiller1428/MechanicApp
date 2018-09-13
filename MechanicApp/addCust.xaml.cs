using System;
using System.Collections.Generic;
using System.IO;
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

namespace MechanicApp
{
    /// <summary>
    /// Interaction logic for addCust.xaml
    /// </summary>
    public partial class addCust : Window
    {
        public addCust()
        {
            InitializeComponent();
        }
        //saves new customer information to the customer file 
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer = new StreamWriter(FileManager.Append("Customer.txt"));



            writer.WriteLine(txtbName.Text + "; "+ txtbPhone.Text+"; "+ txtbAddress.Text + ";");
            writer.WriteLine();
            writer.Close();
            
        }
    }
}
