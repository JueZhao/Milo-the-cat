using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlPatrol : MonoBehaviour
{
    [HideInInspector]
    public bool mustPatrol;
    private bool mustTurn;

    public Rigidbody2D rigidbody;
    public Transform checkGroundPos;
    public LayerMask groundLayer;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        mustPatrol = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(mustPatrol)
        {
            Patrol();
        }
    }

    private void FixUpdate()
    {
        if(mustPatrol)
        {

            mustTurn= !Physics2D.OverlapCircle(checkGroundPos, 0.1f, groundLayer);
        }
    }
    void Patrol()
    {
                    if(mustTurn)
            {
                walkback();
            }
        rigidbody.velocity = new Vector2(speed * Time.fixedDeltaTime, rb.velocity.y);
    }

    void walkback()
    {
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        speed *= -1;
        mustPatrol = true;
    }
}
