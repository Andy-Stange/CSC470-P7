using System.Collections.Generic;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title Must Be Unique!";
        public const string EMPTY_TITLE_ERROR = "Title Must Have A Value!";
        public const string NOT_FOUND_ERROR = "Feature Not Found!";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid ProjectID For Feature!";

        private static List<Feature> features = new List<Feature>();

        public string Add(Feature feature)
        {
            string newFeatureTitle = feature.Title;
            if(newFeatureTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            foreach(Feature feat in features)
            {
                if(feat.Title == newFeatureTitle)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
            }
            features.Add(feature);
            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectID)
        {
            return features;
        }
        public string Remove(Feature feature)
        {
            int index = 0;
            foreach(Feature feat in features)
            {
                if(feat.ID == feature.ID)
                {
                    features.RemoveAt(index);
                    return NO_ERROR;
                }
            }
            return NOT_FOUND_ERROR;
        }
        public string Modify(Feature feature)
        {
            string newFeatureTitle = feature.Title;
            int index = 0;
            if(newFeatureTitle == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            foreach(Feature feat in features)
            {
                if(feat.Title == newFeatureTitle)
                {
                    return DUPLICATE_TITLE_ERROR;
                }
            }
            foreach(Feature feat in features)
            {
                if(feat.ID == feature.ID)
                {
                    features[index] = feature;
                    return NO_ERROR;
                }
                index++;
            }
            return NOT_FOUND_ERROR;
        }
        public Feature GetFeatureByID(int FeatureID)
        {
            Feature foundFeature = new Feature(); ;
            foreach(Feature feat in features)
            {
                if(feat.ID == FeatureID)
                {
                    foundFeature = feat;
                }
            }
                return foundFeature;

        }
        public Feature GetFeatureByTitle(string Title)
        {
            Feature foundFeature = new Feature();
            foreach (Feature feat in features)
            {
                if (feat.Title == Title)
                {
                    foundFeature = feat;
                }
            }
            return foundFeature;
        }
        public int GetNextFeatureID(int ProjectID)
        {
            int NextID = 0;
            foreach (Feature feat in features)
            {
                if (ProjectID == feat.ProjectID)
                {
                    if (feat.ID > NextID)
                    {
                        NextID = feat.ID;
                    }
                }
            }
            NextID++;
            return NextID;
        }
    }
}
