using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed =  15.0f;
    private float turnSpeed = 70.0f;
    private float forwardInput = 0.0f;
    private float horizontalInput = 0.0f;

    public Camera thirdPersonCamera;
    public Camera firstPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        // Start the game with the thirdPersonCamera active
        thirdPersonCamera.enabled = true;
        firstPersonCamera.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Getting player input
        if(gameObject.name == "Player_Car")
        {
            forwardInput = Input.GetAxis("Vertical2");
            horizontalInput = Input.GetAxis("Horizontal2");
        }
        else if(gameObject.name == "Player_Car_2")
        {
            forwardInput = Input.GetAxis("Vertical");
            horizontalInput = Input.GetAxis("Horizontal");
        }

        // Move the car forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn the car
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        // Switch camera when the player presses space
        if(Input.GetKeyUp(KeyCode.Space) && gameObject.name == "Player_Car")
        {
            SwitchActiveCamera();
        }
        if(Input.GetKeyUp(KeyCode.Keypad0) && gameObject.name == "Player_Car_2")
        {
            SwitchActiveCamera();
        }

        // Restart the game if a player falls down
        if(transform.position.y < -10)
        {
            SceneManager.LoadScene("Prototype 1");
        }
    }

    // Switches the active camera when called
    private void SwitchActiveCamera()
    {
        if(thirdPersonCamera.isActiveAndEnabled)
        {
            thirdPersonCamera.enabled = false;
            firstPersonCamera.enabled = true;
        }
        else if(firstPersonCamera.isActiveAndEnabled)
        {
            thirdPersonCamera.enabled = true;
            firstPersonCamera.enabled = false;
        }
    }
}
