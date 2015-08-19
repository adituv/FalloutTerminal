using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FalloutTerminal {
    public partial class frmEdit : Form {
        public List<string> words;
        public int? wordLength;

        public frmEdit() {
            words = new List<string>();
            InitializeComponent();
        }

        private void frmEdit_FormClosing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
            }
        }

        private void CloseAlways() {
            this.FormClosing -= frmEdit_FormClosing;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            words = new List<string>();
            foreach (string s in txtWords.Lines) {
                var st = s.Trim();
                if (!string.IsNullOrWhiteSpace(st)) {
                    if (!wordLength.HasValue) wordLength = st.Length;

                    if (st.Length == wordLength) {
                        words.Add(st.ToLower());
                    } else {
                        MessageBox.Show(string.Format("Not all the words given are the same length.  ({0})", st));
                        return;
                    }
                }
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CloseAlways();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseAlways();
        }

        private void txtWords_KeyDown(object sender, KeyEventArgs e) {
            if (e.Control && e.KeyCode == Keys.A) {
                txtWords.SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
