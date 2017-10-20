namespace WordCounter.ViewModels.Home
{
    public class IndexModel
    {
        public bool DisplayMatchResults{get; set;}
        public int MatchCount {get; set;}

        public IndexModel()
        {
            DisplayMatchResults = false;
            MatchCount = 0;
        }

        public IndexModel(int matchCount)
        {
            DisplayMatchResults = true;
            MatchCount = matchCount;
        }
    }
}
