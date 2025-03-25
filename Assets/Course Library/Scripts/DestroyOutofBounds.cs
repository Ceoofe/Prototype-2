using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    float leftBound = -30;
    float rightBound = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound)
        {
            //Debug.Log("Game Over!");
            PlayerController.score = 0;
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject);
        }
        if (transform.position.x < leftBound)
        {
            PlayerController.score = 0;
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject);
        } else if (transform.position.x > rightBound)
        {
            PlayerController.score = 0;
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject);
        }
    }
}
