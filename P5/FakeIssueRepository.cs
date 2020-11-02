using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace P5
{
    class FakeIssueRepository:IssueRepository
    {
        public string NO_ERROR = "";
        public string EMPTY_TITLE_ERROR = "A Title is required.";
        public string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date";
        public string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public string EMPTY_DISCOVERER_ERROR = "A Discoverer is required";

        private List<Issue> Issues;
    }
}
