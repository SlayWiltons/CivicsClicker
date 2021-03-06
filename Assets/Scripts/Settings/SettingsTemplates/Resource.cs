using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewResource", menuName = "Resource")]
public class Resource : ScriptableObject
{
    public string resourceName;
    public ulong startQuantity;
}
