using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class UI_ItemSlot : MonoBehaviour
{

    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemText;

    public InventoryItem item;

    public void UpdateSlot(InventoryItem newItem)
    {
        item = newItem;

        if (item != null)
        {
            itemImage.sprite = item.data.itemSprite;

        }
        if (item.stacksize > 1)
        {
            itemText.text = item.stacksize.ToString();
        }
        else
        {
            itemText.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
