using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private List<IssueStatus> IssueStatuses;
        public void Add(int StatID, string Value)
        {
            IssueStatus IsStat = new IssueStatus();
            IsStat.ID = StatID;
            IsStat.Value = Value;
            IssueStatuses.Add(IsStat);
        }
        public List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }
        public int GetIdByStatus(string Value)
        {
            int ID = 0;
            foreach (IssueStatus entry in IssueStatuses)
            {
                if(entry.Value == Value)
                {
                    ID = entry.ID;
                }
            }
            return ID;
        }
        public string GetValueByID(int ID)
        {
            string Value = "";
            foreach (IssueStatus entry in IssueStatuses)
            {
                if (entry.ID == ID)
                {
                    Value = entry.Value;
                }
            }
            return Value;
        }
    }
}
