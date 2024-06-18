using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStarMovementOneTime1 : MonoBehaviour
{
 public float Speed = 4.5f;

    private void Start(){
        transform.Rotate(new Vector3(0,0,90));
    }

    private void Update()
    {
        transform.position += -transform.up * Time.deltaTime * Speed;
    }



    private void OnCollisionEnter2D(Collision2D collision){
        Destroy(gameObject);
    }
}

