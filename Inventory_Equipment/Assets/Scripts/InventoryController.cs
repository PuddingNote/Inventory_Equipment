using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 인벤토리 컨트롤러 스크립트
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
