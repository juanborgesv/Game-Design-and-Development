# Game Design and Development - Log

## Day 0: November 28, 2018
**Today's Progress:** I compared 3 scripts for a Character Controller behavior for the player's character, write down some important details, and got some interesting things that I would like to add to my own Character Controller script. After reading the three scripts I got an interesting and really important question: "When should I read user's input? Update vs FixedUpdate". After reading a post about it in the Unity forum, in short words, I should read user input in the Update method, and then move the character in FixedUpdate, due to possible input loss.

**Thoughts:** Happy to start another log.md, inspired by my previous log's success about Android Development. I hope to keep working, learning and motivated as good as I did with Android Development.

## Day 1: December 1, 2018
**Today's Progress:** I finished the CharacterController script, the player can run and jump, and it flips the character appropiately. Checking [Execution Order of Event Functions](https://docs.unity3d.com/Manual/ExecutionOrder.html) was really useful, it has a diagram that shows which things should I do in the different Event Functions.

**Thoughts**: I did checked several times the Execution Order of Event Functions before but never read it completely, it has really interesting information.

## Day 2: December 2, 2018
**Today's Progress:** I felt that the character's jump did not go as well as Super Mario Bros games, so I watched a really good video about [Better Jumping in Unity With Four Lines of Code](https://www.youtube.com/watch?v=7KiK0Aqtmzc&t=601s). Basically, the trick is to modify how fast the player jumps and falls; so it reaches the peak of the jump slower than it falls. Created all the animations and manage the animator to animate the character as expected.

**Thoughts**: The Unity forum is not as good as I thought, I had two simple questions and did not get an answer, so I'd rather stick with Stackoverflow to look for answers.

## Day 3: January 4, 2019
**Today's Progress:** I've done many things since the last time I write the *Day 2 Log*. I adjust every SeriliazeField of the CharacterController script so the character movement felt right. I created several scripts, a DeathZone script that is used to kill the player when the character falls to the DeathZone, a FallingTrap script that is used in random platforms or ground tiles to make the player fall with the ground as the player steps on it. Finished the first stage of the tutorial, design the second stage of the tutorial level so the player knows how and when crouch. Create an eagle GameObject, animate it, and create its script so it moves between two points, and set some falling traps, so the player reinforces jumping, and crouching to avoid the eagle. I set several checkpoints so it moves the camera and sets a respawn position to the player. Finally I created the pause menu and pause button, it is very basic, it only has a resume option but it should display much more. 
 
**Thoughts**: There are so many things I have to work on, such as TextMesh Pro, ProBuilder, and Particle System. They are useful not only for this project, but for the whole learning experience.

## Day 4: January 18, 2019
**Today's Progress:** I have created the GameManager script and modified it these days a couple of times to make the scene work properly, I encounter many obstacles (bugs/erros) that make the experience very valuable. At first I wanted to create the GameManager script as apropiate and well setted up as possible, so I found [this post](https://answers.unity.com/questions/1124691/creating-a-proper-game-manager.html); it did not convice me about how to manage various things of the project or at least for what I need to do in my project. I took the GameManager script of two projects that I used in other courses and used it as a guide/base for my own GameManager script. 

I needed to delete a couple of things when the game is about to be quitted, so I found [OnApplicationQuit](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnApplicationQuit.html) very useful.

The game I am creating is intended to be played on mobile devices so I needed to start implementing [Buttons](https://docs.unity3d.com/ScriptReference/UI.Button.html) that will move the player around. It didn't took much effort to make everything work, since all the movement logic was already done, the only challenge was to discover how buttons call their respective methods on the CharacterController script. I found [this post](https://answers.unity.com/questions/911698/moving-character-with-touch-buttons-android.html) where it is explained how to move the character using buttons by implementing an Event Trigger Component to each button.

After building and running the game on my mobile device I realized that a couple of things weren't working well, UI elements had a smaller size than I expected, and It was not deleting some things that I was deleting on the OnApplicationQuit method. First, I read [this](https://docs.unity3d.com/Manual/HOWTO-UIMultiResolution.html) link about Designing UI for Multiple Resolutions, and learned how to fix the issue that I had (I change the UI Scale Mode to Scale With Screen Size and tested it a couple of times). Lastly I needed to learn how to debug the Unity application used in my mobile device while watching its logs on the computer, so I found [this](https://forum.unity.com/threads/how-to-capturing-device-logs-on-android.528680/) and learned how to do it on Mac, since the post explains how to do it on Windows I created a [file](https://github.com/juanborgesv/Game-Design-and-Development/blob/master/debug-android-mac.md) that explains how to do it on Mac.

After debugging I realize that the OnApplicationQuit method was not being called, so I replace it with [OnApplicationPause](https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnApplicationPause.html) and it fixed it.

**Thoughts**: I learned a lot of things, and I there is still a lot more to learn. One of the things that always has bother me was Static variables, because I have never used them with complete awareness of what it is doing and why did I need it, the few times I have implemented it was because it was already in the script or I was told to use it with no explanation, but right when I needed It suddenly came to my mind, the "lives" variables was not being modified, and by declaring it as static I could accomplish it.

## Day 5: March 1, 2019
**Today's Progress:** I have advanced a lot, the tutorial level is almost "complete". Pause, Game Over, and Level Complete menu are practically finished. I added a Blur effect when the game is paused which I still have to check how it affects the device's performance, I've seen many posts about it saying that achieving that effect is tricky, and using the Blur script from [Post Processing](https://docs.unity3d.com/Manual/PostProcessingOverview.html) is not the best way to solve it.
 
**Thoughts**: Once I checked little details on the menus and comment some lines of code. I'll start working on my own Sprites in order to replace the [Sunny Land](https://assetstore.unity.com/packages/2d/characters/sunny-land-103349) ones.

## Day 6: March 2, 2019
**Today's Progress:** I watched [this Brackeys video](https://www.youtube.com/watch?v=XOjd_qU2Ido&t=906s) and read [this tutorial](https://gamedevelopment.tutsplus.com/tutorials/how-to-save-and-load-your-players-progress-in-unity--cms-20934) about saving and reading data. Both share really good concepts and very complete information. The positive thing is that my version was not identical to their sample codes since I am using a different type of data, so I had to think how to optimize and apply what I learned with what I had to work on. Finally the game saves the score and it also tells if it is a new High Score or not.
 
**Thoughts**: 
