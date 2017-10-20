using WordCounter.Models;

namespace WordCounter.ViewModels.Home
{
    public class IndexModel
    {
        public string InputSentence {get; private set;} = "";
        public string InputWord {get; private set;} = "";
        public bool DisplayMatchResults {get; private set;} = false;
        public int MatchCount {get; private set;} = 0;

        public IndexModel()
        {

        }

        public IndexModel(string inputSentence, string inputWord)
        {
            InputSentence = inputSentence;
            InputWord = inputWord;
            DisplayMatchResults = true;
            try
            {
                MatchCount = MatchFinder.CountMatches(inputSentence, inputWord);
            }
            catch
            {
                MatchCount = 0;
            }
        }
    }
}
