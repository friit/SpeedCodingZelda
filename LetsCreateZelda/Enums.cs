﻿public enum ComponentType
{
   Sprite,
    PlayerInput,
    Animation,
    Collision,
    AIMovement,
    EnemyOctorok,
    Camera,
    Items,
    GUI,
    Damage,
    Stats,
    DeathAnimation
}

public enum Input
{
    Left,
    Right,
    Up,
    Down,
    None,
    Enter,
    A,
    S
}

public enum Direction
{
    Left, 
    Right,
    Up,
    Down
}


public enum State
{
    Standing, 
    Walking,
    Special
}

public enum ItemSlot
{
    A,
    B
}

public enum WindowMessagePosition
{
    Up,
    Down
}

public enum GameEventType
{
    Message,
    EventSwitch
}

public enum DeathAnimation
{
    Link, 
    Explosion
}