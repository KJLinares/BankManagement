using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using BusinessLayer;

namespace ClassLibraryDataSide
{
    public static class CustomerDB
    {
        public static String filePath = @"custpmerDict.ser";
        public const String textFile = @"C:\C#project\customerDB.txt";


        public static void SaveToTextFile(Dictionary<int, Customer> customerList)
        {
            if (!File.Exists(textFile))
                File.Create(textFile);

            StreamWriter textOut = new StreamWriter(new FileStream(textFile, FileMode.OpenOrCreate, FileAccess.Write));
            foreach (Customer customer in customerList.Values)
            {
                textOut.Write(customer.CustomerId + "|");
                textOut.Write(customer.Pin + "\n");
            }
            textOut.Close();
        }

        public static void SaveToFile(Dictionary<int, Customer> customerList)
        {
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (Customer current in customerList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, Customer> ReadFromFile()
        {
            Dictionary<int, Customer> customerList = new Dictionary<int, Customer>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    Customer aCustomer = new Customer();
                    aCustomer = (Customer)binaryFormatter.Deserialize(fileStream);
                    customerList.Add(aCustomer.CustomerId, aCustomer);
                }
                fileStream.Close();
            }
            else
            {

                customerList = null;
            }
            return customerList;
        }


    }
}
