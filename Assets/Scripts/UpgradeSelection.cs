using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeSelection : MonoBehaviour
{
    public static bool reinforceBulkheads = false;
    public static bool reflectorShields = false;
    public static bool weaponUpgrades = false;
    //public float health = PlayerHealth.health;
    public PlayerHealth playerHealth;
    public PlayerHealth shields;
    public PlayerMovement playerMovement;
    public PlayerMovement speed;
    public PlayerMovement playerSpeed;
    public bool reinforceBulkheadsApplied = false;
    public bool reflectorShieldsApplied = false;
    public bool weaponUpgradesApplied = false;
    public bool reset = false;
    public bool upgrade1chosen = false;
    public bool level1reset = false;

    void Start()
    {
        if(reset || level1reset){
            Debug.Log("Resetting player upgrades");
            reinforceBulkheads = false;
            reflectorShields = false;
            weaponUpgrades = false;
            upgrade1chosen = false;
            weaponUpgradesApplied = false;
            reflectorShieldsApplied = false;
            reinforceBulkheadsApplied = false;
        }


        /*if(reinforceBulkheads == false && reinforceBulkheadsApplied == false && upgrade1chosen == false){
            //upgrade1chosen = true;
            //reinforceBulkheadsApplied = true;
            //reinforceBulkheads = true;
                //ReinforceBulkheads();
        }
        if(reflectorShields == false && reflectorShieldsApplied == false && upgrade1chosen == false){
            //upgrade1chosen = true;
            //reflectorShieldsApplied = true;
            //reflectorShields = true;
                //ReflectorShields();
        }
        if(weaponUpgrades == false && weaponUpgradesApplied == false && upgrade1chosen == false){
            //upgrade1chosen = true;
            //weaponUpgradesApplied = true;
            //weaponUpgrades = true;
                //WeaponUpgrades();
        }*/
        
    }

    public void EasyMode(){
            reinforceBulkheadsApplied = true;
            reinforceBulkheads = true;
            reflectorShieldsApplied = true;
            reflectorShields = true;
            weaponUpgradesApplied = true;
            weaponUpgrades = true;
    }

    public void ReinforceBulkheads(){
        
        //reinforceBulkheads = true;
        
        if(reinforceBulkheads == false && reinforceBulkheadsApplied == false && upgrade1chosen == false){
            upgrade1chosen = true;
            reinforceBulkheadsApplied = true;
            reinforceBulkheads = true;
            //ReinforceBulkheads();
        }
            //health = health + (health*.5);
        //playerHealth.health = playerHealth.health + 2;
        //playerMovement.speed = 20;//(playerMovement.speed * 0.25f) - playerMovement.speed;
        //PlayerMovement.playerSpeed = PlayerMovement.playerSpeed + 10;//((PlayerMovement.playerSpeed * 0.25f) - PlayerMovement.playerSpeed);
            //playerMovement.speed = 25f;
        //PlayerMovement.playerSpeed = PlayerMovement.playerSpeed - (PlayerMovement.playerSpeed * 0.25f);//- PlayerMovement.playerSpeed;//PlayerMovement.playerSpeed + 100f;
    }

    public void ReflectorShields(){
        //reflectorShields = true;
        //playerHealth.shields = true;
        //if(reflectorShields == false && reflectorShieldsApplied == false && upgrade1chosen == false){
        if(reflectorShieldsApplied == false && upgrade1chosen == false){
            playerHealth.shields = true;
            reflectorShieldsApplied = true;
            reflectorShields = true;
            upgrade1chosen = true;
            //ReflectorShields();
        }
    }

    public void WeaponUpgrades(){
       // weaponUpgrades = true;
        if(weaponUpgrades == false && weaponUpgradesApplied == false && upgrade1chosen == false){
            upgrade1chosen = true;
            weaponUpgradesApplied = true;
            weaponUpgrades = true;
            //WeaponUpgrades();
        }
        //PlayerAttack.playerDamage = (PlayerAttack.playerDamage * .50f) + PlayerAttack.playerDamage;
        //PlayerAttack.playerShootingCooldown = PlayerAttack.playerShootingCooldown - (PlayerAttack.playerShootingCooldown * .25f);
    }


}
