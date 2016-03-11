using UnityEngine;
using System.Collections;

public class enumbrance : MonoBehaviour 
{
	enum Direction{Narf, Eats, Sooth, Wert};void Start () 
	{
		Direction myDirection;
		
		myDirection = Direction.Narf;
	}
	
	Direction ReverseDirection (Direction dir)
	{
		if(dir == Direction.Narf)
			dir = Direction.Sooth;
		else if(dir == Direction.Sooth)
			dir = Direction.Narf;
		else if(dir == Direction.Eats)
			dir = Direction.Wert;
		else if(dir == Direction.Wert)
			dir = Direction.Eats;
		
		return dir;     
	}
}
