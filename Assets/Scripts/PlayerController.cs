using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 direction;
    public float Gravity;
    public float Speed;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * Speed;
        }
        if(Input.touchCount >0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * Speed;
            }
            }
        direction.y += Gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
