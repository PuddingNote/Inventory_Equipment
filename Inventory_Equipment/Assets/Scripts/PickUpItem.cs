using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 아이템들이 가지고있는 아이템 줍기 스크립트
public class PickUpItem : MonoBehaviour
{
    Transform player;
    [SerializeField] float speed = 3f;
    [SerializeField] float pickUpDistance = 1.5f;
    [SerializeField] float ttl = 10f;

    public Item item;
    public int count = 1;

    private void Awake()
    {
        player = GameManager.instance.player.transform;
    }

    private void Update()
    {
        ttl -= Time.deltaTime;
        if (ttl < 0)
        {
            Destroy(gameObject);
        }

        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > pickUpDistance)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        if (distance < 0.1f)
        {
            if (GameManager.instance.inventoryContainer != null)
            {
                GameManager.instance.inventoryContainer.Add(item, count);
            }

            Destroy(gameObject);
        }
    }

}
