using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace EasyModbusServerSimulator
{
    /// <summary>
    /// 절전 모드 헬퍼
    /// </summary>

    public static class SleepModeHelper
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Import
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Private

        #region 스레드 실행 상태 설정하기 - SetThreadExecutionState(state)

        /// <summary>
        /// 스레드 실행 상태 설정하기
        /// </summary>
        /// <param name="state">실행 상태</param>
        /// <returns>실행 상태</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]

        private static extern ExecutionState SetThreadExecutionState(ExecutionState state);

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Static
        //////////////////////////////////////////////////////////////////////////////// Public
        #region 절전 모드 방지하기 - Prevent()

        /// <summary>
        /// 절전 모드 방지하기
        /// </summary>
        public static void Prevent()
        {
            SetThreadExecutionState
            (
                ExecutionState.ES_CONTINUOUS |
                ExecutionState.ES_SYSTEM_REQUIRED |
                ExecutionState.ES_AWAYMODE_REQUIRED |
                ExecutionState.ES_DISPLAY_REQUIRED
            );
        }

        #endregion
        #region 절전 모드 허용하기 - Allow()

        /// <summary>
        /// 절전 모드 허용하기
        /// </summary>
        public static void Allow()
        {
            SetThreadExecutionState(ExecutionState.ES_CONTINUOUS);
        }

        #endregion
    }
}
