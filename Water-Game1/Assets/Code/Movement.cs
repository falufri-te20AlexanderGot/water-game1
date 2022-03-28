using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private KeyCode jumpKey;
    [SerializeField] private KeyCode moveLeftKey;
    [SerializeField] private KeyCode moveRightKey;

    [SerializeField] private LayerMask groundMask;
    [SerializeField] private Rigidbody2D playerRigidBody;
    [SerializeField] private GameObject player;
    [SerializeField] private float jumpForce;

    private bool canJump = false;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(jumpKey))
        {
            if (Groundcheck())
                playerRigidBody.AddForce(Vector2.up * jumpForce);
        }

        if (Input.GetKey(moveLeftKey))
        {

        }

        if (Input.GetKey(moveRightKey))
        {

        }
    }


    private bool Groundcheck()
    {
        var collision = Physics2D.OverlapBox(player.transform.position + new Vector3(0f, -0.1f, 0f), player.transform.localScale, 0f);

        if (collision == null)
            return false;

        if (collision.IsTouchingLayers(groundMask))
        {
            return true;
        }

        return false;
    }

}
