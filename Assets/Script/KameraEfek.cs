using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class KameraEfek : MonoBehaviour
{
    public PostProcessVolume volume;
    private Vignette vignate;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings(out vignate);
        vignate.smoothness.value = 1f;
    }

}
