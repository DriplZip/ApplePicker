using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition2d = Input.mousePosition;
        currentMousePosition2d.z = Camera.main.nearClipPlane;
        
        Vector3 currentMousePosition3d = Camera.main.ScreenToWorldPoint(currentMousePosition2d);
        
        Vector3 basketPosition = this.transform.position;
        basketPosition.x = currentMousePosition3d.x;

        this.transform.position = basketPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.CompareTag("Apple")) Destroy(collidedWith);
    }
}
