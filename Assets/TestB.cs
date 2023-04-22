using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestB : TestA
{
    public void Start()
    {
        Move();
    }

    public override void Fly()
    {
        
    }

    public override bool stock()
    {
        return false;
    }


}
