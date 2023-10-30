using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class animationController : MonoBehaviour
{
    Inputs inputs;
    CharacterController characterController;
    Animator animator;

    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;
    Vector2 currentMovementInput;
    Vector3 currentMovement;
    Vector3 currentRunMovement;
    bool isMovementPressed;
    bool isRunPressed;
    float rotatioFactorPerFrame = 10;
    float runMultiplier = 5.0f;
    float walkMultiplier = 3.0f;
    float groundedGravity = -0.5f;
    float gravity = -9.8f;
    float maxJumpTime = 2f;
    float maxJumpHeight = 10.0f;
    float initialJumpVelocity;
    bool isJumping = false;

    bool isJumpPressed = false;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");

        inputs = new Inputs();
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        inputs.charactercontrol.move.started += OnMovementInput;

        inputs.charactercontrol.move.canceled += OnMovementInput;

        inputs.charactercontrol.move.performed += OnMovementInput;

        inputs.charactercontrol.run.started += OnRun;
        inputs.charactercontrol.run.canceled += OnRun;

        inputs.charactercontrol.jump.started += OnJump;
        inputs.charactercontrol.jump.canceled += OnJump;
        inputs.charactercontrol.jump.performed += OnJump;

        SetupJumpVariables();
    }
    void SetupJumpVariables()
    {
        float timeToApex = maxJumpTime / 2;
        gravity = (-2 * maxJumpHeight) / Mathf.Pow(timeToApex, 2);
        initialJumpVelocity = (2 * maxJumpHeight) / timeToApex;
    }
    void HandleJump()
    {
        if (!isJumping && characterController.isGrounded && isJumpPressed || !isJumping && isRunPressed && isJumpPressed)
        {
            isJumping = true;
            currentMovement.y = initialJumpVelocity * 0.5f;
            currentRunMovement.y = initialJumpVelocity * .5f;
        }
        else if (!isJumpPressed && isJumping && characterController.isGrounded)
        {
            isJumping = false;
        }
        //Debug.Log(isJumping);

    }
    void HandleGravity()
    {
        float previousYVelocity = currentMovement.y;
        float newYVelocity = currentMovement.y + (gravity * Time.deltaTime);
        float nextYVelocity = (previousYVelocity + newYVelocity) * .5f;
        if (characterController.isGrounded)
        {

            currentMovement.y = groundedGravity;
            currentRunMovement.y = groundedGravity;
            animator.SetBool(isJumpingHash, false);
        }
        else
        {

            currentMovement.y = newYVelocity;
            currentRunMovement.y = newYVelocity;
            if (isJumping)
            {
                animator.SetBool(isJumpingHash, true);
            }
        }
    }

    void OnJump(InputAction.CallbackContext context)
    {
        isJumpPressed = context.ReadValueAsButton();
    }
    void OnRun(InputAction.CallbackContext context)
    {
        isRunPressed = context.ReadValueAsButton();

    }

    void OnMovementInput(InputAction.CallbackContext context)
    {
        currentMovementInput = context.ReadValue<Vector2>();

        currentMovement.x = currentMovementInput.x * walkMultiplier;
        currentMovement.z = currentMovementInput.y * walkMultiplier;
        currentMovement.y = groundedGravity;

        currentRunMovement.x = currentMovementInput.x * runMultiplier;
        currentRunMovement.z = currentMovementInput.y * runMultiplier;

        isMovementPressed = currentMovementInput.x != 0 || currentMovementInput.y != 0;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    void HandleRotation()
    {
        Vector3 positionToLookAt;

        positionToLookAt.x = currentMovement.x;
        positionToLookAt.y = 0.0f;
        positionToLookAt.z = currentMovement.z;

        Quaternion currentRotation = transform.rotation;


        if (isMovementPressed)
        {
            Quaternion targetRotation = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Slerp(currentRotation, targetRotation, rotatioFactorPerFrame * Time.deltaTime);
        }
    }
    void HandleAnimation()
    {
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isRunning = animator.GetBool(isRunningHash);

        if (isMovementPressed && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }
        else if (!isMovementPressed && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if ((isMovementPressed && isRunPressed) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }
        else if ((!isMovementPressed || !isRunPressed) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
        //if(isJumpPressed && !isJumping){
        //  animator.SetBool(isJumpingHash, true);
        //}else if(!isJumpPressed && isJumping){
        //  animator.SetBool(isJumpingHash, false);
        //}
    }
    // Update is called once per frame
    void Update()
    {
        HandleRotation();
        HandleAnimation();
        if (isRunPressed)
        {
            characterController.Move(currentRunMovement * Time.deltaTime);
        }
        else
        {
            characterController.Move(currentMovement * Time.deltaTime);
        }
        HandleGravity();
        HandleJump();
    }
    void OnEnable()
    {
        inputs.charactercontrol.Enable();
    }
    void OnDisable()
    {
        inputs.charactercontrol.Disable();
    }
}
