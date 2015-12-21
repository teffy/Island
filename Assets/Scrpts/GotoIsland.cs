using UnityEngine;
using System.Collections;

public class GotoIsland : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //UnityEngine.UI.Button gotoIsland = GameObject.Find("Canvas/gotoMyIsland").GetComponent<UnityEngine.UI.Button>();
       
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 150, 60), "上岛上去看看"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("island");
            //Application.LoadLevel("island");
        }

    }

}
