# Unity Junior Programmer Prototype4

---

This project was carried out as part of the "unity junior programer pathway". Throughout the project, the following game mechanics were practiced.

## Until Now!

* We defined mobility for the player and moved the camera to determine the direction of movement.
 
* Enemy Control and SpawnManager scripts were created.
 
* Added powerup feature for player.
 
* Spawn conditions set for powerup system

* Adjusted the behavior of the enemy object when it collides with the player while the powerup system is active

* The system that destroy the enemies when they fall from the platform has been created.

* A loop that allows enemies to multiply and respawn after they die has been created. 

* The powerup system is formed depending on the number of enemies.

### Challenge 4

1) Bug: Hitting an enemy sends it back towards the player;
   * The mentioned bug was caused by line 69 of the PlayerControllerX script. In the operation on this line, when the player gameobject touches an object in the Enemy tag, it subtracts the position of the enemy object from the position of the player object.
   ***For the bug solution, I rewrote this process in reverse order.***


2) Bug: A new wave spawns when the player gets a powerup;
    * The mentioned bug was caused by line 23 of the SpawnManagerX script. In the operation on this line, the variable enemyCount was bound to the gameobjects with the Powerup tag. For this reason, the game spawned new enemies when it touched the powerup icon. ***To fix the bug, I set the tag to follow Enemy objects.***


3) Bug: The powerup never goes away;
    * The mentioned bug was caused by line 56 of the PlayerControllerX script. The PowerupCooldown function in this line was defined but not used. For this reason, the powerup was constantly running. ***For the solution of the bug, I assigned the PowerupCooldown method as the parameter of the StartCoroutine method and activated it in the OnTriggerEnter method.***


4) Bug: 2 enemies are spawned in every wave;
   *The mentioned bug was caused by line 52 of the SpawnManagerX script. In the for loop on this line, it was working as long as the variable i was less than 2. ***For the solution of the bug, I defined the enemiesToSpawn variable, which is the parameter of the SpawnEnemyWave method, in the for loop.***


5) Bug: The enemy balls are not moving anywhere;
   *The mentioned bug was due to the playerGoal object not being defined and it was giving a null reference error in Unity. ***For the solution of the bug, I defined the playerGoal object in the Start method in the EnemyX script.***


6) Bonus: The player needs a turbo boost;
   *Input.GetKey(Key.Code.Space) condition has been added for add force method in PlayerControllerX script.