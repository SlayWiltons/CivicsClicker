using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator
{
    private ulong _currentPoints;

    public void PlusPoints(ulong points)
    {
        _currentPoints += points;
    }

    public void MinusPoints(ulong points)
    {
        _currentPoints -= points;
    }

    public void SetCurrentPoints(ulong points)
    {
        _currentPoints = points;
    }

    public ulong GetCurrentPoints()
    {
        return _currentPoints;
    }
}
