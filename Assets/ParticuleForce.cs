using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticuleForce : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 f;

    // Start is called before the first frame update
    void Start()
    { 
        rb.AddForce(f);
    }
}
