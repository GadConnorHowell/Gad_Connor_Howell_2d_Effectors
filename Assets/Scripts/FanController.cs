using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanController : MonoBehaviour {

	public ButtonController button ; 
	public AreaEffector2D fan;
	public GameObject air;
	private bool spawnAir;
	public float airCount ; 
	public float airR = 0.6f ;
	// Use this for initialization
	void Start () {
		fan = gameObject.GetComponent<AreaEffector2D> ();


	}
	
	// Update is called once per frame
	void Update () {

		if (button.fanOn == true) {


			fan.forceMagnitude = 15; 
			spawnAir = true; 
		}

		if (spawnAir == true && airCount <= 0) {

			StartCoroutine (AirSpawn());

		}
		air.transform.position = new Vector2 (2, -5);
		air.transform.rotation = Quaternion.Euler (0, 0, 0.6f);
	}


	IEnumerator AirSpawn () 
	{

		Instantiate (air);
		yield return new WaitForSeconds (0.1f);
		airCount += 1; 
	
	}
}
