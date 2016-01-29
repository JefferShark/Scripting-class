using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{
	public float monkeyBananas = 100.0f;
	public float badBananas = 70.0f;
	public float bananaPeels = 30.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		monkeyBananas -= Time.deltaTime * 5f;
	}
	
	
	void TemperatureTest ()
	{
		// If the monkey's total bananas are more than the amount of bad bananas...
		if(monkeyBananas > badBananas)
		{
			// ... do this.
			print("Too many bad bananas.");
		}
		// If it isn't, but the monkey's bananas have been eaten...
		else if(monkeyBananas < bananaPeels)
		{
			// ... do this.
			print("Only peels left.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("DELICIOUS BANANAAAAAAAAAAAS!!!!!.");
		}
	}
}
