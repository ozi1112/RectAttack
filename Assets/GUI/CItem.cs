using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CItem : MonoBehaviour {

    public string m_strName;

    public bool m_bBought;

    public int m_fPrice;

    public string m_strDescription;

    public EWeapon m_eWeapon;

    public VoidDelegateEWeapon m_dlgtBuyNotify;

    public void Buy()
    {
        if(!m_bBought)
        {
            if (null != m_dlgtBuyNotify)
            {
                m_dlgtBuyNotify.Invoke(m_eWeapon);
            }
        }
        else
        {
            Debug.Log(m_eWeapon + " already bought");
        }
    }

}
