using Microsoft.AspNetCore.Components.Web;
using System.Threading.Tasks;

namespace BlazorAddressify
{
    public partial class Address
    {
        public bool IsShowCandidates { get; set; }
        public string Predicate { get; set; }
        public double Top { get; set; } 
        public double Left {  get; set; }
        public double Width { get; set; }

        private ExampleJsInterop ExampleJsInterop;

        protected override void OnInitialized()
        {
            ExampleJsInterop = new(JS);
        }

        public async Task OnKeyup(KeyboardEventArgs args)
        {
            IsShowCandidates = Predicate?.Length >= 3;

            var addressPosition = await ExampleJsInterop.GetAddressPosition();

            Top = addressPosition.top + addressPosition.height;
            Left = addressPosition.left;
            Width = addressPosition.width;
        }
    }
}
