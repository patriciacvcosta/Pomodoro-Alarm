using PomodoroAlarm;

namespace System.ComponentModel
{
    internal class AbortableBackgroundWorker
    {
        public static implicit operator AbortableBackgroundWorker(PomodoroAlarm.AbortableBackgroundWorker v)
        {
            throw new NotImplementedException();
        }
    }
}