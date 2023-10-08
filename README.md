# Angel_Simulation
Project #1 - A Sky Full of Rotating Stars

https://hun-bxsci.itch.io/angel

# Script discriptions 
centerMotion
-
controls the center eye thing
- Uses slerp to rotate
- Axis of rotation and degree of rotation can be configured from unity editor
- Is used to give repeating rotation that has a set degree of change

hovering
-
super simple script giving the main body of the angel a bobbing movement
- a sine wave is used to give that number, hard coded because the random number I thought of was good enough :)

RingRotation
-
rotates ring
- is different from centerMotion because this one does not have a specified degree of rotation, the onnly thing that can be changed is the speed of the rings via the slide-y thing in unity editor

RingRotationAlt
-
this is never used and is a failed attempt at making the rings follw the movement of the center

WingMovemen
-
controls all movement in wings
- does the same thing as RingRotation except in a different axis
- Variable Center does absolutly nothing and is also a failed attempt at making the wings follow the center, its ok tho cuz I like it more with out following the center


