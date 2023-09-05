using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaingun : Pistol
{
    private void Awake() {
        waitingTime = 0.12f;
    }
}
