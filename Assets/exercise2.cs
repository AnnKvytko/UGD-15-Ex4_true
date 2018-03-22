using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		public int a;
		if (a>0 && a<30)
		{
			print ("F");
		}else if (a>30 && a<50){
			print ("E"); 
		}else if (a>50 && a<60){
			print ("D");
		}else if (a>60 && a<70){
			print ("C");
		}else if (a>70 && a<80){
			print ("B");
		}else if (a>80 && a<100)
			print ("A");

			

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
