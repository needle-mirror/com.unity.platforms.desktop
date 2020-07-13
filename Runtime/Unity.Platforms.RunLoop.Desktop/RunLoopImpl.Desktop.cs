#if ((UNITY_WINDOWS || UNITY_MACOSX || UNITY_LINUX || UNITY_EDITOR))
using System.Runtime.InteropServices;

namespace Unity.Platforms
{
    public class RunLoopImpl
    {
        [DllImport("lib_unity_platforms_runloop")]
        private static extern double GetSecondsMonotonic();

        public static void EnterMainLoop(RunLoop.RunLoopDelegate runLoopDelegate)
        {
            while (true)
            {
                double timestampInSeconds = GetSecondsMonotonic();

                if (runLoopDelegate(timestampInSeconds) == false)
                    break;
            }
        }
    }
}
#endif