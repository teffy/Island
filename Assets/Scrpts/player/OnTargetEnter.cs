using UnityEngine;
using System.Collections;

public class OnTargetEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    void OnTriggerEnter(Collider other)
    {
        print("tag:"+other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {
            gameObject.transform.FindChild("door").SendMessage("doorcheck");
        }
    }

}
