namespace AcademicPerformance
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Import = new System.Windows.Forms.Button();
            this.Adddata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 383);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Import
            // 
            this.button_Import.Location = new System.Drawing.Point(701, 12);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(87, 37);
            this.button_Import.TabIndex = 1;
            this.button_Import.Text = "Получить";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adddata
            // 
            this.Adddata.Location = new System.Drawing.Point(12, 12);
            this.Adddata.Name = "Adddata";
            this.Adddata.Size = new System.Drawing.Size(87, 37);
            this.Adddata.TabIndex = 2;
            this.Adddata.Text = "Добавить";
            this.Adddata.UseVisualStyleBackColor = true;
            this.Adddata.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Adddata);
            this.Controls.Add(this.button_Import);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Import;
        private System.Windows.Forms.Button Adddata;
        
    }
}

