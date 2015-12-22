using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour {
	Light _light;
    GameObject movecube;
    UnityEngine.UI.Text brightness;
    // Use this for initialization
    void Start () {
        _light = GameObject.Find("Spotlight").GetComponent<Light>();
        brightness = GameObject.Find ("Canvas/brightness").GetComponent<UnityEngine.UI.Text> ();
        movecube =GameObject.Find("MoveUpDownCube");
	}
    float brightnesschangegap = 0.02f;
    int textsizechangegap = 1;
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.L)) {
			_light.intensity += brightnesschangegap;
            brightness.color = Color.red;
            brightness.fontSize += textsizechangegap;
            if (brightness.fontSize > 40)
            {
                brightness.fontSize = 40;
            }
            brightness.text = "当亮度：" + _light.intensity;
		}
		if (Input.GetKey (KeyCode.K)) {
			_light.intensity -= brightnesschangegap;
            brightness.color = Color.green;
            brightness.fontSize -= textsizechangegap;
            if(brightness.fontSize < 12)
            {
                brightness.fontSize = 12;
            }
            brightness.text = "当亮度：" + _light.intensity;
		}
        if (Input.GetKey(KeyCode.S))
        {
            movecube.SendMessage("getMessage");
        }
    }
}
