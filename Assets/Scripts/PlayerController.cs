
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    public float MovementSpeed = 5f;
    public float gravity = 9.8f;
    float yMovement;
    void Start()
    {  
        characterController = GetComponent<CharacterController>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal =Input.GetAxis("Horizontal") * MovementSpeed;
        float vertical = Input.GetAxis("Vertical") * MovementSpeed;
        characterController.Move(transform.forward * vertical + transform.right * horizontal);

        
            
      if (characterController.isGrounded)
        { 
                yMovement = 0; 
    }
        else
        {
            yMovement -= gravity;
            characterController.Move(new Vector3(0, yMovement, 0));

        }
    }
}
