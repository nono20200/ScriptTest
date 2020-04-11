using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

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
			for (int j = i + 1; j < 5; j++)
			{
				if (array[i] < array[j])
				{
					int a = array[i];
					array[i] = array[j];
					array[j] = a;

				}
			}

			Debug.Log(array[i]);
		}

	}

	// Update is called once per frame
	void Update()
	{

	}
}