using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetedByMouse : MonoBehaviour
{
    private Renderer renderer;
    //public Renderer side1;
    //public Renderer side2;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
        //side1.material.color = Color.red;
        //side2.material.color = Color.red;
    }

    private void OnMouseExit()
    {
        renderer.material.color = Color.white;
        //side1.material.color = Color.white;
        //side2.material.color = Color.white;
    }
}
