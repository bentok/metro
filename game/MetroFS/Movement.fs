module Movement

open Godot

let speed = Vector2(300.00f, 1000.00f)
let gravity = 3000.00f
let mutable velocity = Vector2.Zero
let direction = Vector2(Input.GetActionStrength("move_right") - Input.GetActionStrength("move_left"), 0.00f)

let velocityYFunc (velo, delta) =
    [velo + gravity * delta; speed.y]
    |> List.min
