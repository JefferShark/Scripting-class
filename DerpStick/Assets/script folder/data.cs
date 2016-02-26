using UnityEngine;
using System.Collections;

public class data : MonoBehaviour 
{
	void Start () 
	{
		Vector3 pos = transform.position;
		pos = new Vector3(0, 7, 0);

		Transform tran = transform;
		tran.position = new Vector3(0, 7, 0);
	}
}
