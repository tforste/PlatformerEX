using UnityEngine;
using System.Collections;

public class LadderScript : MonoBehaviour {

    CharacterController PlayerController;
    GameObject Player;
    GameObject UpperGround;

	// Use this for initialization
	void Start () {
	    PlayerController = GameObject.FindWithTag("Player").GetComponent<CharacterController>();
        Player = GameObject.FindWithTag("Player");
        UpperGround = GameObject.FindWithTag("Finish");
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerEnter( Collider otherObj )
    {
        if (otherObj.tag == "Player")
        {
            Debug.Log("Climbing the Ladder");
            UpperGround.collider.enabled = false;
        }
    }

    void OnTriggerExit( Collider otherObj )
    {
        if (otherObj.tag == "Player")
        {
            Debug.Log("Leaving the Ladder");
        }

        UpperGround.collider.enabled = true;
    }

    //Checks if the player is standing in the Ladder Trigger
    void OnTriggerStay(Collider otherObj)
    {
        if ( Player.transform.position.y > 7 )
        {
            UpperGround.collider.enabled = true;
        }

        //Check if the object is the player
        //If the Up Key is pressed down, move the character up
        if (otherObj.tag == "Player" && Input.GetKey("up"))
        {
            Debug.Log("Up Key is Pressed While on Ladder");
            Debug.Log("Staying in the ladder");
            ClimbLadder();
        }
    }

    void ClimbLadder()
    {
        Vector3 vertMove = new Vector3(0.0f, 0.4f, 0.0f);

        //vertMove = vertMove * (Time.deltaTime);

        PlayerController.Move(vertMove);
    }
}
