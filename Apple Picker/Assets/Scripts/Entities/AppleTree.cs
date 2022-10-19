using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject applePrefab;
    
    public float appleTreeSpeed = 1.0f;

    public float treeDirectionChangeDistance = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float appleCreationFrequency = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(DropApple), 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate(applePrefab);
        apple.transform.position = transform.position;
        
        Invoke(nameof(DropApple), appleCreationFrequency);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 appleTreePosition = transform.position;
        appleTreePosition.x += appleTreeSpeed * Time.deltaTime;
        
        transform.position = appleTreePosition;

        if (Mathf.Abs(appleTreePosition.x) >= treeDirectionChangeDistance)
        {
            appleTreeSpeed = -appleTreeSpeed;
        }
    }

    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections && Mathf.Abs(transform.position.x) < treeDirectionChangeDistance)
        {
            appleTreeSpeed = -appleTreeSpeed;
        }
    }
}
