Feature: CreateCharacter
![Gamer](./gamerErin.png)
    I want to create a new custom character, setting their name

@acceptance 
Scenario Outline: Set character name
    Character creation is currently split to be very simple: the only customization is setting the name.

    Given the player supplies the name <characterNameInput> and character type as <characterType>
    When the character is created
    Then the Game sets the character name to <characterNameOutput>
    Examples:

        | characterNameInput | characterType | characterNameOutput |
        | Erin               | Monk          | Erin             |
        | | | Character |
