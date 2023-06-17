# Battleship - Console version



---

## UML Mockup

``` C#
                                            +--------------------------------+
                                            |         BattleshipGame         |
                                            +--------------------------------+
                                            | - player1: Player              |
                                            | - player2: Player              |
                                            | - currentPlayer: Player        |
                                            | - gameBoard: GameBoard         |
                                            +--------------------------------+
                                            | + StartGame(): void            |
                                            | + PlayTurn(): void             |
                                            +--------------------------------+

                                                    /                      \
                                                   /                        \
                                        +---------------------+       +------------------+
                                        |      Player         |       |    GameBoard     |
                                        +---------------------+       +------------------+
                                        | - name: string      |       | - board: Cell[,] |
                                        | - ships: Ship[]     |       +------------------+
                                        | - score: int        |
                                        +---------------------+
                                        | + PlaceShips(): void|
                                        | + FireShot(): void  |
                                        +---------------------+

                                                  ^
                                                  |
                                                  |
                                        +-------------------+
                                        |       Ship        |
                                        +-------------------+
                                        | - name: string    |
                                        | - size: int       |
                                        | - position: Cell[]|
                                        +-------------------+
                                        | + IsSunk(): bool  |
                                        +-------------------+

                                                  ^
                                                  |
                                                  |
                                        +-------------------+
                                        |       Cell        |
                                        +-------------------+
                                        | - x: int          |
                                        | - y: int          |
                                        | - state: State    |
                                        | - ship: Ship      |
                                        +-------------------+
                                        | + SetState(): void|
                                        +-------------------+

                                                  ^
                                                  |
                                                  |
                                        +---------------------+
                                        |      State          |
                                        +---------------------+
                                        | - name: string      |
                                        +---------------------+
                                        | + Empty(): State    |
                                        | + Occupied(): State |
                                        | + Hit(): State      |
                                        | + Missed(): State   |
                                        +---------------------+
```

---

## Folder Structure

This structure follows the best practice of separation of concerns and helps improve code readability and maintainability.


```
BattleshipGameUI
└── Program.cs

BattleshipGameLibrary
├── Models
│   ├── GameBoard.cs
│   ├── Cell.cs
│   ├── Ship.cs
│   └── State.cs
├── Helpers
│   ├── InputHelper.cs
│   └── DisplayHelper.cs
└── Players
    ├── Player.cs
    └── ComputerPlayer.cs
```

- **BattleshipGameUI** : This folder (project) is the folder for the console application

  - `Program.cs` : The entry point of the application. It contains the Main method to start the game.

- **BattleshipGameLibrary** : This folder (project) is the folder for the library that contains most of the logic in our application.

  - ***Models*** : This folder contains the classes that represent the core entities of the game.

    - `GameBoard.cs` : Represents the game board and its functionality.

    - `Cell.cs` : Represents a cell on the game board.

    - `Ship.cs` : Represents a ship in the game.

    - `State.cs` : Represents the states a cell can have.

  - ***Helpers*** : This folder contains helper classes that provide utility functions.

    - `InputHelper.cs` : Helps with reading and validating user input.

    - `DisplayHelper.cs` : Provides helper methods for displaying information on the console.

  - ***Players*** : This folder contains classes related to the players in the game.

    - `Player.cs` : Represents a human player in the game.

    - `ComputerPlayer.cs` : Represents an AI player in the game.

---