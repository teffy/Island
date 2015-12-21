using UnityEngine;
using System.Collections;

public class LightChange : MonoBehaviour {
	Light _light;
	UnityEngine.UI.Text sum;
	// Use this for initialization
	void Start () {
		_light = gameObject.GetComponent<Light> ();
		sum = GameObject.Find ("Canvas/sum").GetComponent<UnityEngine.UI.Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.L)) {
			_light.intensity += 0.5f;
			sum.text = "当亮度：" + _light.intensity;

		}
		if (Input.GetKey (KeyCode.K)) {
			_light.intensity -= 0.5f;
			sum.text = "当亮度：" + _light.intensity;

		}
	}
}
