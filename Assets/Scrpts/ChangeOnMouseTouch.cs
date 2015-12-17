using UnityEngine;
using System.Collections;

public class ChangeOnMouseTouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
        rd = GetComponent<Renderer>();
        defaultcolor = rd.material.color;
	}
    Renderer rd;
    Color defaultcolor;
	// Update is called once per frame
	void Update () {
	    
	}
    void OnMouseOver()
    {
        rd.material.color = Color.red;
        transform.Rotate(0, 90 * Time.deltaTime, 0);
        //transform.Rotate(180 * Time.deltaTime, 90 * Time.deltaTime, 270 * Time.deltaTime);
    }
    void OnMouseExit()
    {
        rd.material.color = defaultcolor;
    }
    public AudioSource music;
    void OnMouseDown()
    {
        if (music.isPlaying)
        {
            music.Pause();
        }
        else
        {
            music.Play();
        }
    }
    void OnMouseUp()
    {
        
    }
}
