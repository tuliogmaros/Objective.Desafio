namespace Objective.Desafio
{
    partial class frmQuestionarioPrato
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
            lblQualPrato = new Label();
            txtResposta = new TextBox();
            btnOKQuest = new Button();
            btnCancelarQuest = new Button();
            SuspendLayout();
            // 
            // lblQualPrato
            // 
            lblQualPrato.AutoSize = true;
            lblQualPrato.Location = new Point(12, 9);
            lblQualPrato.Name = "lblQualPrato";
            lblQualPrato.Size = new Size(138, 15);
            lblQualPrato.TabIndex = 0;
            lblQualPrato.Text = "Qual prato você pensou?";
            // 
            // txtResposta
            // 
            txtResposta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResposta.Location = new Point(12, 27);
            txtResposta.Name = "txtResposta";
            txtResposta.Size = new Size(282, 23);
            txtResposta.TabIndex = 1;
            // 
            // btnOKQuest
            // 
            btnOKQuest.Location = new Point(12, 56);
            btnOKQuest.Name = "btnOKQuest";
            btnOKQuest.Size = new Size(75, 23);
            btnOKQuest.TabIndex = 2;
            btnOKQuest.Text = "OK";
            btnOKQuest.UseVisualStyleBackColor = true;
            btnOKQuest.Click += btnOKQuest_Click;
            // 
            // btnCancelarQuest
            // 
            btnCancelarQuest.Location = new Point(93, 56);
            btnCancelarQuest.Name = "btnCancelarQuest";
            btnCancelarQuest.Size = new Size(75, 23);
            btnCancelarQuest.TabIndex = 3;
            btnCancelarQuest.Text = "Cancelar";
            btnCancelarQuest.UseVisualStyleBackColor = true;
            btnCancelarQuest.Click += btnCancelarQuest_Click;
            // 
            // frmQuestionarioPrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 109);
            Controls.Add(btnCancelarQuest);
            Controls.Add(btnOKQuest);
            Controls.Add(txtResposta);
            Controls.Add(lblQualPrato);
            Name = "frmQuestionarioPrato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JogoGourmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQualPrato;
        private TextBox txtResposta;
        private Button btnOKQuest;
        private Button btnCancelarQuest;
    }
}