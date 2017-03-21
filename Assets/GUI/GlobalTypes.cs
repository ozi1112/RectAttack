
public enum EWeapon
{
    Pistol,
    Uzi,
    Last
}

public delegate void VoidDelegateEWeapon(EWeapon a_eWeapon);

public delegate void VoidDelegate();

class CProperty<T>
{
    public T Value
    {
        get
        {
            return m_value;
        }
        set
        {
            m_value = value;
            if(null != OnChange)
                OnChange();
        }
    }

    public VoidDelegate OnChange;

    T m_value;


}