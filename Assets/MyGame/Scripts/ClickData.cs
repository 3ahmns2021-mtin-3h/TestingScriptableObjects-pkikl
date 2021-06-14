using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(menuName = "ClickData")]
public class ClickData : ScriptableObject, ISerializationCallbackReceiver
{
    public int clickInfoInitial;
    public int clickInfoRuntime;

    public void OnAfterDeserialize()
    {
        clickInfoRuntime = clickInfoInitial;

        if(clickInfoRuntime >= 100)
        {
            clickInfoRuntime = 0;
        }
    }

    public void OnBeforeSerialize()
    { 

    }

}


