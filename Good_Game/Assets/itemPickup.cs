using UnityEngine;

public class itemPickup : Inventory
{
    public Item item;

    public override void Interact() {
        base.Interact();
        Debug.Log("itemPickup.Interact()");

        PickUp();
    }

    void PickUp() {
        Debug.Log("itemPickup.PickUp()");
        Inventory.instance.Add(item);
        
        Destroy(gameObject);
    }
}
