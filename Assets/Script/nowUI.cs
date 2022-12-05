using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class nowUI : MonoBehaviour
{
    public Text playername;

    public Text[] playerStat;

    public Marimo_C marimo;
    public InputField inputname;

    public hpBarUI hpbarnow;
    
   

    void Start()
    {
        // playername = GetComponentInChildren<Text>();
        // SetName(GameManager.Instance.player.playername);
        
       
        GameObject marimo_Go = GameObject.FindGameObjectWithTag("Marimo"); //Marimo �±׵� ������Ʈ�� marimo_Go�� �Ѵ�!
        marimo = marimo_Go.GetComponent<Marimo_C>();
        playerStat = GetComponentsInChildren<Text>(); //??
        SetPlayerInfo();

        // SetStat(GameManager.Instance.playerStat.stat);   //??

    }
    
    public void SetName(string name)
    {
        playername.text = name;   
    
    }

    // public void SetStat(string[] playerstat)
    // {
    //    playerStat.text = playerstat;

       
    // }

    public void SetPlayerInfo()
    {
       hpbarnow = FindObjectOfType<hpBarUI>();
        playername.text = inputname.text;
        playerStat[2].text = marimo.HP.ToString();
        playerStat[4].text = marimo.Atk.ToString();
        playerStat[6].text = marimo.Dfn.ToString();
        playerStat[8].text = marimo.Gold.ToString();
        
        hpbarnow.playerName.text = inputname.text;


    }



}
