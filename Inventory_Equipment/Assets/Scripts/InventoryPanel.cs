using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �κ��丮 UI ���� ��ũ��Ʈ
public class InventoryPanel : ItemPanel
{
    public override void OnClick(int id)
    {
        GameManager.instance.dragAndDropController.OnClick(inventory.slots[id]);
        Show();
    }
}