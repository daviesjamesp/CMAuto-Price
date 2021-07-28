using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AutoPrice
{
    public partial class Main : Form
    {
        public readonly string SettingsFilepath = Application.StartupPath + "\\settings.bin";
        private VehicleDataSource vehicleDataSource;
        private bool needInitialSetup = false;

        public static SettingData settings = new SettingData();

        public Main()
        {
            InitializeComponent();
        }

        private async void LoadListAsync()
        {
            var loadForm = new LoadingForm(vehicleDataSource.Parts.Count);
            Progress<int> progress = new Progress<int>();
            progress.ProgressChanged += (_, i) => loadForm.Step();
            loadForm.Show();
            this.Enabled = false;
            await Task.Run(() => BuildPartList(progress));
            this.Enabled = true;
            partDataGrid.DataSource = vehicleDataSource.Parts;
        }

        private void BuildPartList(IProgress<int> progress)
        {
            for (int i = 0; i < 5; i++) // TODO reset to vehicleDataSource.Parts.Count
            {
                var current = vehicleDataSource.Parts[i];
                if (!current.Skip) { current.Build(); }
                settings.Check(current);
                progress.Report(i);
            }
        }

        private void ShowPartList()
        {
            partDataGrid.Rows.Clear();
            for (int i = 0; i < 5; i++) // TODO reset to vehicleDataSource.Parts.Count
            {
                var current = vehicleDataSource.Parts[i];
                var priceStr = current.ProjectedPrice.ToString();
                if (priceStr == "0") { priceStr = "None"; }
                if (priceStr != "None") { priceStr = "$" + priceStr; }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Shown += Main_Shown;
            CheckSettings();
        }

        private void CheckSettings()
        {
            if (!File.Exists(SettingsFilepath))
            {
                CreateSettings();
            }
            else
            {
                settings.LoadSettings();
            }
        }

        private void CreateSettings()
        {
            needInitialSetup = true;
        }

        private void WriteSettings()
        {
            settings.SaveSettings();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            if (needInitialSetup)
            {
                var settingsForm = new SettingsForm(settings);
                settingsForm.ShowDialog();
                settings = settingsForm.EditedSettings;
                WriteSettings();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sForm = new SettingsForm(settings);
            sForm.ShowDialog();
            settings = sForm.EditedSettings;
            WriteSettings();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicleDataSource == null)
            {
                MessageBox.Show("There is no session open to write!\n" +
                                "Import new data or open an existing \n" +
                                "session to continue.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sFD.FileName = "";
            sFD.Title = "Export To File";
            sFD.Filter = "Text|*.txt";
            sFD.ShowDialog();
            if (sFD.FileName == "")
            {
                MessageBox.Show("File was not saved!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Exporter.FormatData(vehicleDataSource, true);
            Exporter.WriteToFile(sFD.FileName);
            MessageBox.Show("File exported successfully!", "Export",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var startup = new ImportForm();
            startup.ShowDialog();
            if (startup.Tag != null) { return; }
            try
            {
                var rawText = startup.ClipText;
                vehicleDataSource = new VehicleDataSource(rawText);
                LoadListAsync();
            }
            catch (Exception)
            {
                MessageBox.Show("Clipboard data was not formatted correctly.\n" +
                                "Try again or see the help page for more \n" +
                                "instructions on copying data.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tryPyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newAutomatedEntryForm = new AutomatedEntryForm("192.168.0.150","DAVID");
            newAutomatedEntryForm.ShowDialog();
            //try
            //{
            //    PythonDependencyChecker.CheckPython();
            //}
            //catch (NotSupportedException ex)
            //{
            //    var errorMessage = ex.Message + "\nPython is not installed on this PC. See the Readme file for instructions";
            //    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //if (vehicleDataSource == null)
            //{
            //    MessageBox.Show("There is no session open to write!\n" +
            //                    "Import new data or open an existing session to continue.", "Warning",
            //                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //Exporter.RunPyScript(vehicleDataSource);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oFD.FileName = "";
            oFD.Title = "Open Session";
            oFD.Filter = "Session|*.sess";
            oFD.InitialDirectory = settings.ExportPath;
            oFD.FileName = "";
            oFD.ShowDialog();
            if (oFD.FileName == "") { return; }
            try
            {
                vehicleDataSource = Exporter.OpenSession(oFD.FileName);
                ShowPartList();
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be opened!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vehicleDataSource == null) { return; }
            sFD.FileName = vehicleDataSource.Stock + ".sess";
            sFD.Filter = "Session|.sess";
            sFD.InitialDirectory = settings.ExportPath;
            sFD.ShowDialog();
            try
            {
                Exporter.SaveSession(vehicleDataSource, sFD.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("File could not be saved!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void partDataGrid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (partDataGrid.SelectedRows.Count == 0) { return; }
            var index = partDataGrid.SelectedRows[0].Index;
            var editPart = vehicleDataSource.Parts[index];
            if (settings.AlwaysSkip.Contains(editPart.Name))
            {
                MessageBox.Show("This part is on the \"Always Skip\" list " +
                                "and cannot be edited. To include, remove " +
                                "this part from the list in Settings.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var itemEditForm = new ItemEditForm(editPart);
            itemEditForm.ShowDialog();
            vehicleDataSource.Parts[index] = itemEditForm.EditedPart;
            ShowPartList();
        }
    }
}
