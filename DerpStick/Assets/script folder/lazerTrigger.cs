using UnityEngine;
using System.Collections;

public class lazerTrigger : MonoBehaviour 
	{
		void OnTriggerEnter(Collider Player) {
			Destroy(Player.gameObject);
		}
	}
