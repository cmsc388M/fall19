# Project 2: Barrel Murderer


## Introduction
In for this project you will be creating a very basic Unity project from scratch in order to get you more comfortable with scripting and get you used to Unity's physics system, Instantiation, and raycasting.  This game will be played from a first person perspective and the objective of the game will be destroy all of the barrels placed in the level by left clicking and shooting them with bullets.  Here is a high level outline of the project:

1. Create a new Unity Project titled LastName_FirstName_Project2
2. Build a very basic 3D environment with Unity's terrain tool
3. Create a simple physics based barrel prefab 
4. Create a first person character controller
5. Fire a bullet when left click is pressed
6. Spawn a barrel when right click is pressed
7. Archive the project with git and submit it on elms.

Bonus Objectives (Totally optional but you can get extra points for them)
8. Implement jumping on your character controller and make sure your character can only jump when touching the ground.
9. Figure out how to make a game object that moves towards the player and can be destroyed with a bullet


### Building an Environment
For this project you will be making your own basic scene for the player to walk around in. You can create a simple plane for the player to walk on by:
- Right clicking on the hierarchy
- Mouse over the 3D category
- Select terrain from the drop down options
- Click on the terrain GameObject and look at it in the inspector
- Use the terrain paint tools to form mountains and other shapes as you like
[This youtube video](https://www.youtube.com/watch?v=ZwlwCFz9Vvg) can show you how to do that, and also shows how to add textures and color your terrain. The terrain tool may run very slowly on old computers so if you are having performance issues just make the terrain very simple.

### Creating a barrel prefab
You now need to create a simple barrel prefab and add a rigidbody and collider onto it in order to make it a physical object and have it be affected by physics and gravity. The barrel could be a 3D model you import, or could just be a basic cylinder object with some physics applied to it. You should then place 2+ prefabs around the terrain that you created.

### Creating the player controller
A player controller is a term for a GameObject that the player controls somehow via input. In this project this GameObject will be controlled from a first person perspective and will move based on input from the mouse and keyboard.

- The player GameObject should have both a rigidbody component and a collider component attached to it. The collider component gives the controller physical bounds and means that it can collide and interact with other colliders. The rigidbody makes it a physics object and ensures it is affected by gravity, and that it cannot pass through colliders. All movement in scripts should be done through rigidbody functions. This means it should not pass through walls or floors when moving.
- When the up/down arrow keys are pressed or held down the character should move forwards/backwards, relative to the camera's current view
- When the left/right arrow keys are pressed or held down the character should move left/right, relative to the camera's current view
-When the mouse is moved to the left or right the camera should rotate left or right, and when the mouse is moved up/down the camera should also move up/down.

Note that all movement should occur relative to the camera, meaning that when the player moves forward they should move in the direction that the camera is facing. Once you have made the player controller, test it and make sure that it collides with physical objects and moves correctly.

### Firing a bullet
When the left mouse button is clicked the player should fire a bullet in the direction they are facing. The bullet should also be a physical object, be affected by gravity, and collide with stuff. This bullet should be generated via [GameObject.Instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html). GameObject.Instantiate creates a GameObject at runtime and returns a reference to the created GameObject. You can use this to spawn a bullet, get a reference to it, and then start moving that spawned bullet in some way. The bullet should also be moved using rigidbody functions and should collide with objects. If a bullet collides with a barrel object the barrel should be destroyed. The bullet should then destroy itself regardless of what it hit.

### Raycasting
When the right mouse button is pressed a new barrel object should be created 3 Unity units above wherever you clicked. The should be accomplished using the [Physics.RayCast](https://docs.unity3d.com/ScriptReference/Physics.Raycast.html) method. You should raycast from the center of the camera, in the direction the camera is facing, and if you hit something you should spawn a barrel 3 Unity units above that position. There are many different ways to call Physics.Raycast, so to avoid confusion we reccommend that you use a method similar to the script we used in class and described in the slides.


Potential Art Resources
- [Free Terrain Textures](https://assetstore.unity.com/packages/2d/textures-materials/terrain-textures-pack-free-139542) 
- [Barrel](https://assetstore.unity.com/packages/3d/props/industrial/barrel-840)
