module PhysicsFs
open Godot

let FLOOR_NORMAL = Vector2.Up
let speed = Vector2(400.00f, 500.00f)
let gravity = 3500.00f
let mutable velocity = Vector2.Zero

let velocityYFunc veloY delta =
    [veloY + gravity * delta; speed.y]
    |> List.min
