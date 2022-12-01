using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //This will make unity run the game at 10 frames per second if it were made as actual code
        //QualitySettings.vSyncCount = 0;Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        //create 2 variables to use the unity built in axes
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        //Create our movement vector
        Vector2 position = transform.position;

        //Create Horizantal and vertical movement
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        //setting the new position
        transform.position = position;
    }
}
