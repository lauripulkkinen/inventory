using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemScript : MonoBehaviour
{
    public Item item; // Esine, johon t‰m‰ UI-elementti viittaa

    public void RemoveItemFromInventory()
    {
        InventoryManager.Instance.Remove(item); // Poistaa esineen
        // InventoryManager.Instance.ListItems(); // P‰ivitt‰‰ inventaarion UI:n tarvittaessa
    }
}
