using System;
using System.Windows.Forms;

namespace Jedi.HierarchyBuilder.Forms
{
    public partial class JsonViewerForm : Form
    {
        #region Constructors

        protected JsonViewerForm()
        {
            InitializeComponent();
        }
        
        public JsonViewerForm(string json)
            : this()
        {
            txtAboutText.Text = json;
        }

        #endregion

        #region Event handlers

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAboutText.Text);
        }

        #endregion
    }
}
