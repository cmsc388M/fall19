# Project 1: Shark Runner

**Due:** Friday, September 13, 2019 at 4:59:59 AM EDT

In this project, you will be completing the functionality for a very simple level-based game that we started called _"Shark Runner"_. Shark Runner is a first-person runner-style game that takes place under the sea, where you are the shark and you must eat fish and dodge obstacles in order to survive. You will be responsible for implementing various game logic, such as the shark movement. The project contains three Unity scenes where you will have to add functionality via C# scripting.

## Instructions

At a high level, these are the main tasks that this project involves. Read below for more detailed information about each.

- Use the Unity Hub to open the project in the _**Shark Runner**_ folder.
- Add a persistent audio track to the first level that will play throughout the entire game 
- Implement the movement and game logic as described below
- Spruce up the "Level_1" Scene by adding some decorative prefabs to the level, and finding and importing a mesh of your own
- Use Git to create a zip file of the your project and submit it via ELMS

Google and the Unity Docs are your friends in this project. Unfortunately, we don't have time to go through all of the Unity features in our class, so you will be responsible for learning how to do certain things. Luckily, Unity has great documentation and a very responsive community on the unity forums and stackoverflow. If you don't know how to do a X thing in Unity, 90% of the time if you type _"How to do X thing in Unity"_ you will get a link to the right documentation. You can also ask us questions on Piazza or come into office hours for help as well (PLEASE DO SO!!!!), but we strongly suggest you use Google first, since ultimately, learning how to effectively use Google and the Unity Docs and forums is a neccesary skill for this class. If there is a term you don't recognize you should Google it immediately and start getting yourself familiar with different Unity terms and components.

### 1. Adding Persistent Audio

Open up the "Main_Menu" scene in the scenes folder. There are buttons in this scene that we have set up to move between the scenes via the LevelSwitcher script. We have one music track that we would like to play throughout the entire app. The music should start in the "Main_Menu" scene and persist throughout the entire game without restarting the track. This means that when you switch scenes the audio should continue playing and loop on completion. The audio track that should be played is called _**Underwater_Theme.mp3**_ and can be found in the _**Music**_ folder within your _**Assets**_. The audio player should be a singleton, meaning there should only ever be one of them present in a given scene at any time. If you want to swap in your own music track for this you are welcome to do so, just make sure we can hear it.

### 2. Implementing Game Logic

Open up the "Level_1" scene in the scenes folder. We have already set up the layout of the level for you, but you are welcome to change it. The objective of this level is to reach the portal at the end of the underwater passageway while obtaining the maximum amount of points by eating fish and avoiding the walls and landmines. The player will control the shark prefab, which already has a camera and mesh attached to it. The game will be played from a first person perspective, so the mesh is not really necessary, but it helps show the dimensions of the shark. Currently, nothing happens when you are in this scene, so it will be your responsibility to get the scene working.

#### Important design constraints and notes

- Read all of functionality and requirements before implementing anything

- All of your code for this project should be created in new file(s). It is up to you to decide how you want to design your C# script(s) and what GameObject(s) you will be adding them too.

- You should not edit any of the scripts that we created or that were already attached to GameObjects in the starter project. They are mainly there to provide additional and/or helper functionality. This document will inform you of anything that you need to know about the included scripts in order to complete the project. You do not have to worry about reading through the code, but you are welcome to do so for your own learning.

- The player has points that are collected when they collide with goldfish and eat them. These points are stored in the _**GameData**_ helper class that we created for you and should only be changed with the static methods `GameData.AddPoints()` and `GameData.ResetPoints()`.

- Switching between scenes should be done with a reference to a _**LevelSwitcher**_ component. This script has already been written for you. As a general practice, if you are going to switch scenes often, it is a good idea to keep all the scene switching logic in one or two classes as you can control how scenes are loaded without having to jump through multiple scripts. Thus, we recommend that you look over this script to understand how it works.

#### Game Functionality

1. Shark Movement
	- The Shark should constantly be moving forward while the game is not paused.
	- When the player presses the right or left arrow keys the shark should move to the right or left respectively, but only while the key is pressed. If the game is paused the shark should not move.
2. Pausing
	- When the player presses the escape key, the game should pause. All this means is that the "Pause_Menu" GameObject attached to the shark should appear on the screen and the shark should stop moving. If the player presses the escape key while paused, the "Pause_Menu" GameObject should disappear and the shark should continue moving.
3. Bumping Into Other Objects
	- If the shark collides with the portal at the end of the level, the scene should change using a call to `LevelSwitcher.GoToGameOver()`. In order to call LevelSwitcher functions you must have a reference to a LevelSwitcher object, like the one already present in the scene.
	- If the shark prefab collides with a rock or a landmine, the Shark should stop moving and the "Lose_Text" GameObject attached to the shark should appear. Then after 2 seconds the level should be reset using a call to `LevelSwitcher.GoToLevelOne()`. The timing on the reset **MUST** be accomplished with a coroutine for full points. Note that the "RockWall_Prefab" and "Landmine_Prefab" are both tagged with a "Die" tag.
	- If the shark collides with a "Goldfish_Prefab" the player should gain 100 points using the `GameData.AddPoints` function. Note that the goldfish has a trigger collider. A trigger collider is used here because  we don't want eating a goldfish to affect the physics of a player when they are picked up.

### 3. Decorating The Level 1 Scene

To get you more familiar to the process of creating and using prefabs we would like you guys to add some decorations to the Level 1 Scene and design it a bit. The prefabs are located in the prefabs folder and you can click and drag them into the scene in order to place them.

1. Place 2+ Goldfish_Prefabs somewhere in the level where the player can pick them up.
2. Place 2+ Landmine_Prefabs in places where the player could potentially collide with them.
3. Place some of the decorative prefabs found in the /Prefabs/Decorations in the level.
4. Find or create a new mesh and import it into the project and place it in the level as a decoration or obstacle. You can find many free 3D models via the Asset Store (as described in the last project) or at the sites below:

	- [Poly by Google](https://poly.google.com/)
	- [SketchFab](https://sketchfab.com/)
	- [Kenney's Free Game Assets](https://kenney.nl/assets?q=3d)
			
Or you can try to make your own models using modeling software like  [Blender](https://www.blender.org/) or [MagicaVoxel](https://ephtracy.github.io/)

## Testing Details

Before submitting, make sure to thoroughly test your project to ensure you have implemented all the functionality that we outlined. You do **not** have to build and test on a mobile phone for this project; using the Unity play mode is perfectly fine.

While grading, we will be looking over your source code to make sure you see your implementation and to ensure that you have adhered to all guidelines and instructions.

## Submission Details

Your submission to ELMS should consist of a single zip file, entitled `Last_First_SharkRunner.zip`. **Make sure to use Git to zip your project**. The basic steps involve initializing a new repo, commit all your changes, and using archive to create the zip file (follow the steps from last project if you need a refresher).


## Sources:
- [Underwater Music](https://www.youtube.com/watch?v=IMyLqoZomo4)
- [Rock 3D models](https://www.kenney.nl/assets/nature-kit)
- [Fish 3D Model](https://poly.google.com/view/3GPUntjwqCa)
- [Shark 3D Model](https://poly.google.com/view/8Ke5qCnWxsZ)
- [Crab 3D Model](https://poly.google.com/view/2DgM36qZW2u)
- [Kelp 3D Model](https://poly.google.com/view/4cFllH6Iazk)
