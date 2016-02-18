using UnityEngine;
using System.Collections;

public class ControllerRaycastHit : MonoBehaviour {

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hitInfo;
        if (Physics.Raycast(transform.position, transform.forward,out hitInfo,3.0f))
        {
            if(hitInfo.collider.gameObject.tag == "playerdoor")
            {
                GameObject currentdoor = hitInfo.collider.gameObject;
                print("hit hit ");
                currentdoor.SendMessage("doorcheck");
            }
        }
	}
}
