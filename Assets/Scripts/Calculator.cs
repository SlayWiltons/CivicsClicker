using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] private MainController _mainController;
    private ulong _currentCivics;
    private ulong _incomeCivics;

    private void Awake()
    {
        _currentCivics = 0;
    }

    private void Start()
    {
        _incomeCivics = _mainController.GetCivics();
    }

    public void AddCivics()
    {
        _currentCivics += _incomeCivics;
        Debug.Log(_currentCivics);
    }
}
