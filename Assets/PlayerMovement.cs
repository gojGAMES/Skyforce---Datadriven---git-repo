using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PositionDelta = Vector3.zero;
        
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            PositionDelta = new Vector2(Input.GetAxis("Horizontal") * Speed * Time.deltaTime, PositionDelta.y);
        }
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0)
        {
            PositionDelta = new Vector2(PositionDelta.x, Input.GetAxis("Vertical") * Speed * Time.deltaTime);
        }

        transform.position += PositionDelta;
    }
}
