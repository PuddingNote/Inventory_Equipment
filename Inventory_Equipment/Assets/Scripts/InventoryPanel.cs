using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �κ��丮 Panel
public class InventoryPanel : MonoBehaviour 
{   
    [SerializeField] ItemContainer inventory;
    [SerializeField] List<InventoryButton> buttons;

    private void Start()
    {
        SetIndex();
        Show();
    }

    // �κ��丮 ���Ե鿡�� index�� �ο�
    private void SetIndex()
    {   
        for (int i = 0; i < inventory.slots.Count; i++)
        {
            buttons[i].SetIndex(i);
        }
    }

    // �κ��丮 �����ֱ�
    private void Show()
    {   
        for (int i = 0; i < inventory.slots.Count; i++)
        {
            if (inventory.slots[i].item == null)
            {   // ���Կ� �������� ������
                buttons[i].Clean();
            }
            else
            {   // ���Կ� �������� ������
                buttons[i].Set(inventory.slots[i]);
            }
        }
    }
}
