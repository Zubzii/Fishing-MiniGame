using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    [SerializeField] private ItemDataSO itemDataSO;
    private SpriteRenderer sr;


    private void OnValidate()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = itemDataSO.itemSprite;
        gameObject.name = itemDataSO.name;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Inventory.Instance.AddItem(itemDataSO) ;
            Destroy(gameObject);
        }
    }
}
