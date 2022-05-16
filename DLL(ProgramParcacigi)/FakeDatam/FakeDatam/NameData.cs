using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDatam
{
   public static class NameData
    {
        public static  String GetName()
        {
            List<String> nameList = new  List <String>();
            nameList.Add("Tuğçe");
            nameList.Add("Merve");
            nameList.Add("Beyza");
            nameList.Add("Yeserra");
            nameList.Add("Büşra");
            nameList.Add("Hilal");
            nameList.Add("Nida");
            nameList.Add("Recep");




            Random rnd = new Random();
            int index = rnd.Next(nameList.Count);

            return nameList[index];
        }


        public static String GetSurname()
        {
            List<String> surnameList = new List<String>();
            surnameList.Add("Matur");
            surnameList.Add("Ercan");
            surnameList.Add("Mılık");
            surnameList.Add("Ak");
            surnameList.Add("Türker");
        
      
            Random rnd = new Random();
            int index = rnd.Next(surnameList.Count);

            return surnameList[index];
        }



    }
}
