using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 134. Gas Station
    //Description Submission  Discussion Add to List
    //There are N gas stations along a circular route, where the amount of gas at station i is gas[i].
    //You have a car with an unlimited gas tank and it costs cost[i] of gas to travel from station i to its next station(i+1). 
    //You begin the journey with an empty tank at one of the gas stations.
    //Return the starting gas station's index if you can travel around the circuit once, otherwise return -1.
    //Note:The solution is guaranteed to be unique.
    /// </summary>
    internal class GasStation
    {
        /*当总的gas数小于消耗的cost数时，那么就可以到达目的地。如果当前的gas数小于消费数cost，那么起点就要从下一个点开始算。最后统计总的gas数量和总的cost数量*/
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int tank = 0, start = 0, sumGas = 0, sumCost = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                sumGas += gas[i];
                sumCost += cost[i];
                tank += gas[i] - cost[i];
                if (tank < 0)
                {
                    start = i + 1;
                    tank = 0;
                }
            }
            return sumGas >= sumCost ? start : -1;
        }
    }
}
