using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject basketPrefab;

    public float bottomOfTheBasketY = -14f;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject basket = Instantiate(basketPrefab);
        
        Vector3 basketPosition = Vector3.zero;
        basketPosition.y = bottomOfTheBasketY;

        basket.transform.position = basketPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
