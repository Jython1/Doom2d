using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShootingLight : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyLight());
    }

    IEnumerator DestroyLight()
    {
        yield return new WaitForSeconds(0.03f);
        Destroy(gameObject);
    }


}
