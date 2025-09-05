namespace pryTaborda_InterfazRegistrar2
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
            btnGrabar = new Button();
            chklstContacto = new CheckedListBox();
            lblRegistrarContacto = new Label();
            lblContacto = new Label();
            lblTelefono = new Label();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(228, 231);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(98, 48);
            btnGrabar.TabIndex = 0;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // chklstContacto
            // 
            chklstContacto.FormattingEnabled = true;
            chklstContacto.Location = new Point(86, 323);
            chklstContacto.Name = "chklstContacto";
            chklstContacto.Size = new Size(223, 94);
            chklstContacto.TabIndex = 1;
            // 
            // lblRegistrarContacto
            // 
            lblRegistrarContacto.AutoSize = true;
            lblRegistrarContacto.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegistrarContacto.Location = new Point(31, 32);
            lblRegistrarContacto.Name = "lblRegistrarContacto";
            lblRegistrarContacto.Size = new Size(167, 25);
            lblRegistrarContacto.TabIndex = 2;
            lblRegistrarContacto.Text = "Registrar Contacto";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BorderStyle = BorderStyle.FixedSingle;
            lblContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(49, 113);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(71, 22);
            lblContacto.TabIndex = 3;
            lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BorderStyle = BorderStyle.FixedSingle;
            lblTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(51, 167);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(69, 22);
            lblTelefono.TabIndex = 4;
            lblTelefono.Text = "Telefono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(154, 164);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 445);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(lblRegistrarContacto);
            Controls.Add(chklstContacto);
            Controls.Add(btnGrabar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGrabar;
        private CheckedListBox chklstContacto;
        private Label lblRegistrarContacto;
        private Label lblContacto;
        private Label lblTelefono;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}
