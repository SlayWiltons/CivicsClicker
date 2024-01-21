using UnityEngine;

[CreateAssetMenu(fileName = "NewResource", menuName = "Resource")]
public class Resource : ScriptableObject
{
    public string ResourceName;
    public int Quantity;
    public int Limit;
}
