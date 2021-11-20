using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Collidable
{
    bool temp = true;
    protected override void OnCollide(Collider2D coll)
    {
        if(temp)
            GameManager.instance.ShowText("Szia uram, olcsó kötél érdekel?", 20, Color.magenta, transform.position, Vector3.up * 0, 3f);
            temp = false;
    }
}
