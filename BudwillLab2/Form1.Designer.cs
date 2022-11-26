namespace BudwillLab2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupMultiplier = new System.Windows.Forms.GroupBox();
            this.txtMultiplier = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.lblStar = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.groupMultiplier.SuspendLayout();
            this.groupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupMultiplier
            // 
            this.groupMultiplier.Controls.Add(this.txtMultiplier);
            this.groupMultiplier.Controls.Add(this.txtNumber);
            this.groupMultiplier.Controls.Add(this.lblNumber);
            this.groupMultiplier.Controls.Add(this.btnCalculate);
            this.groupMultiplier.Controls.Add(this.btnReset);
            this.groupMultiplier.Controls.Add(this.lblMultiplier);
            this.groupMultiplier.Controls.Add(this.lblAnswer);
            this.groupMultiplier.Controls.Add(this.lblOutput);
            this.groupMultiplier.Location = new System.Drawing.Point(12, 26);
            this.groupMultiplier.Name = "groupMultiplier";
            this.groupMultiplier.Size = new System.Drawing.Size(263, 283);
            this.groupMultiplier.TabIndex = 0;
            this.groupMultiplier.TabStop = false;
            this.groupMultiplier.Text = "Multiplier";
            // 
            // txtMultiplier
            // 
            this.txtMultiplier.Location = new System.Drawing.Point(124, 109);
            this.txtMultiplier.Name = "txtMultiplier";
            this.txtMultiplier.Size = new System.Drawing.Size(100, 27);
            this.txtMultiplier.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(124, 57);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 27);
            this.txtNumber.TabIndex = 0;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(20, 65);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(71, 19);
            this.lblNumber.TabIndex = 8;
            this.lblNumber.Text = "Number:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 230);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(88, 42);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(148, 230);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 42);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(20, 117);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(78, 19);
            this.lblMultiplier.TabIndex = 6;
            this.lblMultiplier.Text = "Multiplier:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(20, 166);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(68, 19);
            this.lblAnswer.TabIndex = 0;
            this.lblAnswer.Text = "Answer:";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(124, 161);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 24);
            this.lblOutput.TabIndex = 2;
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.lblStar);
            this.groupInfo.Controls.Add(this.lblData);
            this.groupInfo.Controls.Add(this.btnPicture);
            this.groupInfo.Controls.Add(this.picStar);
            this.groupInfo.Controls.Add(this.btnExit);
            this.groupInfo.Controls.Add(this.btnData);
            this.groupInfo.Controls.Add(this.btnHide);
            this.groupInfo.Location = new System.Drawing.Point(299, 26);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(406, 283);
            this.groupInfo.TabIndex = 1;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Information";
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.Location = new System.Drawing.Point(180, 20);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(61, 19);
            this.lblStar.TabIndex = 14;
            this.lblStar.Text = "My Cat";
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(30, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(352, 182);
            this.lblData.TabIndex = 16;
            this.lblData.Text = "\r\n";
            this.lblData.Visible = false;
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(22, 230);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(88, 42);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // picStar
            // 
            this.picStar.Image = ((System.Drawing.Image)(resources.GetObject("picStar.Image")));
            this.picStar.Location = new System.Drawing.Point(30, 42);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(352, 182);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStar.TabIndex = 15;
            this.picStar.TabStop = false;
            this.picStar.Visible = false;
            this.picStar.Click += new System.EventHandler(this.picStar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(304, 230);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 42);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(116, 230);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(88, 42);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(210, 230);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(88, 42);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(717, 323);
            this.Controls.Add(this.groupInfo);
            this.Controls.Add(this.groupMultiplier);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Evan Budwill";
            this.groupMultiplier.ResumeLayout(false);
            this.groupMultiplier.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMultiplier;
        private System.Windows.Forms.TextBox txtMultiplier;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.Label lblData;
    }
}

