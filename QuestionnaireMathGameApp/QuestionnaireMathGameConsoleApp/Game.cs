using System;

namespace QuestionnaireMathGameConsoleApp;

public class Game
{
    MessageView _messageView = new MessageView();
    UserIteration _userIteration = new UserIteration();
    GameHistory _gameHistory = new GameHistory();

    public Game()
    {
        _messageView = new MessageView();
        _userIteration = new UserIteration();
        _gameHistory = new GameHistory();        
    }

    internal void Run()
    {
        _messageView.WelcomeMessage();
        _messageView.DisplayRule();

        Options userSelection;
        do
        {
            _messageView.DisplayMainMenu();
            userSelection = _userIteration.ReadUserSelection();
            switch (userSelection)
            {
                case Options.Play:
                    Play();
                    break;
                case Options.DisplayGameHistory:
                    DisplayGameHistory();
                    break;
                case Options.Exit:
                    MessageView.Display("Gracias por usar nuestra Questionnaire Math Game App");
                    break;
            }
        } while (userSelection != Options.Exit);
    }

    internal void Play()
    {
        throw new NotImplementedException();
    }

    internal void DisplayGameHistory()
    {
        throw new NotImplementedException();
    }
}
