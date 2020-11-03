using Builder;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public string EMPTY_DISCOVERER_ERROR = "A Discoverer is required";
        public string DUPLICATE_TITLE_ERROR = "That title already exists!";
        public const string MODIFIED_ISSUE_ERROR = "Can not modify the Issue.";
        public const string EMPTY_PROJECT_NAME_ERROR = "Required Spots are empty or blank.";
        public int _selectID;

        private static List<Issue> Issues;

        public FakeIssueRepository()
        {

            Issues.Add(new Issue
            {
                ID = 1,
                ProjectID = 1,
                Title = "First Issue",
                DiscoveryDate = System.Convert.ToDateTime("10/1/2017 12:00:00 AM"),
                Discoverer = "Kyle",
                InitialDescription = "The first issue ever",
                Component = "FormMain",
                IssueStatusID = 2

            });
        }

        public string Add(Issue issue)
        {
            if (isDuplicate(issue.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if(issue.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectID)
        {
            List<Issue> IssueList = new List<Issue>();
            foreach(Issue issue in Issues)
            {
                if(issue.ProjectID == ProjectID)
                {
                    IssueList.Add(issue);
                }
            }
            return IssueList;
        }

        public bool Remove(Issue issue)
        {
            int index = 0;
            foreach (Issue issues in Issues)
            {
                if (issues == issue)
                {
                    Issues.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
        public string Modify(Issue issue)
        {
            FormModifySelectIssue modify = new FormModifySelectIssue();
            _selectID = modify._selectedID;

            int index = 0;
            foreach (Issue i in Issues)
            {
                if (_selectID == i.ID)
                {
                    Issues[index] = issue;
                    return NO_ERROR;
                }
                index++;
            }
            return "Error";
        }
        public int GetTotalNumberOfIssues(int ProjectID)
        {
            int issueCount = 0;
            foreach(Issue issue in Issues)
            {
                if(issue.ProjectID == ProjectID)
                {
                    issueCount++;
                }
            }
            return issueCount;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectID)
        {
            List<string> Discs = new List<string>();
            foreach(Issue issue in Issues)
            {
                if(ProjectID == issue.ProjectID)
                {
                    Discs.Add(issue.Discoverer);
                }
            }
            return Discs;
        }

        public List<string> GetIssuesByMonth(int ProjectID)
        {
            List<string> IsMonth = new List<string>();
            List<int> numbers = new List<int>();
            foreach(Issue issue in Issues)
            {
                if (IsMonth.Contains(issue.DiscoveryDate.Year.ToString() + " - " + issue.DiscoveryDate.Month.ToString()))
                {
                    numbers[IsMonth.IndexOf(issue.DiscoveryDate.Year.ToString() + " - " + issue.DiscoveryDate.Month.ToString())]++;
                }
                else
                {
                    IsMonth.Add(issue.DiscoveryDate.Year.ToString() + " - " + issue.DiscoveryDate.Month.ToString());
                    numbers.Add(1);
                }
            }
            int index = 0;
            foreach(int num in numbers)
            {
                IsMonth[index] = IsMonth[index] + ": " + numbers;
                index++;
            }
            return IsMonth;
        }

        public Issue GetIssueByID(int ID)
        {
            Issue foundIssue = new Issue();
            foreach(Issue issue in Issues)
            {
                if(ID == issue.ID)
                {
                    foundIssue = issue;
                }
            }
            return foundIssue;
        }
        public bool isDuplicate(string title)
        {
            bool isDup = false;
            foreach(Issue issue in Issues)
            {
                if(issue.Title == title)
                {
                    isDup = true;
                }
            }
            return isDup;
        }
        public string ValidateIssue(Issue issue)
        {
            int result = DateTime.Compare(issue.DiscoveryDate, DateTime.Now);
            if(issue.Title == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if (isDuplicate(issue.Title))
            {
                return DUPLICATE_TITLE_ERROR;
            }
            if(issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if(result > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if(issue.Discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            return NO_ERROR;
        }
    }
}
