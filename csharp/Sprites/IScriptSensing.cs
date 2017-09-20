namespace Scratchup.Models.Actors
{
    interface IScriptSensing
    {
        bool Touching(TouchKind kind);
        bool Touching(IColor color);
        bool ColorIsTouching(IColor color1, IColor color2);
        float DistanceTo(KnownPosition position);
        float DistanceTo(ISprite sprite);

        void AskAndWait(string question);
        string Answer { get; }

        bool KeyPressed(IKey key);
        bool MouseDown();
        int MouseX { get; }
        int MouseY { get; }

        int Loudness { get; }
        
        //TODO: more...

    }
}
