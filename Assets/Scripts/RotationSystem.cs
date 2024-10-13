using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationSystem : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private GameObject selectedObject;

    [Header("Physics")]
    [SerializeField] private float rotationSpeed;

    private float pipeAngle;
    public Camera cam;
    public GameObject selectedIcon;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                if(hitInfo.collider.gameObject.tag == "Selectable")
                {
                    selectedObject = hitInfo.collider.gameObject;
                    selectedIcon.transform.position = selectedObject.transform.position;
                } 
            }
        }

        if (Input.GetKeyDown("e"))
        {
            RotateObjectRight();
        }
        
        if (Input.GetKeyDown("q"))
        {
            RotateObjectLeft();
        }
    }

    private void RotateObjectLeft()
    {
        //Pipe.Rotate(Vector3.left * rotationSpeed);
        selectedObject.transform.rotation *= Quaternion.Euler(0, 0, 15);
    }
    
    private void RotateObjectRight()
    {
        //Pipe.Rotate(Vector3.right * rotationSpeed);
        selectedObject.transform.rotation *= Quaternion.Euler(0, 0, -15);
    }
}
