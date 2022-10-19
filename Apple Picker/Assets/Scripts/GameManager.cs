using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int _numberOfBaskets = 3;

    private List<GameObject> _basketsList;

    [Header("Set in Inspector")]
    public GameObject basketPrefab;

    public float bottomOfTheBasketY = -14f;

    public float spaceBetweenBasketsY = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        _basketsList = new List<GameObject>();
        
        for (int i = 0; i < _numberOfBaskets; i++)
        {
            GameObject basket = Instantiate(basketPrefab);

            Vector3 basketPosition = Vector3.zero;
            basketPosition.y = bottomOfTheBasketY + (spaceBetweenBasketsY * i);

            basket.transform.position = basketPosition;
            
            _basketsList.Add(basket);
        }
    }

    public void destroyBasket()
    {
        int basketIndex = _basketsList.Count - 1;
        GameObject lastBasket = _basketsList[basketIndex];
        
        _basketsList.RemoveAt(basketIndex);
        Destroy(lastBasket);

        if (_basketsList.Count == 0) SceneManager.LoadScene("EndScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
