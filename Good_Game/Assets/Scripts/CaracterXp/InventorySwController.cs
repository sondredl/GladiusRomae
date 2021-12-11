using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySwController : MonoBehaviour
{
    public GameObject playerHand;
    public GameObject EquippedWeapon { get; set; }

    CharStats charStats;

    IWeapon equippedWeapon;
    void Start()
    {
        charStats = GetComponent<CharStats>();
    }

    public void EquipWeapon(CharacterItem itemToEquip)
    {
       if(EquippedWeapon != null)
        {
            charStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
            Destroy(playerHand.transform.GetChild(0).gameObject);

        }
         EquippedWeapon = (GameObject)Instantiate(Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug),
             
             playerHand.transform.position, playerHand.transform.rotation);
        equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
        equippedWeapon.Stats = itemToEquip.Stats;
        EquippedWeapon.transform.SetParent(playerHand.transform);
        charStats.AddStatBonus(itemToEquip.Stats);
        Debug.Log(equippedWeapon.Stats[0]);
    }
    public void PerformWeaponAttack()
    {
        equippedWeapon.PerFormAttack();
        
        //EquippedWeapon.GetComponent<IWeapon>().PerformWeaponAttack();
    }

}
