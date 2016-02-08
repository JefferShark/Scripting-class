using UnityEngine;
using System.Collections;

public class farreach : MonoBehaviour 
{
	void Start () 
	{
		string[] bananas = new string[3];
		
		bananas[0] = "One banana";
		bananas[1] = "Two banana";
		bananas[2] = "Three banana";
		
		foreach(string item in bananas)
		{
			print (item);
		}
	}
}
