
	var target : Transform; //the enemy's target
	var myHit : RaycastHit;
	var moveSpeed = 3; //move speed
	var rotationSpeed = 3; //speed of turning
	var range : float=10f;
	var range2 : float=10f;
	var stop : float=0;
	var offsetAlign:float = 0.0; //Add offset to make your object align perfect to terrain
	var myTransform : Transform; //current transform data of this enemy
	function Awake()
	{
		myTransform = transform; //cache transform data for easy access/preformance
	}
	
	function Start()
	{
		target = GameObject.FindWithTag("Car").transform; //target the player
		
	}
	
	 
	
	function Update () {
		//rotate to look at the player
		var distance = Vector3.Distance(myTransform.position, target.position);
		if (distance<=range2 &&  distance>=range){
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		}
		
		
		else if(distance<=range && distance>stop){
			
			//move towards the player
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
		}
		else if (distance<=stop) {
			myTransform.rotation = Quaternion.Slerp(myTransform.rotation,
			                                        Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed*Time.deltaTime);
		}
		
		
     
     if(Physics.Raycast (myTransform.position, Vector3.down, myHit))
     {
          myTransform.position.y = myHit.point.y + offsetAlign;
     }
		
		
	}
	