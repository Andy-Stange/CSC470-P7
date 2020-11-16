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

        List<Requirement> requirements = new List<Requirement>();
        public FakeRequirementRepository()
        {
            
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
        public Requirement GetRequirementByID(int requirementID)
        {
            Requirement foundReq = new Requirement();
            foreach(Requirement req in requirements)
            {
                if(req.ID == requirementID)
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

    }
}
