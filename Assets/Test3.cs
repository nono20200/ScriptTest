using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
	private int mp = 53;

    public void MagicAttack(int magic)
    {
		if (mp >= 5)
		{
			this.mp -= 5;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

        } else if (mp < 5)
        {
			Debug.Log("MPが足りないため魔法が使えない");
		}
    }
 
}


public class Test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Boss lastboss = new Boss();

	    for (int i = 0; i < 10; i++)
        {
			lastboss.MagicAttack(5);
        }

        Debug.Log("MPが足りないため魔法が使えない");
	}


	// Update is called once per frame
	void Update () {

	}

}
