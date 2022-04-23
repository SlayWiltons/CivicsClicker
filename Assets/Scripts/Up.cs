using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    [SerializeField] private ClickUpgrade _clickUpgrade;

    public void OnClickUpgrade()
    {
        _clickUpgrade.IncUpgrades();
    }
}
