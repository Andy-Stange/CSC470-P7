using System.Collections.Generic;

namespace P5
{
    public interface IRequirementRepository
    {
        string Add(Requirement requirement);
        List<Requirement> GetAll(int ProjectID);
        string Remove(Requirement requirement);
        string Modify(Requirement requirement);
        Requirement GetRequirementByID(int requirementID);
        int CountByFeatureID(int featureID);
        void RemoveByFeatureID(int featureID);

    }
}
