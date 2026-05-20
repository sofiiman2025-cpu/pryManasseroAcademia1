namespace pryManasseroAcademia1
{
    partial class frmCargaPlan
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
            this.lblNombrePlan = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPlan = new System.Windows.Forms.TextBox();
            this.lstPlanes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombrePlan
            // 
            this.lblNombrePlan.AutoSize = true;
            this.lblNombrePlan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePlan.Location = new System.Drawing.Point(11, 31);
            this.lblNombrePlan.Name = "lblNombrePlan";
            this.lblNombrePlan.Size = new System.Drawing.Size(112, 19);
            this.lblNombrePlan.TabIndex = 0;
            this.lblNombrePlan.Text = "Nombre del Plan";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(171, 94);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(79, 27);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(269, 94);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(79, 27);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPlan
            // 
            this.txtPlan.Location = new System.Drawing.Point(139, 32);
            this.txtPlan.Name = "txtPlan";
            this.txtPlan.Size = new System.Drawing.Size(100, 20);
            this.txtPlan.TabIndex = 4;
            // 
            // lstPlanes
            // 
            this.lstPlanes.FormattingEnabled = true;
            this.lstPlanes.Location = new System.Drawing.Point(37, 145);
            this.lstPlanes.Name = "lstPlanes";
            this.lstPlanes.Size = new System.Drawing.Size(252, 108);
            this.lstPlanes.TabIndex = 5;
            // 
            // frmCargaPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(360, 279);
            this.Controls.Add(this.lstPlanes);
            this.Controls.Add(this.txtPlan);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblNombrePlan);
            this.Name = "frmCargaPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga Plan de Estudio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombrePlan;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPlan;
        private System.Windows.Forms.ListBox lstPlanes;
    }
}