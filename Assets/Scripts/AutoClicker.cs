using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    [SerializeField] private WorkersCalculator _workersCalculator;
    [SerializeField] private ulong _workersForOneClick;

    public ulong _getAutoPoints()
    {
        var _points = _workersCalculator.GetWorkersCount() / _workersForOneClick;
        return _points;
    }
}
