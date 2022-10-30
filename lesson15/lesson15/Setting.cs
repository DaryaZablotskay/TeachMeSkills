using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson15
{
    public class ComplexSettings
    {
        public const string path = "ComplexSettings";
        public int InnerSetting { get; set; }
        public InerComplexSetting InnerInnerSettings { get; set; }
    }
    public class InerComplexSetting
    {
        public string InnerInnerSetting { get; set; }
    }
}
