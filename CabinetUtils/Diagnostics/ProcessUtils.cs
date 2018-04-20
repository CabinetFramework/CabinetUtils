
/**********************************************************
 * 
 * 命名空间：
 *          CabinetUtils.Diagnostics
 * 
 * 描述：
 *          N/A
 *          
 * 功能及上下游：
 *          N/A
 *          
 * 人员：
 *          大鱼
 *          
 * 创建时间：
 *          2018/4/20 16:07:07
 * 
 ***********************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CabinetUtils.Diagnostics
{
    public class ProcessUtils
    {
        /// <summary>
        /// 启动当前程序
        /// </summary>
        public static void AppRestartUnExit()
        {
            Application.Restart();
        }

        public static void AppRestart()
        {
            // TODO
        }
    }
}
