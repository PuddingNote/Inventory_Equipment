using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �κ��丮 ��Ʈ�ѷ�
public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))    // EŰ�� �κ��丮 On/Off
        {   
            panel.SetActive(!panel.activeInHierarchy);
        }
    }
}
