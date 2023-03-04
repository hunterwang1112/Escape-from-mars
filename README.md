# EscapeFromMars
## Table of Contents
* [About the Project](#about-the-project)
* [Instructions to Open the Project](#instructions-to-open-the-project)
* [Instructions to Play the Game](#instructions-to-play-the-game)
* [Networking Document](#networking-document)
* [Sprint 1](#sprint-1)
* [Sprint 2](#sprint-2)
* [Sprint 3](#sprint-3)
* [Sprint 4](#sprint-4)


## About the Project
### Introduction
This is a multi-player escape room game developed through Unity. We aim to create an experience where players can immerse in the weightlessness experience in the space and can resolve puzzles through team works.

### Built With
- Unity
- Blender
- Procreate (Artwork)

## Instructions to Open the Project
1. Prerequisite: make sure you have Unity installed
2. Clone the project from Github to your local machine
3. Open the project in Unity
4. Scenes: Project -> Assets -> Scenes (Launcher/StartPage/Lobby/Mars/InsideSpaceship/Earth)
5. Build: Navigation Bar -> File -> Build Settings -> Select the 6 scenes in order -> Build And Run. 

## Instructions to Play the Game
- After a short video, click on "Start" button
- Log in with player name
- Create a new room/Join random room/Join existed room
- Click on "Ready" and then "Start" the game
- Inside the game scenes, use WASD to control the direction
- Click on "Hint" to see the task
- Click on "Quit Game" to quit
- In the Mars scene
  - The task is to find the spaceship. For the sake of easy testing, the spaceship is put close to the players. When you run into the spaceship, a notification shows up and it goes to the next scene.
  - For testing, right click on the screen to skip the task and go to the next scene.
- In the InsideSpaceship scene
  - The task is to find the password to boot the spaceship. There are 3 equations hidden in the scene. The players are supposed to find them and solve for the password.
  - After solving the equations, enter the password by clicking on the number buttons on the wall.
  - After entering password, there will be a notification telling the player if it's correct. If not, stays in the same scene. If correct, it goes to the next scene.
  - For testing, right click on the screen to skip the task and go to the next scene.
- In the Earth scene
  - End of the game 

## Networking Document
The default number of players in our game is 4. The game will have an entering lobby. When a total of 4 players enter the lobby, the game starts. In each scene, all the characters should be able to interact with each other. This can be created by assigning all the characters into the same shared scenes and a live voice chat/ simple messages that allow them to communicate. The characters will have names on them, so that everyone knows who the characters are. In each scene, characters have their physics bodies so that they cannot overlap. For transitions between scenes, characters should enter the next scene at the same time.
### Technical Description
1. Lobby (to be implemented) - The lobby serves as a waiting room for players. The players should stay in the lobby until all the 4 players are ready. It will be implemented with Photon Unity Networking.
2. Scenes - The networking for the game follows the instructions of PhotonDemoOverview on Brightspace. We have enabled networking for the Mars scene and are working to include the next 2 scenes into networking.
3. Voice Chat (to be implemented) - This function will be implemented with the Photon Voice service. It enables players to communicate through the game. This will be similar to the PhotonVoiceOverview tutorial on Brightspace.


## Sprint 1

### Overview
For the first sprint, we designed the storyline for our game and implemented the starting animation, the front page of the game, as well as the relevant scenes and game objects for the game.

### Game related Artwork 
#### - Starting animation @maggieqin0506
I used Procreate to draw each frame of the animation.
The starting animation is about the main character who is a astronomy-lover dreaming about going to Mars, but then his spaceship unfortunately get crashed when landing in Mars.
#### - Game front page @maggieqin0506
I used Procreate to design and draw the front page.

### List of Scenes 
#### - Mars surface @hunterwang1112
The Mars surface scene is created entirely on Unity. The gravity has been changed to the Mars gravity: -3.711 m/s^2. Broken spaceship pieces and astronauts controllers are in this scene. For now, user has to controll the 4 astronauts at the same time.
#### - Inside the spaceship @GuanlanXia
A sci-fi themed spaceship interior with 2 levels. Currently there is no interactions for this scene. But it will be developed into a major area for the players to walk around and solve puzzles.
#### - Earth surface @GuanlanXia
The landing spot for our spaceship. The current setting for this is an abandoned airport in the midst of a forest. Players need to land the spaceship correctly so that it does not crash into the mountains at the end of the runway.
### List of Game Objects
#### - Astronauts @yuki-yi-ji
source: CGTrader.
#### - Broken spaceship with pieces @carterbeardmore
source: TurboSquid.  
also imported texture jpg of rusted metal, this will be turned into a material and used on the barrels and plates. 
#### - Non-broken spaceship 
source: Standard Assets


## Sprint 2

### Overview
For the second sprint, we created the networking for our game, updated the launcher page, redesigned the mars environment, and created the networking version of characters. We also focused on defining roles within our team. 

### Roles
#### Networking - Hunter, Guanlan, Yi
#### Environments - Carter, Maggie
#### Documentation - Carter
#### Testing - Yi
#### User Interface - Maggie, Guanlan
#### GitHub Guru - Hunter

### Networking  
#### - Networking Architecture @hunterwang1112
Followed the PhotonDemoOverview tutorial online and created the basic networking architecture for the game.
#### - Adding networking to scenes @hunterwang1112
Brought Mars scene into the networking version.
#### - Characters @hunterwang1112
Created networking version of characters.

### Game UI
#### - Launcher page @hunterwang1112
Updated launcher page to show the first drawing we had originally created.
#### - Game Interface @hunterwang1112
Improved the in-game experience.
#### - Scene transitions @GuanlanXia
Updated transitions within our scenes in order to have a playable game. 
#### - Start button @maggieqin0506
Created the start button on the launcher page. 
#### - Hint button @maggieqin0506
Created the hint button which will show hints during the game. 
#### - Controller issue @maggieqin0506
Attempted to resolve controller issue, where keys were not corresponding to player movements how we had expected. This issue remains unresolved and will be worked on in Sprint 3. 

### Environments 
#### - Updating mars environment @carterbeardmore
Updated the mars ground using a red rock texture. Increased the metallic levels to give off a more extra-terrestial vibe. Increased opacity and changed lighting.  
#### - Texture on objects @carterbeardmore
Added material textures to the rocks, the barrels, and the metal plates to create a realistic look of debris. 

#### Documentation
#### - Sprint 2 Video @carterbeardmore
Created burndown chart, google slides presentation, and created video documentation of Sprint 2. 


## Sprint 3

### Overview
For the third sprint, we came up with puzzles for the game, created the lobby page, created scene transitions, fixed the hint button, and created a trigger for picking up broken spaceship pieces. 

### Puzzles Brainstorming
Each team member came up with an idea for a puzzle. We put all these ideas into a shared good doc and made a list of the models we needed for each one.  

### Networking 
#### - Created loby/waiting room - @hunterwang1112
Created a lobby page for the start of our game. 
#### - Fixed hint button - @magieqin0506
Fixed hint button so that it is synched to all rooms. 

### Game UI
#### - Added front page and beginning animation to game - @maggieqin0506
Now the animation will play before the game begins. 
#### - Scene transitions - @GuanlanXia
When user right clicks they will transition to next scene. 
#### - Created pieces trigger - @yuki-yi-ji
Created a trigger so that when astronauts collect borken spaceship pieces, the pieces disappear. 

#### Documentation
#### - Sprint 2 Video @carterbeardmore
Created burndown chart, google slides presentation, video. Updated ReadMe. 
#### - File clean up @hunterwang1112
Cleaned up and managed the project files. 

## Sprint 4

### Overview
For the fourth sprint, we implemented puzzles, fixed bugs and issues, and added some final aesthetic touches to the scenes. 

### Puzzles - @hunterwang1112, @maggieqin0506, @yuki-yi-ji
#### - Mars puzzle 
Goal is to find the hidden spaceship. Once found and the player touches it, the player is transported to spaceship scene. 
#### - Inside Spaceship puzzle 
Players must find 3 hidden equations to obtain a secret password. Once this password is entered they will be transported to earth scene. 

### Bugs/ issues fixed
#### - Fixed player control. 
#### - Fixed exit button.  
#### - Fixed transitions. 
#### - Fixed networking issues. 
#### - Fixed player speed on mars.

### Aesthetics
#### - Mars scene 
added materials to 3D objects that did not have any. 
added boundaries to the scene.
#### - Earth scene
added terrain, mountains, trees. 
