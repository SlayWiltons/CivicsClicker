using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private MainController _mainController;
    [SerializeField] private ClickUpgrade _clickUpgrade;
    private ulong _civicsFromUpgrade;
    private ulong _currentCivics;
    private ulong _incomeCivics;

    private void Awake()
    {
        _currentCivics = 0;
        _civicsFromUpgrade = 0;
    }

    private void Start()
    {
        _incomeCivics = _mainController.GetCivics();
    }

    public void AddCivics()
    {
        _civicsFromUpgrade = _clickUpgrade.GetUpgradesWithPoints();
        var sumPoints = _incomeCivics + _civicsFromUpgrade;
        _currentCivics += sumPoints;
    }
}
