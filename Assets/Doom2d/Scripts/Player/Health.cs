using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    float currentHealth;

    public delegate void OnHealthChange();
    public OnHealthChange healthChange;

    void Start()
    {

        currentHealth = maxHealth;
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public void AddHealth(float val)
    {
        currentHealth += val;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthChange();
    }


    public void ReduceHealth(float val)
    {
        currentHealth -= val;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        healthChange();
    }


    private void Update() {
        if(Input.GetKey(KeyCode.F))
        {
            ReduceHealth(5);
        }
    }
}
