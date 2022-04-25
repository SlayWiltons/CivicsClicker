using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkersCalculator : MonoBehaviour
{
    [SerializeField] private Workers _workers;
    private ulong _currentWorkersCount;

    private void Awake()
    {
        _currentWorkersCount = _workers.baseCount;
    }

    public void AddWorkers()
    {
        _currentWorkersCount++;
    }

    public ulong GetWorkersCount()
    {
        return _currentWorkersCount;
    }
}
