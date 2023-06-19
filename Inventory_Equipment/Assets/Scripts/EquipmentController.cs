using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ���â ��Ʈ�ѷ�
public class EquipmentController : MonoBehaviour
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
