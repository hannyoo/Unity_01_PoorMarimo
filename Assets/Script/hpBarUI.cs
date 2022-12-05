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

    public GameObject ShopUI = null;



    public void OpenShop()
    {
        if(ShopUI ==null)
        {
            Object shopUI = Resources.Load("shop_UI");
            ShopUI = (GameObject)Instantiate(shopUI);
        }

    }
    public void CloseShop()
    {
        if (ShopUI != null)
        {
            ShopUI.SetActive(false);
        }

    }

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
    

   private void Update()
   {
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
