using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour {

    public Text descriptionText;
    public Image image;

    public void SetItem(InventoryItem item)
    {
        descriptionText.text = item.itemName;
        image.sprite = item.itemIcon;
    }
}
