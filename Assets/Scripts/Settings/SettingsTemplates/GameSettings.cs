using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewGameSettings", menuName = "Game settings")]
public class GameSettings : ScriptableObject
{
    [Header("Click parameters", order = 0)]
    public int defaultPointsOnClick;
}
