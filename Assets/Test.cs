using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start()
	{
		int[] array = new int[5];

		array[0] = 30;
		array[1] = 120;
		array[2] = 180;
		array[3] = 60;
		array[4] = 240;

		for (int i = 0; i < 5; i++)
		{
			Debug.Log(array[i]);
		}

        for (int j = 4; j >= 0; j--)
        {
			Debug.Log(array[j]);
        }
	}

	// Update is called once per frame
	void Update()
	{

	}
}