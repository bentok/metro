namespace FSPlayer
 
open Godot
 
type PlayerFs() =
    inherit KinematicBody2D()
 
    override this._Ready() = 
        GD.Print("F# is ready")
        
    override this._PhysicsProcess (delta) =
        let velocity = Vector2(300.00f, 0.00f)
        this.MoveAndSlide(velocity) |> ignore
