using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
 
    public float speed = 7f;
    public static float playerSpeed = 7f;
    private Rigidbody2D rb2d;
 
    void Start()
    {

        playerSpeed = speed;
        if(UpgradeSelection.reinforceBulkheads == true){
        speed = playerSpeed - (playerSpeed * 0.25f);;
        playerSpeed = speed;
        }

        //speed = playerSpeed;
        //playerSpeed = speed;

        rb2d = GetComponent<Rigidbody2D> ();
    }
 
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
 
        rb2d.velocity = new Vector2 (moveHorizontal*speed, moveVertical*speed);
    }
 
    void FixedUpdate()
    {

    }
}
