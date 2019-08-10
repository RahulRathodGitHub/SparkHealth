using System;
using System.Collections.Generic;

namespace Lapbase.LapbaseModels
{
    public partial class TblCharacters
    {
        public int TblCharacterSno { get; set; }
        public string LanguageCode { get; set; }
        public string CharacterCaption { get; set; }
        public short? CharacterOrderNo { get; set; }
    }
}
