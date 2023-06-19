using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인벤토리 UI 관련 스크립트
public class InventoryPanel : ItemPanel
{
    public override void OnClick(int id)
    {
        GameManager.instance.dragAndDropController.OnClick(inventory.slots[id]);
        Show();
    }
}