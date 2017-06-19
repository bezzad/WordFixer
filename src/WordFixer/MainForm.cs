using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordFixer.Properties;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace WordFixer
{
    public partial class MainForm : Form
    {
        public string DefaultPatternStoragePath { get; set; }

        public MainForm()
        {
            //DefaultPatternStoragePath = Path.Combine(
            //    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            //    typeof(MainForm).Assembly.GetName().Name,
            //    "Patterns.json");
            DefaultPatternStoragePath = "Patterns.json";

            InitializeComponent();

            LoadPatterns();

            dgvPatterns.RowsRemoved += (s, e) => DgvPatterns_RowsChanged();
            dgvPatterns.CellEndEdit += (s, e) => DgvPatterns_RowsChanged();
        }

        private void DgvPatterns_RowsChanged()
        {
            SavePatterns();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = Resources.XmlOpenFileFilter,
                Multiselect = false,
                Title = Resources.PleaseSelectWordFileToFix
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofd.FileName;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                var pattern = GetPatterns().Where(p => p.Item2).Select(p => p.Item1).ToArray();
                var input = File.ReadAllText(txtPath.Text, Encoding.UTF8);
                var matches = Regex.Matches(input, string.Join("|", pattern), RegexOptions.Multiline);
                MessageBox.Show(string.Format(Resources.Find__PatternMatches, matches.Count));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            try
            {
                var pattern = GetPatterns().Where(p => p.Item2).Select(p => p.Item1).ToArray();
                var path = txtPath.Text;
                var input = File.ReadAllText(path, Encoding.UTF8);
                var matches = Regex.Matches(input, string.Join("|", pattern), RegexOptions.Multiline);
                var output = Regex.Replace(input, string.Join("|", pattern), "");
                File.WriteAllText(path, output, Encoding.UTF8);
                MessageBox.Show(string.Format(Resources.Find__PatternMatches, matches.Count));
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPattern.Text)) return;

            dgvPatterns.Rows.Add(txtPattern.Text, true);
            SavePatterns();
        }

        private void LoadPatterns()
        {
            try
            {
                if (!File.Exists(DefaultPatternStoragePath)) return;

                var patterns = File.ReadAllText(DefaultPatternStoragePath);
                var rows = JsonConvert.DeserializeObject<List<Tuple<string, bool>>>(patterns);
                dgvPatterns.Rows.Clear();
                foreach (var row in rows)
                {
                    dgvPatterns.Rows.Add(row.Item1, row.Item2);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void SavePatterns()
        {
            try
            {
                var rows = GetPatterns();

                var patterns = JsonConvert.SerializeObject(rows, Formatting.Indented);

                File.WriteAllText(DefaultPatternStoragePath, patterns);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public List<Tuple<string, bool>> GetPatterns()
        {
            var result = new List<Tuple<string, bool>>();
            foreach (var row in dgvPatterns.Rows.Cast<DataGridViewRow>())
            {
                result.Add(Tuple.Create(row.Cells["colPattern"].Value.ToString(), (bool)row.Cells["colActive"].Value));
            }

            return result;
        }
    }
}
