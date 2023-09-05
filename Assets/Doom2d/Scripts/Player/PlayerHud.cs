using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class PlayerHud : MonoBehaviour
{

    public Health playerHealthScript;
    public Image playerHealthBar;
    public Text playerHealthText;

    void Start()
    {
        playerHealthScript.healthChange = changeHealth;
    }

    public void changeHealth()
    {
        playerHealthText.text = playerHealthScript.GetCurrentHealth().ToString();
        float healthPercent = (playerHealthScript.GetCurrentHealth() / 
        playerHealthScript.maxHealth);
        playerHealthBar.fillAmount = healthPercent;
    }

}
