using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickCalculator : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    [SerializeField] private TextMeshProUGUI _civicsTextValue;
    private ulong _defaultPoints;
    private ulong _currentPoints;

    private void Awake()
    {
        _defaultPoints = _gameSettings.clickDefaultPoints;
        _civicsTextValue.text = _currentPoints.ToString();
    }

    public void AddPoints()
    {
        var _addingPoints = _defaultPoints;
        _currentPoints += _addingPoints;
        _civicsTextValue.text = _currentPoints.ToString();
    }
}
