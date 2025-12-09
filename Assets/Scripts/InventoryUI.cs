using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class InventoryUI : MonoBehaviour
{
    [System.Serializable]
    public class Item
    {
        public Sprite icon;
        public int amount;
    }

    public GameObject itemSlotPrefab;
    public Transform content;
    public List<Item> items = new List<Item>(); 

    void Start()
    {
        RefreshInventory();
    }

    public void RefreshInventory()
    {
       
        foreach (Transform child in content)
        {
            Destroy(child.gameObject);
        }

        
        foreach (var item in items)
        {
            GameObject slot = Instantiate(itemSlotPrefab, content);

            
            slot.transform.Find("Icono").GetComponent<Image>().sprite = item.icon;
            slot.transform.Find("Cantidad").GetComponent<TextMeshProUGUI>().text = item.amount.ToString();
        }
    }
}