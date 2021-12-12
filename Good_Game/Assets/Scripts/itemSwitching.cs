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
        // if (Input.GetAxis("Mouse ScrollWheel") > 0f) {
        if (Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("itemSwitching.update() keykode: R");
            // if (selectedItem == transform.childCount) {
            //     Debug.Log("itemSwitching.update() last item selected ");
            //     selectedItem = 0;
            //     SelectWeapon();
            // }
                // selectedItem++;
                // SelectWeapon();
            if (selectedItem >= transform.childCount - 1) {
                Debug.Log("itemSwitching.update() if --> if ");
                selectedItem = 0;
                SelectWeapon();
            } else {
                Debug.Log("itemSwitching.update() if --> else ");
                selectedItem++;
                SelectWeapon();
            }
        }
        // if (Input.GetAxis("Mouse ScrollWheel") < 0f) {
        // if (Input.GetKeyDown(KeyCode.R)) {
        //     if (selectedItem <= 0) {
        //         selectedItem = transform.childCount - 1;
        //     } else {
        //         selectedItem--;
        //     }
        // }
    }

    void SelectWeapon() {
        int i = 0;
        Debug.Log("itemSwitching.SelectedWeapon()");
        foreach (Transform item in transform) {
            if (i == selectedItem) {
                item.gameObject.SetActive(true);
                Debug.Log("item.gameobject active: " + item.gameObject.name);
            } else {
                item.gameObject.SetActive(false);
                Debug.Log("item.gameobject inactive: " + item.gameObject.name);
            }
            i++;
        }
    }
}

