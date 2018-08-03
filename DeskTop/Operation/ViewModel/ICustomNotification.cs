using Prism.Interactivity.InteractionRequest;

namespace Operation.ViewModel
{
    public interface ICustomNotification:IConfirmation
    {
        string SelectedItem { get; set; }
    }
}