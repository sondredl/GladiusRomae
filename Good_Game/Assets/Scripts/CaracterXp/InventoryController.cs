using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public InventorySwController inventorySwController;
    public CharacterItem SW;

    private void Start()
    {
        inventorySwController = GetComponent<InventorySwController>();
        List<BaseStat> swStats = new List<BaseStat>();
        swStats.Add(new BaseStat(6, "Damage", "Your sword level."));
        SW = new CharacterItem(swStats, "sword");

    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
            inventorySwController.EquipWeapon(SW);

        }
    }
}
