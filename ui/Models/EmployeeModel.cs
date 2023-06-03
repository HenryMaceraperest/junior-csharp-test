using System.ComponentModel;

namespace ui.Models
{
    public class EmployeeModel
    {
        [Browsable(false)]
        public int EmployeeNumber { get; set; }
        [Browsable(false)]
        public string LineManagerNumber { get; set; }
        public BranchModel Branch { get; set; }
        [Browsable(false)]
        public string Forename { get; set; }
        [Browsable(false)]
        public string Surname { get; set; }
    }
}
