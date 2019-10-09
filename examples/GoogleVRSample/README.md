# Google VR Sample

This sample app is based off of a completed version of [this tutorial](https://youtu.be/xz5cP2JdxTM) with a few modifications.

## Using the Editor Emulator

In the scene, you may notice a few prefabs that will help you simulate the behavior of an actual VR headset. They are as follows:


1. GvrEditorEmulator - This prefab will allow you to simulate the movement of the VR headset in your editor. Once you place this prefab in your scene and hit play you can hold down Alt and move your mouse in order to simulate the rotation of the player's head.

![enter image description here](https://lh3.googleusercontent.com/RH_wuNcuWaPgVfLzPOZaGBtzjvKkgbyvaSVKClEHv0rJIZz4zZWqteGJWsduZYp4WF4kEiMHQ8eo)

2. GvrControllerPointer - This prefab will place a daydream controller model in your scene that will linked up to the movements of the Daydream motion controller in your final app. This controller has a pointer gameObject that will be used to interact with buttons and 3D Objects in the VR Scene

![enter image description here](https://lh3.googleusercontent.com/pGYJFJ8cmPu6huELQhoNycNGEUomZ6UVk4PjF_IK3ojLeQ9_xnaOXhpxs9tm1n0QoVcRzaLqjHcf)

3. GvrControllerMain - This prefab will allow you to emulate the movements of the Daydream controller when you play the in the editor. You can rotate the controller by holding down shift and moving the mouse while playing the app. You can also simulate button clicks on the controller using the right and left mouse buttons. The full controls for the controller emulator are listed on the GvrController component attached to the prefab.

![enter image description here](https://lh3.googleusercontent.com/NjMUSafkNTqOPN-CGwBgRuNaE8zLrYhVSsy-Q4o01NtkXbz0Y99Kt2gM47U9WDRoy0W1pLCokYJ1)

## Interactions with Google VR

In this example, all of our interactions will be done using the controller pointer gameobject with either World UI gameobjects or interactable 3D gameobjects. The latter can be done by attaching an Event Trigger component to the gameobject and then adding event types related to the pointer. You can then set action(s) that should be performed when each event type occurs. Check out the Cube in the scene to see how this is implemented to make the cube change colors and play audio when the pointer passes over or clicks on it.

![enter image description here](https://lh3.googleusercontent.com/ZcxA5kMukvzT4YcGyG1ESkjEkimUkOqNN1jdbqp-IEOED93rV57AlBahZ232o5FBrZu31Lm_BHaU)

You can use this method as a template for figuring out how you should add functionality to other objects in the project. The other form of interaction we are going to have in this project is with world scale UI.

### World UI Canvases

In the Shark Runner Project we included some basic UI elements in the form of the Pause Menu and Main Menu scenes. These were examples of screen space UI, which means they were always drawn on top of the screen. As we will go over in lecture, Screen Space UI looks really bad in VR and very immersion breaking and annoying. This means we have to use world space UI if we want to make buttons and other interactive UI elements and Menus. In order to create a world space canvas and button you must:
1. Right click on the hierarchy and select UI->Canvas. This will create a world space canvas.
2. Right click on the Canvas and select UI->Button. This will add a button to the canvas.
3. Click on the Canvas GameObject and set the Canvas component's render mode to "World Space". This will turn the canvas into a word space object allowing it to be resized and moved around in the game world.
4. Drag your camera gameObject into the event Camera Field on the Canvas Component
5. Delete the graphic raycaster component from the canvas and add a GvrPointerGraphicRaycaster to the canvas instead.
6. Scale down the canvas and reposition it so it is visible to the player.

Once the world space UI is in the scene you can interact with it by moving the pointer over the button and left clicking. If you are confused by this process or want to learn more about Canvases and Unity's UI system here is a [youtube video](https://www.youtube.com/watch?v=_RIsfVOqTaE) describing how it works in more depth. You can also look at the canvas GameObject in the sample project and use that as a reference for when you create your World Space Menu for the project.
