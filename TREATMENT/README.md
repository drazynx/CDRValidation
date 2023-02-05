# Treatment process for the Microsoft Hololens 2 based on CDR MVP 2. 

First rough layout listed below.

![20230124_181658](https://user-images.githubusercontent.com/93949561/216845556-70024801-d724-4be6-b4a1-9c18baac5460.jpg)

Program reflects the Epley Maneuver which is segmented into multiple scenes which move the patient through the treatment process.

There is an audio confirmation and instruction component for each scene as well as a "perfect" confirmation when the desired angle is achieved.

There is a color confirmation of an asset turning green upon achievement of correct angle.

There is a 4 second countdown one the angle is achieved to automatically advance to the next scene.

If for some reason the angle can not be achieved within the given time (15-25 seconds for most scenes) the user will be kicked out of the treatment cycle and a error/help screen will appear.

![Screenshot 2023-02-05 142510](https://user-images.githubusercontent.com/93949561/216846910-f69e7757-febf-4cc9-b25f-92295d4fb8a0.jpg)


The error message appears so that anyone who does not have enough body control to match the angle is suggested to see a medical professional immediately.

----------
## Switching Scenes

To switch scenes, all scenes first need to be added into the build.

![Screenshot 2023-02-05 134529](https://user-images.githubusercontent.com/93949561/216845952-7f273f28-d0ec-45fa-99ae-13f0d4f28c0e.jpg)

The trigger made to switch scenes is a text countdown timer called 'CDToSceneSwitch'.

![Screenshot 2023-02-05 134520](https://user-images.githubusercontent.com/93949561/216846236-b1f8410a-ee6c-4a69-9280-bbbb88738f82.jpg)

This text will be attached to HeadReference -> Object.

![Screenshot 2023-02-05 134816](https://user-images.githubusercontent.com/93949561/216846023-41f53be9-e493-452b-915c-34cb719acd43.jpg)

A script is then made so that when currentTime is <= to 0, it will trigger 'SceneManager.LoadScene("NAME_OF_SCENE");

![Screenshot 2023-02-05 134447](https://user-images.githubusercontent.com/93949561/216846068-25a624c3-5465-4a39-b343-3d7fd5bd8242.jpg)

All together this is meant for when the headreference (hololens 2) is in the corect orientation or angle, a countdown starts (e.g. startTime).

Once startTime reduces to currentTime, shown to the patient through the text 'CDToSceneSwitch' counting down, the 'SceneManager.LoadScene("NAME_OF_SCENE"); is triggered.

For more on scene switching see attached resource below.

----------

## Change Log : 

### TODO:

REMEMBER TO COMMENT EVERYTHING

Mirror Scene 1, 2, 3 and 4 to have a complete treatment process

Make a fade between scenes

### Research:

Implement Speech Recognition to choose language?

Phrases in Spanish and Navajo (2nd and 3rd most spoken languages in Arizona)

https://support.microsoft.com/en-us/windows/use-voice-recognition-in-windows-83ff75bd-63eb-0b6c-18d4-6fae94050571

https://www.youtube.com/watch?v=o4GV-EbnMfI&ab_channel=FauquierENT

### DONE:

#### Audio Recordings

Record Audio : Scene 0 : “You are having trouble completing this treatment process, we recommend you contact a medical professional”

Record Audio : Scene 1L : Angle not matched : “Tilt your head left to match the image“

Record Audio : Scene 1LR : Angle not matched : “Tilt your head to match the image”

Record Audio : Scene 1LR : Angle matched : “Perfect”

Record Audio : Scene 2 LR : Angle not matched : “Keep your head tilted and carefully lay backwards”

Record Audio : Scene 3 LR : “Perfect, we will wait in this position for 45 seconds”

Record Audio : Scene 3 LR “Breathe”

Record Audio : Scene 4 LR : “Turn on your side, but keep your head still”

Record Audio : Scene 5 LR : “Sit in an upright position”

Record Audio : Scene 5 LR : “Sit Up”

FIX NEGATIVE EDGE ON Record Audio : Scene 1 : Angle matched : “Perfect”

Implement 30 second timer that defaults to “Call the hospital” if patient does not align within the time

#### Finish Scene 1R

Input countdown timer when correct angle is achieved

Countdown timer resets if the position becomes misaligned

Added visual component that changes color of reference when angle is correct

Added visual component that shows the reference angle to be achieved by patient

After countdown of correct angle, automatic transition to the next scene	

Implement the arrows for direction

Animate the arrows

Implement audio inside scene

Implement audio to confirm angle

#### Finish Scene 2R
	
Input countdown timer when correct angle is achieved

Countdown timer resets if the position becomes misaligned

Record Audio : Scene 1R : Angle non matched : “Tilt your head right to match the image“

Scene 2 : Correct angle is more than 75 degrees on the x axis and less than 100.

Finish color changing confirmation

Finish countdown to next scene on confirmation of correct angle

Implement audio inside scene

Implement “perfect” confirmation when the angle is correct in case patient cannot see

Implement the arrows for direction

Animate the arrows

#### Finish Scene 3R
	
Input countdown timer when correct angle is achieved

Countdown timer resets if the position becomes misaligned

Added visual component that changes color of reference when angle is correct

Added visual component that shows the reference angle to be achieved by patient

After countdown of correct angle, automatic transition to the next scene	

Implement the arrows for direction

Animate the arrows

Implement audio inside scene

Implement audio to confirm angle

#### Finish Scene 4R

Input countdown timer when correct angle is achieved
	
Countdown timer resets if the position becomes misaligned

Added visual component that changes color of reference when angle is correct

Added visual component that shows the reference angle to be achieved by patient

After countdown of correct angle, automatic transition to the next scene	

Implement the arrows for direction

Animate the arrows

Implement audio inside scene

Implement audio to confirm angle

### WILL NOT DO:

Foster Maneuver : Too complex without outside assistance

----------

## Resources

https://docs.unity3d.com/ScriptReference/SceneManagement.SceneManager.LoadScene.html

## Scene Change Reference 

https://www.youtube.com/watch?v=OmobsXZSRKo&ab_channel=Tarodev

https://www.youtube.com/watch?v=RPvlK4sFVCM&t=223s&ab_channel=iC7Zi
