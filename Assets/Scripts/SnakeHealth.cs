using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeHealth : MonoBehaviour
{
    public GameObject asteroidOnDeathPrefab;
    public Transform asteroidOnDeathPoint;
    public float health = 1;
    [SerializeField] public static float enemyHealth = 1;
    public float score;
    [SerializeField] public static float getScore;
    public float currentLevelNumber;    
    public PlayerHealth playerHealth;
    void Start()
    {
        getScore = score;
        //health = enemyHealth;
        //GameObject newAsteroid = Instantiate(asteroidOnDeathPrefab, asteroidOnDeathPoint.position, asteroidOnDeathPoint.rotation);
        
    }


    void Update()
    {
        if(health < 1){
            //playerHealth.playEnemyKillSound();
            PlayerScore.totalScore += score;
            //PlayerScore.totalScore = PlayerScore.totalScore + Score.getScore;
            //PlayerScore.AddScore(101);//Score.getScore);
            if(currentLevelNumber == 1){
            LevelOneWinCondition.snakesKilled = LevelOneWinCondition.snakesKilled + 1;
            Destroy(gameObject);
            }
            else if(currentLevelNumber == 2){
            LevelTwoWinCondition.snakesKilled = LevelTwoWinCondition.snakesKilled + 1;
            Destroy(gameObject);
            }
            else if(currentLevelNumber == 3){
            LevelThreeWinCondition.snakesKilled = LevelThreeWinCondition.snakesKilled + 1;
            Destroy(gameObject);
            }
            else if(currentLevelNumber == 4){
            LevelFourWinCondition.snakesKilled = LevelFourWinCondition.snakesKilled + 1;
            Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Projectile"){
            GameObject newAsteroid = Instantiate(asteroidOnDeathPrefab, asteroidOnDeathPoint.position, asteroidOnDeathPoint.rotation);
            health = health - PlayerAttack.playerDamage;
            //Destroy(gameObject);
        }
    }






}
