using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collecting : MonoBehaviour {
	public int update_ctrl;
	public int Points;
	public Text TextPoints;
	Playerhealth uh;
	// Use this for initialization
	void Start () {

		uh = GameObject.Find("Car").GetComponent<Playerhealth>();
		update_ctrl = 0;
		Points = 0;
		TextPoints.text = "Points : " + Points.ToString(); 
	}
	
	// Update is called once per frame
	void Update () {

	

		TextPoints.text = "Points : " + Points.ToString(); 

			

	
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("health_boost")) {

						other.gameObject.SetActive (false);
			Points += 10;
			TextPoints.text = "Points : " + Points.ToString(); 
				}
		if (uh.player_health < 100) {
						update_ctrl = 1;
				}

		}



}
