using UnityEngine;

public class ResourceController : MonoBehaviour
{
    [SerializeField] private Resource Resource;
    private Resource _resource;
    private string _resName;
    private int _resQuantity;
    private int _resLimit;

    private void Awake()
    {
        _resource = Instantiate(Resource);
        _resName = _resource.ResourceName;
        _resQuantity = _resource.Quantity;
        _resLimit = _resource.Limit;
    }

    public void OnValueChanged()
    {

    }
}
