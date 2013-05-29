using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public bool isOnLadder;
    public bool isClimbing;

    public float horizontalMovementSpeed = 5f;
    public float gravity = 10f;
    private CharacterController characterController;
    private bool jumping = false;
    private bool falling;

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        isOnLadder = false;
        isClimbing = false;
    }

    // Update is called once per frame
    void Update()
    {
        float Y = -gravity;

        //Jump with the space bar
        if (!falling) //if falling is true, this means the char is travelling down from a jump and cannot jump until they are on the ground again
        {
            if (Input.GetKeyDown("space"))
            {
                StartCoroutine("Jump");
            }
        }

        if (jumping)
        {
            Y = 10f;
        }

        //Movement based on the arrow keys
        float X = Input.GetAxis("Horizontal") * horizontalMovementSpeed;

        Vector3 movement = new Vector3(X, Y, 0.0f);

        movement = movement * (Time.deltaTime);

        characterController.Move(movement);
    }

    IEnumerator Jump()
    {
        jumping = true;

        yield return new WaitForSeconds(0.5f);

        StartCoroutine("Falling");

        jumping = false;
    }

    //to prevent the user from stacking jumps, forces user to wait 0.5s before they can jump again
    IEnumerator Falling()
    {
        falling = true;

        yield return new WaitForSeconds(0.5f);

        falling = false;
    }
}
