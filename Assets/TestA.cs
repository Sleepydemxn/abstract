using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TestA : MonoBehaviour
{
    public abstract bool stock();
    public void Move()
    {
        print("я двигаюсь");
    }

    public abstract void Fly();
}
