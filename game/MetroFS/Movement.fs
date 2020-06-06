module MovementFs
open Godot
open PhysicsFs

//let moveAndSlideWithGravity =
//    this.MoveAndSlideWithSnap(Vector2(1.00f, 1.00f) * speed, Vector2.Down * 60.00f, System.Nullable(Vector2.Up), true) |> ignore

let getDirection (right, left, jump, jumpJustPressed, isOnFloor) =
    let y = if isOnFloor && jumpJustPressed then -jump else 1.00f
    (right - left, y)
    |> Vector2

let getIsJumpInterrupted (isJumpReleased, velocity: Vector2) =
    isJumpReleased && velocity.y < 0.00f

let calculateMoveVelocity (linearVelocity: Vector2,
                           direction: Vector2,
                           speed: Vector2,
                           isJumpIntrpt: bool) =
    let y = if direction.y <> 0.00f then speed.y * direction.y
                                    else if isJumpIntrpt then linearVelocity.y
                                    else 0.00f

    Vector2(direction.x * speed.x, y)


