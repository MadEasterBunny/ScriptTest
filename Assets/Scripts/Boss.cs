using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {
    private int hp = 100;
    private int power = 25;
    private int mp = 53;
    private int cost = 5;

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
        
        if (mp >= 5)
        {
            this.mp -= cost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

    

	// Use this for initialization
	void Start ()
    {
        Boss lastboss = new Boss();

        lastboss.Attack();
        lastboss.Defense(3);
        for(int i = 0; i <= 10; i++)
        {
            lastboss.Magic();
        }
        //lastboss.Magic();
	}
	
	// Update is called once per frame
	void Update () {
       
    }
}
