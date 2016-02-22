using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour 
{
	public int apples;
	public int bananas;
	
	
	private int pie;
	private int cookies;
	
	
	public void FruitMachine (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Ammo total: " + answer);
	}
	
	
	private void BakerBot (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Total baking capabilities: " + answer);
	}
}
