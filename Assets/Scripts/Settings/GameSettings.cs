using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameSettings", menuName = "GameSettings")]
public class GameSettings : ScriptableObject
{
    [Header("Click parameters", order = 0)]
    public ulong _clickDefaultCost;
    public ulong _autoClickDefaultCost;
    public ulong _clickDefaultUpgradePrice;
    public ulong _autoClickDefaultPrice;
    [Header("Resourses parameters", order = 1)]
    public ulong _maxCivicsStart;
    public ulong _maxFoodStart;
    public ulong _maxWoodStart;
    public ulong _maxGoldStart;
    public ulong _maxStoneStart;
    public ulong _maxPeopleStart;
}
