module Movement

open Godot

let speed = Vector2(300.00f, 1000.00f)
let gravity = 3000.00f
let mutable velocity = Vector2.Zero

let directionalVelocity (right, left) =
    // TODO: the second argument should be velocity.y when I fix the tileset collisions
    (right - left, 0.00f)
    |> Vector2
    |> fun v2 -> v2 * speed

let velocityYFunc veloY delta =
    [veloY + gravity * delta; speed.y]
    |> List.min
