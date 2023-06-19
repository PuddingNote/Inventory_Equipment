using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 캐릭터 위치 계산 후 Hit 판별
public class ToolsCharacterController : MonoBehaviour
{
    CharacterController character;
    Rigidbody2D rigid2D;
    [SerializeField] float offsetDistance = 1f;
    [SerializeField] float sizeOfInteractableArea = 0.1f;

    private void Awake()
    {
        character = GetComponent<CharacterController>();
        rigid2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UseTool();
        }
    }

    private void UseTool()
    {
        Vector2 position = rigid2D.position + character.lastMotionVector * offsetDistance;

        Collider2D[] colliders = Physics2D.OverlapCircleAll(position, sizeOfInteractableArea);

        foreach (Collider2D c in colliders)
        {
            ToolHit hit = c.GetComponent<ToolHit>();
            if (hit != null)
            {
                hit.Hit();
                break;
            }
        }
    }

}
