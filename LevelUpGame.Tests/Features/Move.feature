Feature: Move
![Move](./movespec.jpeg)
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | 0                 | 0                 | NORTH     | 10                | 0               | 1               | 11              |
        | 0 | 0 | SOUTH | 32 | 0 | 0 | 33 |
        | 0 | 0 | EAST | 1 | 1 | 0 | 2 |
        | 0 | 0 | WEST | 4 | 0 | 0 | 5 |
        | 9 | 0 | NORTH | 78 | 9 | 1 | 79 |
        | 9 | 0 | SOUTH | 45 | 9 | 0 | 46 |
        | 9 | 0 | EAST | 12 | 9 | 0 | 13 |
        | 9 | 0 | WEST | 98 | 8 | 0 | 99 |
        | 0 | 9 | NORTH | 44 | 0 | 9 | 45 |
        | 0 | 9 | SOUTH | 64 | 0 | 8 | 65 |
        | 0 | 9 | EAST | 11 | 1 | 9 | 12 |
        | 0 | 9 | WEST | 93 | 0 | 9 | 93 |
        | 9 | 9 | NORTH | 67 | 9 | 9 | 68 |
        | 9 | 9 | SOUTH | 54 | 9 | 8 | 55 |
        | 9 | 9 | EAST | 32 | 9 | 9 | 33 |
        | 9 | 9 | WEST | 41 | 8 | 9 | 42 |
        | 5 | 5 | NORTH | 71 | 5 | 6 | 72 |
        | 5 | 5 | SOUTH | 18 | 5 | 4 | 19 |
        | 5 | 5 | EAST | 9 | 6 | 5 | 10 |
        | 5 | 5 | WEST | 88 | 4 | 5 | 89 |
