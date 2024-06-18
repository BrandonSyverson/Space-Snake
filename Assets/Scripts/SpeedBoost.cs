using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public SnakeMovement snakeMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.tag == "SpeedBoost")
    {
        snakeMovement.Speed = snakeMovement.Speed * 3;
        Debug.Log("Speed Boost activate.");
    }
}
}
