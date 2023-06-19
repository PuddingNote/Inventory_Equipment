using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �κ��丮 ��Ʈ�ѷ� ��ũ��Ʈ
public class InventoryController : MonoBehaviour
{
    [SerializeField] GameObject inventoryPanel;
    bool isPause = false;

    private void Awake()
    {
        inventoryPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeInHierarchy);

            if (isPause == false)
            {
                Time.timeScale = 0;
                isPause = true;
                return;
            }
            if (isPause == true)
            {
                Time.timeScale = 1;
                isPause = false;
                return;
            }
        }
    }
}
