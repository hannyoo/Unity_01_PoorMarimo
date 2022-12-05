using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hpBarUI : MonoBehaviour
{
    public Slider hpBar;
    private float curHP;

    public Text playerName;

    Color ogColor = new Color(255,255,255,200);
    //컬러 근본의 근본이 없었다 새색상을 생성해서 근본찾자!


    public void SetName(string playername)
    {
        playerName.text = playername;
    }

   
    public void SetTotalHP(int hp)
    {
        hpBar.maxValue = hp;
        hpBar.value = hp;
    }

    public void SetCurHP(int hp)
    { 
        curHP = hp;


    }
    private void Start()
    {
      // hpBar=GetComponent<Slider>();
        playerName.text = "***";
       
    }


    private void Update()
   {
        if (Camera.main == null)
        { return; }
        else if (Camera.main != null)
        { transform.rotation = Camera.main.transform.rotation; }

        if (hpBar.value > curHP)
        {
            hpBar.value -= 0.1f;
        }
        
        if(hpBar.value < curHP)
        {
            hpBar.value += 0.1f;
        }

   }

    
    public void SetColor(Color color)
    {
        playerName.color = color;
    }

    public void SetOgColor()
    {
        playerName.color = ogColor;
    }



}
