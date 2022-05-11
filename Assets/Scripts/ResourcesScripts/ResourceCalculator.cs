using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceCalculator : MonoBehaviour
{
    [SerializeField] private Resource _resource;
    [SerializeField] private TextMeshProUGUI _resourceName;
    [SerializeField] private TextMeshProUGUI _resourceQuantity;
    private ulong _currentQuantity;

    private void Awake()
    {
        _resourceName.text = _resource.resourceName;
        _currentQuantity = _resource.startQuantity;
        _resourceQuantity.text = _currentQuantity.ToString();
    }

    public void PlusPoints(ulong points)
    {
        _currentQuantity += points;
        _resourceQuantity.text = _currentQuantity.ToString();
    }

    public void MinusPoints(ulong points)
    {
        _currentQuantity -= points;
        _resourceQuantity.text = _currentQuantity.ToString();
    }

    public ulong GetCurrentQuantity()
    {
        return _currentQuantity;
    }
}
