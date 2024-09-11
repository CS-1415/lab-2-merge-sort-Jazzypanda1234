// Mathew Olsen 9/11/24 Lab 2 Merge Sort

namespace MergeSort;

public static class Lab2{

//Method to split and sort using CombineSortedArrays method.
public static int[] SortViaMergeSort(int[] values)
{
    //splits the array into two halves
    int middle = values.Length / 2;
    int[] firstHalf = values[0..middle];
    int[] secondHalf = values[middle..values.Length];

    //checks if the arrays are the correct length, if they are not, the method runs again via recursion.
    if (values.Length < 2){
        return values;
    }
    else{
        return CombineSortedArrays(SortViaMergeSort(firstHalf), SortViaMergeSort(secondHalf));
    }
}

//Method used to combine two already sorted arrays into a larger sorted array.
public static int[] CombineSortedArrays(int[] a, int[] b)
    {
        //creates the larger array using the length of the two arrays.
        int[] c = new int[a.Length + b.Length];

        //initializes a count for each array to track how to combine.
        int count1 = 0;
        int count2 = 0;
       
        //loops to create the larger array from the two smaller.
        while(count1 + count2 < c.Length)
        {
            //checks to see if either array has been fully used, if not then it sorts and adds to the array until one is complete.
            if (count1 == a.Length){
                c[count1 + count2] = b[count2++];
            }
            else if(count2 == b.Length){
                c[count1 + count2] = a[count1++];
            }
            else if (a[count1] <= b[count2]){
                c[count1 + count2] = a[count1++];
            }
            else{
                c[count1 + count2] = b[count2++];
            }
        }
        return c;
    }
}
