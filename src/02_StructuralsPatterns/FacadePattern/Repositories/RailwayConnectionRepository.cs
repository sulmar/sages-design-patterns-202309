using FacadePattern.Models;
using System;

namespace FacadePattern.Repositories
{
    public interface IRailwayConnectionRepository
    {
        RailwayConnection Find(string from, string to, DateTime when);
    }

    public class PkpRailwayConnectionRepository : IRailwayConnectionRepository
    {
        public RailwayConnection Find(string from, string to, DateTime when)
        {
            return new RailwayConnection { From = from, To = to, When = when, Distance = 1000 };
        }
    }
}
