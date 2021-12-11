using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public static List<GameObject> items = new List<GameObject>();
    // public List<Item> items = new List<Item>();

    // public bool Add (Item item) {

    //     Debug.Log("itemController.Add: " + item.name);
    //     GameObject sword = GameObject.FindGameObjectWithTag("MySward");

    //     if (!item.isDefaultItem) {
    //         items.Add(item);
    //     }
    //     return true;
    // }
    public static bool Add (GameObject item) {

        Debug.Log("itemController.Add: " + item.name);
        items.Add(item);
        Debug.Log("item added to items");

        GameObject sword = GameObject.FindGameObjectWithTag("MySward");

        // if (!item.isDefaultItem) {
        //     items.Add(item);
        // }
        return true;
    }

    public void Remove (GameObject item) {
        items.Remove(item);
    }
    // public void Remove (Item item) {
    //     items.Remove(item);
    // }

    public virtual void Interact(){}
}
