using System;
using System.Collections;
using System.Collections.Generic;
using Command;
using UnityEngine;
using UnityEngine.UI;

public class WaitCommand : BaseShikibuCommand
{
    public override void Setup(UIObjectManager objectManager)
    {
    }


    [ShikibuMethod]
    public IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
