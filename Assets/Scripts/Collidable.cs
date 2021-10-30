using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter2D;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }
}
