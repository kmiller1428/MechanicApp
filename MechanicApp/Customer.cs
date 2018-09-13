using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MechanicApp
{
    class Customer
    {
        public String name { get; set; }
        public String phone { get; set; }
        public String address { get; set; }

        public Customer() { }

        public Customer(String n, String p, String a) {
            name = n;
            phone = p;
            address = a;
        }
        //searches the customer file to find a customer by phone number
        //need to find a way to make this used end of line instead of semicolon
        //because this makes the Customer.txt format unfirendly.

        public Customer findCustomer(String p) {

            Customer found = new Customer { };

      

            StreamReader reader = new StreamReader(FileManager.Open("Customer.txt"));
            String search;
            string[] strArray;

          

            while ((search = reader.ReadLine()) != null)
            {
                
                if (search.Contains(p))
                {
                    strArray = search.Split(';');
                    found.name = strArray[0];
                    found.phone = strArray[1];
                    found.address = strArray[2];
                    reader.Close();
                    break;
                }
                else
                {
                    found.name = "Customer Not found";
                    found.phone = " ";
                    found.address = " ";
                    
                }
            }
            return found;
        }
    }
}
