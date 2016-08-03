using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /* https://leetcode.com/problems/reconstruct-itinerary/
     * 332. Reconstruct Itinerary
        Total Accepted: 15108
        Total Submissions: 58334
        Difficulty: Medium
        Given a list of airline tickets represented by pairs of departure and arrival airports [from, to], reconstruct the itinerary in order. 
        All of the tickets belong to a man who departs from JFK. Thus, the itinerary must begin with JFK.

        Note:
        If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string. 
        For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
        All airports are represented by three capital letters (IATA code).
        You may assume all tickets form at least one valid itinerary.
        Example 1:
        tickets = [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]
        Return ["JFK", "MUC", "LHR", "SFO", "SJC"].
        Example 2:
        tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
        Return ["JFK","ATL","JFK","SFO","ATL","SFO"].
        Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"]. But it is larger in lexical order.
     */
    internal class ReconstructItinerary
    {
        public IList<string> FindItinerary(string[,] tickets)
        {
            IList<string> list = new List<string>();
            if (tickets == null || tickets.Length == 0)
            {
                return list;
            }
            int row = tickets.GetLength(0);
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>(row);
            for (int i = 0; i < row; i++)
            {
                if (!dict.ContainsKey(tickets[i, 0]))
                {
                    List<string> temp = new List<string>();
                    dict.Add(tickets[i, 0], temp);
                }
                dict[tickets[i, 0]].Add(tickets[i, 1]);
            }
            foreach (var item in dict.Values)
            {
                item.Sort();
            }
            Stack<string> stack = new Stack<string>();
            string key = string.Empty;
            stack.Push("JFK");
            while (row > 0)
            {
                string s = stack.Peek();
                if (dict.ContainsKey(s) && dict[s].Count() != 0)
                {
                    key = s;
                    string temp = dict[s][0];
                    stack.Push(temp);
                    dict[s].RemoveAt(0);
                    row--;
                }
                else
                {
                    if (dict.ContainsKey(key) && dict[key].Count != 0)
                    {
                        dict[key].Add(stack.Pop());
                        row++;
                    }
                }
            }

            return stack.ToList().Reverse<string>().ToList();
        }
    }
}
