using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MechanicApp
{
    class FileManager
    {
        static String CustFilePath = @"C:\Users\Kevin\Documents\Visual Studio 2015\Projects\MechanicApp\MechanicApp\Customer.txt";
        static String InvFilePath = @"C:\Users\Kevin\Documents\Visual Studio 2015\Projects\MechanicApp\MechanicApp\Invoice.txt";

        //opens file for reading and writing 
        public static FileStream Open(String FileName)
        {
            String FilePath = "";
            if (FileName == "Customer.txt") {
                FilePath = CustFilePath;
            }
            if (FileName == "Invoice.txt")
            {
                FilePath = InvFilePath;
            }
            FileStream inFile = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);
         
            return inFile;
        }

        // allows to append the text files. 
        //Honestly, this is bad code
        // I have two functions that essentially do the same thing 
        //One is used to open the other is used to append
        //will need to fix at some point but for now it works. 
        public static FileStream Append(String FileName)
        {
            String FilePath = "";
            if (FileName == "Customer.txt")
            {
                FilePath = CustFilePath;
            }
            if (FileName == "Invoice.txt")
            {
                FilePath = InvFilePath;
            }
            FileStream inFile = new FileStream(FilePath, FileMode.Append, FileAccess.Write);

            return inFile;
        }

    }
}
