namespace MergeSort;

public class Lab2
{

    

    public static int[] CombineSortedArrays(int[] a, int[] b)
    {
        
        int[] c = new int[a.Length + b.Length];

        int count1 = 0;
        int count2 = 0;
       
        for (int i = 0; i <= c.Length; i++)
        {
            if (a[count1] <= b[count2])
            {
                c[count1 + count2] = a[count1++];
            }
            else
            {
                c[count1 + count2] = b[count2++];
            }
        }
        return c;
    }


}
