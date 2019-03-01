using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed ;
	Rigidbody2D rb2d ;
	public float jumpForce;

	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> (); 
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {

			gameObject.transform.Translate (Vector2.left * speed * Time.deltaTime);

		}

		if (Input.GetKey (KeyCode.D)) {

			gameObject.transform.Translate (Vector2.right * speed * Time.deltaTime);

		}

		if (Input.GetButtonDown ("Jump")) {
			Vector2 jf = new Vector2 (0, jumpForce);

			rb2d.AddForce (jf ,ForceMode2D.Impulse) ;

		}

	}


}
