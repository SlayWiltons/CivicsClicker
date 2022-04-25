using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkersController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _workersGroupName;
    [SerializeField] private TextMeshProUGUI _workersCurrentCount;
    [SerializeField] private WorkersCalculator _workersCalculator;

    private void Awake()
    {
        _workersGroupName.text = _workersCalculator.GetWorkersGroupName() + ":";
        _workersCurrentCount.text = _workersCalculator.GetWorkersCount().ToString();
    }

    public void AddWorker()
    {
        _workersCalculator.AddWorkers();
        _workersCurrentCount.text = _workersCalculator.GetWorkersCount().ToString();
    }
}
