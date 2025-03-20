namespace QuestionnaireMathGameConsoleApp;

public class GameHistory
{
    List<Result> _results;

    private List<string> _gameResults;

    public GameHistory()
    {
        _results = new List<Result>();
        _gameResults = new List<string>();
    }

    internal IReadOnlyList<string> GameResults => _gameResults;

    internal void Add(string result) => _gameResults.Add(result);    
}
