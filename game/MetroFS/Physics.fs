module PhysicsFs
open Godot

let FLOOR_NORMAL = Vector2.Up
let speed = 1200.0f
let gravity = 4000.0f
let jumpSpeed = -1800.0f
let friction = 0.1f
let acceleration = 0.25f
let mutable velocity = Vector2.Zero
