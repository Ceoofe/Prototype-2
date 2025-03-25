using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerController.lives -= 1;
            PlayerController.score = 0;
            Destroy(gameObject);
            if (PlayerController.isGameOver == false)
            {
                Debug.Log("Lives: " + PlayerController.lives);
                Debug.Log("Score: " + PlayerController.score);
            }
            if (PlayerController.lives < 1)
            {
                Debug.Log("Game Over!");
                PlayerController.isGameOver = true;
                PlayerController.lives = 1;
            }
        }
        else
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            if (PlayerController.isGameOver == false)
            {
                PlayerController.score += 1;
                Debug.Log("Score: " + PlayerController.score);
            }
        }
    }
}
