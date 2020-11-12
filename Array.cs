using static System.Console;

namespace Data_Structures___Algorithms
{
    public class DS_Array
    {
        private int[] _array;
        private bool _isSorted = false;

        //Methods to implement:
        /*
            Search − Algorithm to search an item in a data structure.
            Sort − Algorithm to sort items in a certain order.
            Insert − Algorithm to insert item in a data structure.
            Update − Algorithm to update an existing item in a data structure.
            Delete − Algorithm to delete an existing item from a data structure.
        */

        public DS_Array(int[] arr)
        {
            _array = arr;
        }

        public void Search(int number)
        {
            if (!isEmpty())
            {
                for (int i = 0; i < _array.Length - 1; i++)
                {
                    if (_array[i] == number)
                    {
                        WriteLine("{0} found at index {1}", number, i);
                        break;
                    }
                }
            }
        }

        private bool isEmpty()
        {
            if (_array == null || _array.Length <= 0)
            {
                WriteLine("The array is empty.");
                return true;
            }
            else { return false; }
        }
    }
}