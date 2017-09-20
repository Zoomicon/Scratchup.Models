namespace Scratchup.Models.Actors
{
    interface IScriptData
    {
        IVariable MakeVariable(string name, bool forAllSprites);

        void Set(IVariable variable, object value);
        void Change(IVariable variable, float delta);
        void ShowVariable(IVariable variable);
        void HideVariable(IVariable variable);

        //

        IList MakeList(string name, bool forAllSprites);

        void Add(object thing, IList list);

        void Delete(int index, IList list);
        void Insert(object thing, int index, IList list);
        void Replace(int index, IList list, object thing);

        object Item(int index, IList list);
        int Length(IList list);
        bool Contains(IList list, object thing);

        void ShowList(IList list);
        void HideList(IList list);
    }
}
