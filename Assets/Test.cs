using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        int[] array = { 1, 20, 300, -4000, 500 };

        for (int x = 0; x < array.Length; x++)
        {
            Debug.Log(array[x]);
        }

        for (int y = array.Length - 1; 0 <= y; y--)
        // - 1　と　y--　の両方が必要になる理由がよくわからない　-1　が蛇足に見えるけど……ないと動かない。理由が知りたい
        {
            Debug.Log(array[y]);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
//ここまで１つ目の課題

//ここから発展課題

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private void Start()


    {

        Boss lastboss = new Boss();
        lastboss.Attack();
        lastboss.Defence(3);
        lastboss.Magic();
    }

}

public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 53;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }

    public void Magic()
    {
        for (int i = 0; i < 11; i++)
        {
            if (mp >= 5)
            {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp);
            }

            else { Debug.Log("MPが足りないため魔法が使えない"); }

        }

    }



    // Update is called once per frame
    void Update()
    {

    }
}