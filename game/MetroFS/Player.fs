namespace FSPlayer
open Godot
open PhysicsFs

type PlayerFs() =
    inherit KinematicBody2D()

    override this._PhysicsProcess delta =
        let mutable dir = 0.0f
        if Input.IsActionPressed("move_right")
            then dir <- dir + 1.0f
        if Input.IsActionPressed("move_left")
            then dir <- dir - 1.0f
        if dir <> 0.0f
            then velocity.x <- Mathf.Lerp(velocity.x, dir * speed, acceleration)
            else velocity.x <- Mathf.Lerp(velocity.x, 0.0f, friction)
        velocity.y <- gravity * delta
        if Input.IsActionJustPressed("jump") && this.IsOnFloor()
            then velocity.y <- jumpSpeed
        this.MoveAndSlide(velocity, System.Nullable(Vector2.Up)) |> ignore
