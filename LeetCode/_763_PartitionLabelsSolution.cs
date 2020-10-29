using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _763_PartitionLabelsSolution
    {
        public _763_PartitionLabelsSolution()
        {
        }

        public IList<int> PartitionLabels(string S)
        {
            Dictionary<char, int> maxIndex = new Dictionary<char, int>();
            List<int> lengthList = new List<int>();

            char[] chars = S.ToCharArray();

            //记录每个字符出现的最远的index
            for (int i = 0; i < chars.Length; i++)
            {
                if (maxIndex.ContainsKey(chars[i]))
                {
                    maxIndex[chars[i]] = i;
                }
                else
                {
                    maxIndex.Add(chars[i], i);
                }
            }

            //应该分割的最远距离
            int max = 0;
            //分割的起始位置
            int start = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                //当前字符的最远距离
                int curMaxIndex = maxIndex[chars[i]];
                max = Math.Max(max, curMaxIndex);
                if (i == max)
                {
                    lengthList.Add(i - start + 1);
                    start = i + 1;
                }

            }
            return lengthList;
        }
    }
}
