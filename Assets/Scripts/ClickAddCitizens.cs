using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAddCitizens : MonoBehaviour
{
    [SerializeField] private WorkersController _workersController;

    public void OnAddCitizenClick()
    {
        _workersController.AddWorker();
    }
}
