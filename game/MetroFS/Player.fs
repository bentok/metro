namespace FSPlayer

open Godot
open Movement
 
type PlayerFs() =
    inherit KinematicBody2D()
 
    override this._Ready() = 
        GD.Print("F# is ready")
        
    override this._PhysicsProcess (delta) =
        velocity.y <- velocityYFunc(velocity.y, delta)
        this.MoveAndSlide(velocity) |> ignore
