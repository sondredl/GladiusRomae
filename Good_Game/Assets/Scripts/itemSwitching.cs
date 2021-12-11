using UnityEngine;

public class itemSwitching : MonoBehaviour
{
    public int selectedItem = 0; 

    void Start()
    {
        SelectWeapon();
    }

    void Update()
    {
        
    }
    void SelectWeapon() {
        int i = 0;
        foreach (Transform item in transform) {
            if (i == selectedItem) {
                item.gameObject.SetActive(true);
            } else {
                item.gameObject.SetActive(false);
            }
            i++;
        }
    }
}
