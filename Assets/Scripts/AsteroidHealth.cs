using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidHealth : MonoBehaviour
{
    public float health = 10;
    public float maxHealth;
    public SpriteRenderer spriteRenderer;
    public Sprite damage1;
    public Sprite damage2;
    public float score;
    [SerializeField] public static float getScore;
    public AudioClip rockDestroySound;
    private AudioSource audioSource;
    private Collider2D myCollider;
    void Start()
    {
        getScore = score;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        maxHealth = health;

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = rockDestroySound;

        myCollider = GetComponent<Collider2D>();
    }

    void Update()
    {
        if(health <= (maxHealth/2)+1 ){//&& health > maxHealth/3){//if(health < 3 && health > 2){
            spriteRenderer.sprite = damage1; 
        }
        if(health <= (maxHealth/3) ){//if(health < 2 && health > 0){
            spriteRenderer.sprite = damage2; 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" ){
            health = health - .5f;
            if(health < 1f){
                audioSource.Play();
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Momma" ){
            health = health - 100f;
            if(health < 1f){
                audioSource.Play();
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Projectile" ){
            //health = health - 2;
            health = health - PlayerAttack.playerDamage;
            if(health < .1f && collision.gameObject.tag == "Projectile"){
                PlayerScore.totalScore += score;
                PlayerScore.totalScore = PlayerScore.totalScore + Score.getScore;
                audioSource.Play();
                audioSource.transform.parent = null;
                spriteRenderer.enabled = false;
                myCollider.enabled = false;
                Destroy(audioSource.gameObject, audioSource.clip.length);
                //Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "EnemyProjectile" ){
            //health = health - 2;
            //health = health - SnakeAttack.snakeAttackDamage;
            if(health < 1f){
                audioSource.Play();
                Destroy(gameObject);
            }
        }
    }


}
