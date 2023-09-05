using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public GameObject shootingLightPrefab;
    public GameObject shootingPoint;
    private AudioSource shootingSound;
    private Animator pistolAnimator;

    private void Awake() 
    {
        waitingTime = 0.37f;
        shootingSound = gameObject.GetComponent<AudioSource>();
        pistolAnimator = gameObject.GetComponent<Animator>();
    }
    protected override void Shoot()
    {
        if(canShoot)
        {
            //RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
            //Debug.Log(hit.collider);
            //Debug.DrawRay(transform.position, Vector2.right * 100f, Color.red, waitingTime);


            shootingSound.Play();
            Instantiate(shootingLightPrefab, shootingPoint.transform.position, Quaternion.Euler(0, 90, 0));
            pistolAnimator.SetTrigger("Fire");
            canShoot = !canShoot;
            StartCoroutine(Recover());
        }

    }

    private void Update() {
        if(Input.GetKey(KeyCode.LeftControl))
        {
            Shoot();
        }
    }
}
