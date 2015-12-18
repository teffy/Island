using UnityEngine;
using System.Collections;

public class GotoIsland : MonoBehaviour {

	// Use this for initialization
	void Start () {
        UnityEngine.UI.Button gotoIsland = GameObject.Find("Canvas/gotoMyIsland").GetComponent<UnityEngine.UI.Button>();
        gotoIsland.onClick.AddListener(()=>gotoIslandScene(gameObject));
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void gotoIslandScene(GameObject go)
    {
        Application.LoadLevel("island");
    }
}
