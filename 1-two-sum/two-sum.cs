using System.Collections;

public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        
        Dictionary<int,int> seen = new Dictionary<int,int>();   // Stores numbers seen and the index
        
        for( int i=0; i < nums.Length; i++)
        {
           int neededValue = target - nums[i];
           if (seen.TryGetValue(neededValue, out int neededValueIndex))
           {
                return new int[] {i, neededValueIndex};
           }
           seen.TryAdd(nums[i], i);
           
        }
        return null;
    }
}