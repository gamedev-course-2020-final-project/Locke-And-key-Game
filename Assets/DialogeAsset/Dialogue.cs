using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue {

	public string name;
	public GameObject currentKey;

	[TextArea(1, 10)]
	public string[] sentences;

	public void Start()
	{
		//currentKey = currentKey;
	}
/*	private void Sentences()
	{
		switch(currentKey)
		{
			case 1:
		}
		
	}
	*/
}
