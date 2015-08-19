using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FalloutTerminal {
    public partial class frmMain : Form {
        private List<string> AvailableWords;
        private BindingSource bsWords = new BindingSource();

        private string editItem;
        private WordsData data;

        public frmMain() {
            InitializeComponent();

            AvailableWords = new List<string>();
            bsWords.DataSource = AvailableWords;
            editItem = lblEditText.Text;

            // Soft ensure that the label will never be used or appear
            // as it is intended just as a translation workaround
            this.Controls.Remove(lblEditText);

            cmbWordSelect.Items.Add(editItem);
            lstAvailableWords.DataSource = bsWords;
        }

        private void cmbWordSelect_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox cmbSelector = (ComboBox)sender;

            if (cmbSelector.SelectedIndex == cmbSelector.Items.Count - 1) {
                editWords(cmbSelector);
            }
        }

        private void btnFilterWords_Click(object sender, EventArgs e) {
            AvailableWords.RemoveAll((s) => WordsData.countSimilarities(s, cmbWordSelect.Text) != nudCharacterMatches.Value );
            lblNextGuessValue.Text = data.getNextGuess(AvailableWords);
            bsWords.ResetBindings(false);
        }

        private void btnReset_Click(object sender, EventArgs e) {
            AvailableWords.Clear();
            AvailableWords.AddRange(data.Words);
            bsWords.ResetBindings(false);
            lblNextGuessValue.Text = data.getNextGuess(AvailableWords);
        }

        private void frmMain_Load(object sender, EventArgs e) {
            editWords(cmbWordSelect);
        }

        private void editWords(ComboBox cmbSelector) {
            frmEdit editor = new frmEdit();

            if (data != null) {
                editor.txtWords.Lines = data.Words.ToArray();
            }

            DialogResult r = editor.ShowDialog();
            if (r != System.Windows.Forms.DialogResult.OK) return;

            int? wordLength = editor.wordLength;
            data = new WordsData(editor.words);

            AvailableWords.Clear();
            AvailableWords.AddRange(editor.words);
            bsWords.ResetBindings(false);

            cmbSelector.Items.Clear();
            cmbSelector.Items.AddRange(AvailableWords.ToArray());
            cmbSelector.Items.Add(editItem);

            lblNextGuessValue.Text = data.getNextGuess(AvailableWords);

            nudCharacterMatches.Maximum = wordLength.HasValue ? wordLength.Value : 0;
        }

        private void nudCharacterMatches_Enter(object sender, EventArgs e) {
            nudCharacterMatches.Select(0, nudCharacterMatches.Value.ToString().Length);
        }
    }
}
