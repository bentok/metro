namespace FSPlayer
open Godot
open MovementFs
open PhysicsFs

type PlayerFs() =
    inherit KinematicBody2D()

    override this._Ready() =
        GD.Print("F# is ready")

    override this._PhysicsProcess delta =
        // Apply horizontal directional input
        let direction = getDirection(Input.GetActionStrength("move_right"),
                                     Input.GetActionStrength("move_left"),
                                     Input.GetActionStrength("jump"),
                                     Input.IsActionJustPressed("jump"),
                                     this.IsOnFloor())
        let isJumpInterrupted = getIsJumpInterrupted(Input.IsActionJustReleased("jump"), velocity)
        let snap = if direction.y = 0.00f then Vector2.Down * 60.00f else Vector2.Down

        velocity <- (velocity, direction, speed, isJumpInterrupted)
            |> calculateMoveVelocity

        this.MoveAndSlideWithSnap(velocity, snap, System.Nullable(Vector2.Up), true) |> ignore

