using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    public float Speed = 4.5f;
    bool goingRight = true;
    bool goingLeft = false;
    public bool flip = false;
    public bool upperSpeed = false;
    public bool bottomSpeed = false;
    public float turnTime = .25f;

    void Start()
    {
 
    }

    void Update()
    {
        transform.position += -transform.up * Time.deltaTime * Speed;
        //Debug.Log("Left = " + goingLeft + " | right = " + goingRight);
        Debug.Log(Speed);
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Asteroid" || collision.gameObject.tag == "Player" || collision.gameObject.tag == "Barrier"){
            StartCoroutine(turn());
            if(goingRight){
                //goingRight = false;
                //goingLeft = true;
                //Debug.Log("Now going left");
            }
            if(goingLeft){
                //goingRight = true;
                //goingLeft = false;
                //Debug.Log("Now going right");
            }
            //Debug.Log("Left = " + goingLeft + " | right = " + goingRight);
            goingRight = !goingRight;
            goingLeft = !goingLeft;
            //transform.Rotate(new Vector3(0,0,-90));
            //yield return new WaitForSeconds(2);
            //transform.Rotate(new Vector3(0,0,-90));
        }

        if (collision.gameObject.tag == "BottomBarrier"){
            flip = true;
            if(bottomSpeed == false){
                Speed = Speed * 3;
                bottomSpeed = true;
            }
        }

        if (collision.gameObject.tag == "UpperBarrier"){
            flip = false;
            if(upperSpeed == false){
                Speed = Speed * 3;
                upperSpeed = true;
            }
        }

 
        
        
       
    }

    private void OnTriggerEnter2D(Collider2D SpeedBoost)
    {
        //Speed = Speed * 3f;
        StartCoroutine(speedBoost());
    }

    IEnumerator turn(){
    if(flip == false){
        if(goingRight){
            transform.Rotate(new Vector3(0,0,-90));
            yield return new WaitForSeconds(turnTime);
            transform.Rotate(new Vector3(0,0,-90));
        }
        else{
            transform.Rotate(new Vector3(0,0,90));
            yield return new WaitForSeconds(turnTime);
            transform.Rotate(new Vector3(0,0,90));
        }
    }

        if(flip == true){
        if(goingRight){
            //transform.Rotate(new Vector3(0,0,90));
            //yield return new WaitForSeconds(.25f);
            //transform.Rotate(new Vector3(0,0,90));
            transform.Rotate(new Vector3(0,0,-90));
            yield return new WaitForSeconds(.25f);
            transform.Rotate(new Vector3(0,0,-90));
        }
        else{
            //transform.Rotate(new Vector3(0,0,-90));
            //yield return new WaitForSeconds(.25f);
            //transform.Rotate(new Vector3(0,0,-90));
            transform.Rotate(new Vector3(0,0,-90));
            yield return new WaitForSeconds(.25f);
            transform.Rotate(new Vector3(0,0,-90));
        }

    }
    }

    IEnumerator speedBoost(){
        Speed = Speed * 1.5f;
        Debug.Log("Speed boost active");
        yield return new WaitForSeconds(2f);
        Speed = Speed / 2f;
    }




}
