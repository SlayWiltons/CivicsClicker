using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickUpgrade : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    private ulong _pointsFromUpgrade;
    private ulong _upgrades;
    private ulong _finalPoints;

    private void Awake()
    {
        _pointsFromUpgrade = _gameSettings._clickUpgradesPoints;
        _upgrades = _gameSettings._clickUpgrades;
    }

    public void IncUpgrades()
    {
        _upgrades++;
    }

    public ulong GetUpgradesWithPoints()
    {
        _finalPoints = _upgrades * _pointsFromUpgrade;
        return _finalPoints;
    }
}
