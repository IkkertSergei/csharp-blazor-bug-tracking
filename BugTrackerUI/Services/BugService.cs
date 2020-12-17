using BugTrackerUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI.Services
{
    public class BugService : IBugService
    {
        private readonly List<Bug> _bugs = new List<Bug>();

        public void AddBug(Bug newBug)
        {
            newBug.Id = _bugs.Count + 1;
            _bugs.Add(newBug);
        }

        public List<Bug> GetBugs()
        {
            return _bugs;
        }
    }
}
