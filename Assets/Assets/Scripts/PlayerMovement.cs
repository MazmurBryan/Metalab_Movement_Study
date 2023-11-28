using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");//X axis
        float verticalInput = Input.GetAxis("Vertical");//Z axis

        Vector3 move = new Vector3(horizontalInput,0f,verticalInput) * speed * Time.deltaTime;

        transform.Translate(move);
        
    }
}
