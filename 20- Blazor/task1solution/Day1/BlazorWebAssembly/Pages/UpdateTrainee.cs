using Microsoft.AspNetCore.Components;
using sharedLib;

namespace BlazorWebAssembly.Pages
{
    public partial class UpdateTrainee
    {
        [Parameter]
        public int empId { get; set; }

        public Trainee CurEmp { get; set; }

        public bool Saved;

        protected override Task OnInitializedAsync()
        {
            Saved = false;

            CurEmp = MockList.trainees.FirstOrDefault(em => em.Id == empId);

            return base.OnInitializedAsync();
        }

        protected void HandleValidSubmit()
        {
            var editedEmp = MockList.trainees.FirstOrDefault(em => em.Id == empId);
            editedEmp.Name = CurEmp.Name;
            editedEmp.Email = CurEmp.Email;
            editedEmp.MobileNo = CurEmp.MobileNo;
            editedEmp.Birthdate = CurEmp.Birthdate;
            editedEmp.TrackId = CurEmp.TrackId;

            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            Saved = false;
        }
    }
}
