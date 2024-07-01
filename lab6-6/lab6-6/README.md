# Concentration Game

This C# console application implements a memory matching game, also known as Concentration. Players must find matching pairs of cards on a 4x5 grid.

## Description

The Concentration Game challenges players to match pairs of cards by remembering their positions on the board. The game features:

- A 4x5 grid of cards (20 cards total)
- 10 pairs of matching cards (words and their corresponding numbers)
- Randomized card positions for each new game
- Turn-based gameplay where players reveal two cards at a time

## How to Play

1. Run the program.
2. The game board will be displayed with all cards face down, represented by "?n?" where n is the card number.
3. Enter the number of the first card you want to reveal.
4. Enter the number of the second card you want to reveal.
5. If the cards match, they will be removed from the board.
6. If the cards don't match, they will be turned face down again.
7. Repeat steps 3-6 until all pairs are matched.
8. The game ends when all pairs have been found.

## Features

- Dynamic board creation and shuffling
- Input validation to ensure valid card selections
- Visual representation of the game board in the console
- Pause between turns for better gameplay experience
- Match checking logic for word-number pairs

## Implementation Details

- Uses string arrays to represent the game board and card values
- Implements Fisher-Yates shuffle algorithm for randomizing card positions
- Utilizes console clearing and redrawing for a smooth visual experience
- Implements a pause feature using `Thread.Sleep()`

## Key Methods

- `CreateBoard`: Initializes the game board with words and matching numbers
- `Shuffle`: Randomizes the positions of cards on the board
- `GetIndex`: Handles player input for card selection
- `IsMatch`: Checks if two selected cards form a matching pair
- `DrawBoard`: Renders the current state of the game board in the console

