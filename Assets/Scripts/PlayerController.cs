using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     //   QualitySettings.vSyncCount = 0; 
     //   Application.targetFrameRate = 10; // This line, along with the vSync line, can help to test the game on higher and lower framerates.
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);
        Debug.Log(vertical);
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime; // It's key to add the time variable so that movement is synced across all types of framerate!
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
