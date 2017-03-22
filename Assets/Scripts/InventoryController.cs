using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : Singleton<InventoryController>
{
    public InventoryItemList itemList;
    public PanelController panel;
    private int numeroItems;
    public GameObject prefab;

    // Use this for initialization
    void Start()
    {
     
        numeroItems = itemList.itemList.Count;
        for (int i = 0; i < numeroItems; i++)
        {
            ItemButton button = Instantiate(prefab).GetComponent<ItemButton>();
            button.transform.SetParent(transform);
            button.SetItem(itemList.itemList[i]);
        }    
    }

    public void SetItem(InventoryItem item)
    {
        panel.SetItem(item);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log(itemList.itemList[0].itemName);
    //}
}
