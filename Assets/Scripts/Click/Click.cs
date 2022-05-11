using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    [SerializeField] private ClickController _clickController;

    public void OnButtonClick()
    {
        _clickController.PlusPoints();
    }
}
