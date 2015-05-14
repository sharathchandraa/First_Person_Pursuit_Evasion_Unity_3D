using UnityEngine;
using System.Collections;

public class Enemy_attack : MonoBehaviour {
	public GameObject target;
	public float coolDown;
	public float attackTimer;
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		coolDown = 1.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (attackTimer > 0) {
			attackTimer -= Time.deltaTime;
				}
		if (attackTimer < 0) {
			attackTimer = 0;
				}
		if (attackTimer == 0) {
						attack ();
			attackTimer = coolDown;
				}
	}

	private void attack()
	{
		GameObject target = GameObject.Find ("Car");
		Playerhealth ph = target.GetComponent<Playerhealth> ();

		float distance = Vector3.Distance (target.transform.position, transform.position); 



		if (distance < 10) {
						ph.updatehealth (10);
				}



		}
}
