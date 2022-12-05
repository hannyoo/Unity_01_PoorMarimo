using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHpBarUI : MonoBehaviour
{
    public Slider hpBar;
    private float curHP;
    
    public Text monsterNName;

    public int maxhp, hp;
    //=int hp;


    Color ogColor = new Color(5, 5, 5, 200);

   

    public void SetName(string monsterName)
    {
      //  monsterNName.text = monsterName;

      //monsterNName.text = monsterName; //??
    }


    public void SetTotalHP(int hp)
    {
        hpBar.maxValue = maxhp;
        hpBar.value = hp;
    }

    public void SetCurHP(int hp)
    {
        curHP = hp;

    }


    private void Update()
    {
        if (hpBar.value > curHP)
        {
            hpBar.value -= 0.1f;
        }

        if (hpBar.value < curHP)
        {
            hpBar.value += 0.1f;
        }

    }

    public void SetColor(Color color)
    {
        monsterNName.color = color;
    }

    public void SetOgColor()
    {
        monsterNName.color = ogColor;
    }
}
