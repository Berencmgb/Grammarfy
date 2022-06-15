using Grammarfy.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammarfy
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class PhraseAttribute : Attribute
    {
        public PhraseAttribute(Tense tense, string singlePhrase, string multiplePhrase)
        {
            Tense = tense;
            SinglePhrase = singlePhrase;
            MultiplePhrase = multiplePhrase;
        }

        [Required]
        private Tense Tense { get; set; }

        [Required]
        private string SinglePhrase { get; set; }

        [Required]
        private string MultiplePhrase { get; set; }
    }
}
