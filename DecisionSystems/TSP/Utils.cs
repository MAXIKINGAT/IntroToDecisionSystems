using System;
using System.Collections.Generic;
using System.Linq;

namespace DecisionSystems.TSP
{
    public static class Utils
    {
        public static double GetDistance(IReadOnlyCollection<int> solution, IReadOnlyList<Location> cities)
        {
            Location getLocation(int solutionIndex)
            {
                return cities[solutionIndex - 1];
            }

            return solution
                .Append(solution.First())
                .Select(getLocation)
                .PairWise(GetDistance)
                .Sum();
            
        }      

        public static double GetDistance(Location a, Location b)
        {
            var dx = a.X - b.X;
            var dy = a.Y - b.Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}