using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    private Text _scoreCounterText;

    private readonly float _basketMovementLimit = 26f;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreCounter = GameObject.Find("ScoreCounter");

        _scoreCounterText = scoreCounter.GetComponent<Text>();
        _scoreCounterText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition2d = Input.mousePosition;
        
        currentMousePosition2d.z = Camera.main.nearClipPlane;

        Vector3 currentMousePosition3d = Camera.main.ScreenToWorldPoint(currentMousePosition2d);

        Vector3 basketPosition = this.transform.position;
        basketPosition.x = currentMousePosition3d.x;

        if (Mathf.Abs(currentMousePosition3d.x) < _basketMovementLimit) this.transform.position = basketPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;

        if (collidedWith.CompareTag("Apple")) Destroy(collidedWith);

        int score = int.Parse(_scoreCounterText.text);
        score++;

        _scoreCounterText.text = score.ToString();

        if (score > HighScore.highScore) HighScore.highScore = score;
    }
}
