namespace Testing;
using MergeSort;
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
            Lab2.CombineSortedArrays(new int[]{1, 3, 5}, new int[]{-5, 3, 6, 7}),
            new int[]{-5, 1, 3, 3, 5, 6, 7}));

       
    }
}