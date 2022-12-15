using System;
using System.Globalization;

namespace MultiDimentional_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            BUSTIMETABLE[,] arr = new BUSTIMETABLE[3, 3];
            arr[0, 0] = new BUSTIMETABLE("Jhansi", "08:40", "09:40", "10:40");
            arr[0, 1] = new BUSTIMETABLE("Jaipur", "08:50", "09:50", "10:50");
            arr[0, 2] = new BUSTIMETABLE("Lucknow", "09:00", "10:00", "11:00");
            arr[1, 0] = new BUSTIMETABLE("Orai", "09:10", "10:10", "11:10");
            arr[1, 1] = new BUSTIMETABLE("Kalpi", "09:20", "10:20", "11:20");
            arr[1, 2] = new BUSTIMETABLE("Kanpur", "09:30", "10:30", "11:30");
            arr[2, 0] = new BUSTIMETABLE("Orai", "09:10", "10:10", "11:10");
            arr[2, 1] = new BUSTIMETABLE("Jaipur", "08:50", "09:50", "10:50");
            arr[2, 2] = new BUSTIMETABLE("Orai", "09:10", "10:10", "11:10");

            for (int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.WriteLine(BUSTIMETABLE[i][j]);
                }
            }
            
        }
    }

}