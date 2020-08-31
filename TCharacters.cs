using System;
using System.Collections.Generic;

namespace core
{
    public partial class TCharacters
    {
        public int FId { get; set; }
        public int? FMemberId { get; set; }
        public int? FMaxHp { get; set; }
        public int? FMaxMana { get; set; }
        public int? FSteps { get; set; }
        public int? FLevel { get; set; }
        public int? FHp { get; set; }
        public int? FMana { get; set; }
        public int? FAtt { get; set; }
        public string FPath { get; set; }
        public string FName { get; set; }
        public int? FGold { get; set; }
        public int? FExp { get; set; }
    }
}
