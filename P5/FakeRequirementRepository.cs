using System.Collections.Generic;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements Must Be Unique!";
        public const string EMPTY_STATEMENT_ERROR = "Statement Must Have A Value!";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement Does Not Exist!";
        public const string MISSING_FEATUREID_ERROR = "Must Select A Feature For This Requirement!";
        public const string MISSING_PROJECTID_ERROR = "Must Select A Project For This Requirement!";

        private static List<Requirement> requirements = new List<Requirement>();
        public FakeRequirementRepository()
        {
            if(requirements.Count == 0)
            {
                requirements.Add(new Requirement
                {
                    ID = 1,
                    ProjectID = 1,
                    FeatureID = 1,
                    Statement = "This is how we recieve things..."
                });
                requirements.Add(new Requirement
                {
                    ID = 2,
                    ProjectID = 1,
                    FeatureID = 2,
                    Statement = "This is how we pay things..."
                });
                requirements.Add(new Requirement
                {
                    ID = 3,
                    ProjectID = 1,
                    FeatureID = 3,
                    Statement = "This is how we balance things..."
                });


            }
        }

        public string Add(Requirement requirement)
        {
            if(requirement.Statement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            foreach(Requirement req in requirements)
            {
                if(requirement.Statement == req.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }
            if(requirement.ProjectID == 0)
            {
                return MISSING_PROJECTID_ERROR;
            }
            if(requirement.FeatureID == 0)
            {
                return MISSING_FEATUREID_ERROR;
            }
            requirements.Add(requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectID)
        {
            return requirements;
        }
        public string Remove(Requirement requirement)
        {
            int index = 0;
            foreach(Requirement req in requirements)
            {
                if(requirement.ID == req.ID)
                {
                    requirements.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public string Modify(Requirement requirement)
        {
            string newReqStatement = requirement.Statement;
            int index = 0;
            if(newReqStatement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }
            foreach(Requirement req in requirements)
            {
                if(newReqStatement == req.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }
            foreach (Requirement req in requirements)
            {
                if(req.ID == requirement.ID)
                {
                    requirements[index] = requirement;
                    return NO_ERROR;
                }
                index++;
            }
            return REQUIREMENT_NOT_FOUND_ERROR;

        }
        public Requirement GetRequirementByID(int featureID)
        {
            Requirement foundReq = new Requirement();
            foreach(Requirement req in requirements)
            {
                if(req.FeatureID == featureID)
                {
                    foundReq = req;
                }
            }
            return foundReq;
        }
        public int CountByFeatureID(int featureID)
        {
            int count = 0;
            foreach(Requirement req in requirements)
            {
                if(featureID == req.FeatureID)
                {
                    count++;
                }
            }
            return count;
        }
        public void RemoveByFeatureID(int featureID)
        {
            int index = 0;
            foreach(Requirement req in requirements)
            {
                if(featureID == req.FeatureID)
                {
                    requirements.RemoveAt(index);
                }
                index++;
            }
        }
        public int GetNextReqID(int ProjectID)
        {
            int NextID = 0;
            foreach (Requirement r in requirements)
            {
                if (ProjectID == r.ProjectID)
                {
                    if (r.ID > NextID)
                    {
                        NextID = r.ID;
                    }
                }
            }
            NextID++;
            return NextID;
        }

    }
}
