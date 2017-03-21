using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CShop : MonoBehaviour {

    public CItem[] m_Items;

    CInventory m_Inventory;

	void Start () {
		foreach(CItem item in m_Items)
        {
            item.m_dlgtBuyNotify = ItemBuy;
        }
	}

    void ItemBuy(EWeapon a_eWeapon)
    {
        Debug.Log(a_eWeapon.ToString() + " bought");
    }
	
}
