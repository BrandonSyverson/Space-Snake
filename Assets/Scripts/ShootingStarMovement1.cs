using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStarMovement : MonoBehaviour
{
 
    public float Speed = 4.5f;
    public GameObject shootingStar;
    public Transform shootingStarRespawnPoint;

    private void Start(){
        transform.Rotate(new Vector3(0,0,90));//270));
    }

    private void Update()
    {
        transform.position += -transform.up * Time.deltaTime * Speed;
    }



    private void OnCollisionEnter2D(Collision2D collision){
        GameObject newShootingStar = Instantiate(shootingStar, shootingStarRespawnPoint.position, shootingStarRespawnPoint.rotation);
        Destroy(gameObject);
    }
}

