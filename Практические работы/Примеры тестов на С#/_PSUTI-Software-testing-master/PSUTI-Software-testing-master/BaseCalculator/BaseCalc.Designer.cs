namespace BaseCalculator
{
    partial class BaseCalc
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
            this.bAnswer = new System.Windows.Forms.Button();
            this.bMC = new System.Windows.Forms.Button();
            this.bMPlus = new System.Windows.Forms.Button();
            this.bMR = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.bBackSpace = new System.Windows.Forms.Button();
            this.bEmpty = new System.Windows.Forms.Button();
            this.bLbrackets = new System.Windows.Forms.Button();
            this.bRbrackets = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMin = new System.Windows.Forms.Button();
            this.bMult = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.bPoint = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bPlusMinus = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnswer
            // 
            this.bAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bAnswer.ForeColor = System.Drawing.Color.Red;
            this.bAnswer.Location = new System.Drawing.Point(312, 299);
            this.bAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bAnswer.Name = "bAnswer";
            this.bAnswer.Size = new System.Drawing.Size(49, 36);
            this.bAnswer.TabIndex = 1;
            this.bAnswer.Text = "=";
            this.bAnswer.UseVisualStyleBackColor = true;
            this.bAnswer.Click += new System.EventHandler(this.bAnswer_Click);
            this.bAnswer.Leave += new System.EventHandler(this.bAnswer_Leave);
            // 
            // bMC
            // 
            this.bMC.ForeColor = System.Drawing.Color.Blue;
            this.bMC.Location = new System.Drawing.Point(312, 256);
            this.bMC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMC.Name = "bMC";
            this.bMC.Size = new System.Drawing.Size(49, 36);
            this.bMC.TabIndex = 67;
            this.bMC.Text = "MC";
            this.bMC.UseVisualStyleBackColor = true;
            this.bMC.Click += new System.EventHandler(this.bMC_Click);
            // 
            // bMPlus
            // 
            this.bMPlus.ForeColor = System.Drawing.Color.Blue;
            this.bMPlus.Location = new System.Drawing.Point(312, 213);
            this.bMPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMPlus.Name = "bMPlus";
            this.bMPlus.Size = new System.Drawing.Size(49, 36);
            this.bMPlus.TabIndex = 66;
            this.bMPlus.Text = "M+";
            this.bMPlus.UseVisualStyleBackColor = true;
            this.bMPlus.Click += new System.EventHandler(this.bMPlus_Click);
            // 
            // bMR
            // 
            this.bMR.ForeColor = System.Drawing.Color.Blue;
            this.bMR.Location = new System.Drawing.Point(312, 170);
            this.bMR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMR.Name = "bMR";
            this.bMR.Size = new System.Drawing.Size(49, 36);
            this.bMR.TabIndex = 65;
            this.bMR.Text = "MR";
            this.bMR.UseVisualStyleBackColor = true;
            this.bMR.Click += new System.EventHandler(this.bMR_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.bBackSpace);
            this.groupBoxEdit.Controls.Add(this.bEmpty);
            this.groupBoxEdit.Controls.Add(this.bLbrackets);
            this.groupBoxEdit.Controls.Add(this.bRbrackets);
            this.groupBoxEdit.Location = new System.Drawing.Point(16, 80);
            this.groupBoxEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEdit.Size = new System.Drawing.Size(345, 70);
            this.groupBoxEdit.TabIndex = 64;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Редактирование";
            // 
            // bBackSpace
            // 
            this.bBackSpace.ForeColor = System.Drawing.Color.Red;
            this.bBackSpace.Location = new System.Drawing.Point(165, 23);
            this.bBackSpace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bBackSpace.Name = "bBackSpace";
            this.bBackSpace.Size = new System.Drawing.Size(91, 36);
            this.bBackSpace.TabIndex = 36;
            this.bBackSpace.Text = "Стереть";
            this.bBackSpace.UseVisualStyleBackColor = true;
            this.bBackSpace.Click += new System.EventHandler(this.bBackSpace_Click);
            // 
            // bEmpty
            // 
            this.bEmpty.ForeColor = System.Drawing.Color.Red;
            this.bEmpty.Location = new System.Drawing.Point(267, 23);
            this.bEmpty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bEmpty.Name = "bEmpty";
            this.bEmpty.Size = new System.Drawing.Size(71, 36);
            this.bEmpty.TabIndex = 35;
            this.bEmpty.Text = "Сброс";
            this.bEmpty.UseVisualStyleBackColor = true;
            this.bEmpty.Click += new System.EventHandler(this.bEmpty_Click);
            // 
            // bLbrackets
            // 
            this.bLbrackets.Location = new System.Drawing.Point(8, 23);
            this.bLbrackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLbrackets.Name = "bLbrackets";
            this.bLbrackets.Size = new System.Drawing.Size(49, 36);
            this.bLbrackets.TabIndex = 34;
            this.bLbrackets.Text = "(";
            this.bLbrackets.UseVisualStyleBackColor = true;
            this.bLbrackets.Click += new System.EventHandler(this.bLbrackets_Click);
            // 
            // bRbrackets
            // 
            this.bRbrackets.Location = new System.Drawing.Point(65, 23);
            this.bRbrackets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRbrackets.Name = "bRbrackets";
            this.bRbrackets.Size = new System.Drawing.Size(49, 36);
            this.bRbrackets.TabIndex = 33;
            this.bRbrackets.Text = ")";
            this.bRbrackets.UseVisualStyleBackColor = true;
            this.bRbrackets.Click += new System.EventHandler(this.bRbrackets_Click);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bPlus.ForeColor = System.Drawing.Color.Red;
            this.bPlus.Location = new System.Drawing.Point(196, 299);
            this.bPlus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(49, 36);
            this.bPlus.TabIndex = 62;
            this.bPlus.TabStop = false;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMin
            // 
            this.bMin.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMin.ForeColor = System.Drawing.Color.Red;
            this.bMin.Location = new System.Drawing.Point(196, 256);
            this.bMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMin.Name = "bMin";
            this.bMin.Size = new System.Drawing.Size(49, 36);
            this.bMin.TabIndex = 61;
            this.bMin.TabStop = false;
            this.bMin.Text = "-";
            this.bMin.UseVisualStyleBackColor = true;
            this.bMin.Click += new System.EventHandler(this.bMin_Click);
            // 
            // bMult
            // 
            this.bMult.Font = new System.Drawing.Font("Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMult.ForeColor = System.Drawing.Color.Red;
            this.bMult.Location = new System.Drawing.Point(196, 213);
            this.bMult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bMult.Name = "bMult";
            this.bMult.Size = new System.Drawing.Size(49, 36);
            this.bMult.TabIndex = 60;
            this.bMult.TabStop = false;
            this.bMult.Text = "*";
            this.bMult.UseVisualStyleBackColor = true;
            this.bMult.Click += new System.EventHandler(this.bMult_Click);
            // 
            // bDiv
            // 
            this.bDiv.ForeColor = System.Drawing.Color.Red;
            this.bDiv.Location = new System.Drawing.Point(196, 170);
            this.bDiv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(49, 36);
            this.bDiv.TabIndex = 59;
            this.bDiv.TabStop = false;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = true;
            this.bDiv.Click += new System.EventHandler(this.bDiv_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(24, 170);
            this.b1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(49, 36);
            this.b1.TabIndex = 58;
            this.b1.TabStop = false;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // bPoint
            // 
            this.bPoint.ForeColor = System.Drawing.Color.Red;
            this.bPoint.Location = new System.Drawing.Point(139, 299);
            this.bPoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPoint.Name = "bPoint";
            this.bPoint.Size = new System.Drawing.Size(49, 36);
            this.bPoint.TabIndex = 57;
            this.bPoint.TabStop = false;
            this.bPoint.Text = "mod";
            this.bPoint.UseVisualStyleBackColor = true;
            this.bPoint.Click += new System.EventHandler(this.bPoint_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(81, 299);
            this.b0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(49, 36);
            this.b0.TabIndex = 56;
            this.b0.TabStop = false;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // bPlusMinus
            // 
            this.bPlusMinus.Location = new System.Drawing.Point(24, 299);
            this.bPlusMinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPlusMinus.Name = "bPlusMinus";
            this.bPlusMinus.Size = new System.Drawing.Size(49, 36);
            this.bPlusMinus.TabIndex = 55;
            this.bPlusMinus.TabStop = false;
            this.bPlusMinus.Text = "+/-";
            this.bPlusMinus.UseVisualStyleBackColor = true;
            this.bPlusMinus.Click += new System.EventHandler(this.bPlusMinus_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(139, 256);
            this.b9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(49, 36);
            this.b9.TabIndex = 54;
            this.b9.TabStop = false;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(81, 256);
            this.b8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(49, 36);
            this.b8.TabIndex = 53;
            this.b8.TabStop = false;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(24, 256);
            this.b7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(49, 36);
            this.b7.TabIndex = 52;
            this.b7.TabStop = false;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(139, 213);
            this.b6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(49, 36);
            this.b6.TabIndex = 51;
            this.b6.TabStop = false;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(81, 213);
            this.b5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(49, 36);
            this.b5.TabIndex = 50;
            this.b5.TabStop = false;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(24, 213);
            this.b4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(49, 36);
            this.b4.TabIndex = 49;
            this.b4.TabStop = false;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(139, 170);
            this.b3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(49, 36);
            this.b3.TabIndex = 48;
            this.b3.TabStop = false;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(81, 170);
            this.b2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(49, 36);
            this.b2.TabIndex = 47;
            this.b2.TabStop = false;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Результат";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(104, 48);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(256, 22);
            this.textBoxResult.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Выражение";
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(104, 16);
            this.textBoxExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(256, 22);
            this.textBoxExpression.TabIndex = 2;
            // 
            // BaseCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 334);
            this.Controls.Add(this.bAnswer);
            this.Controls.Add(this.bMC);
            this.Controls.Add(this.bMPlus);
            this.Controls.Add(this.bMR);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bMin);
            this.Controls.Add(this.bMult);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bPoint);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bPlusMinus);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(379, 381);
            this.Name = "BaseCalc";
            this.ShowIcon = false;
            this.Text = "Калькулятор (Базовая версия)";
            this.Load += new System.EventHandler(this.BaseCalc_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BaseCalc_KeyPress);
            this.groupBoxEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAnswer;
        private System.Windows.Forms.Button bMC;
        private System.Windows.Forms.Button bMPlus;
        private System.Windows.Forms.Button bMR;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Button bBackSpace;
        private System.Windows.Forms.Button bEmpty;
        private System.Windows.Forms.Button bLbrackets;
        private System.Windows.Forms.Button bRbrackets;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMin;
        private System.Windows.Forms.Button bMult;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button bPoint;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bPlusMinus;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxExpression;
    }
}

