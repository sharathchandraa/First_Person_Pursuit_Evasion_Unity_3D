using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckPointControl : MonoBehaviour 
{
	//public int startTime1;
	//CheckPointControl2 gate_2;
	public Text textGui1;
	public Text textGui2;
	public int gate1_access;
	public int gate2_access;
	public int gate3_access;
	public int gate1_display = 0;
	public int gate2_display = 0;
	public int gate3_display = 0;
   float coolDown = 1.0f;
 float attackTimer;
	public int game_finish;


	int time1;

	//int totalTime1 =0;

	bool gameover1 = false;

	void Start()
	{
		gate1_access = 1;
		gate2_access = 0;
		gate3_access = 0;
		time1 = 0;
		game_finish = 0;
		//startTime1 = 0;
		//gate_2 = GameObject.Find ("Car").GetComponent<CheckPointControl2> ();

	}
	void Update()

	{

		if (gate1_access == 1) {
			time1 = 20;
			gate1_access = 0;
			//StartCoroutine (Timer());
		}
		
		else if (gate2_access == 1) {
			time1 = 40;
			gate2_access = 0;
			gameover1 = false;
			//StartCoroutine (Timer());
		}
		
		else if (gate3_access == 1) {
			time1 = 70;
			gate3_access = 0;
			gameover1 = false;
		}

		if (coolDown > 0) {

			coolDown = coolDown - Time.deltaTime;
		}
	
		if (coolDown <= 0) {
			bilboard ();
			coolDown = 1.0f;
		}

		if(gate1_display == 1)
		{
			textGui2.text = "Reached Checkpoints : 1/3 ";
			gate1_display = 0;
		}
		if(gate2_display == 1)
		{
			textGui2.text = "Reached Checkpoints : 2/3 ";
			gate2_display = 0;
		}
		if (gate3_display == 1) {
			textGui2.text = "Reached Checkpoints : 3/3 ";
			gate3_display = 0;
				}


		//Debug.Log (Time.deltaTime);
		}
	//public void addTime(int addedTime)
	//{
		//time1 += addedTime;
	//}

	//private IEnumerator Timer()
	//{
	public void bilboard(){
					if(time1 >0 && !gameover1)
				{

					textGui1.text = "Catchup by "+ time1.ToString();
					//yield return new WaitForSeconds(1);
					time1--;

				//totalTime1++;
				}


				if(time1 <=0)
				{
				textGui1.text = "Game Over";
				//	yield return new WaitForSeconds(3);
					Application.LoadLevel(Application.loadedLevel);
				//	}
				}
		}

	public void FinishLine()
	{
		//gate_2.gate2_access = 1;
		//textGui.text = "First Check Point Crossed in "+totalTime+" seconds";
		gameover1 = true;
		if (game_finish == 1) {
			textGui1.text = "Winner!!!";
				}

		//textGui1.text = "";

	}


}
