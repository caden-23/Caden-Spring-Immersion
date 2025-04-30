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
    private bool isCollected = false;

    // Update is a built-in Unity function/method called every frame of your game (there is on average 60 frames per second)
    void Update()
    {
        // 2. Access this GameObject's transform component & call the 'transform.Rotate()'  function/method; 
        // Pass a 'new Vector3(15, 30, 45) * Time.deltaTime' as the parameter  for this function/method call;
        // This statement makes this GameObject rotate 15 degrees on the x-axis, 30 on the y-axis, & 45 on the z-axis every second; 
        // (Time.deltaTime is a special number that makes an operation in Update() happen per second rather than per frame, creating a more consistent performance across many different frame rates)
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    // OnTriggerEnter(Collider other) is a built-in Unity function/method that is called when another collider enters a trigger collider attached to the GameObject where this script is applied.
    // This function/method is therefore called on a pickup GameObject whenever the player character collides with it, but only if one of these GameObjects' collider component is marked as a 'trigger'
    private void OnTriggerEnter(Collider other)
    {   
        // 3. Write a single-line if statement with the following condition: if 'isCollected == true'; after the parentheses, type 'return;'
        // This if statement checks to see if the player has already collected a pickup to avoid the player from picking up the same item more than once
        // The 'return' keyword exits this OnTriggerEnter() method/function early since we do not want to calculate picking up a pickup item more than once
        if (isCollected == true) return;

        if (other.gameObject.CompareTag("Player")) //if the object this pickup collied with us tagged as ...
        {
            isCollected = true;
            AudioManager.Instance.PlaySound("Collect Coin");
            GameManager.Instance.UpdateScore(1);
            Destroy(this.gameObject);
        }
    }
}
