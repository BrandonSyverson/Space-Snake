using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject projectilePrefab;
    public float shootingCooldown = 0.5f;
    public static float playerShootingCooldown = 0.5f;
    public float attackDamage = 1f;
    public static float playerDamage = 1f;
    public AudioClip shootSound;
    private AudioSource audioSource;
    private float nextShotTime;

    void Start()
    {
        playerShootingCooldown = shootingCooldown;
        playerDamage = attackDamage;
        if(UpgradeSelection.weaponUpgrades == true){
        attackDamage = (attackDamage * .50f) + attackDamage;
        playerDamage = attackDamage;

        shootingCooldown = shootingCooldown - (shootingCooldown * .25f);
        playerShootingCooldown = shootingCooldown;
        //attackDamage = playerDamage;
        //playerDamage = attackDamage;

        //shootingCooldown = playerShootingCooldown;
        //playerShootingCooldown = shootingCooldown;
        }
        //shootingCooldown = playerShootingCooldown;

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = shootSound;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextShotTime)
        //Input.GetKeyDown(KeyCode.Space)
        {
            Shoot();
            nextShotTime = Time.time + shootingCooldown;
        }
    }

    void Shoot()
    {
        if (shootingPoint != null && projectilePrefab != null)
        {
            GameObject projectile = Instantiate(projectilePrefab, shootingPoint.position, shootingPoint.rotation);
            Destroy(projectile, 5f);
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Shooting point or projectile prefab not set in the inspector!");
        }
    }
}