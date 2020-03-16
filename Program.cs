using System.Collections.Generic;
using System.Linq;
using System;

namespace iseng
{
    class Program
    {
        static void FindMedian(List<int> arr){
            var rnd = new Random();
            var arrCount = arr.Count();
            var halfIndex = arr.Count()/2;
            var sortedArray = arr.OrderBy(n => n);
            double median;
            var medianLow = new List<int>();
            var medianHigh = new List<int>();

            if(arrCount % 2 == 0){
                median = ((sortedArray.ElementAt(halfIndex) + sortedArray.ElementAt(halfIndex - 1)) / 2);
            }
            else{
                median = sortedArray.ElementAt(halfIndex);
            }

            for(int i = 0; i < arrCount; i++){
                if(arr[i] <= median){
                    medianLow.Add(arr[i]);
                }
                else if(arr[i] >= median){
                    medianHigh.Add(arr[i]);
                }
            }

            var indexLow1 = rnd.Next(medianLow.Count);
            var indexLow2 = rnd.Next(medianLow.Count);
            var indexHigh1 = rnd.Next(medianHigh.Count);
			var indexHigh2 = rnd.Next(medianHigh.Count);

            Console.WriteLine($"{medianLow[indexLow1]} {medianLow[indexLow2]}");
            Console.WriteLine($"{medianHigh[indexHigh1]} {medianHigh[indexHigh2]}");

        }

        static void Main(string[] args)
        {
            var arrList = new List<int>();
            for(int i = 0; i < 999; i++){
                var input = Convert.ToInt32(Console.ReadLine());

                if(input == 0){
                    break;
                }
                else{
                    arrList.Add(input);
                }
            }

            FindMedian(arrList);
        }
    }
}
