using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float zRange = 10;
    public GameObject projectilePrefab;
    public static int lives = 3; // Lives of the player
    public static int score = 0; // Score of the player
    public static bool isGameOver = false; // Bool of game over

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives: " + lives);
        Debug.Log("Score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        // Keep the player in bound
        if (transform.position.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }// Border for the player left
        if (transform.position.x > xRange) 
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }// Border for the player right

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        } // Border for the player Bottom
        if (transform.position.z > zRange) 
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }  // Border for the player Top

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
