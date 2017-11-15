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
    public static class CreditAccountDB
    {
        public static string filePath = @"creditAccountDict.ser";

        public static void SaveToFile(Dictionary<int, CreditAccount> creditAccountList)
        {

            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            foreach (CreditAccount current in creditAccountList.Values)
            {
                binaryFormatter.Serialize(fileStream, current);
            }
            fileStream.Close();
        }

        public static Dictionary<int, CreditAccount> ReadFromFile()
        {
            Dictionary<int, CreditAccount> creditAccountList = new Dictionary<int, CreditAccount>();
            if (File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                while (fileStream.Position < fileStream.Length)
                {
                    CreditAccount anAccount = new CreditAccount();
                    anAccount = (CreditAccount)binaryFormatter.Deserialize(fileStream);
                    creditAccountList.Add(anAccount.AccountNum, anAccount);
                }
                fileStream.Close();
            }
            else
            {

                creditAccountList = null;
            }
            return creditAccountList;
        }
    }
}