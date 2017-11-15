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
    public static class CheckingAccountDB
    {
        public static string filePath = @"checkingAccountDict.ser";

        public static void SaveToFile(Dictionary<int, CheckingAccount> checkingAccountList)
        {

            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (CheckingAccount current in checkingAccountList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, CheckingAccount> ReadFromFile()
        {

            Dictionary<int, CheckingAccount> checkingAccountList = new Dictionary<int, CheckingAccount>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {

                        CheckingAccount anAccount = new CheckingAccount();
                        anAccount = (CheckingAccount)binaryFormatter.Deserialize(fileStream);
                        checkingAccountList.Add(anAccount.AccountNum, anAccount);

                }
                fileStream.Close();
            }
            else
            {

                checkingAccountList = null;
            }
            return checkingAccountList;
        }
    }
}