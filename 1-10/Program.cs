namespace Main;
class Program
{
     static void Main()
     {
          //? Problem #1 
          #region
          int[] TwoSum(int[] nums, int target)
          {
               Dictionary<int, int> map = new();

               for (int i = 0; i < nums.Length; i++)
                    if (map.ContainsKey(nums[i])) return [map[nums[i]], i];
                    else map[target - nums[i]] = i;

               return [];
          };
          #endregion

          //? Problem #2
          #region
          bool ContainsDuplicate(int[] nums)
          {
               HashSet<int> map = new();

               for (int i = 0; i < nums.Length; i++)
                    if (map.Contains(nums[i])) return true;
                    else map.Add(nums[i]);

               return false;

          };
          #endregion

          //? Problem #3
          #region
          int MissingNumber(int[] nums)
          {
               int expectedSum = nums.Length * (nums.Length + 1) / 2;
               return expectedSum - nums.Sum();
          };
          #endregion

          //? Problem #4
          #region
          IList<int> FindDisappearedNumbers(int[] nums)
          {
               HashSet<int> setNums = new(nums);
               List<int> missingNums = new();

               for (int i = 1; i <= nums.Length; i++)
                    if (!setNums.Contains(i)) missingNums.Add(i);

               return missingNums;
          };
          #endregion

          //? Problem #5
          #region
          int[] SmallerNumbersThanCurrent(int[] nums)
          {
               int[] orderedNums = (nums.OrderBy(num => num)).ToArray();
               Dictionary<int, int> smallerNumbersCounter = new();

               for (int i = 0; i < nums.Length; i++)
                    if (!smallerNumbersCounter.ContainsKey(orderedNums[i]))
                         smallerNumbersCounter.Add(orderedNums[i], i);

               return nums.Select(num => smallerNumbersCounter[num]).ToArray();
          };
          #endregion

          //? Problem #?
          #region
          #endregion
     }
};
