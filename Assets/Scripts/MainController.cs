using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    [SerializeField] private GameSettings _gameSettings;
    private ulong _baseCivics;

    private void Awake()
    {
        _baseCivics = _gameSettings._clickDefaultCost;
    }

    public ulong GetCivics()
    {
        return _baseCivics;
    }
}
