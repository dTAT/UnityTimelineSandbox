using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpatialSwitch : MonoBehaviour {
    AudioSource source;
    void Awake()
    {
        source = transform.GetComponent<AudioSource>();
    }
    void OnEnable()
    {
        source.spatialBlend = 1;
    }

    void OnDisable()
    {
        source.spatialBlend = 0;
    }
}
