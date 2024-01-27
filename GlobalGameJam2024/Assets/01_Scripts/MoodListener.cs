using System;

namespace CeltaGames
{
    public class MoodListener
    {
        readonly Action<float> _onMoodChange;

        public MoodListener(Action<float> onMoodChange) => _onMoodChange = onMoodChange;
        public void UpdateMood(float currentMood) => _onMoodChange.Invoke(currentMood);
    }
}