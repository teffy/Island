using UnityEngine;
using System.Collections;
//物理碰撞检测，主角身上单独使用
public class ControllerColiderHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isdooropen)
        {
            dooropendtime += Time.deltaTime;
            if(dooropendtime > closedoortimer)
            {
                dooro_o_c(currentdoor,false,door_close_sound,"closedoor");
                dooropendtime = 0;
            }
        }
	}
    public AudioClip door_open_sound;
    public AudioClip door_close_sound;

    GameObject currentdoor;

    float dooropendtime = 0;
    float closedoortimer = 3.0f;
    bool isdooropen = false;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        print("hit");
        if(hit.gameObject.tag == "playerdoor" && !isdooropen)
        {
            currentdoor = hit.gameObject;
            dooro_o_c(currentdoor, true, door_open_sound, "opendoor");
        }
    }

    void dooro_o_c(GameObject door,bool open, AudioClip sound,string anmition)
    {
        isdooropen = open;
        door.GetComponent<AudioSource>().PlayOneShot(sound);
        door.transform.parent.GetComponent<Animation>().Play(anmition);
    }

}
