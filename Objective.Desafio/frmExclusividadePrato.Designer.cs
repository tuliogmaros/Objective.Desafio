namespace Objective.Desafio
{
    partial class frmExclusividadePrato
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
            lblCompletar = new Label();
            btnOKComplete = new Button();
            btnCancelarComplete = new Button();
            txtRespostaComplete = new TextBox();
            SuspendLayout();
            // 
            // lblCompletar
            // 
            lblCompletar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCompletar.AutoSize = true;
            lblCompletar.Location = new Point(12, 9);
            lblCompletar.Name = "lblCompletar";
            lblCompletar.Size = new Size(300, 15);
            lblCompletar.TabIndex = 0;
            lblCompletar.Text = "pratoAdicionado é __________ mas pratoComparado não";
            // 
            // btnOKComplete
            // 
            btnOKComplete.Location = new Point(12, 65);
            btnOKComplete.Name = "btnOKComplete";
            btnOKComplete.Size = new Size(75, 23);
            btnOKComplete.TabIndex = 1;
            btnOKComplete.Text = "OK";
            btnOKComplete.UseVisualStyleBackColor = true;
            btnOKComplete.Click += btnOKComplete_Click;
            // 
            // btnCancelarComplete
            // 
            btnCancelarComplete.Location = new Point(93, 65);
            btnCancelarComplete.Name = "btnCancelarComplete";
            btnCancelarComplete.Size = new Size(75, 23);
            btnCancelarComplete.TabIndex = 2;
            btnCancelarComplete.Text = "Cancelar";
            btnCancelarComplete.UseVisualStyleBackColor = true;
            btnCancelarComplete.Click += btnCancelarComplete_Click;
            // 
            // txtRespostaComplete
            // 
            txtRespostaComplete.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRespostaComplete.Location = new Point(12, 36);
            txtRespostaComplete.Name = "txtRespostaComplete";
            txtRespostaComplete.Size = new Size(320, 23);
            txtRespostaComplete.TabIndex = 3;
            // 
            // frmExclusividadePrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 150);
            Controls.Add(txtRespostaComplete);
            Controls.Add(btnCancelarComplete);
            Controls.Add(btnOKComplete);
            Controls.Add(lblCompletar);
            Name = "frmExclusividadePrato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complete";
            Load += frmExclusividadePrato_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompletar;
        private Button btnOKComplete;
        private Button btnCancelarComplete;
        private TextBox txtRespostaComplete;
    }
}