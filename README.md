# spaceShooter

Heres the Link to the entire file!

https://drive.google.com/drive/folders/1U0JQgzey_vFv9CBbN996fuc3kuKfrU3T?usp=sharing



It's time to play!


Avoid your enemies and Get as far as you can, in this amazing shooter game!


You are controlling a spaceship and traversing through space, as enemy spaceships try to shoot you!


Fight back by shooting and avoiding them! Get as far as you can!


![Demo](https://user-images.githubusercontent.com/26602639/45920630-a7a0c980-bec4-11e8-92f6-51064bc9e8f5.gif)


Control: Arrow Keys/WASD
Shooting: Space bar

# What are the objects and Prefabs?

There are all in all 4 major working parts in this project:
1) the Player: the player is the most important part. The player has the scripts for firing upon pressing Spacebar, the script for movement etc.

2) The Game manager: The game manager controls game start, end and restart sequences. It also controls the vaarious conditions to be satisfied for ending etc.

3)The obstacle: This gets in your way. When you hit it, your game ends, as your script for movement is disabled.

4)The Enemy SpaceCraft: The enemy periodically shoots in a single direction. Hitting the enemy will end the game. Shooting the enemy will kill it

5) The Bullet: The bullet is fired from the Player and the enemy. It's mass and speed of exit from the bullet_emitter is variable

6) bulletEmitter: The bullet Emitter is the point from where the bullet is fired, upon pressing spacebar.It is placed under enemy and player space
