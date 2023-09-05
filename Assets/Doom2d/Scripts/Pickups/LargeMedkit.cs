using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeMedkit : Item
{
    
    protected override void Use(Collider2D col)
    {
        var healthComponent = col.gameObject.GetComponent<Health>();
        if(healthComponent.GetCurrentHealth() < healthComponent.maxHealth)
        {
            Debug.Log(healthComponent.GetCurrentHealth());
            healthComponent.AddHealth(75);
            gameObject.SetActive(false);
        }
        
    }

}
