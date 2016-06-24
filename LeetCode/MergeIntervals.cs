using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    // Definition for an interval.
    public class Interval
    {
        public int start;
        public int end;
        public Interval() { start = 0; end = 0; }
        public Interval(int s, int e) { start = s; end = e; }
    }

    /* https://leetcode.com/problems/merge-intervals/
     * 56. Merge Intervals 
        Total Accepted: 71039 Total Submissions: 273716 Difficulty: Hard
        Given a collection of intervals, merge all overlapping intervals.

        For example,
        Given [1,3],[2,6],[8,10],[15,18],
        return [1,6],[8,10],[15,18].
     */
    internal class MergeIntervals
    {
        public IList<Interval> Solution(IList<Interval> intervals)
        {
            List<Interval> list = new List<Interval>();
            if (intervals == null || intervals.Count == 0)
            {
                return intervals;
            }
            list = intervals.OrderBy(s => s.start).ToList();
            int i = 0;
            while (i < list.Count - 1)
            {
                if (list[i].end >= list[i + 1].start)
                {
                    if (list[i].end < list[i + 1].end)
                    {
                        list[i].end = list[i + 1].end;
                    }
                    list.RemoveAt(i + 1);
                }
                else
                {
                    i++;
                }
            }
            return list;
        }
    }
}
