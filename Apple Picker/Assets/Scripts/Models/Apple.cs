using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private static float _endYCoordinateApple = -18f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < _endYCoordinateApple)
        {
            Destroy(this.gameObject);
        }
    }
}
