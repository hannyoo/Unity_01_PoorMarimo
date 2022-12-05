using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopitemUI_C : MonoBehaviour
{
    public Text[] itemName;
    public Image[] itemImg;



    void Start()
    {
        itemImg = GetComponentsInChildren<Image>();
        //itemImg[1].sprite = Resources.Load<Sprite>("Moisture");

        itemName = GetComponentsInChildren<Text>();

        ItemInfo();

    }

    void ItemInfo()
    {
        int idx = transform.GetSiblingIndex();
        //�� ������ ������??

        itemName[0].text = ShopManager_C.instance.ItemList[idx].itemName;
        itemName[1].text = ShopManager_C.instance.ItemList[idx].itemPrice.ToString();
        itemImg[1].sprite = Resources.Load<Sprite>(ShopManager_C.instance.ItemList[idx].itemName);
    }
    // todo : �������̿��� ĥ�己���� ã�� �������� �����غ���!
   

}
