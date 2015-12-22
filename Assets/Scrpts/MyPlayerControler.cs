using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class MyPlayerControler : MonoBehaviour {
    bool isongroud = false;
    float movespeed = 6.0f;
    float jumpspeed = 8.0f;
    Vector3 moveV = Vector3.zero;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
        if (isongroud)
        {
            moveV = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveV = transform.TransformDirection(moveV);
            if (Input.GetButton("Jump"))
            {
                moveV.y = jumpspeed;
            }
        }

        moveV.y -= Time.deltaTime;
        CharacterController con = GetComponent<CharacterController>();
        CollisionFlags flags = con.Move(moveV * Time.deltaTime);
        isongroud = (flags & CollisionFlags.CollidedBelow) != 0;
	}

}
