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

          //? Problem #?
          #region
          #endregion
     }
};
