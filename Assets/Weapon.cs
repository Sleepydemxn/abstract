using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int magazine;
    public abstract void shoot();
    public abstract void CountBullet();

}
