using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VignetteFlash : MonoBehaviour
{
    public Image Vignette;
    public float Frequency = 1;
    public float MaxOpacity = 0.5f;
    private float activationTimeModifier;
    // Start is called before the first frame update
    void Start()
    {
        if (Vignette == null)
        {
            Vignette = gameObject.GetComponent<Image>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float alph;
        alph = Mathf.Sin(Frequency * (Time.fixedTime - activationTimeModifier));
        Vignette.color = new Color(1, 1, 1, MaxOpacity* alph);
    }

    private void OnEnable()
    {
        activationTimeModifier = Time.fixedTime;
        activationTimeModifier %= (2*Mathf.PI);
    }
}
