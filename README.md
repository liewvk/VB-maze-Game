# VB Maze Game

This repository contains a Windows Forms maze game built with Visual Basic .NET. The player navigates a character through a maze, avoids walls, collects points, and reaches the green goal before time runs out.

## Features

- Maze-based movement using arrow keys
- Start and restart controls
- Collision detection with wall objects
- Lives system with reset after wall hits
- Countdown timer and scoring
- Win/lose game flow with message dialogs

## Project Type

- Language: Visual Basic .NET
- UI Framework: Windows Forms
- Target: .NET 10 Windows desktop application

## Requirements

- Windows 10 or later
- Visual Studio 2022 or newer with .NET desktop development workload
- .NET SDK compatible with the project target framework

## How to Run

1. Open `maze.slnx` in Visual Studio.
2. Restore NuGet packages if prompted.
3. Set the solution to build in Debug or Release mode.
4. Run the app with F5 or via the Visual Studio Start button.

## Main Files

- `Form1.vb` - Core game logic and UI event handlers
- `Form1.Designer.vb` - Windows Form designer-generated code
- `maze.vbproj` - Project configuration and build settings
- `ApplicationEvents.vb` - Application-level event handling

## Gameplay

- Press Start to begin a round.
- Use the arrow keys to move the player.
- Avoid collisions with walls.
- Reach the green goal tile to finish the level.
- Survive the timer and remaining lives to maximize your score.

## License

This project does not currently include a license file. If you intend to distribute or reuse this code, add an appropriate open-source license before publishing.
