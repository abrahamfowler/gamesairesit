Steering behaviours are very popular in the gaming industry. This is good because it is fast to implement from just basic groundwork. The purpose of a steering behaviour system is to move a group of objects through a world. The system itself has various child behaviors to complete the move. Through the process of each update, vectors starts to build velocity.[1] 

Steering behaviors either have the vectors can have a final velocity or a helpful force to the current velocity. In the scene there is a 2D plane with walls on the outskirts of the plane, It's an eight – a – side match with 4 players on each side (opponent – red team, player's team blue and the player highlighted yellow). There is a single ball that can be moved or pushed by all the players. The players are able to score and when the ball enters the goal the ball resets back to the middle of the 2D plane. The user needs to use the arrow keys to move the player around in order push the ball into the goal whilst the opposition will try to tackle the player.

A game menu template was used the system had different menu panels and different features. An instruction page which tells you the controls for the game and the objective of the game. The user can also pause the game which asks if you want to quit the game or resume from where the user left off. 

The football has its own class where an OnTriggerEnter public class created for collision. A game object tag was attached to the goals and an empty game object was positioned at the center of the 2D plane, this allowed the ball to go back to the center of the 2D plane when a player scores. 

There are wandering agents in the game, I found out that sometimes game characters move randomly around their environment. Sometimes they might be waiting for something to occur (such as a battle versus the player) or they may be looking for something. When the player observes this behavior, the character wandering ability has to be realistic. If the player can identify the strong line lines or unrealistic behavior, then it will possibly build some frustration. This could be a problem as the player will figure out the character's movement, resulting in an unexciting game experience. The code used to generate the wander AI produces the character's current velocity and every game frame. 

The wander behavior was a way to add random movements to the game. The code used for the wandering behavior applies random movements to the characters. It begins with the applying the character's current direction vector and updates it every frame, any inference with that vector will change the current route. Gizmos were drawn on the wandering characters for detection to sense its surrounding knowing when to change direction. [2]

The follow AI behavior challenges the player, when this behavior sees the target it suddenly chases it. The agent and the environment needed to be baked so that the agent is aware of its surrounding so that the agent can avoid obstacle instead of ensuring that the agent go through obstacles. The player was set as the target to make it difficult for the player to score. 

In the scene there is one following agent that chases the player, the other agents wander. The player's team mate all wander (they don't have a target) to give the player full control and some space to manoeuvre.

My video link: https://www.youtube.com/watch?v=nXw_i8mKPRk

References: 

[1]http://www.gameaipro.com/GameAIPro2/GameAIPro2_Chapter18_Context_Steering_Behavior-Driven_Steering_at_the_Macro_Scale.pdf
[2]https://gamedevelopment.tutsplus.com/tutorials/understanding-steering-behaviors-wander--gamedev-1624
[3] Player controller - https://www.youtube.com/watch?v=F5eE1YL1ZJY&t=1316s
[4]Following AI - https://www.youtube.com/watch?v=hyZPpACBW_8
[5]Wandering AI - https://www.youtube.com/watch?v=4CCAvUqAC7k&t=2s
[6]Goal detection
TheCGMaster: https://www.youtube.com/watch?v=Kjb79y-Lp3k&t=803s 
[7]Faryland Skies – This was from the assets store, this was used for the skybox for the game.
[8] Edo.tff - https://www.fontsquirrel.com/fonts/Edo?filter%5Btags%5D%5B0%5D=distressed&filter%5Btags%5D%5B1%5D=handrawn&sort=popular - This is the site where I got the font from.





 



