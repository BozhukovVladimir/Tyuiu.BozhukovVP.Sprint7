using Tyuiu.BozhukovVP.Sprint7.Project.V7.Lib;
using System.ComponentModel;
using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.BozhukovVP.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string filePath)
        {
            string FileData = File.ReadAllText(filePath);

            FileData = FileData.Replace('\n', '\r');
            string[] lines = FileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void buttonHelp_BVP_Click(object sender, EventArgs e)
        {
            FormHelp_BVP formHelp = new FormHelp_BVP();
            formHelp.ShowDialog();
        }

        private void buttonOpenBase_BVP_Click(object sender, EventArgs e)
        {
            openFileDialogMain_BVP.ShowDialog();
            openFilePath = openFileDialogMain_BVP.FileName;

            string[,] arrayValues = new string[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);


            arrayValues = ds.GetBase(openFilePath);

            buttonViewBase_BVP.Enabled = true;
        }

        private void buttonSaveBase_BVP_Click(object sender, EventArgs e)
        {
            saveFileDialogMain_BVP.FileName = "Home_Base.csv";
            saveFileDialogMain_BVP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMain_BVP.ShowDialog();

            string path = saveFileDialogMain_BVP.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool FileExists = fileInfo.Exists;

            if (FileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewBase_BVP.RowCount;
            int columns = dataGridViewBase_BVP.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewBase_BVP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewBase_BVP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonViewBase_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.ColumnCount = columns;
            dataGridViewBase_BVP.RowCount = rows;


            dataGridViewBase_BVP.Rows[0].ReadOnly = true;
            dataGridViewBase_BVP.Columns[0].ReadOnly = true;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewBase_BVP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetBase(openFilePath);

            buttonPod_BVP.Enabled = true;
            buttonDolg_BVP.Enabled = true;
            buttonHome_BVP.Enabled = true;
            buttonSize_BVP.Enabled = true;
            buttonChild_BVP.Enabled = true;
            buttonEdit_BVP.Enabled = true;
            buttonAdd_BVP.Enabled = true;
            buttonRooms_BVP.Enabled = true;
            buttonMinSize_BVP.Enabled = true;
            buttonMidSize_BVP.Enabled = true;
            buttonMaxSize_BVP.Enabled = true;
            buttonMinRooms_BVP.Enabled = true;
            buttonMaxRooms_BVP.Enabled = true;
            buttonBackFiltr_BVP.Enabled = true;
            buttonFiltrDolg_BVP.Enabled = true;
            buttonFiltrChild_BVP.Enabled = true;
            textBoxSearch_BVP.Enabled = true;
            buttonSearch_BVP.Enabled = true;
            textBoxMaxSize_BVP.Enabled = true;
            textBoxMinSize_BVP.Enabled = true;
            textBoxMidSize_BVP.Enabled = true;
            textBoxMinRooms_BVP.Enabled = true;
            textBoxMaxRooms_BVP.Enabled = true;
            comboBoxDolg_BVP.Enabled = true;
            comboBoxChild_BVP.Enabled = true;
            buttonStartChart_BVP.Enabled = true;
        }

        private void buttonAdd_BVP_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(this);
            formAdd.ShowDialog();
        }

        private void dataGridViewBase_BVP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDel_BVP_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewBase_BVP.CurrentRow.Index >= 0)
                {
                    int a = dataGridViewBase_BVP.CurrentRow.Index;
                    dataGridViewBase_BVP.Rows.Remove(dataGridViewBase_BVP.Rows[a]);
                    if (dataGridViewBase_BVP.Rows.Count == 1)
                    {
                        dataGridViewBase_BVP.Rows.Clear();
                    }
                }
                if (dataGridViewBase_BVP.Rows.Count <= 1)
                {
                    buttonDel_BVP.Enabled = false;
                    buttonSearch_BVP.Enabled = false;
                }
                if (dataGridViewBase_BVP.Rows.Count > 1)
                {
                    buttonDel_BVP.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Ошибка при удалении комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_BVP_Click(object sender, EventArgs e)
        {
            try
            {
                int a = dataGridViewBase_BVP.CurrentRow.Index;
                FormEdit_BVP fed = new FormEdit_BVP(this);
                fed.textBoxPodEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[0].Value.ToString();
                fed.textBoxHomeEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[1].Value.ToString();
                fed.textBoxRoomsEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[2].Value.ToString();
                fed.textBoxSizeEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[3].Value.ToString();
                fed.textBoxChildEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[4].Value.ToString();
                fed.textBoxDolgEdit_BVP.Text = dataGridViewBase_BVP.Rows[a].Cells[5].Value.ToString();

                fed.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка при редактировании комплектующего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_BVP_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_BVP_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dataGridViewBase_BVP.RowCount; i++)
                {
                    dataGridViewBase_BVP.Rows[i].Selected = false;
                    for (int j = 0; j < dataGridViewBase_BVP.ColumnCount; j++)
                        if (dataGridViewBase_BVP.Rows[i].Cells[j].Value != null)
                            if (dataGridViewBase_BVP.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_BVP.Text))
                            {
                                dataGridViewBase_BVP.Rows[i].Selected = true;
                                break;
                            }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPod_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[0], ListSortDirection.Descending);
        }

        private void buttonHome_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[1], ListSortDirection.Descending);
        }

        private void buttonRooms_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[2], ListSortDirection.Descending);
        }

        private void buttonSize_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[3], ListSortDirection.Descending);
        }

        private void buttonChild_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[4], ListSortDirection.Descending);
        }

        private void buttonDolg_BVP_Click(object sender, EventArgs e)
        {
            dataGridViewBase_BVP.Sort(dataGridViewBase_BVP.Columns[5], ListSortDirection.Descending);
        }

        private void buttonFiltrDolg_BVP_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxDolg_BVP.SelectedItem?.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {

                if (row.Cells[5].Value != null && int.TryParse(row.Cells[5].Value.ToString(), out int cellValue))
                {

                    if (cellValue == 0)
                    {

                        row.Cells[5].Value = "Нет";
                        row.Visible = true;
                    }

                    else if (cellValue > 0)
                    {

                        row.Cells[5].Value = cellValue;
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void buttonFiltrChild_BVP_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxChild_BVP.SelectedItem?.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {

                if (row.Cells[5].Value != null && int.TryParse(row.Cells[5].Value.ToString(), out int cellValue))
                {

                    if (cellValue == 0)
                    {

                        row.Cells[4].Value = "Нет";
                        row.Visible = true;
                    }

                    else if (cellValue > 0)
                    {

                        row.Cells[5].Value = cellValue;
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void buttonBackFiltr_BVP_Click(object sender, EventArgs e)
        {
            string filterValue = comboBoxDolg_BVP.SelectedItem.ToString();
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                string cellValue = row.Cells[5].Value.ToString();
                if (cellValue == filterValue)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = true;
                }
            }
        }

        private void buttonMinSize_BVP_Click(object sender, EventArgs e)
        {
            double minValue = double.MaxValue;
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue < minValue)
                    {
                        minValue = cellValue;
                    }
                }
            }
            textBoxMinSize_BVP.Text = minValue.ToString();
        }

        private void buttonMaxSize_BVP_Click(object sender, EventArgs e)
        {
            double maxValue = double.MinValue;
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    if (cellValue > maxValue)
                    {
                        maxValue = cellValue;
                    }
                }
            }
            textBoxMaxSize_BVP.Text = maxValue.ToString();
        }

        private void buttonMidSize_BVP_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int count = 0;

            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                if (row.Cells[3].Value != null && row.Cells[3].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[3].Value);
                    sum += cellValue;
                    count++;
                }
            }

            double average = sum / count;
            textBoxMidSize_BVP.Text = Convert.ToString(Math.Round(average, 2));
        }

        private void buttonMinRooms_BVP_Click(object sender, EventArgs e)
        {
            double minValue = double.MaxValue;
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[2].Value);
                    if (cellValue < minValue)
                    {
                        minValue = cellValue;
                    }
                }
            }
            textBoxMinRooms_BVP.Text = minValue.ToString();
        }

        private void buttonMaxRooms_BVP_Click(object sender, EventArgs e)
        {
            double maxValue = double.MinValue;
            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    double cellValue = Convert.ToDouble(row.Cells[2].Value);
                    if (cellValue > maxValue)
                    {
                        maxValue = cellValue;
                    }
                }
            }
            textBoxMaxRooms_BVP.Text = maxValue.ToString();
        }

        private void buttonStartChart_BVP_Click(object sender, EventArgs e)
        {
            chart_BVP.Series.Clear();
            Series series = new Series();
            series.ChartType = SeriesChartType.Area;


            foreach (DataGridViewRow row in dataGridViewBase_BVP.Rows)
            {

                double area = Convert.ToDouble(row.Cells[2].Value);
                int roomCount = Convert.ToInt32(row.Cells[3].Value);
                series.Points.AddXY(roomCount, area);
            }
            chart_BVP.Series.Add(series);
            chart_BVP.Show();
        }
    }
}

