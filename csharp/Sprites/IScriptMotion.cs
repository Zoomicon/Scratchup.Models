namespace Scratchup.Models.Actors
{
    interface IScriptMotion
    {
        void Move(int steps);

        void TurnRight(int degrees);
        void TurnLeft(int degrees);

        void PointInDirection(int degrees);
        void PointTowards(KnownPosition position); //Scratch 2 v456.0.4 only has "mouse-pointer", not "random position" here as it has in "GoTo"
        void PointTowards(ISprite sprite);

        void GoTo(int x, int y);
        void GoTo(KnownPosition position);
        void GoTo(ISprite sprite);

        void GlideTo(double secs, int x, int y);

        void ChangeX(int delta);
        void SetX(int x);

        void ChangeY(int delta);
        void SetY(int y);

        void IfOnEdgeBounce();

        void SetRotationStyle(RotationStyle rotationStyle);

        int Xposition { get; }
        int Yposition { get; }

        int Direction { get; } //degrees
    }
}
