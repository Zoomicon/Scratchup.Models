using System;

namespace Scratchup.Models.Actors
{
    interface IScriptEvents
    {

        void WhenClicked(Action action);
        void WhenPressed(IKey key, Action action);
        void WhenThisSpriteClicked(Action action);
        void WhenBackdropSwitchesTo(IBackdrop backdrop, Action action);

        void WhenAttributeGreater(Attribute attribute, int value, Action action);

        void WhenIReceive(IMessage message, Action action);
        void Broadcast(IMessage message);
        void BroadcastAndWait(IMessage message);
    }
}
