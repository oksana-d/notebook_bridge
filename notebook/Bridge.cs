using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    interface ILanguage
    {
        void Apply();
        void ApplyCulture(ComponentResourceManager res, Control ctrl);
    }

    class English: ILanguage
    {
        private void GettAllMenuNames(ToolStripItemCollection toolStripItemCollection, ComponentResourceManager res, Control c)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            
            foreach (ToolStripItem item in toolStripItemCollection)
            {
                res.ApplyResources(item, item.Name);
                ApplyCulture(res, c);
                ToolStripDropDownItem dropDawnItem = item as ToolStripDropDownItem;
                if (dropDawnItem != null)
                {
                    GettAllMenuNames(dropDawnItem.DropDownItems, res, c);
                }
            }
        }

        public void Apply()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en");
            foreach (Form form in Application.OpenForms)
            {
                foreach (Control c in form.Controls)
                {
                    var res = new ComponentResourceManager(form.GetType());
                    res.ApplyResources(form, "$this");
                    foreach (Control ctrl in form.Controls)
                        ApplyCulture(res, ctrl);

                    if (c is MenuStrip)
                    {
                        res.ApplyResources(form, "$this");
                        ToolStripItemCollection items = form.MainMenuStrip.Items;
                        GettAllMenuNames(items, res, c);
                    }
                }
            }
        }

        public void ApplyCulture(ComponentResourceManager res, Control ctrl)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
                ApplyCulture(res, child);
        }
    }

    class Russian : ILanguage
    {
        private void GettAllMenuNames(ToolStripItemCollection toolStripItemCollection, ComponentResourceManager res, Control c)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("ru-RU");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");

            foreach (ToolStripItem item in toolStripItemCollection)
            {
                res.ApplyResources(item, item.Name);
                ApplyCulture(res, c);
                ToolStripDropDownItem dropDawnItem = item as ToolStripDropDownItem;
                if (dropDawnItem != null)
                {
                    GettAllMenuNames(dropDawnItem.DropDownItems, res, c);
                }
            }
        }

        public void Apply()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            foreach (Form form in Application.OpenForms)
            {
                foreach (Control c in form.Controls)
                {
                    var res = new ComponentResourceManager(form.GetType());
                    res.ApplyResources(form, "$this");
                    foreach (Control ctrl in form.Controls)
                        ApplyCulture(res, ctrl);

                    if (c is MenuStrip)
                    {
                        res.ApplyResources(form, "$this");
                        ToolStripItemCollection items = form.MainMenuStrip.Items;
                        GettAllMenuNames(items, res, c);
                    }
                }
            }
        }

        public void ApplyCulture(ComponentResourceManager res, Control ctrl)
        {
            res.ApplyResources(ctrl, ctrl.Name);
            foreach (Control child in ctrl.Controls)
            {
                ApplyCulture(res, child);
            }
        }
    }


    abstract class Windows
    {
        ILanguage language;

        public ILanguage ILanguage
        {
            set { language = value; }
        }

        public Windows(ILanguage lng)
        {
            language = lng;
        }

        public virtual void GetLng()
        {
            language.Apply();
        }
    }

    class WindowsEng : Windows
    {
        public WindowsEng(ILanguage lng) : base(lng) { }
    }

    class WindowsRus : Windows
    {
        public WindowsRus(ILanguage lng) : base(lng) { }
    }
}
