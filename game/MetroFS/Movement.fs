module MovementFs
open Godot
open PhysicsFs

let directionalVelocity (right, left) =
    (right - left, 0.00f)
    |> Vector2
    |> fun v2 -> v2 * speed


