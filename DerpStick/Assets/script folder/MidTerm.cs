/*using UnityEngine;
using System.Collections;

public class MidTerm : MonoBehaviour {
	
	public int myInt = 6;
	float coffeeTemperature = 85.0f;
	private float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
	int numEnemies = 3;
	private MidTerm myMidterm;
	public GameObject[] players;
	
	void Start ()
	{
		TemperatureTest();
		Debug.Log (myInt);
		
		for(int i = 0; i < numEnemies; i++)
		{
			Debug.Log("Creating enemy number: " + i);
		}
		myMidterm = GetComponent<MidTerm>();
		
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
		
		Direction myDirection;
		
		myDirection = Direction.North;
		
		ReverseDirection (myDirection);
		
	}
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		coffeeTemperature -= Time.deltaTime * 5f;
	}
	
	void TemperatureTest ()
	{
		string tooHot = "Coffee is too hot.";
		if(coffeeTemperature > hotLimitTemperature)
		{
			print(tooHot);
		}
	}
	
	enum Direction{North, East, South, West};
	
	void ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		
		
	}
	
	void Greet()
	{
		switch (myInt)
		{
		case 5:
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			break;
		case 4:
			print ("Hello and good day!");
			break;
		case 3:
			print ("Whadya want?");
			break;
		case 2:
			print ("Grog SMASH!");
			break;
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
		default:
			print ("Incorrect intelligence level.");
			break;
		}
	}
	
	Your Answer:
	public class MidTerm : MonoBehaviour { //The class that other scripts can access
		
		public int myInt = 6; //An integer
		float coffeeTemperature = 85.0f; //Default temperature
		private float hotLimitTemperature = 70.0f; //Too hot
		public float coldLimitTemperature = 40.0f; // Too cold
		int numEnemies = 3; //How many enemies are spawned each time.
		private MidTerm myMidterm; //A class that can only be accessed by the script it's in
		public GameObject[] players; //An asset with code that can be accessed by other scripts
		
		void Start () //Starts the code
		{
			TemperatureTest(); 
			Debug.Log (myInt);
			
			for(int i = 0; i < numEnemies; i++) //Specifies when the for loop starts up
			{
				Debug.Log("Creating enemy number: " + i); //What it says in the script when it loops
			}
			myMidterm = GetComponent<MidTerm>();
			
			for(int i = 0; i < players.Length; i++)
			{
				Debug.Log("Player Number "+i+" is named "+players[i].name);
			}
			
			Direction myDirection; 
			
			myDirection = Direction.North;
			
			ReverseDirection (myDirection);
			
		}
		
		void Update ()
		{
			if(Input.GetKeyDown(KeyCode.Space)) //If a button is pressed (like the space bar), test for temperature
				TemperatureTest();
			
			coffeeTemperature -= Time.deltaTime * 5f; //The coffee lowers every five seconds
		}
		
		void TemperatureTest ()
		{
			string tooHot = "Coffee is too hot.";
			if(coffeeTemperature > hotLimitTemperature) //If the coffee is hotter than the designated heat limit
			{
				print(tooHot); //Say that it's too hot
			}
		}
		
		enum Direction{North, East, South, West}; //Enum script that holds the variables North, East, South and West
		
		void ReverseDirection (Direction dir) //When the player or object goes the other way
		{
			if(dir == Direction.North) //If the player or object was facing north
				dir = Direction.South; //The reverse is south
			
			
		}
		
		void Greet()
		{
			switch (myInt) //switch statement
			{
			case 5: //When the value of the switch statement is 4
				print ("Why hello there good sir! Let me teach you about Trigonometry!"); //Say this
				break;
			case 4: //When the value of the switch statement is 3
				print ("Hello and good day!"); //Say this
				break;
			case 3: //When the value of the switch statement is 2
				print ("Whadya want?"); //Say this
				break;
			case 2: //When the value of the switch statement is 1
				print ("Grog SMASH!"); //Say this
				break;
			case 1: //When the value of the switch statement is 0
				print ("Ulg, glib, Pblblblblb"); //Say this
				break;
			default: //When the value of the switch statement is none of the above
				print ("Incorrect intelligence level."); //Say this
				break;
			}
		}
*/