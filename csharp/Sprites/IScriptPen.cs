namespace Scratchup.Models.Actors
{
    interface IScriptPen
    {
        void Clear();

        void Stamp();

        void PenDown();
        void PenUp();

        void SetPenColor(int color);
        void ChangePenColor(int delta);
        void SetPenColor(IColor color);

        void ChangePenShade(int delta);
        void SetPenShade(int value);

        void ChangePenSize(int delta);
        void SetPenSize(int value);
    }
}
