# Project 2: Barrel Bouncer (Part 1)

**Due:** Friday, September 20, 2019 at 4:59:59 AM EDT

In this project, you will be creating a first-person game where you spawn barrels in a custom environment and then try to break them by throwing balls at them. This project is intended to give you practice with some of the topics learned last class, including Unity's physics system, raycasting, and rotations, and also to serve as an introduction to a few other cool features in Unity.

## Instructions

At a high level, these are the main tasks that this project involves. Read below for more detailed information about each.

- Use the Unity Hub to create a new project titled _**Barrel Bouncer**_.
- Build a basic 3D environment from scratch using Unity's terrain tool.
- Create a first-person character controller from scratch.
- Program game logic to instantiate and destroy various gameobjects.
- Implement physics-based interactions between gameobjects in scene.
- Use Git to create a zip file of the your project and submit it via ELMS.

### Building an Environment

The first step is to create your own basic 3D environment from scratch for the player to walk around in. Here is how you can accomplish this:

- On the menu bar, go to `GameObject` -> `3D Object` -> `Terrain`.
- In the Heirarchy, click on the GameObject titled _**Terrain**_.
- In the Inspector, explore the Terrain component on the Terrain GameObject and familiarize yourself with the various tools it offes. Use these to form hills, valleys, and mountains in your scenes. Then add textures and color to your terrain, such as dirt, moss, rock, sand, grass, and snow. For reference on how to do this, see [this YouTube video](https://youtu.be/ZwlwCFz9Vvg).
- You may also add _**Trees**_ if you would like. To add them, go to `GameObject` -> `3D Object` -> `Tree` and experiment with its components.

Note that the terrain tools and textures included in Unity by default are very limited. Luckily, Unity has additional terrain tools in preview and also has some optional brushes and textures to allow you to create even more exciting environments. To access these, you will need to import packages using the Package Manager and the Asset Store, as described below:

- On the menu bar, go to `Window` -> `Package Manager`.
- In the new window that pops up, go to the _**Advanced**_ dropdown menu and check _**Show preview packages**_.
- Scroll down to, or search for, _**Terrain Tools**_. Click on this item and install it.
- Once it is installed, go to the _**Asset Store**_ and import the following [sample assets](https://assetstore.unity.com/packages/2d/textures-materials/terrain-tools-sample-asset-pack-145808).

While this may be the first time you are using the package manager, it will be used a lot more in some of our later projects. In Unity, a package is a collection of assets, which are any kind of files supported by Unity (scripts, scenes, materials, 3D models, audio, images, etc.). Both the Asset Store and Package Manager allow you to import and upgrade packages. The difference between the two is that the Package Manager is used for optional features of Unity itself as well as certain 3rd-party SDKs. This is how we'll be managing some of the AR and VR SDKs in the future. The Asset Store, on the other hand, is generally used as a marketplace for specific content that would end up in your scene.

### Creating the Character Controller

A character controller is a component on your main "player" or "camera" GameObject that allows the user to control movement via input. Common tasks that a player controller allows for are looking around in all directions and left/right/forward/backwards movement of the player. A character controller can be either first-person or third-person.

Note that while there are many character controllers available on the asset store and via other sources, you are required to implement your own from scratch for this project.

Here are the requirements for your character controller:

- The player GameObject should have both a RigidBody component and a Collider component attached to it. The collider component gives the controller physical bounds and means that it can collide and interact with other colliders. The rigidbody makes it a physics object and ensures it is affected by gravity, and that it cannot pass through colliders. All movement in scripts should be done through rigidbody functions. This means it should not pass through the ground or objects when moving.
- Your controller should be first-person.
- When the up/down arrow keys are pressed or held down the character should move forwards/backwards.
- When the left/right arrow keys are pressed or held down the character should move left/right.
- When the mouse is moved to the left or right the camera should rotate left or right, and when the mouse is moved up/down the camera should also move up/down.

Note that all movement should occur relative to the camera, meaning that when the player moves forward they should move in the direction that the camera is facing. Once you have made the player controller, test it and make sure that it collides with physical objects and moves correctly. Note that you may have to add objects into your scene to test this.

### Spawning Barrels

In this section, you will implement functionality where you use raycasting to spawn a barrel somewhere in your environment every time you right-click with your mouse.

First, you will need to import a model of a barrel, such as [this one](https://assetstore.unity.com/packages/3d/props/barrels-32975) on the Asset Store (though feel free to use a different one if you would like). Make sure to add a Rigidbody and Collider onto it if it does not already have one in order to make it a physical object that is affected by physics and gravity.

When the right-click is pressed on your mouse, you should raycast out from the center of your camera view (see the [Physics.RayCast](https://docs.unity3d.com/ScriptReference/Physics.Raycast.html) method). Below are the two possible outcomes from doing this, as well as how you should respond to each outcome:

* Ray intersected with a Collider on a GameObject in your scene
  - Use the `Debug.Log` method to send output to the console that states the name of the gameobject that was hit.
  - Spawn a new barrel 1 meter above that position, so that the barrel then falls down onto that position. See the documentation for [GameObject.Instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html).
* Nothing was in the path of the ray
  - Use the `Debug.Log` method to send output to the console with a message that says that nothing was hit.

You may notice that there are many different ways to call `Physics.Raycast`. We went over one such method over class, which you can find in our slides and on the example project.

### Throwing a Ball

You will need to make a ball prefab as well. To do this, create a new sphere and drag it from the heirarchy to the project window. Then modify your ball prefab so that it is also a physical object that is affected by gravity and can collide with stuff. If you would like, you can also create a new material to add a custom color to your ball.

When the left button of your mouse is clicked, the player should throw a new ball in the direction they are facing (once again see [GameObject.Instantiate](https://docs.unity3d.com/ScriptReference/Object.Instantiate.html)). The ball should also be moved using rigidbody functions and should collide with objects. It should move in a projectile fashion and should bounce once it hits the ground, much like it would do in real life _(Hint: Look up physics material to get "bounciness" behavior)_. If a ball collides with a barrel object the barrel should be destroyed. Regardless of if anything is hit, the ball should destroy itself after 5 seconds.

### Bonus Tasks (Optional)

* Instead of destroying the barrel immediately upon impact with a ball, add a particle effect to it for 3 seconds before destorying it. Check out [this package](https://assetstore.unity.com/packages/essentials/tutorial-projects/unity-particle-pack-127325) for some cool effects.
* Implement jumping on your character controller and make sure your character can only jump when touching the ground.
* Add monsters or aliens into the scene that always move towards your player. They should obey the laws of physics and should also be destroyed if a ball hits it.

## Submission Details

Your submission to ELMS should consist of a single zip file, entitled `Last_First_BarrelBouncer_Part1.zip`. **Make sure to use Git to zip your project**. The basic steps involve initializing a new repo, commit all your changes, and using archive to create the zip file (follow the steps from project 0 if you need a refresher).
