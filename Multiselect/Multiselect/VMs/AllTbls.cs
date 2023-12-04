using Multiselect.Models;

namespace Multiselect.VMs
{
    public class AllTbls
    {
        public List<tbl_subject> Subjects { get; set; }
        public List<Stud_Subj> stud_subj { get; set; }
        public List<tblAcademics> tblAcademics { get; set; }

        public tbl_subject tbl_Subject { get; set; }
        public Stud_Subj Stud_Subj { get; set; }
        public tblAcademics tblAcademic { get; set; }
    }
}
