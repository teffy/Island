using UnityEngine;
using System.Collections;

public class ControllerColiderHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public AudioClip door_open_sound;
    public AudioClip door_close_sound;

    GameObject door;

    float dooropendtime = 0;
    float closedoortimer = 3.0f;
    bool isdooropen = false;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("hit");
        if(hit.gameObject.tag == "playerdoor" && !isdooropen)
        {
            hit.gameObject.GetComponent<AudioSource>().PlayOneShot(door_open_sound);
           // opendoor(hit.gameObject);
        }
    }

    void opendoor(GameObject door)
    {
        door.GetComponent<AudioSource>().PlayOneShot(door_open_sound);
        door.transform.parent.GetComponent<Animation>().Play();
        isdooropen = true;
    }
}
