namespace Presentacion
{
    partial class FormularioPersonas
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
            dataGridViewPersona = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersona).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPersona
            // 
            dataGridViewPersona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPersona.Location = new Point(53, 250);
            dataGridViewPersona.Name = "dataGridViewPersona";
            dataGridViewPersona.RowTemplate.Height = 25;
            dataGridViewPersona.Size = new Size(897, 448);
            dataGridViewPersona.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(823, 221);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormularioPersonas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 764);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridViewPersona);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormularioPersonas";
            Text = "FormularioPersonas";
            Load += FormularioPersonas_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPersona).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPersona;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}