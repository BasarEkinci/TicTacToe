using UnityEngine;

public class ObjectAnimation : MonoBehaviour
{
    [SerializeField] Vector3 rotateAxis;
    void Update()
    {
        transform.Rotate(rotateAxis * Time.deltaTime);    
            
    }
}
