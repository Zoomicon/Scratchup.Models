using System;

namespace Scratchup.Models.Actors
{
    interface IScriptControl
    {
        void Wait(float sec);

        void Repeat(int count, Action action);
        void Forever(Action action);

        void IfThen(bool condition, Action action);
        void IfThenElse(bool condition, Action thenAction, Action elseAction);
        void WaitUntil(bool condition);
        void RepeatUntil(bool condition, Action action);

        void Stop(StopActions stop);

        void WhenIStartAsClone(Action action);
        void CreateCloneOf(ISprite sprite); //TODO: need to have a way to specify MySelf 
        void DeleteThisClone();
    }
}
