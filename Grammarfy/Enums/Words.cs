using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammarfy.Enums
{
    public enum Word
    {
        [Phrase(Tense.Past, "had a", "had")]
        //[Phrase(Tense.Present, "has an", "has")]
        [Phrase(Tense.Future, "will have a", "will have")]
        Had_Has_WillHave,
    }
}
