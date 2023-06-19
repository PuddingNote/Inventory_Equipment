using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// �κ��丮 ����(��ư) ���� ��ũ��Ʈ
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
        icon.sprite = slot.item.itemIcon; // �̹��� �ҷ�����

        if (slot.item.stackable == true) // ������ ���� ����
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
    {   // ������ �����
        icon.sprite = null;
        icon.gameObject.SetActive(false);
        text.gameObject.SetActive(false);
    }

}
