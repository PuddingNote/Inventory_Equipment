using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ���â Panel
public class EquipmentPanel : MonoBehaviour
{
    [SerializeField] ItemContainer equipment;
    [SerializeField] List<InventoryButton> buttons;

    private void Start()
    {
        SetIndex();
        Show();
    }

    // �κ��丮 ���Ե鿡�� index�� �ο�
    private void SetIndex()
    {
        for (int i = 0; i < equipment.slots.Count; i++)
        {
            buttons[i].SetIndex(i);
        }
    }

    // �κ��丮 �����ֱ�
    private void Show()
    {
        for (int i = 0; i < equipment.slots.Count; i++)
        {
            if (equipment.slots[i].item == null)
            {   // ���Կ� �������� ������
                buttons[i].Clean();
            }
            else
            {   // ���Կ� �������� ������
                buttons[i].Set(equipment.slots[i]);
            }
        }
    }
}
