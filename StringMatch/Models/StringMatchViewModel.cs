
using System.ComponentModel.DataAnnotations;

namespace StringMatch.Models
{
    public class StringMatchViewModel
    {
        [Required(ErrorMessage = "Please enter the text")]
        public string Text { get; set; }
        [Required(ErrorMessage = "Please enter the sub text")]
        public string SubText { get; set; }
        public string Output { get; set; }
    }
}