using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Item ��ũ���ͺ� ������Ʈ
[CreateAssetMenu(menuName = "Data/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public bool stackable;
    public Sprite icon;
    [TextArea] public string itemDesc;
}