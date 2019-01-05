# Game Design and Development - Log

## Day 0: November 28, 2018
**Today's Progress:** I compared 3 scripts for a Character Controller behavior for the player's character, write down some important details, and got some interesting things that I would like to add to my own Character Controller script. After reading the three scripts I got an interesting and really important question: "When should I read user's input? Update vs FixedUpdate". After reading a post about it in the Unity forum, in short words, I should read user input in the Update method, and then move the character in FixedUpdate, due to possible input loss.

**Thoughts:** Happy to start another log.md, inspired by my previous log's success about Android Development. I hope to keep working, learning and motivated as good as I did with Android Development.

## Day 1: December 1, 2018
**Today's Progress:** I finished the CharacterController script, the player can run and jump, and it flips the character appropiately. Checking [Execution Order of Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html) was really useful, it has a diagram that shows which things should I do in the different Event Functions.

**Thoughts**: I did checked several times the Execution Order of Event Functions before but never read it completely, it has really interesting information.

## Day 2: December 2, 2018
**Today's Progress:** I felt that the character's jump did not go as well as Super Mario Bros games, so I watched a really good video about [Better Jumping in Unity With Four Lines of Code](https://www.youtube.com/watch?v=7KiK0Aqtmzc&t=601s). Basically, the trick is to modify how fast the player jumps and falls; so it reaches the peak of the jump slower than it falls.

Create all the animations and manage the animator to animate the character as expected.

**Thoughts**: The Unity forum is not as good as I thought, I had two simple questions and did not get an answer, so I'd rather stick with Stackoverflow to look for answers.

## Day 3: January 4, 2019
**Today's Progress:** I've done many things since the last time I write the *Day 2 Log*. I adjust every SeriliazeField of the CharacterController script so the character movement felt right. I created several scripts, a DeathZone script that is used to kill the player when the character falls to the DeathZone, a FallingTrap script that is used in random platforms or ground tiles to make the player fall with the ground as the player steps on it. Finished the first stage of the tutorial, design the second stage of the tutorial level so the player knows how and when crouch. Create an eagle GameObject, animate it, and create its script so it moves between two points, and set some falling traps, so the player reinforces jumping, and crouching to avoid the eagle. I set several checkpoints so it moves the camera and sets a respawn position to the player. Finally I created the pause menu and pause button, it is very basic, it only has a resume option but it should display much more. 
 
**Thoughts**: There are so many things I have to work on, such as TextMesh Pro, ProBuilder, and Particle System. They are useful not only for this project, but for the whole learning experience.