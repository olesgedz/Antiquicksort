using System;

namespace Antiquicksort
{
    class MainClass
    {
        static void ft_print_array(int[] array)
        {
            int i;

            i = 0;
            while (i < array.Length)
            {
                Console.Write("{0} ", array[i]);
                i++;
            }
            Console.Write("\n");
        }

       static void ft_array_swap(ref int[] array, int index_one, int index_two)
        {
            int temp;

            temp = array[index_one];
            Console.WriteLine("indexes:{0} {1}", index_one, index_two);
            array[index_one] = array[index_two];
            array[index_two] = temp;
            ft_print_array(array);
        }

       /* static void ft_quicksort(ref int[] array, int left, int right)
        {
            int pivot = (right - left) / 2;
            int pivot_new_postition = right + 1;
            Console.WriteLine("p: {0}, pn:{1} l:{2},r:{3}", pivot, pivot_new_postition, left, right);
            ft_array_swap(ref array, pivot, pivot_new_postition);
            while (right > left)
            {
                Console.WriteLine("hello");
                while (array[left] < array[pivot_new_postition] && (right > left))
                    left++;
                while (array[right] >= array[pivot_new_postition] && (right > left))
                    right--;

                if (right <= left)
                    break;
                Console.WriteLine("l:{0}r:{1}", left, right);
                ft_array_swap(ref array, left, right);
            }
            ft_array_swap(ref array, pivot, pivot_new_postition);

            //I have no idea f*** recursion 
            if (pivot - 1 > 0)
            {
                ft_quicksort(ref array, 0, pivot - 1); //left half
                                                      
            }

            if ((pivot + 1 < array.Length - 1) && (pivot < array.Length - 2) && !((array.Length - 1 - pivot) == 1))
            {
                ft_quicksort(ref array, pivot + 1, array.Length - 2); //right half
            }

            return;
        } */

        static void ft_quicksortv3(ref int[] array)
        {
            ft_quicksortv3(ref array, 0, array.Length - 1);

        }
        static void ft_quicksortv3(ref int[] array, int left, int right) // works and more readable 
        {
            if (left >= right)
                return;

            int pivot = array[(right + left) / 2];
            int index = ft_partition(ref array, left, right, pivot);

            ft_quicksortv3(ref array, left, index - 1);
            ft_quicksortv3(ref array, index, right);

        }
        static int ft_partition(ref int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (array[left] < pivot)
                    left++;
                while (array[right] >  pivot)
                    right--;

                if(left <= right)
                {
                    ft_array_swap(ref array, left, right);
                    left++;
                    right--;
                }
            }
            return (left);
        }

        static void ft_quicksortv2(ref int[] array)
        {
            ft_quicksortv3(ref array, 0, array.Length - 1);

        }

        static void ft_quicksortv2(ref int[] array, int left, int right) //works
        {
            int pivot = (right + left) / 2;
            int pivotValue = array[pivot];
            Console.WriteLine(pivotValue);
            int index = ft_partition(ref array, left, right, pivot);
            while (right >= left)
            {
                while (array[left] < pivotValue && (right > left))
                    left++;
                while (array[right] >= pivotValue && (right > left))
                    right--;


                if (left <= right)
                {
                    ft_array_swap(ref array, left, right);
                    left++;
                    right--;
                }
            }
            ft_quicksortv3(ref array, left, left - 1); //left
            ft_quicksortv3(ref array, left, right); //right
        }

        public static void Main(string[] args)
        {
            //int[] array1 = { 38, 257, 791, 279, 510, 275, 493, 59};
            //int[] array2 = { 38, 257, 791, 279, 510, 275, 493, 59};

            int[] array1 = {1,3,2};
            ft_print_array(array1);

            // ft_array_swap(ref array, 0, 1);
            //ft_print_array(array);
            DateTime start1 = DateTime.Now;
            Array.Sort(array1);
           
            DateTime end1 = DateTime.Now;



            Console.WriteLine("First:{0}", end1 - start1);
            ft_print_array(array1);

        }

      

    }
}
