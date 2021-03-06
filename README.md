# Assignment 3
This is our CS4240 VR Scarecrow shooter and teleportation game! :D

You are a farmer in a rural farmland. You are tasked with destroying all the evil scarecrows that plague that farm.
With the fruits you have grown in your farm, destory all the scarecrows with as little fruits as possible.

### Environment Scene
![image](https://user-images.githubusercontent.com/7495242/110196271-662aeb80-7e7e-11eb-8bbe-8b8706a3f852.png)

## Platform
Best run on Oculus Quest/ Oculus Quest 2.

## Setting Up
1. Go to Assets > Import Package > Custom Package
2. Navigate to where you have downloaded our unity package and select it
3. Project is optimized for PC build on Oculus (if this option doesn't work, try building it as an android apk)

## Features
### 1. Grabbing object
A fruit is grabbed by pressing <kbd>A</kbd>(joystick button 0) on <kbd>RIGHT CONTROLLER</kbd>.
A fruit can be grabbed if it is one meter distance away from the controller.
When a fruit is successfully grabbed, a grabbing sound effect is played.

> ### Grabbing Script
> 
> GunController.cs

### 2. Throwing object
The fruit that is grabbed can be thrown by pressing <kbd>A</kbd>(joystick button 0) on <kbd>RIGHT CONTROLLER</kbd>.
Throwing will be done only when a fruit is successfully grabbed.
When the fruit hits a scarecrow, a sound effect will be played on impact and the fruit will disappear.
Throwable objects include: The eggplants placed on the ground all over the world.

> ### Throwing Script
> GunController.cs
> </br>
> ProjectileController.cs

### 3. Teleportation
Teleportation is done by pushing the <kbd>JOYSTICK</kbd> forward + <kbd>11th AXIS BUTTON</kbd> on <kbd>LEFT CONTROLLER</kbd>. 
A green line will be displayed that goes into the distance. 
This line shows the destination that user will teleport to.
When the line is pointed to towards an area that you cannot teleport to, it will turn red.

> ### Teleportation Script
> 
> Teleportation.cs

### 4. Show scoreboard
Scoreboard is shown by pressing <kbd>2ND TRIGGER</kbd>(12th Axis) on <kbd>RIGHT CONTROLLER</kbd>.
A sound effect will be played a scoreboard appears on screen.
The scoreboard contains the following:
- Scarecrows Hit
- Fruits Thrown
- Progress (in terms of the numbe of scarecrows hit out of the total number)
![image](https://user-images.githubusercontent.com/7857839/110211976-1d9e1d00-7ed4-11eb-8876-32d0f424a150.png)


> ### Scoreboard Script
> </br>
> ScoreController.cs
> ScoreScript.cs

## Assets Used
- Oculus XR Plugin (Oculus Integration)
- XR Plugin Management
- OpenVR/XR Plugin
- Polygon Farm
<span style="color:gray">- SteamVR (Not Used)</span>
