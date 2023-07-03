using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectsCreator : MonoBehaviour
{
    [SerializeField] GameObject objectCreator;

    [SerializeField] List<GameObject> objects = new List<GameObject>();
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (objectCreator == GetClicked(out RaycastHit hit))
            {
                Instantiate(objects[GameManager.Instance.Order], transform.position, transform.rotation);
                GameManager.Instance.ChangeOrder();
                Destroy(gameObject);
            }
        }
    }

    private GameObject GetClicked(out RaycastHit hit)
    {
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction * 10, out hit))
        {
            if (!IsPointerOverUIObject())
                target = hit.collider.gameObject;
        }
        return target;
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData ped = new PointerEventData(EventSystem.current);
        ped.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        List<RaycastResult> results = new List<RaycastResult>();
        return results.Count > 0;
    }
}
