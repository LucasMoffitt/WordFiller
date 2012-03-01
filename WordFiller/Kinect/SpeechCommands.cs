using Microsoft.Speech.Recognition;

namespace WordFiller.Kinect
{
    class SpeechCommands
    {
        public static Choices Commands()
        {
            var commands = new Choices();
            commands.Add("wordfiller move");
            commands.Add("wordfiller drop");
            commands.Add("wordfiller mark");
            commands.Add("wordfiller click");
            commands.Add("wordfiller open menu");
            commands.Add("wordfiller close menu");
            return commands;
        }
    }
}
