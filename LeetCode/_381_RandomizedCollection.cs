using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    /*
     * 此题完全按照题解，自己没有想出来
     */
    public class RandomizedCollection
    {
        Dictionary<int, HashSet<int>> idx;
        List<int> nums;
        Random random = new Random();
        /** Initialize your data structure here. */
        public RandomizedCollection()
        {
            idx = new Dictionary<int, HashSet<int>>();
            nums = new List<int>();
        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            int index = nums.Count;
            nums.Add(val);
            if (idx.ContainsKey(val))
            {
                idx[val].Add(index);
            }
            else
            {
                idx.Add(val, new HashSet<int> { index });
            }
            return idx[val].Count == 1;
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            if (!idx.TryGetValue(val, out var valIndexList) ||
                valIndexList.Count == 0)
                return false;

            var lastValue = nums.Last();
            if (lastValue == val)
            {
                valIndexList.Remove(nums.Count - 1);
                nums.RemoveAt(nums.Count - 1);
                return true;
            }

            var valLastIndex = valIndexList.Last();
            var exchangeIndexList = idx[lastValue];

            valIndexList.Remove(valLastIndex);
            exchangeIndexList.Remove(nums.Count - 1);
            exchangeIndexList.Add(valLastIndex);

            nums[valLastIndex] = lastValue;
            nums.RemoveAt(nums.Count - 1);
            return true;

        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            return nums[random.Next(nums.Count)];
        }
    }

    /**
     * Your RandomizedCollection object will be instantiated and called as such:
     * RandomizedCollection obj = new RandomizedCollection();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
