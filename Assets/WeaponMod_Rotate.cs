using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class WeaponMod_Rotate : MonoBehaviour
{
    #region Public Vars
    [Tooltip("Rotation in Degrees per frame.")]
    public float RotationSpeed;
    public bool RotateClockwise;
    public bool ResetRotationOnDisable;
    #endregion

    private quaternion defaultRotation; 
    // Start is called before the first frame update
    void Start()
    {
        defaultRotation = transform.rotation;
    }

    // Update is called once per frame
     void Update()
     {
         if (RotateClockwise)
             transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z - RotationSpeed);
         else
         {
             transform.rotation = Quaternion.Euler(0, 0, transform.rotation.eulerAngles.z + RotationSpeed);
         }
     }

     private void OnDisable()
     {
         if(ResetRotationOnDisable)
            transform.rotation = defaultRotation;
     }
}
