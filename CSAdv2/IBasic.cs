using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAdv2
{
    internal interface IBasic
    {
        int TestInstanceMethod(); // 메서드 내부 구현을 입력할 수 없습니다.
        int TestProperty {  get; set; } // 속성에도 마찬가지로 내부 구현을 입력할 수 없습니다. 속성: Property
    }
}
