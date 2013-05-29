using UnityEngine;
using System.Collections;

public class ladderTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Ladder Movement Script
    void onTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        /*if (other.gameObject.name == "Rope")
        {
            Debug.Log("Entered a Trigger!!!");
        }*/
    }

}
