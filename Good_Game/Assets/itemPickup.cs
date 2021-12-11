using UnityEngine;

public class itemPickup : Interactable
{
    public override void Interact() {
        base.Interact();
        Debug.Log("itemPickup.Interact()");

        PickUp();
    }

    void PickUp() {
        Debug.Log("itemPickup.PickUp()");
        
        Destroy(gameObject);
    }
}
