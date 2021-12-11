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
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
            if (selectedItem >= transform.childCount - 1) {
                selectedItem = 0;
            } else {
                selectedItem++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
            if (selectedItem <= 0) {
                selectedItem = transform.childCount - 1;
            } else {
                selectedItem--;
            }
        }
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

