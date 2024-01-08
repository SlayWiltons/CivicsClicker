using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    [SerializeField] private Controller _controller;
    [SerializeField] private Resource _resource;

    public void PlusPoints()
    {
        if ((_resource.Quantity + _gameSettings.defaultPointsOnClick) <= _resource.Limit)
        {
            _controller.Add(_gameSettings.defaultPointsOnClick);
            _resource.Quantity += _gameSettings.defaultPointsOnClick;
        }
        else
        {
            _resource.Quantity = _resource.Limit;
        }
    }
}
