namespace materials_dbPr5
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
            panelTop = new Panel();
            buttonSave = new Button();
            dataGridViewSupplier = new DataGridView();
            panelFill = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSave);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(4);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1029, 70);
            panelTop.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Left;
            buttonSave.Location = new Point(10, 10);
            buttonSave.Margin = new Padding(4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 50);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSupplier
            // 
            dataGridViewSupplier.BackgroundColor = Color.White;
            dataGridViewSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSupplier.Dock = DockStyle.Fill;
            dataGridViewSupplier.Location = new Point(10, 10);
            dataGridViewSupplier.Margin = new Padding(4);
            dataGridViewSupplier.Name = "dataGridViewSupplier";
            dataGridViewSupplier.Size = new Size(1009, 540);
            dataGridViewSupplier.TabIndex = 1;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewSupplier);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 70);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1029, 560);
            panelFill.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(panelFill);
            Controls.Add(panelTop);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSupplier).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button buttonSave;
        private DataGridView dataGridViewSupplier;
        private Panel panelFill;
    }
}
