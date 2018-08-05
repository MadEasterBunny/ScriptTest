using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int call = 0;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defense(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
        Debug.Log(hp);
    }

    public void Magic()
    {
        for (int i = mp; i >= 0; i -= 5)
        {
            //this.mp -= magic;
            if (i >= 5)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + i + "。"); 
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない");
            }
        }
    }

    

	// Use this for initialization
	void Start ()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defense(3);
        for(call = 0; call <= 9; call++)
        {
            lastboss.Magic();
        }
        //lastboss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
       
    }
}
