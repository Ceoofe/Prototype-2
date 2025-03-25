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
        if (transform.position.z > topBound) // Top border
        {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) // Bottom border
        {
            //Debug.Log("Game Over!");
            PlayerController.score = 0; // If animal goes beyond the border, player score resets to 0
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject); //Destroys the animal
        }
        if (transform.position.x < leftBound) //Left Border
        {
            PlayerController.score = 0;
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject);
        } else if (transform.position.x > rightBound) // Right Border
        {
            PlayerController.score = 0;
            Debug.Log("Score: " + PlayerController.score);
            Destroy(gameObject);
        }
    }
}
