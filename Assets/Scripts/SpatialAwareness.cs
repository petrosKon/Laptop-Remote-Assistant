using Microsoft.MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialAwareness : MonoBehaviour
{
    public bool disableSpatialAwareness = true;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
        if (disableSpatialAwareness)
        {
            // disable
            MixedRealityToolkit.SpatialAwarenessSystem.Disable();
        }
        else
        {
            // enable
            MixedRealityToolkit.SpatialAwarenessSystem.Enable();
        }
    }
}
