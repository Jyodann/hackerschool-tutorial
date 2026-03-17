using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLovingSphere : LovingSphere
{
    
    // Update is called once per frame
    public override void Update()
    {
        base.Update();
    }

    public void Jump()
    {
        rb.AddForce(0f, jumpHeight, 0f, ForceMode.VelocityChange);
    }

    public bool isOnTheGround()
    {
        return base.isGrounded;
    }
}
