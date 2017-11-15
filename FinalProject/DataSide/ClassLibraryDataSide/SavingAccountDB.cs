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
    public static class SavingAccountDB
    {
        public static string filePath = @"savingAccountDict.ser";

        public static void SaveToFile(Dictionary<int, SavingAccount> savingAccountList)
        {

            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (SavingAccount current in savingAccountList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, SavingAccount> ReadFromFile()
        {
            Dictionary<int, SavingAccount> savingAccountList = new Dictionary<int, SavingAccount>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    SavingAccount anAccount = new SavingAccount();
                    anAccount = (SavingAccount)binaryFormatter.Deserialize(fileStream);
                    savingAccountList.Add(anAccount.AccountNum, anAccount);
                }
                fileStream.Close();
            }
            else
            {

                savingAccountList = null;
            }
            return savingAccountList;
        }
    }
}
