using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 메인 장비창 컨트롤러
public class EquipmentController : MonoBehaviour
{
    [SerializeField] GameObject panel;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))    // E키로 인벤토리 On/Off
        {
            panel.SetActive(!panel.activeInHierarchy);
        }
    }
}
