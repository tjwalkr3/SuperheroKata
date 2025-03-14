@tag1
Feature: RPG Battle System
  As a "hero"
  I want to battle a monster
  So that I can test my strength

  Scenario: Hero attacks "monster"
    Given a "hero" with 100 health and 20 attack power
    And a "monster" with 50 health and 10 attack power
    When the "hero" attacks the "monster"
    Then the "monster" should have 30 health remaining

  Scenario: Monster attacks "hero"
    Given a "hero" with 100 health and 20 attack power
    And a "monster" with 50 health and 10 attack power
    When the "monster" attacks the "hero"
    Then the "hero" should have 90 health remaining

  Scenario: Hero defeats "monster"
    Given a "hero" with 100 health and 50 attack power
    And a "monster" with 40 health and 10 attack power
    When the "hero" attacks the "monster"
    Then the "monster" should be defeated

  Scenario: Hero lands a critical hit
    Given a "hero" with 100 health and 20 attack power
    And a "monster" with 50 health and 10 attack power
    When the "hero" lands a critical hit on "monster"
    Then the "monster" should have 10 health remaining

  Scenario: multiplayer battles
    Given a "hero" with 50 health and 20 attack power
    And a "heroe" with 50 health and 20 attack power
    And a "monster" with 60 health and 10 attack power
    When the "hero" attacks the "monster"
    And the "heroe" lands a critical hit on "monster"
    Then the "monster" should be defeated

  Scenario: special abilities
    Given a "hero" with 50 health and 10 attack power 
    And the "hero" has the special ability "power word kill" 
    And a "monster" with 50 health and 10 attack power
    When the "hero" uses their ability on the "monster"
    Then the "monster" should be defeated

  Scenario: random attack
    Given a "hero" with 50 health and 10 attack power 
    And a "monster" with 50 health and 10 attack power
    When the "hero" attacks the "monster" seed 10
    Then the "monster" should have 31 health remaining