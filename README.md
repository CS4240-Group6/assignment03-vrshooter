# Shooting Mechanism
### BUGS

- Right now there is a problem with the shooting direction, I have not managed to debug yet. Basically, when the gun is facing straight, shooting is fine, however, when the gun is tiled or facing anywhere but straight, the projectile will shoot at an awkward angle. 

## Implementation

### Shooting

Shooting is done using the `A` button on the right controller. Please take not of the mapping in `Project Settings > Input`. 

The shooting mechanism consists of 2 main scripts

- `GunController.cs`
  - Handles grabbing and shooting of projectile
  - To be put on the right hand
- `ProjectileController.cs`
  - Handles Collision with objects in scene with Tag: `Target` 
  - Plays sound on collision, will play a "hay" sound when it encounters object with Tag: `Target`, will play a fruit splat sound when it encounters anything else. 
    **NOTE**: Hay sound is not in the original project audio provided by Joanna, it is a new sound I added

### Scoring

I have integrated scoring done by Joanna into this local project, and made some changes to `ScoreScript.cs` (Formally `DummyScoreScript.cs`) and `CircularProgressBar.cs`.

I created an additional script, called `ScoreController.cs`, to be put on the right hand. This script manages the toggling of the visibility of the scoreboard. The scoreboard toggling is mapped to the "Grab" button, I.e. the 12th Axis. 