namespace Comision
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
            label1 = new Label();
            txtCod = new TextBox();
            txtSeccion = new TextBox();
            label2 = new Label();
            btCalcular = new Button();
            txtImp = new TextBox();
            label3 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(77, 28);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // txtCod
            // 
            txtCod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCod.Location = new Point(94, 40);
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(178, 29);
            txtCod.TabIndex = 1;
            txtCod.Tag = "false";
            txtCod.TextChanged += txtCod_TextChanged;
            txtCod.KeyPress += txtCod_KeyPress;
            // 
            // txtSeccion
            // 
            txtSeccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSeccion.Location = new Point(94, 110);
            txtSeccion.Name = "txtSeccion";
            txtSeccion.Size = new Size(178, 29);
            txtSeccion.TabIndex = 3;
            txtSeccion.Tag = "False ";
            txtSeccion.TextChanged += txtSeccion_TextChanged;
            txtSeccion.KeyPress += txtSeccion_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(146, 79);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 2;
            label2.Text = "Seccion";
            // 
            // btCalcular
            // 
            btCalcular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btCalcular.Location = new Point(94, 237);
            btCalcular.Name = "btCalcular";
            btCalcular.Size = new Size(178, 38);
            btCalcular.TabIndex = 4;
            btCalcular.Text = "Calcular";
            btCalcular.UseVisualStyleBackColor = true;
            btCalcular.Click += btCalcular_Click;
            // 
            // txtImp
            // 
            txtImp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtImp.Location = new Point(94, 189);
            txtImp.Name = "txtImp";
            txtImp.Size = new Size(178, 29);
            txtImp.TabIndex = 6;
            txtImp.TextChanged += txtImp_TextChanged;
            txtImp.KeyPress += txtImp_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(117, 158);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 5;
            label3.Text = "Importe total";
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(94, 281);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(178, 38);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 376);
            Controls.Add(btnSalir);
            Controls.Add(txtImp);
            Controls.Add(label3);
            Controls.Add(btCalcular);
            Controls.Add(txtSeccion);
            Controls.Add(label2);
            Controls.Add(txtCod);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCod;
        private TextBox txtSeccion;
        private Label label2;
        private Button btCalcular;
        private TextBox txtImp;
        private Label label3;
        private Button btnSalir;
    }
}