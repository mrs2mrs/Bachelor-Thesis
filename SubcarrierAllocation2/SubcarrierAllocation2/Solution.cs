using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubcarrierAllocation2
{
    [Serializable()]	
    public class RelaySolution
    {
        public int RelayID { get; set; }
        public List<int> PRBs { get; set; }
        public RelaySolution() { }
        public RelaySolution(int id)
        {
            RelayID = id;
            PRBs = new List<int>();
        }
    }
    [Serializable()]	
    public class UserSolution
    {
        public UserSolution() { }
        public int UserID { get; set; }
        public List<int> PRBs { get; set; }
        public UserSolution(int id)
        {
            UserID = id;
            PRBs = new List<int>();
        }
    }
    [Serializable()]	
    public class Solution
    {
        public String description { get; set; }
        public List<RelaySolution> relaySolutions { get; set; }
        public List<UserSolution> userSolutions { get; set; }

        public Solution() { }
        public Solution(int relayCount, int userCount, String desc = null)
        {
            description = desc;
            relaySolutions = new List<RelaySolution>(relayCount);
            userSolutions = new List<UserSolution>(userCount);
        }

    }
}
