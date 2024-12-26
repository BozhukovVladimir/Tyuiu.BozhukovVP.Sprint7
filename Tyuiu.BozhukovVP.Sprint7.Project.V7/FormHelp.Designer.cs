namespace Tyuiu.BozhukovVP.Sprint7.Project.V7
{
    partial class FormHelp_BVP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp_BVP));
            textBoxInfo_BVP = new TextBox();
            buttonClose_BVP = new Button();
            pictureBoxPhoto_BVP = new PictureBox();
            textBoxCreator_BVP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BVP).BeginInit();
            SuspendLayout();
            // 
            // textBoxInfo_BVP
            // 
            textBoxInfo_BVP.BackColor = SystemColors.Control;
            textBoxInfo_BVP.Location = new Point(305, 67);
            textBoxInfo_BVP.Multiline = true;
            textBoxInfo_BVP.Name = "textBoxInfo_BVP";
            textBoxInfo_BVP.ReadOnly = true;
            textBoxInfo_BVP.Size = new Size(483, 252);
            textBoxInfo_BVP.TabIndex = 0;
            textBoxInfo_BVP.Text = resources.GetString("textBoxInfo_BVP.Text");
            // 
            // buttonClose_BVP
            // 
            buttonClose_BVP.Location = new Point(566, 373);
            buttonClose_BVP.Name = "buttonClose_BVP";
            buttonClose_BVP.Size = new Size(222, 61);
            buttonClose_BVP.TabIndex = 1;
            buttonClose_BVP.Text = "Закрыть";
            buttonClose_BVP.UseVisualStyleBackColor = true;
            buttonClose_BVP.Click += buttonClose_BVP_Click;
            // 
            // pictureBoxPhoto_BVP
            // 
            pictureBoxPhoto_BVP.Image = Properties.Resources._10;
            pictureBoxPhoto_BVP.Location = new Point(3, 67);
            pictureBoxPhoto_BVP.Name = "pictureBoxPhoto_BVP";
            pictureBoxPhoto_BVP.Size = new Size(279, 371);
            pictureBoxPhoto_BVP.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPhoto_BVP.TabIndex = 2;
            pictureBoxPhoto_BVP.TabStop = false;
            // 
            // textBoxCreator_BVP
            // 
            textBoxCreator_BVP.BackColor = SystemColors.Control;
            textBoxCreator_BVP.Location = new Point(305, 373);
            textBoxCreator_BVP.Multiline = true;
            textBoxCreator_BVP.Name = "textBoxCreator_BVP";
            textBoxCreator_BVP.ReadOnly = true;
            textBoxCreator_BVP.Size = new Size(255, 61);
            textBoxCreator_BVP.TabIndex = 3;
            textBoxCreator_BVP.Text = "Разработчик: Божуков Владимир Павлович Группа: ИБКСб-24-1 ";
            textBoxCreator_BVP.TextAlign = HorizontalAlignment.Center;
            // 
            // FormHelp_BVP
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxCreator_BVP);
            Controls.Add(pictureBoxPhoto_BVP);
            Controls.Add(buttonClose_BVP);
            Controls.Add(textBoxInfo_BVP);
            Name = "FormHelp_BVP";
            Text = "О Программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_BVP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInfo_BVP;
        private Button buttonClose_BVP;
        private PictureBox pictureBoxPhoto_BVP;
        private TextBox textBoxCreator_BVP;
    }
}