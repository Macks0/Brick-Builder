using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
 // Max Schmit 2/15/2025
public class PlayerPaddle : MonoBehaviour
{
    // Vars
    protected Vector3 moveDir = Vector3.zero;
    [SerializeField,Range(1, 20)] protected float moveSpeed = 1f;
    //[SerializeField, Range(10, 29)] protected float maxSpeed = 25f;
    // Methods
    private void Update()
    {
        MovePaddle();
    }


    // Take input from action 
    public void MoveInput(InputAction.CallbackContext aCon)
    {
        Vector2 av2 = aCon.ReadValue<Vector2>();

        moveDir.x = av2.x;
        //aMoveDir.z = av2.y;
     


    }

    // Move player paddle
    public void MovePaddle()
    {     
        transform.Translate(moveDir * moveSpeed * Time.deltaTime);

    }

    // Accessors 

}
