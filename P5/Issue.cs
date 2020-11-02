namespace P5
{
    public class Issue
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public System.DateTime DiscoveryDate { get; set; }
        public string Discoverer { get; set; }
        public string InitialDescription { get; set; }
        public string Component { get; set; }
        public int IssueStatusID { get; set; }



    }
}
