using System;
using UnityEngine;

public class JumpPower : Power
{
    public Vector2 force = new Vector2(0, 400);
    void Power.applyOn(GameObject gameObject)
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(force);
    }
}