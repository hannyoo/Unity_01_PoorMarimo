using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager_C : MonoBehaviour
{
    public static ShopManager_C instance = null;

    public ShopItem_C[] ItemList = { new ShopItem_C("Moisture", 50), new ShopItem_C("Attack", 100), new ShopItem_C("Deffence", 70) };

    //ShopItem_C Moisture = new ShopItem_C("Moisture", 50);
    //ShopItem_C Attack = new ShopItem_C("Attack", 100);
    //ShopItem_C Deffence = new ShopItem_C("Deffence", 70);

    private void Awake()
    {
        instance = this;
    }


}
