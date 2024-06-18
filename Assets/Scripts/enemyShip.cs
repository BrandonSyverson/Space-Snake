using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShip : MonoBehaviour
{
    public float speed = 1;
    public float hoverSpeed = 1f;
    public float hoverHeight = 0.5f;
    private Rigidbody2D rb;
    public bool moveRight = true;
    public GameObject projectilePrefab;
    public float shootCooldown = 1f;
    private float lastShootTime;
    public Transform shootPoint; 



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //transform.position += -transform.up * Time.deltaTime * Speed;
        //transform.Translate(Vector3.right * speed * Time.deltaTime);//move right
        float yPos = Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;
        //transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        //rb.velocity = new Vector2(speed, Mathf.Sin(Time.time * hoverSpeed) * hoverHeight);

    if(moveRight){
        rb.velocity = new Vector2(speed, Mathf.Sin(Time.time * hoverSpeed) * hoverHeight);

    }
    else{
        rb.velocity = new Vector2(-speed, Mathf.Sin(Time.time * hoverSpeed) * hoverHeight);
    }

    if (Time.time - lastShootTime > shootCooldown){
            //ShootProjectile();
            lastShootTime = Time.time;
    }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile"){
            Destroy(gameObject);
            PlayerScore.totalScore += 250;
        }
    }

        void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);
        Rigidbody2D projectileRb = projectile.GetComponent<Rigidbody2D>();
        //projectileRb.velocity = new Vector2(speed, 0f);
        float bulletSpeed = speed * 1.5f;
        projectileRb.velocity = new Vector2(bulletSpeed, 0f);
        Destroy(projectile, 2f);
    }
}
