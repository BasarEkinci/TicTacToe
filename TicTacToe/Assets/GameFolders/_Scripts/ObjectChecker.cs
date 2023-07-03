using UnityEngine;

public class ObjectChecker : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        name = other.name;
        Debug.Log(name);
    }
    
}
