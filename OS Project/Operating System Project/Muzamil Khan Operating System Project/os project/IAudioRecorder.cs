using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using NAudio.Mixer;

namespace Muzamil_Khan_Operating_System_Project
{
    public interface IAudioRecorder
    {
        void BeginMonitoring(int recordingDevice);
        void BeginRecording(string path);
        void Stop();
        double MicrophoneLevel { get; set; }
        RecordingState RecordingState { get; }
        SampleAggregator SampleAggregator { get; }
        event EventHandler Stopped;
        WaveFormat RecordingFormat { get; set; }
        TimeSpan RecordedTime { get; }
    }
}
