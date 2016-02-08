using UnityEngine;
using System.Collections;

public class whileloop : MonoBehaviour 
{
	int bananasInMyBelly = 5;
	
	
	void Start ()
	{
		while(bananasInMyBelly > 0)
		{
			Debug.Log ("I've eaten a banana!");
			bananasInMyBelly--;
		}
	}
}
