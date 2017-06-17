/* A simple-ish example of variables and scope.
   
   Inside of FrictionThing, we define:
   		puppet (Transform): the object we will control
   		x_velocity (float): how fast we move
   		kept_speed (float): how much of that speed we keep each Update.

   	Update() happens once per frame.
   	Update can see the variables outside of it (puppet, x_velocity, kept_speed).
   	Each update, we will:
   		slow down a bit (based on kept_speed)
   		change position (based on x_velocity)

   	Try putting this in your scene, dropping an object onto the puppet field,
   	and seeing what happens with different settings for velocity and kept_speed.
   
   FrictionThing is a "Class". That basically means that "it holds a group of information".
   It becomes a convenient container to hold and access our variables.
 */

using UnityEngine;
using System.Collections;

public class FrictionThing : MonoBehaviour {
	
	public Transform puppet;  // <- Drop an object on this from the hierarchy.
	public float x_velocity = 10.0f;  // how fast you start out
	public float kept_speed = 0.9f;  // how much speed you get to keep
	
	// Update is called once per frame
	void Update () {
		// When you multiply the kept_speed (when less than 1), you get slower.
		// Example: 10 * 0.9 -> 9
		// Example: 10 * 0.1 -> 1
		x_velocity *= kept_speed;
		puppet.position += new Vector3(x_velocity, 0, 0);
	}
}
