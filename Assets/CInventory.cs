using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/// <summary>
/// Contains unlocked weapon table. Manages money. Changes active weapon.
/// </summary>
public class CInventory : MonoBehaviour
{

    bool[] m_bArrActiveWeapons;

    int m_fMoney;

    CWeapon ActiveWeapon;

    void Start()
    {
        m_fMoney = 0;
        m_bArrActiveWeapons = new bool[(int)EWeapon.Last];
        m_bArrActiveWeapons[(int)EWeapon.Pistol] = true;

    }

    public bool TryToSpendMoney(int a_fMoney)
    {
        bool bRetVal = false;
        if (m_fMoney >= a_fMoney)
        {
            m_fMoney -= a_fMoney;
            bRetVal = true;
        }
        return bRetVal;
    }

    public void EarnMoney(int a_fMoney)
    {
        m_fMoney += a_fMoney;
    }

    CWeapon GetSelectedWeapon()
    {
        return GetComponent<CWeapon>();
    }

    bool[] GetWeapons()
    {
        return m_bArrActiveWeapons;
    }

    bool SelectWeapon(EWeapon a_eWeapon)
    {
        bool bRetVal = m_bArrActiveWeapons[(int)a_eWeapon];
        if (bRetVal)
        {
            Destroy(GetComponent<CWeapon>());
        }

        return bRetVal;
    }




}
