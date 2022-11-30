using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch12
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new 체크박스연습());
            //Application.Run(new CheckListBox());
            //Application.Run(new FrmRadio());
            //Application.Run(new FrmCombo());
            //Application.Run(new ArrayRadio());
            Application.Run(new 시험문제());

        }
    }
}
