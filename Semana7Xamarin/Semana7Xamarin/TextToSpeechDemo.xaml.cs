using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana7Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechDemo : ContentPage
    {
        public TextToSpeechDemo()
        {
            InitializeComponent();
            var stack = new StackLayout();
            // Text-to-Speech
            var speak = new Button
            {
                Text = "Hello, Forms !",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };
            speak.Clicked += (sender, e) =>
            {
                DependencyService.Get<ITextToSpeech>().Speak("Hello from Xamarin Forms");
            };
            stack.Children.Add(speak);

            Content = speak;

        }
    }
}