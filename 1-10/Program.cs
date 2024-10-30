namespace Main;
class Program
{
     static void Main()
     {
          //? problem #1
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

          //? problem #?
          #region
          #endregion
     }
};
