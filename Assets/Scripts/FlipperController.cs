using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float torque;
    [SerializeField] bool isLeft;
    private KeyCode[] flipKey;
    
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(GetInput()) 
        {
            rb.AddTorque(torque, ForceMode2D.Force);
        }
    }

    bool GetInput()
    {
        // Universal Control
        // Use this input to control all flippers.
        if (Input.GetKeyDown(KeyCode.Space)) { return true; }

        // Directional Controls
        else
        {
            // If isLeft is true, use left flipper controls.
            if (isLeft) { return Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A); }
            // If isLeft is false, use right flipper controls.
            else { return Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D); }
        }
    }
}
