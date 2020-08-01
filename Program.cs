using System;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using System.Threading.Tasks;

namespace diy_smart_home
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var keywordModel = KeywordRecognitionModel.FromFile("./Hey_Roku.table");
            var audioConfig = AudioConfig.FromDefaultMicrophoneInput();
            var keywordRecognizer = new KeywordRecognizer(audioConfig);

            Console.WriteLine("Say \"Hey Roku...\"");
            var result = await keywordRecognizer.RecognizeOnceAsync(keywordModel);
            Console.WriteLine(result.Text);
        }
    }
}
