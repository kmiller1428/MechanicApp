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
        public static bool append = false;
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
            if (!append)
            {
                FileStream inFile = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite);
                return inFile;
            }
            else
            {
                FileStream inFile = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
                return inFile;
            }
            
        }


    }
}
