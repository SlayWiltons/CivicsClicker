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
        _controller.Add(_gameSettings.defaultPointsOnClick);
    }
}
