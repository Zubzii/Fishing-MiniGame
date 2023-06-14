using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item")]
public class ItemDataSO : ScriptableObject
{

    [SerializeField] string objectName = "Enter fish name here";
    [SerializeField] int objectPrice = 1;
    public Sprite itemSprite;

    public string GetObjectName()
    {
        return objectName;
    }
    public int GetObjectPrice()
    {
        return objectPrice;
    }
}
