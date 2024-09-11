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

        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
            Lab2.CombineSortedArrays(new int[]{-5, 2, 5, 8, 10}, new int[]{1, 2, 5}),
            new int[]{-5, 1, 2, 2, 5, 5, 8, 10}));
    }

    [Fact]
    public void Test2()
    {
        System.Diagnostics.Debug.Assert(Enumerable.SequenceEqual(
            Lab2.SortViaMergeSort(new int[]{6, 1, -5, 3, 5, 3, 7}),
            new int[]{-5, 1, 3, 3, 5, 6, 7}));

    }
}