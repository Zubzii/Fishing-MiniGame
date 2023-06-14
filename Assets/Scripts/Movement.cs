using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{

    // movement support
    public float horizontalModifier = 1f;
    public float verticalModifier = 1f;
    public bool playerHasControl = true;
    bool isFacingAway = false;
    public Sprite facingAway;
    public Sprite facingForward;
    public Sprite defaultSprite;

    private void Start()
    {
        playerHasControl = true;
    }


    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Rigidbody2D playerRigidBody = GetComponent<Rigidbody2D>();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        // moves the player based on user input
        if (playerHasControl == true)
        {
            playerRigidBody.velocity = new Vector2(horizontalInput * horizontalModifier, verticalInput * verticalModifier);
        }
        else
        {
            playerRigidBody.velocity = new Vector2(0f, 0f);
        }

        // change sprite direction
        if (verticalInput > 0)
        {
            spriteRenderer.sprite = facingAway;
        }
        else if (verticalInput < 0)
        {
            spriteRenderer.sprite = facingForward;
        }
        else
        {
            spriteRenderer.sprite = defaultSprite;
        }

        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(-.75f, .75f, .75f);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(.75f, .75f, .75f);
        }

    



    }


}
