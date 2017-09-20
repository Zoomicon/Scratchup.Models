namespace Scratchup.Models.Actors
{
    interface IScriptSound
    {
        void PlaySound(ISound sound);
        void PlaySoundUntilDone(ISound sound);

        void StopAllSounds();

        void PlayDrum(Drum drum, float beats);
        void RestFor(float beats);

        void PlayNote(int note, float beats);

        void SetInstrument(Instrument instrument);

        void ChangeVolume(int delta);
        void SetVolumePercent(int percentage);
        int Volume { get; }

        void ChangeTempo(int delta);
        void SetTempo(int bpm);
        int Tempo { get; }
    }
}
