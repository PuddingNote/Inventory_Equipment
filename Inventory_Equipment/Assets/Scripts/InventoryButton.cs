using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 인벤토리 슬롯(버튼) 관련 스크립트
public class InventoryButton : MonoBehaviour
{   
    [SerializeField] Image icon;
    [SerializeField] Text text;

    int myIndex;

    public void SetIndex(int index)
    {
        myIndex = index;
    }

    public void Set(ItemSlot slot)
    {
        text.gameObject.SetActive(true);
        icon.sprite = slot.item.itemIcon; // 이미지 불러오기

        if (slot.item.stackable == true) // 아이템 갯수 관련
        {
            text.gameObject.SetActive(true);
            text.text = slot.count.ToString();
        }
        else
        {
            text.gameObject.SetActive(false);
        }
    }

    public void Clean()
    {   // 아이템 지우기
        icon.sprite = null;
        icon.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
    }

}
