namespace Ejercicio2_CristianLopez_Lenguaje3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.IngresarDatosButton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos de estudiantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(175, 115);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 23);
            this.NombreTextBox.TabIndex = 3;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(175, 182);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(100, 23);
            this.EdadTextBox.TabIndex = 4;
            // 
            // IngresarDatosButton
            // 
            this.IngresarDatosButton.Location = new System.Drawing.Point(379, 118);
            this.IngresarDatosButton.Name = "IngresarDatosButton";
            this.IngresarDatosButton.Size = new System.Drawing.Size(116, 23);
            this.IngresarDatosButton.TabIndex = 5;
            this.IngresarDatosButton.Text = "Ingresar los datos";
            this.IngresarDatosButton.UseVisualStyleBackColor = true;
            this.IngresarDatosButton.Click += new System.EventHandler(this.IngresarDatosButton_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Location = new System.Drawing.Point(81, 256);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.RowTemplate.Height = 25;
            this.DatosDataGridView.Size = new System.Drawing.Size(414, 150);
            this.DatosDataGridView.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.IngresarDatosButton);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NombreTextBox;
        private TextBox EdadTextBox;
        private Button IngresarDatosButton;
        private DataGridView DatosDataGridView;
        private ErrorProvider errorProvider1;
    }
}