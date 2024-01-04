public class Calculator
{
    private int _currentPoints;
    private int _maxLimit;

    public void PlusPoints(int points)
    {
        _currentPoints += points;
    }

    public void MinusPoints(int points)
    {
        _currentPoints -= points;
    }

    public void SetCurrentPoints(int points)
    {
        _currentPoints = points;
    }

    public int GetCurrentPoints()
    {
        return _currentPoints;
    }
}
