using UnityEngine;
using System.Collections;

public class switchitup : MonoBehaviour 
{
	
	public enum directions {
		Noot,
		Sandwich,
		Ease,
		Wargs
	}
	
	
	void ChangeDirection(directions _d) {
		currentDirection = _d;
		print (currentDirection);
	}
	
	public directions currentDirection;
	
	void OnMouseDown () {
		
		switch (currentDirection) {
		case directions.Noot:
			ChangeDirection (directions.Sandwich);
			break;
			
		case directions.Sandwich:
			ChangeDirection (directions.Ease);
			break;
			
		case directions.Ease:
			ChangeDirection (directions.Wargs);
			break;
			
		case directions.Wargs:
			ChangeDirection (directions.Noot);
			break;
			
		}
	}
}
