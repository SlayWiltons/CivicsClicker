using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    [SerializeField] private ResourceCalculator _resourceCalculator;
    private ulong _defaulClickPoints;

    private void Awake()
    {
        _defaulClickPoints = _gameSettings.defaultPointsOnClick;
    }

    public void PlusPoints()
    {
        _resourceCalculator.PlusPoints(_defaulClickPoints);
    }
}
