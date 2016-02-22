using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {

	void Start () {
	}
    public AudioClip door_open_sound;
    public AudioClip door_close_sound;

    GameObject currentdoor;

    float dooropendtime = 0;
    float closedoortimer = 3.0f;
    bool isdooropen = false;

    void Update () {
        if (isdooropen)
        {
            dooropendtime += Time.deltaTime;
            if(dooropendtime > closedoortimer)
            {
                dooro_o_c( false, door_close_sound, "closedoor");
                dooropendtime = 0;
            }
        }
	}

    void doorcheck()
    {
        if (!isdooropen)
        {
            dooro_o_c( true, door_open_sound, "opendoor");
        }
    }
    void dooro_o_c(bool open, AudioClip sound, string anmition)
    {
        isdooropen = open;
        GetComponent<AudioSource>().PlayOneShot(sound);
        transform.parent.GetComponent<Animation>().Play(anmition);
    }
}
