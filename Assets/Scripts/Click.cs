using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private Calculator _calculator;

    public void ClickButton()
    {
        _calculator.AddCivics();
    }
}
