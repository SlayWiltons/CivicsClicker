using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private ClickCalculator _clickCalculator;

    public void OnButtonClick()
    {
        _clickCalculator.AddPoints();
    }
}
