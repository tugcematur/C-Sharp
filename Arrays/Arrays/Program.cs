using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {/*
            #region Tek Boyutlu Array
            int[] arr;
            arr = new int[10];
            arr = new int[] { 1,2,3,4,5,6,7,8,9,0};

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (i * i) + 1;
            }

          //  arr = null;

            Random rnd = new Random ();
            for (int i = 0; i < arr.Length; i++)                                             //REFERANS DEĞİŞKENLER                 stringler yarı referans yarı value değişken
            {
                arr[i] = rnd.Next(10,100); // Next(0,1) ondalık sayı döndürür.
            }

            int[] arr2;      //İki referans değişkeni var 1 arraye işaret eden
            arr2 = arr;
            arr[0] = 100;
            int[] arr3 = new int[10];

            Array.Copy(arr, arr3, arr.Length);                   // method overload
            arr[0] = 1000;                                  //Başta adresi eşitlediğimiz için ikisinde de olacak.
            


            TekBoyutluArrayGoster(arr);
            Console.WriteLine("--------------------------");
          //  TekBoyutluArrayGoster(arr2);
            TekBoyutluArrayGoster(arr3); // adres eşitleme yapılmadı
            #endregion
            */
            #region 2- iki boyutlu diziler
          
          //  int[,] ikiBoyutluArr;
          //  int[,] ikiBoyutluArr2 = new int[3,3];
            int[,] ikiBoyutluArr3 = new int[,] { { 0,1,2}, { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

            
            ikiBoyutluArrayGoster(ikiBoyutluArrayDoldur(ikiBoyutluArr3));


            #endregion

            #region Jagged Arrays

            //  int[][] jaggedArr;
            int[][] jaggedArr2 = new int[5][];
            int[][] jaggedArr3 = new int[5][];
            jaggedArr3[0] = new int[] { 1, 2, 3 };
            jaggedArr3[1] = new int[] { 1, 2, 3, 4, 5, 6 };
            jaggedArr3[2] = new int[] { 1, 2, 3, 4 };
            jaggedArr3[3] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            jaggedArr3[4] = new int[] { 1 };

          //  jaggedArrayGoster(jaggedArr3);



            for (int i = 0; i < jaggedArr3.Length; i++)
            {
                for (int j = 0; j < jaggedArr3[i].Length; j++)
                {
                    Console.Write(jaggedArr3[i][j] + "");
                }

                Console.WriteLine();
            }


           


            #endregion
        }

        private static void jaggedArrayGoster(int[][] arr)
        {



            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j] + "");
                }
            }





        }
        private static void ikiBoyutluArrayGoster(int[,] arr)
        {


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine(i + 1 + ". satır" + j + 2 + "sutun degeri=" + arr[i, j]);
                }
            }


        }

        private static int[,] ikiBoyutluArrayDoldur(int[,] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Null Array. İşlem yapamıyorum.");
                return null;
            }

            else
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = (i + 1) * (j + 2);
                    }
                }

                return arr;
            }

        }

        static void TekBoyutluArrayGoster(int[] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Null Array. İşlem yapamıyorum.");
            }

            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }

            }


            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
