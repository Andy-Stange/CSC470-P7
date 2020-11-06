using Builder;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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

        private static List<Issue> Issues = new List<Issue>();

        public int CurrentProjID { get; private set; }

        public FakeIssueRepository()
        {
            if (Issues.Count == 0)
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
                Issues.Add(new Issue
                {
                    ID = 2,
                    ProjectID = 1,
                    Title = "Second Issue",
                    DiscoveryDate = System.Convert.ToDateTime("10/9/2017 12:00:00 AM"),
                    Discoverer = "Kyle",
                    InitialDescription = "The Second issue ever",
                    Component = "FormMain",
                    IssueStatusID = 2

                });
                Issues.Add(new Issue
                {
                    ID = 3,
                    ProjectID = 1,
                    Title = "Third Issue",
                    DiscoveryDate = System.Convert.ToDateTime("10/31/2017 12:00:00 AM"),
                    Discoverer = "Kyle",
                    InitialDescription = "The Third issue ever",
                    Component = "FormMain",
                    IssueStatusID = 1

                });
                Issues.Add(new Issue
                {
                    ID = 4,
                    ProjectID = 1,
                    Title = "Fourth Issue",
                    DiscoveryDate = System.Convert.ToDateTime("11/15/2017 12:00:00 AM"),
                    Discoverer = "Kyle",
                    InitialDescription = "The Fourth issue ever",
                    Component = "FormMain",
                    IssueStatusID = 2

                });

            }
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
            Issues.Remove(issue);
            return false;
        }
        public string Modify(Issue issue)
        {
            _selectID = issue.ID;
            int index = 0;
            foreach (Issue i in Issues)
            {
                if (_selectID == i.ID)
                {
                    Issues[index].ID = issue.ID;
                    Issues[index].Title = issue.Title;                        ;
                    Issues[index].DiscoveryDate = issue.DiscoveryDate;
                    Issues[index].Discoverer = issue.Discoverer;
                    Issues[index].Component = issue.Component;
                    Issues[index].IssueStatusID = issue.IssueStatusID;
                    Issues[index].InitialDescription = issue.InitialDescription;
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
            List<int> numbers = new List<int>();
            foreach (Issue issue in Issues)
            {
                if (ProjectID == issue.ProjectID)
                {
                    if (Discs.Contains(issue.Discoverer))
                    {
                        numbers[Discs.IndexOf(issue.Discoverer)]++;
                    }
                    else
                    {
                        Discs.Add(issue.Discoverer);
                        numbers.Add(1);
                    }
                }
            }
            int index = 0;
            foreach (int num in numbers)
            {
                Discs[index] = Discs[index] + ": " + numbers;
                index++;
            }
            return Discs;
        }

        public List<string> GetIssuesByMonth(int ProjectID)
        {
            List<string> IsMonth = new List<string>();
            List<int> numbers = new List<int>();
            foreach(Issue issue in Issues)
            {
                if (issue.ProjectID == ProjectID)
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
        public int GetNextIssueID(int ProjectID)
        {
            int currMaxIssueID = 0;
            foreach(Issue issue in Issues)
            {
                if(ProjectID == issue.ProjectID)
                {
                    if(issue.ID > currMaxIssueID)
                    {
                        currMaxIssueID = issue.ID;
                    }
                }
            }
            currMaxIssueID++;
            return currMaxIssueID;
        }
    }
}
