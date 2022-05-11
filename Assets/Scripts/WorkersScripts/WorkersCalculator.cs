using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorkersCalculator : MonoBehaviour
{
    [SerializeField] private Workers _workers;
    [SerializeField] private TextMeshProUGUI _workersName;
    [SerializeField] private TextMeshProUGUI _workersCount;
    [SerializeField] private ResourceCalculator _resourceCalculator;
    private ulong _price;
    private ulong _workersQuantity;

    private void Awake()
    {
        _workersName.text = _workers.groupName;
        _workersQuantity = _workers.startCount;
        _workersCount.text = _workersQuantity.ToString();
        _price = _workers.price;
    }

    public void TryMinus()
    {
        var resPoints = _resourceCalculator.GetCurrentQuantity();
        if (resPoints >= _price)
        {
            _resourceCalculator.MinusPoints(_price);
            PlusWorkers();
        }
        else
        {
            Debug.Log("Не хватает ресурсов!");
        }
    }

    private void PlusWorkers()
    {
        _workersQuantity++;
        _workersCount.text = _workersQuantity.ToString();
    }

    public ulong GetCurrentWorkers()
    {
        return _workersQuantity;
    }
}
