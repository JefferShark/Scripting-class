using UnityEngine;
using System.Collections;

public class scopeitout : MonoBehaviour 
	{
		public int cheese = 5;
		
		
		private int ham = 0;
		private int mustard = 5;
		
		
		private AnotherClass myOtherClass;
		
		
		void Start ()
		{
			cheese = 29;
			
			myOtherClass = new AnotherClass();
			myOtherClass.FruitMachine(cheese, myOtherClass.apples);
		}
		
		
		void Example (int mayo, int tuna)
		{
			int answer;
			answer = mayo * tuna * cheese;
			Debug.Log(answer);
		}
		
		
		void Update ()
		{
			Debug.Log("Alpha is set to: " + cheese);
		}
	}
