using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewWorkersGroup", menuName = "Workers group")]
public class Workers : ScriptableObject
{
    public string groupName;
    public ulong baseCount;
}
