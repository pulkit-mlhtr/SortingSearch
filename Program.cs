// See https://aka.ms/new-console-template for more information

using System;

namespace CountNumber
{
    public static class SortedSearch
    {
        //Method finds number of items present in the array lower than input : "lessThan"
        public static int CountNumbers(int[] sortedArray, int lessThan)
        {                       
            return GetCount(sortedArray,lessThan,0,sortedArray.Length-1);
        }


        private static int GetCount(int[] sortedArray, int lessThan, int min, int max)
        {      
            //Handles the scenrio when pointer moves towards extreme right or left
            if (min>max && min <= sortedArray.Length)
            {
                if(max > -1 && sortedArray[max] == lessThan)
                {
                    return max;
                } 
                else
                {
                    return min;
                }                
            }           
            else
            {                
                int mid = (min + max) / 2;

                if(lessThan == sortedArray[min])
                {
                    //Return if exact value found in the array
                    return min;
                }
               
                if (lessThan < sortedArray[mid])
                {
                    //Move towards left 
                    return GetCount(sortedArray, lessThan, min, mid - 1);
                }
                else
                {
                    //Move towards right
                    return GetCount(sortedArray, lessThan, mid + 1, max);
                }
            }            
        }       

        public static void Main(string[] args)
        {
            //Change input here (Note: array should be sorted)
            Console.WriteLine(SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7,8,9,10,11,15,16,18,19 }, 6));
        }
    }
}
