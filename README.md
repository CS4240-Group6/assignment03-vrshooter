# Assignment03
This is our CS4240 VR Scarecrow shooter and teleportation game! :D

### Environment Scene
![image](https://user-images.githubusercontent.com/7495242/110196271-662aeb80-7e7e-11eb-8bbe-8b8706a3f852.png)

## Features
### 1. Grabbing object
A fruit is grabbed by pressing <kbd>A</kbd>(joystick button 0) on <kbd>RIGHT CONTROLLER</kbd>.
A fruit can be grabbed if it is one meter distance away from the controller.

### Grabbing Script
GunController.cs

### 2. Throwing object
The fruit that is grabbed can be throw by pressing <kbd>A</kbd>(joystick button 0) on <kbd>RIGHT CONTROLLER</kbd>.
Throwing will be done only when a fruit is successfully grabbed.
When the fruit hits a scarecrow, a sound effect will be played on impact and the scarecrow will disappear.

### Throwing Script
GunController.cs
ProjectileController.cs

### 3. Teleportation
Teleportation is done by moving <kbd>JOYSTICK</kbd> + <kbd>11th AXIS BUTON</kbd> on <kbd>LEFT CONTROLLER</kbd>. 
A green line will be displayed that goes into the distance. 
This line shows the destination that user will teleport to.

### Teleportation Script
Teleportation.cs

### 4. Show scoreboard
Scoreboard is shown by pressing <kbd>A</kbd>(joystick button 0) on <kbd>LEFT CONTROLLER</kbd>.
A sound effect will be played a scoreboard appears on screen.
The scoreboard contains the following:
- Scarecrows hit
- Fruits Thrown
- Progress (in terms of the numbe of scarecrows hit out of the total number)

### Scoreboard Script
ScoreController.cs
</br>
ScoreScript.cs
