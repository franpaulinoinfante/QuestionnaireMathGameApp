namespace QuestionnaireMathGameConsoleApp;

public class MathOperation
{
    internal int Add(int firstValue, int secondValue) => firstValue + secondValue;

    internal int Substrat(int firstValue, int secondValue) => firstValue - secondValue;

    internal int Multiply(int firstValue, int secondValue) => firstValue * secondValue;

    internal int Div(int firstValue, int secondValue) => firstValue / secondValue;

    internal bool IsValidDiv(int firstValue, int secondValue)
    {
        return 
            secondValue > 0 &&
            firstValue > secondValue &&
            firstValue % secondValue == 0;
    }

}
