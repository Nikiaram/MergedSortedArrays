using Xunit;

namespace SortedTest
{
    public class Test
    {
        [Fact]
        public void FinalTesting(int[] firstSortedArray, int[] secondSortedArray, int[] thirdSortedArray)
        {
            var result = thirdSortedArray;
            List<int> expectedResult = new List<int>(firstSortedArray.Length + secondSortedArray.Length);
            expectedResult.AddRange(firstSortedArray);
            expectedResult.AddRange(secondSortedArray);
            expectedResult.Sort();

            Assert.True(CheckResult(result, expectedResult));
        }

        private static bool CheckResult(int[] result, List<int> expectedResult)
        {
            if (result == null)
            {
                return false;
            }

            if (result.Length != expectedResult.Count)
            {
                return false;
            }

            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != expectedResult[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}