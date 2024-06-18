using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeAttack : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject projectilePrefab;
    public float attackDamage = 1;
    public static float snakeAttackDamage = 1;
    public bool fireCooldown = false;
    void Start()
    {

    }

    void Update()
    {
        if(fireCooldown == false){
        StartCoroutine(fire());
        fireCooldown = true;
        }
    }

    IEnumerator fire(){
        yield return new WaitForSeconds(Random.Range(5.0f, 10.0f));//5f);
        if (shootingPoint != null && projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, Quaternion.identity);
            Destroy(projectile, 20f);
        }
        fireCooldown = false;
    }



}
