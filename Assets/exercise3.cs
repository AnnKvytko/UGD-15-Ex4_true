using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour {
	int health = 100
	
		bool alive = true;
		bool buff = false;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void MyFunction1 ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && alive) { 
			health - 10;
		}
		else if (health = 20){
			print ("Low Health");
		}
		else if (health <= 0) 
		{
			alive = false;
			print ("Mission Failed, Character is dead");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
