namespace Tyuiu.BozhukovVP.Sprint7.Project.V7
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxMainMenu_BVP = new GroupBox();
            buttonEdit_BVP = new Button();
            buttonViewBase_BVP = new Button();
            buttonDel_BVP = new Button();
            buttonSaveBase_BVP = new Button();
            buttonAdd_BVP = new Button();
            buttonOpenBase_BVP = new Button();
            buttonHelp_BVP = new Button();
            groupBoxFunc_BVP = new GroupBox();
            buttonDolg_BVP = new Button();
            buttonSearch_BVP = new Button();
            buttonHome_BVP = new Button();
            textBoxMaxRooms_BVP = new TextBox();
            textBoxMinRooms_BVP = new TextBox();
            textBoxMidSize_BVP = new TextBox();
            textBoxMaxSize_BVP = new TextBox();
            textBoxMinSize_BVP = new TextBox();
            buttonMaxRooms_BVP = new Button();
            labelFind_BVP = new Label();
            comboBoxChild_BVP = new ComboBox();
            comboBoxDolg_BVP = new ComboBox();
            buttonBackFiltr_BVP = new Button();
            buttonFiltrChild_BVP = new Button();
            labelSearch_BVP = new Label();
            labelFiltr_BVP = new Label();
            labelSort_BVP = new Label();
            textBoxSearch_BVP = new TextBox();
            buttonMinRooms_BVP = new Button();
            buttonStartChart_BVP = new Button();
            buttonMidSize_BVP = new Button();
            buttonMaxSize_BVP = new Button();
            buttonMinSize_BVP = new Button();
            buttonFiltrDolg_BVP = new Button();
            buttonChild_BVP = new Button();
            buttonSize_BVP = new Button();
            buttonRooms_BVP = new Button();
            buttonPod_BVP = new Button();
            dataGridViewBase_BVP = new DataGridView();
            Pod = new DataGridViewTextBoxColumn();
            Home = new DataGridViewTextBoxColumn();
            Rooms = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Child = new DataGridViewTextBoxColumn();
            Dolg = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            chart_BVP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            openFileDialogMain_BVP = new OpenFileDialog();
            saveFileDialogMain_BVP = new SaveFileDialog();
            groupBoxMainMenu_BVP.SuspendLayout();
            groupBoxFunc_BVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BVP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart_BVP).BeginInit();
            SuspendLayout();
            // 
            // groupBoxMainMenu_BVP
            // 
            groupBoxMainMenu_BVP.BackColor = Color.FromArgb(128, 128, 255);
            groupBoxMainMenu_BVP.Controls.Add(buttonEdit_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonViewBase_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonDel_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonSaveBase_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonAdd_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonOpenBase_BVP);
            groupBoxMainMenu_BVP.Controls.Add(buttonHelp_BVP);
            groupBoxMainMenu_BVP.Location = new Point(1307, 3);
            groupBoxMainMenu_BVP.Name = "groupBoxMainMenu_BVP";
            groupBoxMainMenu_BVP.Size = new Size(74, 402);
            groupBoxMainMenu_BVP.TabIndex = 0;
            groupBoxMainMenu_BVP.TabStop = false;
            groupBoxMainMenu_BVP.Text = "Меню";
            // 
            // buttonEdit_BVP
            // 
            buttonEdit_BVP.BackgroundImage = Properties.Resources._9;
            buttonEdit_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEdit_BVP.Location = new Point(13, 352);
            buttonEdit_BVP.Name = "buttonEdit_BVP";
            buttonEdit_BVP.Size = new Size(50, 50);
            buttonEdit_BVP.TabIndex = 5;
            buttonEdit_BVP.UseVisualStyleBackColor = true;
            buttonEdit_BVP.Click += buttonEdit_BVP_Click;
            // 
            // buttonViewBase_BVP
            // 
            buttonViewBase_BVP.BackgroundImage = Properties.Resources._5;
            buttonViewBase_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonViewBase_BVP.Location = new Point(13, 191);
            buttonViewBase_BVP.Name = "buttonViewBase_BVP";
            buttonViewBase_BVP.Size = new Size(50, 50);
            buttonViewBase_BVP.TabIndex = 6;
            buttonViewBase_BVP.UseVisualStyleBackColor = true;
            buttonViewBase_BVP.Click += buttonViewBase_BVP_Click;
            // 
            // buttonDel_BVP
            // 
            buttonDel_BVP.BackgroundImage = Properties.Resources._7;
            buttonDel_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDel_BVP.Location = new Point(13, 302);
            buttonDel_BVP.Name = "buttonDel_BVP";
            buttonDel_BVP.Size = new Size(50, 50);
            buttonDel_BVP.TabIndex = 4;
            buttonDel_BVP.UseVisualStyleBackColor = true;
            buttonDel_BVP.Click += buttonDel_BVP_Click;
            // 
            // buttonSaveBase_BVP
            // 
            buttonSaveBase_BVP.BackgroundImage = Properties.Resources._4;
            buttonSaveBase_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSaveBase_BVP.Location = new Point(13, 135);
            buttonSaveBase_BVP.Name = "buttonSaveBase_BVP";
            buttonSaveBase_BVP.Size = new Size(50, 50);
            buttonSaveBase_BVP.TabIndex = 2;
            buttonSaveBase_BVP.UseVisualStyleBackColor = true;
            buttonSaveBase_BVP.Click += buttonSaveBase_BVP_Click;
            // 
            // buttonAdd_BVP
            // 
            buttonAdd_BVP.BackgroundImage = Properties.Resources._6;
            buttonAdd_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd_BVP.Location = new Point(13, 246);
            buttonAdd_BVP.Name = "buttonAdd_BVP";
            buttonAdd_BVP.Size = new Size(50, 50);
            buttonAdd_BVP.TabIndex = 3;
            buttonAdd_BVP.UseVisualStyleBackColor = true;
            buttonAdd_BVP.Click += buttonAdd_BVP_Click;
            // 
            // buttonOpenBase_BVP
            // 
            buttonOpenBase_BVP.BackgroundImage = Properties.Resources._3;
            buttonOpenBase_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenBase_BVP.Location = new Point(13, 79);
            buttonOpenBase_BVP.Name = "buttonOpenBase_BVP";
            buttonOpenBase_BVP.Size = new Size(50, 50);
            buttonOpenBase_BVP.TabIndex = 1;
            buttonOpenBase_BVP.UseVisualStyleBackColor = true;
            buttonOpenBase_BVP.Click += buttonOpenBase_BVP_Click;
            // 
            // buttonHelp_BVP
            // 
            buttonHelp_BVP.BackgroundImage = (Image)resources.GetObject("buttonHelp_BVP.BackgroundImage");
            buttonHelp_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonHelp_BVP.ForeColor = Color.FromArgb(128, 128, 255);
            buttonHelp_BVP.Location = new Point(13, 23);
            buttonHelp_BVP.Name = "buttonHelp_BVP";
            buttonHelp_BVP.Size = new Size(50, 50);
            buttonHelp_BVP.TabIndex = 0;
            buttonHelp_BVP.UseVisualStyleBackColor = true;
            buttonHelp_BVP.Click += buttonHelp_BVP_Click;
            // 
            // groupBoxFunc_BVP
            // 
            groupBoxFunc_BVP.BackColor = Color.FromArgb(128, 128, 255);
            groupBoxFunc_BVP.Controls.Add(buttonDolg_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonSearch_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonHome_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxMaxRooms_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxMinRooms_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxMidSize_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxMaxSize_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxMinSize_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonMaxRooms_BVP);
            groupBoxFunc_BVP.Controls.Add(labelFind_BVP);
            groupBoxFunc_BVP.Controls.Add(comboBoxChild_BVP);
            groupBoxFunc_BVP.Controls.Add(comboBoxDolg_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonBackFiltr_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonFiltrChild_BVP);
            groupBoxFunc_BVP.Controls.Add(labelSearch_BVP);
            groupBoxFunc_BVP.Controls.Add(labelFiltr_BVP);
            groupBoxFunc_BVP.Controls.Add(labelSort_BVP);
            groupBoxFunc_BVP.Controls.Add(textBoxSearch_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonMinRooms_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonStartChart_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonMidSize_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonMaxSize_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonMinSize_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonFiltrDolg_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonChild_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonSize_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonRooms_BVP);
            groupBoxFunc_BVP.Controls.Add(buttonPod_BVP);
            groupBoxFunc_BVP.ForeColor = SystemColors.Desktop;
            groupBoxFunc_BVP.Location = new Point(9, 3);
            groupBoxFunc_BVP.Name = "groupBoxFunc_BVP";
            groupBoxFunc_BVP.Size = new Size(283, 746);
            groupBoxFunc_BVP.TabIndex = 1;
            groupBoxFunc_BVP.TabStop = false;
            groupBoxFunc_BVP.Text = "Панель Управления";
            // 
            // buttonDolg_BVP
            // 
            buttonDolg_BVP.Location = new Point(146, 111);
            buttonDolg_BVP.Name = "buttonDolg_BVP";
            buttonDolg_BVP.Size = new Size(131, 42);
            buttonDolg_BVP.TabIndex = 30;
            buttonDolg_BVP.Text = "Задолженность";
            buttonDolg_BVP.UseVisualStyleBackColor = true;
            buttonDolg_BVP.Click += buttonDolg_BVP_Click;
            // 
            // buttonSearch_BVP
            // 
            buttonSearch_BVP.BackgroundImage = Properties.Resources.Общественное_мнение1;
            buttonSearch_BVP.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch_BVP.Location = new Point(224, 34);
            buttonSearch_BVP.Name = "buttonSearch_BVP";
            buttonSearch_BVP.Size = new Size(50, 50);
            buttonSearch_BVP.TabIndex = 29;
            buttonSearch_BVP.UseVisualStyleBackColor = true;
            buttonSearch_BVP.Click += buttonSearch_BVP_Click;
            // 
            // buttonHome_BVP
            // 
            buttonHome_BVP.Location = new Point(-3, 159);
            buttonHome_BVP.Name = "buttonHome_BVP";
            buttonHome_BVP.Size = new Size(146, 39);
            buttonHome_BVP.TabIndex = 27;
            buttonHome_BVP.Text = "Номер Квартиры";
            buttonHome_BVP.UseVisualStyleBackColor = true;
            buttonHome_BVP.Click += buttonHome_BVP_Click;
            // 
            // textBoxMaxRooms_BVP
            // 
            textBoxMaxRooms_BVP.Location = new Point(149, 614);
            textBoxMaxRooms_BVP.Name = "textBoxMaxRooms_BVP";
            textBoxMaxRooms_BVP.Size = new Size(125, 27);
            textBoxMaxRooms_BVP.TabIndex = 26;
            // 
            // textBoxMinRooms_BVP
            // 
            textBoxMinRooms_BVP.Location = new Point(149, 569);
            textBoxMinRooms_BVP.Name = "textBoxMinRooms_BVP";
            textBoxMinRooms_BVP.Size = new Size(125, 27);
            textBoxMinRooms_BVP.TabIndex = 25;
            // 
            // textBoxMidSize_BVP
            // 
            textBoxMidSize_BVP.Location = new Point(149, 524);
            textBoxMidSize_BVP.Name = "textBoxMidSize_BVP";
            textBoxMidSize_BVP.Size = new Size(125, 27);
            textBoxMidSize_BVP.TabIndex = 24;
            // 
            // textBoxMaxSize_BVP
            // 
            textBoxMaxSize_BVP.Location = new Point(149, 479);
            textBoxMaxSize_BVP.Name = "textBoxMaxSize_BVP";
            textBoxMaxSize_BVP.Size = new Size(125, 27);
            textBoxMaxSize_BVP.TabIndex = 23;
            // 
            // textBoxMinSize_BVP
            // 
            textBoxMinSize_BVP.Location = new Point(149, 434);
            textBoxMinSize_BVP.Name = "textBoxMinSize_BVP";
            textBoxMinSize_BVP.Size = new Size(125, 27);
            textBoxMinSize_BVP.TabIndex = 22;
            // 
            // buttonMaxRooms_BVP
            // 
            buttonMaxRooms_BVP.Location = new Point(3, 608);
            buttonMaxRooms_BVP.Name = "buttonMaxRooms_BVP";
            buttonMaxRooms_BVP.Size = new Size(140, 39);
            buttonMaxRooms_BVP.TabIndex = 21;
            buttonMaxRooms_BVP.Text = "Макс.Комнат";
            buttonMaxRooms_BVP.UseVisualStyleBackColor = true;
            buttonMaxRooms_BVP.Click += buttonMaxRooms_BVP_Click;
            // 
            // labelFind_BVP
            // 
            labelFind_BVP.AutoSize = true;
            labelFind_BVP.Location = new Point(6, 405);
            labelFind_BVP.Name = "labelFind_BVP";
            labelFind_BVP.Size = new Size(55, 20);
            labelFind_BVP.TabIndex = 20;
            labelFind_BVP.Text = "Найти:";
            // 
            // comboBoxChild_BVP
            // 
            comboBoxChild_BVP.FormattingEnabled = true;
            comboBoxChild_BVP.Location = new Point(146, 324);
            comboBoxChild_BVP.Name = "comboBoxChild_BVP";
            comboBoxChild_BVP.Size = new Size(128, 28);
            comboBoxChild_BVP.TabIndex = 19;
            // 
            // comboBoxDolg_BVP
            // 
            comboBoxDolg_BVP.FormattingEnabled = true;
            comboBoxDolg_BVP.Location = new Point(146, 279);
            comboBoxDolg_BVP.Name = "comboBoxDolg_BVP";
            comboBoxDolg_BVP.Size = new Size(128, 28);
            comboBoxDolg_BVP.TabIndex = 18;
            // 
            // buttonBackFiltr_BVP
            // 
            buttonBackFiltr_BVP.Location = new Point(3, 363);
            buttonBackFiltr_BVP.Name = "buttonBackFiltr_BVP";
            buttonBackFiltr_BVP.Size = new Size(277, 39);
            buttonBackFiltr_BVP.TabIndex = 17;
            buttonBackFiltr_BVP.Text = "Отменить Фильтрацию";
            buttonBackFiltr_BVP.UseVisualStyleBackColor = true;
            buttonBackFiltr_BVP.Click += buttonBackFiltr_BVP_Click;
            // 
            // buttonFiltrChild_BVP
            // 
            buttonFiltrChild_BVP.Location = new Point(0, 318);
            buttonFiltrChild_BVP.Name = "buttonFiltrChild_BVP";
            buttonFiltrChild_BVP.Size = new Size(143, 39);
            buttonFiltrChild_BVP.TabIndex = 16;
            buttonFiltrChild_BVP.Text = "Наличие детей";
            buttonFiltrChild_BVP.UseVisualStyleBackColor = true;
            buttonFiltrChild_BVP.Click += buttonFiltrChild_BVP_Click;
            // 
            // labelSearch_BVP
            // 
            labelSearch_BVP.AutoSize = true;
            labelSearch_BVP.Location = new Point(3, 23);
            labelSearch_BVP.Name = "labelSearch_BVP";
            labelSearch_BVP.Size = new Size(143, 20);
            labelSearch_BVP.TabIndex = 15;
            labelSearch_BVP.Text = "Поисковой запрос:";
            // 
            // labelFiltr_BVP
            // 
            labelFiltr_BVP.AutoSize = true;
            labelFiltr_BVP.Location = new Point(6, 247);
            labelFiltr_BVP.Name = "labelFiltr_BVP";
            labelFiltr_BVP.Size = new Size(119, 20);
            labelFiltr_BVP.TabIndex = 14;
            labelFiltr_BVP.Text = "Фильтрация по:";
            // 
            // labelSort_BVP
            // 
            labelSort_BVP.AutoSize = true;
            labelSort_BVP.Location = new Point(6, 87);
            labelSort_BVP.Name = "labelSort_BVP";
            labelSort_BVP.Size = new Size(124, 20);
            labelSort_BVP.TabIndex = 13;
            labelSort_BVP.Text = "Сортировать по:";
            // 
            // textBoxSearch_BVP
            // 
            textBoxSearch_BVP.Location = new Point(3, 46);
            textBoxSearch_BVP.Multiline = true;
            textBoxSearch_BVP.Name = "textBoxSearch_BVP";
            textBoxSearch_BVP.Size = new Size(218, 27);
            textBoxSearch_BVP.TabIndex = 12;
            textBoxSearch_BVP.Text = "Поиск";
            textBoxSearch_BVP.TextChanged += textBoxSearch_BVP_TextChanged;
            // 
            // buttonMinRooms_BVP
            // 
            buttonMinRooms_BVP.Location = new Point(3, 563);
            buttonMinRooms_BVP.Name = "buttonMinRooms_BVP";
            buttonMinRooms_BVP.Size = new Size(140, 39);
            buttonMinRooms_BVP.TabIndex = 11;
            buttonMinRooms_BVP.Text = "Мин.Комнат";
            buttonMinRooms_BVP.UseVisualStyleBackColor = true;
            buttonMinRooms_BVP.Click += buttonMinRooms_BVP_Click;
            // 
            // buttonStartChart_BVP
            // 
            buttonStartChart_BVP.Location = new Point(19, 653);
            buttonStartChart_BVP.Name = "buttonStartChart_BVP";
            buttonStartChart_BVP.Size = new Size(237, 45);
            buttonStartChart_BVP.TabIndex = 9;
            buttonStartChart_BVP.Text = "Вывести График";
            buttonStartChart_BVP.UseVisualStyleBackColor = true;
            buttonStartChart_BVP.Click += buttonStartChart_BVP_Click;
            // 
            // buttonMidSize_BVP
            // 
            buttonMidSize_BVP.Location = new Point(3, 518);
            buttonMidSize_BVP.Name = "buttonMidSize_BVP";
            buttonMidSize_BVP.Size = new Size(140, 39);
            buttonMidSize_BVP.TabIndex = 10;
            buttonMidSize_BVP.Text = "Сред.Площадь";
            buttonMidSize_BVP.UseVisualStyleBackColor = true;
            buttonMidSize_BVP.Click += buttonMidSize_BVP_Click;
            // 
            // buttonMaxSize_BVP
            // 
            buttonMaxSize_BVP.Location = new Point(0, 473);
            buttonMaxSize_BVP.Name = "buttonMaxSize_BVP";
            buttonMaxSize_BVP.Size = new Size(143, 39);
            buttonMaxSize_BVP.TabIndex = 7;
            buttonMaxSize_BVP.Text = "Макс.Площадь";
            buttonMaxSize_BVP.UseVisualStyleBackColor = true;
            buttonMaxSize_BVP.Click += buttonMaxSize_BVP_Click;
            // 
            // buttonMinSize_BVP
            // 
            buttonMinSize_BVP.Location = new Point(3, 428);
            buttonMinSize_BVP.Name = "buttonMinSize_BVP";
            buttonMinSize_BVP.Size = new Size(140, 39);
            buttonMinSize_BVP.TabIndex = 6;
            buttonMinSize_BVP.Text = "Мин.Площадь";
            buttonMinSize_BVP.UseVisualStyleBackColor = true;
            buttonMinSize_BVP.Click += buttonMinSize_BVP_Click;
            // 
            // buttonFiltrDolg_BVP
            // 
            buttonFiltrDolg_BVP.Location = new Point(0, 273);
            buttonFiltrDolg_BVP.Name = "buttonFiltrDolg_BVP";
            buttonFiltrDolg_BVP.Size = new Size(143, 39);
            buttonFiltrDolg_BVP.TabIndex = 5;
            buttonFiltrDolg_BVP.Text = "Задолженность";
            buttonFiltrDolg_BVP.UseVisualStyleBackColor = true;
            buttonFiltrDolg_BVP.Click += buttonFiltrDolg_BVP_Click;
            // 
            // buttonChild_BVP
            // 
            buttonChild_BVP.Location = new Point(149, 204);
            buttonChild_BVP.Name = "buttonChild_BVP";
            buttonChild_BVP.Size = new Size(128, 40);
            buttonChild_BVP.TabIndex = 4;
            buttonChild_BVP.Text = "Кол-во детей";
            buttonChild_BVP.UseVisualStyleBackColor = true;
            buttonChild_BVP.Click += buttonChild_BVP_Click;
            // 
            // buttonSize_BVP
            // 
            buttonSize_BVP.Location = new Point(149, 159);
            buttonSize_BVP.Name = "buttonSize_BVP";
            buttonSize_BVP.Size = new Size(128, 39);
            buttonSize_BVP.TabIndex = 3;
            buttonSize_BVP.Text = "Площадь";
            buttonSize_BVP.UseVisualStyleBackColor = true;
            buttonSize_BVP.Click += buttonSize_BVP_Click;
            // 
            // buttonRooms_BVP
            // 
            buttonRooms_BVP.Location = new Point(0, 205);
            buttonRooms_BVP.Name = "buttonRooms_BVP";
            buttonRooms_BVP.Size = new Size(143, 39);
            buttonRooms_BVP.TabIndex = 2;
            buttonRooms_BVP.Text = "Кол-во Комнат";
            buttonRooms_BVP.UseVisualStyleBackColor = true;
            buttonRooms_BVP.Click += buttonRooms_BVP_Click;
            // 
            // buttonPod_BVP
            // 
            buttonPod_BVP.Location = new Point(0, 111);
            buttonPod_BVP.Name = "buttonPod_BVP";
            buttonPod_BVP.Size = new Size(143, 39);
            buttonPod_BVP.TabIndex = 1;
            buttonPod_BVP.Text = "Номер Подъезда";
            buttonPod_BVP.UseVisualStyleBackColor = true;
            buttonPod_BVP.Click += buttonPod_BVP_Click;
            // 
            // dataGridViewBase_BVP
            // 
            dataGridViewBase_BVP.AllowUserToAddRows = false;
            dataGridViewBase_BVP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBase_BVP.Columns.AddRange(new DataGridViewColumn[] { Pod, Home, Rooms, Size, Child, Dolg });
            dataGridViewBase_BVP.Location = new Point(298, 3);
            dataGridViewBase_BVP.Name = "dataGridViewBase_BVP";
            dataGridViewBase_BVP.RowHeadersWidth = 51;
            dataGridViewBase_BVP.Size = new Size(1003, 402);
            dataGridViewBase_BVP.TabIndex = 2;
            dataGridViewBase_BVP.CellContentClick += dataGridViewBase_BVP_CellContentClick;
            // 
            // Pod
            // 
            Pod.HeaderText = "Номер подъезда";
            Pod.MinimumWidth = 6;
            Pod.Name = "Pod";
            Pod.Width = 125;
            // 
            // Home
            // 
            Home.HeaderText = "Номер Квартиры";
            Home.MinimumWidth = 6;
            Home.Name = "Home";
            Home.Width = 125;
            // 
            // Rooms
            // 
            Rooms.HeaderText = "Кол-во комнат";
            Rooms.MinimumWidth = 6;
            Rooms.Name = "Rooms";
            Rooms.Width = 125;
            // 
            // Size
            // 
            Size.HeaderText = "Площадь";
            Size.MinimumWidth = 6;
            Size.Name = "Size";
            Size.Width = 125;
            // 
            // Child
            // 
            Child.HeaderText = "Кол-во детей";
            Child.MinimumWidth = 6;
            Child.Name = "Child";
            Child.Width = 125;
            // 
            // Dolg
            // 
            Dolg.HeaderText = "Задолженность";
            Dolg.MinimumWidth = 6;
            Dolg.Name = "Dolg";
            Dolg.Width = 125;
            // 
            // chart_BVP
            // 
            chartArea1.Name = "ChartArea1";
            chart_BVP.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart_BVP.Legends.Add(legend1);
            chart_BVP.Location = new Point(298, 408);
            chart_BVP.Name = "chart_BVP";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart_BVP.Series.Add(series1);
            chart_BVP.Size = new Size(1083, 349);
            chart_BVP.TabIndex = 3;
            chart_BVP.Text = "chart1";
            // 
            // openFileDialogMain_BVP
            // 
            openFileDialogMain_BVP.FileName = "openFileDialogMain_BVP";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(chart_BVP);
            Controls.Add(dataGridViewBase_BVP);
            Controls.Add(groupBoxFunc_BVP);
            Controls.Add(groupBoxMainMenu_BVP);
            Name = "FormMain";
            Text = "Домоуправление Божуков.В.П ИБКСб-24-1";
            groupBoxMainMenu_BVP.ResumeLayout(false);
            groupBoxFunc_BVP.ResumeLayout(false);
            groupBoxFunc_BVP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBase_BVP).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart_BVP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMainMenu_BVP;
        private Button buttonHelp_BVP;
        private GroupBox groupBoxFunc_BVP;
        public DataGridView dataGridViewBase_BVP;
        private Button buttonSaveBase_BVP;
        private Button buttonOpenBase_BVP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonViewBase_BVP;
        private Button buttonEdit_BVP;
        private Button buttonDel_BVP;
        private Button buttonAdd_BVP;
        private Button buttonChild_BVP;
        private Button buttonSize_BVP;
        private Button buttonRooms_BVP;
        private Button buttonPod_BVP;
        private Button buttonMinRooms_BVP;
        private Button buttonMidSize_BVP;
        private Button buttonStartChart_BVP;
        private Button buttonMaxSize_BVP;
        private Button buttonMinSize_BVP;
        private Button buttonFiltrDolg_BVP;
        private Label labelSort_BVP;
        private TextBox textBoxSearch_BVP;
        private Label labelSearch_BVP;
        private Label labelFiltr_BVP;
        private Button buttonFiltrChild_BVP;
        private ComboBox comboBoxDolg_BVP;
        private Button buttonBackFiltr_BVP;
        private Label labelFind_BVP;
        private ComboBox comboBoxChild_BVP;
        private Button buttonMaxRooms_BVP;
        private TextBox textBoxMaxRooms_BVP;
        private TextBox textBoxMinRooms_BVP;
        private TextBox textBoxMidSize_BVP;
        private TextBox textBoxMaxSize_BVP;
        private TextBox textBoxMinSize_BVP;
        private Button buttonHome_BVP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_BVP;
        private Button buttonSearch_BVP;
        private DataGridViewTextBoxColumn Pod;
        private DataGridViewTextBoxColumn Home;
        private DataGridViewTextBoxColumn Rooms;
        private DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Child;
        private DataGridViewTextBoxColumn Dolg;
        private Button buttonDolg_BVP;
        private OpenFileDialog openFileDialogMain_BVP;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialogMain_BVP;
    }
}
