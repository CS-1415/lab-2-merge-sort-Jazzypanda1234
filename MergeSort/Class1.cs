// Mathew Olsen 9/11/24 Lab 2 Merge Sort

namespace MergeSort;

public static class Lab2{

public static int[] SortViaMergeSort(int[] values)
{
    int middle = values.Length / 2;

    int[] firstHalf = values[0..middle];
    int[] secondHalf = values[middle..values.Length];

    if (values.Length < 2){
        return values;
    }
    else{
        return CombineSortedArrays(SortViaMergeSort(firstHalf), SortViaMergeSort(secondHalf));
    }
}

public static int[] CombineSortedArrays(int[] a, int[] b)
    {
        int[] c = new int[a.Length + b.Length];

        int count1 = 0;
        int count2 = 0;
       
        while(count1 + count2 < c.Length)
        {
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
