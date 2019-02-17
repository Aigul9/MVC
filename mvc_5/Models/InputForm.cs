using System.ComponentModel.DataAnnotations;

namespace mvc_5.Models
{
    public class InputForm
    {
        [Required(ErrorMessage="*Form name is required")]
        public string FormName { get; set; }
        
        public string FormDescription { get; set; }
        
        [Required(ErrorMessage="*Field name is required")]
        public string FieldName { get; set; }
        
        [Required(ErrorMessage="*Field type is required")]
        public string FieldType { get; set; }
        
        public string FieldDescription { get; set; }
        
        public bool IsChecked { get; set; }
    }
}