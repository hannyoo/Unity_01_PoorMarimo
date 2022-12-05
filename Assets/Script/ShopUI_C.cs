using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopUI_C : MonoBehaviour
{
    public Text shopName;

    public Button exit;

    public Image itemPlt;


    public GameObject ShopUI = null;



    public void OpenShop()
    {
        if (ShopUI == null)
        {
            Object shopUI = Resources.Load("shop_UI");
            ShopUI = (GameObject)Instantiate(shopUI);
        }
        ShopUI.SetActive(true);
    }

    public void CloseShop()
    {
        if (ShopUI != null)
        {
            ShopUI.SetActive(false);
        }

    }

    private void Start()
    {
        shopName = GetComponentInChildren<Text>();
        
        exit = GetComponentInChildren<Button>();
     
    }




}
