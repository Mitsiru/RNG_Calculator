namespace 운빨계산기_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTrialsText = new Label();
            lblPrabText = new Label();
            lblSucessText = new Label();
            txtProbability = new TextBox();
            nudTrials = new NumericUpDown();
            nudSuccesses = new NumericUpDown();
            lblResult = new Label();
            btnReset = new Button();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTrials).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSuccesses).BeginInit();
            SuspendLayout();
            // 
            // lblTrialsText
            // 
            lblTrialsText.AutoSize = true;
            lblTrialsText.Location = new Point(15, 21);
            lblTrialsText.Name = "lblTrialsText";
            lblTrialsText.Size = new Size(77, 20);
            lblTrialsText.TabIndex = 0;
            lblTrialsText.Text = "실행횟수 :";
            // 
            // lblPrabText
            // 
            lblPrabText.AutoSize = true;
            lblPrabText.Location = new Point(17, 56);
            lblPrabText.Name = "lblPrabText";
            lblPrabText.Size = new Size(75, 20);
            lblPrabText.TabIndex = 1;
            lblPrabText.Text = "확률 (%) :";
            lblPrabText.Click += label2_Click;
            // 
            // lblSucessText
            // 
            lblSucessText.AutoSize = true;
            lblSucessText.Location = new Point(15, 93);
            lblSucessText.Name = "lblSucessText";
            lblSucessText.Size = new Size(69, 20);
            lblSucessText.TabIndex = 2;
            lblSucessText.Text = "성공횟수";
            // 
            // txtProbability
            // 
            txtProbability.Location = new Point(156, 53);
            txtProbability.Name = "txtProbability";
            txtProbability.Size = new Size(150, 27);
            txtProbability.TabIndex = 3;
            // 
            // nudTrials
            // 
            nudTrials.Location = new Point(156, 19);
            nudTrials.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudTrials.Name = "nudTrials";
            nudTrials.Size = new Size(150, 27);
            nudTrials.TabIndex = 4;
            // 
            // nudSuccesses
            // 
            nudSuccesses.Location = new Point(156, 91);
            nudSuccesses.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            nudSuccesses.Name = "nudSuccesses";
            nudSuccesses.Size = new Size(150, 27);
            nudSuccesses.TabIndex = 5;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(15, 137);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 6;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(122, 191);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 7;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += button1_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(222, 191);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "확인";
            btnCalculate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 232);
            Controls.Add(btnCalculate);
            Controls.Add(btnReset);
            Controls.Add(lblResult);
            Controls.Add(nudSuccesses);
            Controls.Add(nudTrials);
            Controls.Add(txtProbability);
            Controls.Add(lblSucessText);
            Controls.Add(lblPrabText);
            Controls.Add(lblTrialsText);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "운빨계산기 V2.0";
            ((System.ComponentModel.ISupportInitialize)nudTrials).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSuccesses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTrialsText;
        private Label lblPrabText;
        private Label lblSucessText;
        private TextBox txtProbability;
        private NumericUpDown nudTrials;
        private NumericUpDown nudSuccesses;
        private Label lblResult;
        private Button btnReset;
        private Button btnCalculate;
    }
}
