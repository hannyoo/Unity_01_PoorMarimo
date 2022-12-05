using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI_C : MonoBehaviour
{
    public Text shopName;

    public Button exit;

    public Image itemPlt;
    
    private void Start()
    {
        shopName = GetComponentInChildren<Text>();
        
        exit = GetComponentInChildren<Button>();
               



    }


}
