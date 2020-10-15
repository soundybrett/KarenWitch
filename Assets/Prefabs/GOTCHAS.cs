using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* GOTCHAS - coding traps - Brett 
 
1. Only add collision boxes to the prefab & not the instance in the scene.

 You will need to add more than 1 collision box if you need to jump on the enemy
from the top to kill or die from the enemy with the 2nd wider collision box on the body.

If you add collision boxes on the scene object Instance & not the Prefab parent
you will get very unhelpful coding & unity errors when you try to use:

OnTriggerEnter2D(Collider2D collision)  - for head kill collisions &

OnCollisionEnter2D(Collision2D collision) - for body die collisions.

Unity will NOT give you a more obvious error like "Component X missing from Prefab".
At least as of version 2019.3.6.
*/