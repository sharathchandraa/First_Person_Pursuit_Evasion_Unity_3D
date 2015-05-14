using UnityEngine;
using System.Collections;

public class finishLine : MonoBehaviour {
	CheckPointControl acc_ctrl1;
	//CheckPointControl2 acc_ctrl2;

	void Start () {
		acc_ctrl1 = GameObject.Find ("Car").GetComponent<CheckPointControl> ();
		//acc_ctrl2 = GameObject.Find ("Car").GetComponent<CheckPointControl2> ();
				
		}
	void OnTriggerEnter(Collider other)
	{
		//if (other.transform.root.CompareTag ("Car")) {

		if (other.gameObject.CompareTag ("finish1")) {

						acc_ctrl1.FinishLine ();
			        acc_ctrl1.gate2_access = 1;
			        acc_ctrl1.gate1_access = 0;
			acc_ctrl1.gate1_display = 1;
					    other.gameObject.SetActive (false);	
			           

				} else if (other.gameObject.CompareTag ("finish2")) {
			acc_ctrl1.gate2_access = 0;
			acc_ctrl1.gate3_access = 1;
			acc_ctrl1.gate2_display = 1;
			     acc_ctrl1.FinishLine ();
			       other.gameObject.SetActive (false);	


				}
		else if (other.gameObject.CompareTag ("finish3")) {
			acc_ctrl1.gate3_access = 0;
			acc_ctrl1.game_finish = 1;
			acc_ctrl1.FinishLine ();
			acc_ctrl1.gate3_display = 1;
			//CheckPointControl3.instance3.FinishLine ();
			other.gameObject.SetActive (false);	

			
		}
	}
}
