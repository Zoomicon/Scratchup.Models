namespace Scratchup.Models.Actors
{
    interface IScriptLooks
    {
        void Say(string text, float duration);
        void Say(string text);

        void Think(string text, float duration);
        void Think(string text);

        void Show();
        void Hide();

        void SwitchCostume(ICostume costume);
        void NextCostume();

        void SwitchBackdrop(IBackdrop backdrop); //TODO: should also have way to select next backdrop and previous backdrop options

        void Change(IEffect effect, int delta);
        void SetEffect(IEffect effect, int value);
        void ClearGraphicsEffects();

        void ChangeSize(int delta);
        void SetSizePercent(int percentage);

        void GoToFront();
        void GoBack(int layers);

        int CostumeIndex { get; }
        string BackdropName { get; }
        int Size { get; }
    }
}
