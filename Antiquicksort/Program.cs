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
        }
        static void ft_quicksort(ref int[] array, int left, int right)
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
        }


        public static void Main(string[] args)
        {
            int[] array = { 38, 257, 791, 279, 510, 275, 493, 59};


            //ft_print_array(array);

           // ft_array_swap(ref array, 0, 1);
            //ft_print_array(array);
            ft_quicksort(ref array, 0, array.Length - 2);
            ft_print_array(array);

        }

      

    }
}
