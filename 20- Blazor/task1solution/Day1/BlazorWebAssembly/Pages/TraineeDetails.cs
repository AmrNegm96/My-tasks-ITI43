using Microsoft.AspNetCore.Components;
using sharedLib;

namespace BlazorWebAssembly.Pages
{
    public partial class TraineeDetails
    {
        [Parameter]
        public int empId { get; set; }

        public Trainee? currentTrainee { get; set; }

        protected override Task OnInitializedAsync()
        {
            currentTrainee = MockList.trainees.FirstOrDefault(t => t.Id == empId);
            return base.OnInitializedAsync();
        }

    }
}
