using UnityEngine;
using System.Collections;

public class forloop : MonoBehaviour 
	{
		int bananaMunch = 6;
		
		
		void Start ()
		{
			for(int i = 1; i < bananaMunch; i++)
			{
				Debug.Log("Eating banana number: " + i);
			}
		}
	}
