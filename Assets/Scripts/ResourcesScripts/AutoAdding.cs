using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAdding : MonoBehaviour
{
    [SerializeField] private ResourceCalculator _resourceCalculator;
    [SerializeField] private WorkersCalculator _workersCalculator;

    private void Start()
    {
        StartCoroutine(AutoAddResource());
    }

    private IEnumerator AutoAddResource()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            var points = _workersCalculator.GetCurrentWorkers();
            _resourceCalculator.PlusPoints(points);
        }
    }
}
