using System.ComponentModel.DataAnnotations;

namespace Portfolio.Common.Enums
{
    public enum ProjectCategory : int
    {
        [Display(Name = "Work")]
        Work = 1,

        [Display(Name = "Free-time")]
        FreeTime = 2,
    }
}
