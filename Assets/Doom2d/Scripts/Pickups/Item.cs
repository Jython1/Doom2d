using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{

    void Start()
    {
        
    } 

    private void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.gameObject.tag == "Player")
        {
            Use(col);
        }
        
    }

    protected virtual void Use(Collider2D col){}


}
