using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour {
   public InventoryItem item;
    private Text nombre;
    

    public void SetItem(InventoryItem item)
    {
        this.item = item;
        nombre.text = item.itemName;
    }

    // Use this for initialization
    void Awake () {
        nombre = GetComponentInChildren<Text>();
	}

    public void OnItemClicked()
    {
        InventoryController.Instance.SetItem(item);
    }
	

}
