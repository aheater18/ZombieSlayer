using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun
{

    public float fireRate = .25f;
    public float weaponRange = 50f;
    [SerializeField] public float damage = 1f;
    public bool hasAmmo = false;
    public float ammoLeft = 0;
    public bool fullAuto = false;

    // Start is called before the first frame update
    public Gun()
    {
        
    }
}
public class Pistol : Gun
{
    public Pistol()
    {
        fireRate = .25f;
        weaponRange = 50f;
        damage = 1f;
    }
}

public class AssaultRifle : Gun
{
    public AssaultRifle()
    {
        fireRate = .1f;
        weaponRange = 30f;
        damage = .5f;
        fullAuto = true;
        hasAmmo = true;
        ammoLeft = 24;
    }
}
