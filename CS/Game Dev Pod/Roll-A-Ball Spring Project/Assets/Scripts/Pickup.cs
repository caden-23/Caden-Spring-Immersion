using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    #region Relevant Concepts
    // Local Variables
    // transform.position
    // LateUpdate()
    // Time.deltaTime
    // Trigger Collider
    // return key word
    // Single-line if statements
    // GameObject vs. gameObject
    // this keyword
    // Parameters
    // Destroy() function/method
    #endregion

    // 1. Declare a private variable of type bool named 'isCollected' and assign it the value 'false';
    // This variable is a flag to trak whether or not this pickup has been collected by the player or not
    // YOUR CODE HERE

    // Update is a built-in Unity function/method called every frame of your game (there is on average 60 frames per second)
    void Update()
    {
        // 2. Access this GameObject's transform component & call the 'transform.Rotate()'  function/method; 
        // Pass a 'new Vector3(15, 30, 45) * Time.deltaTime' as the parameter  for this function/method call;
        // This statement makes this GameObject rotate 15 degrees on the x-axis, 30 on the y-axis, & 45 on the z-axis every second; 
        // (Time.deltaTime is a special number that makes an operation in Update() happen per second rather than per frame, creating a more consistent performance across many different frame rates)
        // YOUR CODE HERE
    }

    // OnTriggerEnter(Collider other) is a built-in Unity function/method that is called when another collider enters a trigger collider attached to the GameObject where this script is applied.
    // This function/method is therefore called on a pickup GameObject whenever the player character collides with it, but only if one of these GameObjects' collider component is marked as a 'trigger'
    private void OnTriggerEnter(Collider other)
    {   
        // 3. Write a single-line if statement with the following condition: if 'isCollected == true'; after the parentheses, type 'return;'
        // This if statement checks to see if the player has already collected a pickup to avoid the player from picking up the same item more than once
        // The 'return' keyword exits this OnTriggerEnter() method/function early since we do not want to calculate picking up a pickup item more than once
        // YOUR CODE HERE

        // 4. Write an if statement with the following condition: access 'other.gameObject.CompareTag()' 
        // Pass "Player" as a parameter into the the CompareTag() method/function
        // This if statement verifies what GameObject just collided with this pickup by checking if it has the tag "Player"; 
        // (HINT: Don't forget to create brackets{} for the body of your if statement; #5-8 should be inside and indented within these brackets{})
        // YOUR CODE HERE

            // 5. Reassign the 'isCollected' variable the value 'true';
            // Only after we have confirmed the player character has touched this pickup can we mark it as collected 
            // YOUR CODE HERE

            // 6. Call the 'AudioManager.Instance.PlaySound()' function/method; Pass "Collect Coin" as the parameter;
            // This statement accesses the AudioManager (another custom script in this project) and calls one of its functions/methods, 'PlaySound()'
            // The custom PlaySound() function/method takes the name of a sound effect to play as a parameter, then plays that sound!
            // YOUR CODE HERE

            // 7. Call the 'GameManager.Instance.UpdateScore()' function/method; Pass 1 as the parameter;
            // (HINT: The number you use for this parameter will be how many points the player earns per pickup; you can set this any number you like!)
            // This statement accesses the GameManager (another custom script in this project) and calls one of its functions/methods, 'UpdateScore();'
            // The UpdateScore() function/method updates the variable that stores the player's score, which is then updated to the UI!
            // YOUR CODE HERE

            // 8. Call the 'Destroy()' function/method; Pass 'this.gameObject'
            // (HINT: The 'this' keyword refers to the instance of this script on this pickup GameObject, Pickup.cs)
            // (HINT: 'gameObject is NOT the same as GameObject! 'gameObject' refers to the GameObject this script is attached to, which is this pickup)
            // This statement destroys this pickup GameObject 
            // YOUR CODE HERE
    }
}
