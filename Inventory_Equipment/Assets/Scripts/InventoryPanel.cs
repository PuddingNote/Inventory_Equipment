using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 메인 인벤토리 Panel
public class InventoryPanel : MonoBehaviour 
{   
    [SerializeField] ItemContainer inventory;
    [SerializeField] List<InventoryButton> buttons;

    private void Start()
    {
        SetIndex();
        Show();
    }

    // 인벤토리 슬롯들에게 index값 부여
    private void SetIndex()
    {   
        for (int i = 0; i < inventory.slots.Count; i++)
        {
            buttons[i].SetIndex(i);
        }
    }

    // 인벤토리 보여주기
    private void Show()
    {   
        for (int i = 0; i < inventory.slots.Count; i++)
        {
            if (inventory.slots[i].item == null)
            {   // 슬롯에 아이템이 없을때
                buttons[i].Clean();
            }
            else
            {   // 슬롯에 아이템이 있을때
                buttons[i].Set(inventory.slots[i]);
            }
        }
    }
}
