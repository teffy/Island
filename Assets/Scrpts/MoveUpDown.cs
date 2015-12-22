﻿using UnityEngine;
using System.Collections;

public class MoveUpDown : MonoBehaviour {
    UnityEngine.UI.Text sum;
    // Use this for initialization
    void Start () {
        sum = GameObject.Find("Canvas/sum").GetComponent<UnityEngine.UI.Text>();
    }
    public float speed = 5.0f;
    float mspeed;
    Vector3 v;
	// Update is called once per frame
	void Update () {
        mspeed = speed * 2.0f;
        Vector3 position = transform.position;
        if (position.y > 8.0f)
        {
            v = new Vector3(0, -mspeed, 0);
        }
        else if(position.y <= 0.7f)
        {
            v = new Vector3(0, mspeed, 0);
        }
        Rigidbody r = GetComponent<Rigidbody>();
        r.velocity = v;
	}
    void getMessage()
    {

        sum.text = v.x + v.y + "";
    }
}
