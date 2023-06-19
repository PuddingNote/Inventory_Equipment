using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Item 스크립터블 오브젝트
[CreateAssetMenu(menuName = "Data/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public bool stackable;
    public Sprite icon;
    [TextArea] public string itemDesc;
}