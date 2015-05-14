using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Playerhealth : MonoBehaviour {
	public GameObject car2;
	public int player_health;
	Collecting repair_health;
	public Text Texthealth;
	public Text Wintext;
	// Use this for initialization
	void Start () {
	Texthealth.text = "Health : " + player_health.ToString(); 
		Wintext.text = "";
		player_health = 100;

	
		repair_health = GameObject.Find("Car").GetComponent<Collecting>();
	}
	
	// Update is called once per frame
	void Update () {


	


		if(player_health == 0){
			Wintext.text = "BUSTED";
			StartCoroutine (tata());
		}
		if (repair_health.update_ctrl == 1) {
			health_update();
				}
		Texthealth.text = "Health : " + player_health.ToString(); 


	}
	public void updatehealth(int decre)
	{
		if (repair_health.Points > 0) {
			player_health = player_health - decre;
			repair_health.update_ctrl = 1;
		} else {

						if (player_health > 0) {
								player_health = player_health - decre;
						
						}
				}

	}
	public void health_update()
	{
		if ((100 - player_health) >= repair_health.Points) {
			player_health = player_health + repair_health.Points;
						repair_health.Points = 0;
				} else {
			player_health = 100;
			repair_health.Points -= (100 - player_health);
				}

		repair_health.TextPoints.text = "Points : " + repair_health.Points.ToString();

		repair_health.update_ctrl = 0;



		}

	private IEnumerator tata()
	{ 
				
						
						yield return new WaitForSeconds (3);
						
		        Application.LoadLevel(Application.loadedLevel);
		
	}
		


	}

	


