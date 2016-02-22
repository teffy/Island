using UnityEngine;
using System.Collections;

public class ControllerRaycastHit : MonoBehaviour {

	void Start () {
	}
	//光线碰撞检测，和DoorManager.cs是配套使用的
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
