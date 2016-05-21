using UnityEngine;
using System.Collections;

public class FinalProject : MonoBehaviour {

	public
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		float speed = 15 *
			Time.deltaTime;
				
		    if(Input.GetKey (KeyCode.LeftArrow)){
			Debug.Log ("Left Arrow Pressed");
			transform.Translate(Vector3.left * speed);}

			if(Input.GetKey(KeyCode.RightArrow)){
			Debug.Log("Right Arrow pressed");
		    transform.Translate(Vector3.right * speed);}

		    if(Input.GetKey(KeyCode.UpArrow)){
			Debug.Log("Up Arrow Pressed");
			transform.Translate(Vector3.forward * speed);}

		    if(Input.GetKey(KeyCode.DownArrow)){
				Debug.Log("Down Arrow Pressed");
			transform.Translate(Vector3.back * speed);}


	
	}
}
