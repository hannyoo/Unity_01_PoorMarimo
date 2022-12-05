using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputField_C : MonoBehaviour
{
    public Text playername;


    void Start()
    {
        playername = GetComponentInChildren<Text>();

        SetName(GameManager.Instance.playername);


    }

    public void SetName(string name)
    {
        playername.text = name;

    }
    void Update()
    {
        
    }
}
