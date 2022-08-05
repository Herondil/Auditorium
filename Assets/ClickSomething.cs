using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSomething : MonoBehaviour
{
    private void FixedUpdate()
    {

        //Physics2D.Raycast(transform.position, Vector2.right);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);

        if (hit.collider != null)
        {
            Debug.Log("Collision");
        }
    }
}

