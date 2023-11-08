using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    GameObject prefabBullet;

    // shooting support
    Timer cooldownTimer;
    bool canShoot = true;


    void Start()
    {
        // initialize cooldown timer
        cooldownTimer = gameObject.AddComponent<Timer>();
        cooldownTimer.Duration = ConfigurationUtils.CooldownSeconds;
    }


    void Update()
    {
        // check for setting can shoot flag
        if (!canShoot &&
            cooldownTimer.Finished)
        {
            canShoot = true;
        }

        // check for shooting input
        if (canShoot &&
            Input.GetAxis("Fire1") > 0)
        {
            // start cooldown
            canShoot = false;
            cooldownTimer.Run();

            // shoot bullet
            Instantiate(prefabBullet, transform.position,Quaternion.identity);
        }
    }
}
