using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1.0f;
    private Vector2 Bounds = new Vector2(1000, 1000);
    
    // Start is called before the first frame update
    void Start()
    {
        Bounds = new Vector2(GameManager.ScreenWidth / 2, GameManager.ScreenHeight / 2);
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

        Vector3 newPos = transform.position + PositionDelta;

        if (Mathf.Abs(newPos.x) > Bounds.x)
        {
            if (newPos.x > 0)
            {
                newPos.x = Bounds.x;
            }
            else
            {
                newPos.x = -1 * Bounds.x;
            }
        }
        
        if (Mathf.Abs(newPos.y) > Bounds.y)
        {
            if (newPos.y > 0)
            {
                newPos.y = Bounds.y;
            }
            else
            {
                newPos.y = -1 * Bounds.y;
            }
            
        }

        transform.position = newPos;
    }
}
