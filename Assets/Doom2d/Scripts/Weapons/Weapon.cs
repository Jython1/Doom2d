using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    protected bool canShoot = true;
    protected float waitingTime;
    protected float xOffset;
    protected float yOffset;
    public delegate void OnShoot();
    public OnShoot onWeaponShot;
    


    protected virtual void Shoot()
    {
        onWeaponShot();

    }

    protected IEnumerator Recover()
    {
        yield return new WaitForSeconds(waitingTime);
        canShoot = !canShoot;
    }

}
