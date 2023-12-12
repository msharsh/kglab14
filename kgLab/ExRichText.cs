using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kgLab
{
    public class ExRichText : RichTextBox
    {
        [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, Int32 msg,
                                                 Int32 wParam, ref PARAFORMAT2 lParam);

        private const int SCF_SELECTION = 1;
        public const int PFM_LINESPACING = 256;
        public const int EM_SETPARAFORMAT = 1095;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public Int16 wNumbering;
            public Int16 wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public Int16 wAlignment;
            public Int16 cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public Int16 sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public Int16 wShadingWeight;
            public Int16 wShadingStyle;
            public Int16 wNumberingStart;
            public Int16 wNumberingStyle;
            public Int16 wNumberingTab;
            public Int16 wBorderSpace;
            public Int16 wBorderWidth;
            public Int16 wBorders;
        }

        public void SetSelectionLineSpacing(byte bLineSpacingRule, int dyLineSpacing)
        {
            PARAFORMAT2 format = new PARAFORMAT2();
            format.cbSize = Marshal.SizeOf(format);
            format.dwMask = PFM_LINESPACING;
            format.dyLineSpacing = dyLineSpacing;
            format.bLineSpacingRule = bLineSpacingRule;
            SendMessage(this.Handle, EM_SETPARAFORMAT, SCF_SELECTION, ref format);
        }
    }
}
