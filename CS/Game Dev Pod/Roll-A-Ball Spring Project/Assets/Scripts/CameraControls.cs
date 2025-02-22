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

    // 1. Declare a public variable of type GameObject named 'target'; We will assign it a value in the Unity Editor. 
    // This variable stores a GameObject we will make the camera follow
    // YOUR CODE HERE

    // 2. Declare a private variable of type Vector3 named 'positionOffset'; We will assign it a value in the Start() method.
    // This variable stores a Vector3(x, y, z) we will use to determine how far the camera is from its target when following it.
    // A Serialized Field keeps a field/variable private while still allowing it to be modified in the Unity Editor
    [SerializeField] // YOUR CODE HERE
    #endregion

    // Start() is a built-in Unity function/method called before the first frame update of the game
    void Start()
    {
        // 3. Assign the 'positionOffset' variable a value: this camera's position - target position
        // (HINT: which component is responsible for a GameObject's position?) 
        // This line of code calculates the difference in position between the camera and its target, then stores that value in the 'positionOffset' var
        // YOUR CODE HERE
    }

    // LateUpdate() is exactly like Update(), only it is called immediately after; Great for camera movement, animations, or physics-realted calculations
    void LateUpdate()
    {
        // 4. Write an if statement with the following condition: if "target" does NOT equal "null"
        // This if statement checks if the camera has a target assigned to it or not, and only executes the following code if it does 
        // (Hint: Don't forget to create {} brackets after the head of the if statement; )
        // (HINT: The "does not equal" operator is !=)
        // YOU CODE HERE

            // 5. Declare a local variable of type Vector3 named 'newPosition'; assign it the value: target's position + 'positionOffset'
            // This line of code calculates the camera's new position based on its target's position and the set position offset.
            // (HINT: Which component is responsible for a GameObject's position?)
            // (HINT: A local variable does NOT use the 'private' or 'public' keywords; simply start with the name of the variable)
            // YOU CODE HERE

            // 6. Assign the camera's transform.position to 'newPosition'
            // This line of code applies the variable created in step 5 and set's the camera's new position based on that value
            // This effectively makes the camera update its position each frame to follow its target using the position offset to maintian the desired distance
    }

    // 7. Return to the Unity Editor
    // Select the 'MainCamera' GameObject in the Hierarchy window
    // In the Inspector window, exapnd the camera's 'Camera Controls compoent'
    // Assign the 'Player' as this camera's target by dragging and dropping the player from the Hierarchy into the 'Target' slot
    // If you skip this step, you will get an UnassignedReferenceException error in the console when testing your game

    // 8. Enter play mode
    // In the Heirarachy, select the 'Player' GameObject to access its components in the Inspector window
    // Exapnd the 'Transform' component, and manually change the player character's position
    // Your camera should follow the player character as it moves!


}
