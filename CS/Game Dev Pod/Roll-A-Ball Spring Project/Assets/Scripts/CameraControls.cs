using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    #region Relevant Concepts
    // Local Variables
    // transform.position
    // LateUpdate()
    #endregion
    
    #region Variables
    public GameObject target;
    [SerializeField] private Vector3 positionOffset;
    private float initialYPos;
    #endregion

    // Start() is a built-in Unity function/method called before the first frame update of the game
    void Start()
    {
        positionOffset = transform.position - target.transform.position;
        initialYPos = transform.position.y;
    }

    // LateUpdate() is exactly like Update(), only it is called immediately after; Great for camera movement, animations, or physics-realted calculations
    void LateUpdate()
    {
        // 4. Write an if statement with the following condition: if "target" does NOT equal "null"
        // This if statement checks if the camera has a target assigned to it or not, and only executes the following code if it does 
        // (Hint: Don't forget to create {} brackets after the head of the if statement; )
        // (HINT: The "does not equal" operator is !=)
        if (target != null)
        {
            Vector3 newPosition = target.transform.position + positionOffset;
            newPosition.y = initialYPos;

            transform.position = newPosition;
        }

          
    }

   


}
