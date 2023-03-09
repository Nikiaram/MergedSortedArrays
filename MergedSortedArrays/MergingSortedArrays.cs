
namespace MergedSortedArrays
{
    internal class MergingSortedArrays
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 1, 2, 3, 40, 55, 66, 77, 88 };
            int[] secondArray = new int[] { 9, 10, 11, 12, 13, 14, 15, 16 };

            var thirdSortedArray = MergingTwoSortedArrays(firstArray, secondArray);

            Test tests = new Test();
            tests.FinalTesting(firstArray, secondArray, thirdSortedArray);
        }

        /// <summary>
        /// Method returns merged collection of two sorted arrays
        /// </summary>
        /// <param name="firstSortedArray">firstSortedArray</param>
        /// <param name="secondSortedArray">secondSortedArray</param>
        /// <returns></returns>
        static int[] MergingTwoSortedArrays(int[] firstSortedArray, int[] secondSortedArray)
        {
            var thirdArray = new int[firstSortedArray.Length + secondSortedArray.Length];
            int x = 0, y = 0;
            for (int i = 0; i < thirdArray.Length; i++)
            {
                if (y == secondSortedArray.Length || ((x < firstSortedArray.Length) && (firstSortedArray[x] < secondSortedArray[y])))
                {
                    thirdArray[i] = firstSortedArray[x];
                    x++;
                }
                else
                {
                    thirdArray[i] = secondSortedArray[y];
                    y++;
                }
            }
            return thirdArray;
        }
    }
}