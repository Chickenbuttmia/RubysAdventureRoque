using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontail");
        float vertical = Input.GetAxis("Vertical");

        //create the movement vector 
        Vector2 position = transform.position;

        //changing the x and y postion
        position.x = position.x + 0.3f * horizontal * Time.deltaTime;

        //Set the updated position
        transform.position = position; 
    }
}
