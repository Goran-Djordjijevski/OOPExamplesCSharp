using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamplesCSharp
{
    public enum CaseType
    {
        Tower,
        MiniTower
    }

    public class Desktop : Computer
    {
        public CaseType CaseType { get; set; }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.CaseType = caseType;
        }
    }
}
