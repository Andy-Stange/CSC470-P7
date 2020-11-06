using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> IssueStatuses = new List<IssueStatus>();

        FakeIssueStatusRepository()
        {
            IssueStatuses.Add(new IssueStatus
            {
                ID = 1,
                Value = "Open"
            });
            IssueStatuses.Add(new IssueStatus
            {
                ID = 2,
                Value = "Assigned"
            });
            IssueStatuses.Add(new IssueStatus
            {
                ID = 3,
                Value = "Fixed"
            });
            IssueStatuses.Add(new IssueStatus
            {
                ID = 4,
                Value = "Closed - Won't fix"
            });
            IssueStatuses.Add(new IssueStatus
            {
                ID = 5,
                Value = "Closed - Fixed"
            });
            IssueStatuses.Add(new IssueStatus
            {
                ID = 6,
                Value = "Closed - By Design"
            });
        }

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
