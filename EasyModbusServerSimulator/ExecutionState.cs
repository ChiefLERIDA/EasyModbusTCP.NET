using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyModbusServerSimulator
{
    /// <summary>
    /// 실행 상태
    /// </summary>
    [FlagsAttribute]
    public enum ExecutionState : uint
    {
        /// <summary>
        /// ES_AWAYMODE_REQUIRED
        /// </summary>
        ES_AWAYMODE_REQUIRED = 0x00000040,

        /// <summary>
        /// ES_CONTINUOUS
        /// </summary>
        ES_CONTINUOUS = 0x80000000,

        /// <summary>
        /// ES_DISPLAY_REQUIRED
        /// </summary>
        ES_DISPLAY_REQUIRED = 0x00000002,

        /// <summary>
        /// ES_SYSTEM_REQUIRED
        /// </summary>
        ES_SYSTEM_REQUIRED = 0x00000001
    }
    //    출처: https://icodebroker.tistory.com/9162 [ICODEBROKER]
}
