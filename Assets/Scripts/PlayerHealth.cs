using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health = 3f;
    public bool shields = false;
    public static float playerHealth;
    public static bool playerShields;
    public float shieldHealth = 1f;
    public GameObject shieldBubble;
    public GameObject damagedShieldBubble;
    public bool shieldRecharging = false;
    public TextMeshProUGUI healthText;
    public float maxHealth;
    public AudioClip damagedSound;
    private AudioSource audioSource;
    public AudioClip enemyKillSound;
    private AudioSource audioSource2;

    void Start()
    {
        //textbox = GetComponent<Text>();

        playerHealth = health;
        if(UpgradeSelection.reinforceBulkheads == true){
            health = Mathf.Ceil((health * .5f) + health);
            playerHealth = health;
        }
        if(UpgradeSelection.reinforceBulkheads == false){
            health = 3;
            playerHealth = 3;
        }

        if(UpgradeSelection.reflectorShields == true){
            playerShields = true;
        }
        if(UpgradeSelection.reflectorShields == false){
            playerShields = false;
        }

        //playerHealth = health;
        //health = playerHealth;
        maxHealth = health;

        //playerShields = shields;
        shields = playerShields;

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = damagedSound;

        audioSource2 = gameObject.AddComponent<AudioSource>();
        audioSource2.clip = enemyKillSound;

        if(playerShields){
            reflectorShield();
        }
    }

    void Update()
    {
        healthText.text = "HP: " + health + "/" + maxHealth;
        if(health < 1){
            Destroy(gameObject);
            SceneManager.LoadScene(5);
        }
        shieldLogic();
    }


    public void shieldLogic(){
        if(shieldHealth <= 0 && shields == true){
            shieldBubble.SetActive(false);
        }
        else if(shieldHealth > .99f && shields == true){
            shieldBubble.SetActive(true);
        }
        if(shieldHealth < 1 && shieldRecharging == false){
            StartCoroutine(rechargeShields());
            shieldRecharging = true;
        }
        
        if(shieldHealth > .5f && shieldHealth < 1f){
            damagedShieldBubble.SetActive(true);
        }else{
            damagedShieldBubble.SetActive(false);
        }
    }
    public void reflectorShield(){
        //shieldBubble.SetActive(true);
    }

    IEnumerator rechargeShields(){
        yield return new WaitForSeconds(1f);
        shieldHealth = shieldHealth + .1f;
        shieldRecharging = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyProjectile"){
            audioSource.Play();
            if(shields == true && shieldHealth > .99f){
                shieldHealth = 0;
            }else{
                health = health - SnakeAttack.snakeAttackDamage;
            }
        }

            if(collision.gameObject.tag == "Enemy"){           
                audioSource.Play();
                if(shields == true && shieldHealth > .99f){
                    shieldHealth = 0;
                }else{
                    health = health - SnakeAttack.snakeAttackDamage;
            }
        }

            if(collision.gameObject.tag == "Momma"){           
                audioSource.Play();
                if(shields == true && shieldHealth > .99f){
                    shieldHealth = 0;
                }else{
                    health = health - 100;
            }
        }
    }
   
    //public void playEnemyKillSound(){
    //    audioSource2.Play();
    //}

}
