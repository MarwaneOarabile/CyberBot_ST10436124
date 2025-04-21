namespace CyberBot_ST10436124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // plays the audio file when the application starts
            Chatbackend myObjChat = new Chatbackend();
            //myObjChat.PlayGreeting();

            // displaying an ASCII representation of a logo
            myObjChat.imageDisplay();

            // displays the welcome message with name 
            myObjChat.WelcomeMessage();


        }
    }
}
