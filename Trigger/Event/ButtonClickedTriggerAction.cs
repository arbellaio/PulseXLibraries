using Xamarin.Forms;

namespace PulseXLibraries.Trigger.Event
{
    public class ButtonClickedTriggerAction : TriggerAction<Button> { protected override void Invoke(Button sender) { sender.BackgroundColor = Color.Red; } }

}