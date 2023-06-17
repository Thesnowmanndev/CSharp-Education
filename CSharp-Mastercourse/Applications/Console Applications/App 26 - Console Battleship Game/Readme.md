# Battleship - Console version

---

## Folder Structure

This structure follows the best practice of separation of concerns and helps improve code readability and maintainability.


```
BattleshipConsole
└── Program.cs
└── ConsoleUI.cs
└── ConsoleMessages.cs

BattleshipGameLibrary
├── Helpers
│   ├── GridHandler.cs
│   └── Validators.cs 
├── Models
│   ├── Enums.cs
│   ├── GridLocationModel.cs
│   └── PlayerInfoModel.cs
│  
└── GameLogic.cs
```

- **BattleshipConsole** : This folder (project) is the folder for the console application

  - `Program.cs` : The entry point of the application. It contains the Main method to start the game.
  - `ConsoleUI.cs` : Contains console specific functions for the game (ones that would not be transferable to a GUI product).
  - `ConsoleMessages.cs` : Holds functions that print messages to the console.

- **BattleshipGameLibrary** : This folder (project) is the folder for the library that contains most of the logic in our application.

  - ***Models*** : This folder contains the classes that represent the core entities of the game.

    - `Enums.cs` : Defines the states for a ship.

    - `GridLocationModel.cs` : Establishes a model for defining a grid location.

    - `PlayerInfoModel.cs` : Establishes a model for defining a player.

  - ***Helpers*** : This folder contains helper classes that provide utility functions.

    - `GridHandler.cs` : Responsible for initializing the game board (A1 - E5) and adding it to the player.

    - `Validators.cs ` : Contains method to validate user input.

---

## Game in Action:

introduction

ShipPlacementPlayerOne

ShipPlacementPlayerTwo

InvalidPlacement

Hit

Miss

InvalidShot

WinScreen