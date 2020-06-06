namespace FSPlayer
open Godot
open MovementFs
open PhysicsFs

type PlayerFs() =
    inherit KinematicBody2D()

    override this._Ready() =
        GD.Print("F# is ready")

    override this._PhysicsProcess delta =
        // Update Y velocity in game loop
        velocity.y <- velocity.y
            |> velocityYFunc
            |> fun applyDelta -> applyDelta delta

        // Apply horizontal directional input
        (Input.GetActionStrength("move_right"), Input.GetActionStrength("move_left"))
            |> directionalVelocity
            |> this.MoveAndSlide
            |> ignore
