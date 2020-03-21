﻿using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Kzx.UserControl.UITypeEdit
{
    public class KzxGridControlColumnsUiTypeEdit : UITypeEditor
    {
        public KzxGridControlColumnsUiTypeEdit()
            : base()
        {
        }

        public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService iwfeds = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));

            if (iwfeds != null)
            {
                frmGridControlColumnsUiTypeEditor f = new frmGridControlColumnsUiTypeEditor(context, value);
                if (DialogResult.OK == iwfeds.ShowDialog(f))
                {
                    return f.Xml;
                }
            }
            return base.EditValue(context, provider, value);
        }
        
    }
}
