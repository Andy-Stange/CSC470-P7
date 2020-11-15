using System.Collections.Generic;

namespace P5

{
    public interface IFeatureRepository
    {
        string Add(Feature feature);
        List<Feature> GetAll(int ProjectID);
        string Remove(Feature feature);
        string Modify(Feature feature);
        Feature GetFeatureByID(int FeatureID);
        Feature GetFeatureByTitle(string Title);
    }
}
