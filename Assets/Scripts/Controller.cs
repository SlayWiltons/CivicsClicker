using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private Resource _resource;
    [SerializeField] private TextMeshProUGUI _resourceName;
    [SerializeField] private TextMeshProUGUI _resourceQuantity;
    private Calculator _calculator;

    private void Awake()
    {
        _calculator = new Calculator();
    }

    private void Start()
    {
        _calculator.SetCurrentPoints(_resource.startQuantity);
        _resourceName.text = _resource.name;
        _resourceQuantity.text = _resource.startQuantity.ToString();
    }

    public void Add(ulong points)
    {
        _calculator.PlusPoints(points);
        _resourceQuantity.text = _calculator.GetCurrentPoints().ToString();
    }
}
