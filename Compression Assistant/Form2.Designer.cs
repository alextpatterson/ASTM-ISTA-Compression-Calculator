namespace Compression_Assistant
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.RadioNo = new System.Windows.Forms.RadioButton();
            this.radioIDK = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.unknownAcceptBtn = new System.Windows.Forms.Button();
            this.boxHLab = new System.Windows.Forms.Label();
            this.boxHTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Will the product be warehoused during distribution?";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Checked = true;
            this.radioYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioYes.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioYes.Location = new System.Drawing.Point(39, 35);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(55, 24);
            this.radioYes.TabIndex = 1;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // RadioNo
            // 
            this.RadioNo.AutoSize = true;
            this.RadioNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioNo.ForeColor = System.Drawing.Color.DarkBlue;
            this.RadioNo.Location = new System.Drawing.Point(39, 65);
            this.RadioNo.Name = "RadioNo";
            this.RadioNo.Size = new System.Drawing.Size(47, 24);
            this.RadioNo.TabIndex = 2;
            this.RadioNo.Text = "No";
            this.RadioNo.UseVisualStyleBackColor = true;
            // 
            // radioIDK
            // 
            this.radioIDK.AutoSize = true;
            this.radioIDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioIDK.ForeColor = System.Drawing.Color.DarkBlue;
            this.radioIDK.Location = new System.Drawing.Point(39, 95);
            this.radioIDK.Name = "radioIDK";
            this.radioIDK.Size = new System.Drawing.Size(94, 24);
            this.radioIDK.TabIndex = 3;
            this.radioIDK.Text = "Unknown";
            this.radioIDK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.boxHTxt);
            this.panel1.Controls.Add(this.boxHLab);
            this.panel1.Controls.Add(this.unknownAcceptBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioIDK);
            this.panel1.Controls.Add(this.radioYes);
            this.panel1.Controls.Add(this.RadioNo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 211);
            this.panel1.TabIndex = 4;
            // 
            // unknownAcceptBtn
            // 
            this.unknownAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unknownAcceptBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.unknownAcceptBtn.Location = new System.Drawing.Point(154, 148);
            this.unknownAcceptBtn.Name = "unknownAcceptBtn";
            this.unknownAcceptBtn.Size = new System.Drawing.Size(130, 29);
            this.unknownAcceptBtn.TabIndex = 4;
            this.unknownAcceptBtn.Text = "Accept";
            this.unknownAcceptBtn.UseVisualStyleBackColor = true;
            this.unknownAcceptBtn.Click += new System.EventHandler(this.unknownAcceptBtn_Click);
            // 
            // boxHLab
            // 
            this.boxHLab.AutoSize = true;
            this.boxHLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHLab.ForeColor = System.Drawing.Color.DarkBlue;
            this.boxHLab.Location = new System.Drawing.Point(197, 95);
            this.boxHLab.Name = "boxHLab";
            this.boxHLab.Size = new System.Drawing.Size(87, 20);
            this.boxHLab.TabIndex = 5;
            this.boxHLab.Text = "Box Height";
            // 
            // boxHTxt
            // 
            this.boxHTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxHTxt.Location = new System.Drawing.Point(290, 92);
            this.boxHTxt.Name = "boxHTxt";
            this.boxHTxt.Size = new System.Drawing.Size(84, 26);
            this.boxHTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(380, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "in.";
            // 
            // Form2
            // 
            this.AcceptButton = this.unknownAcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(456, 235);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Box Number Unknown";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.RadioButton RadioNo;
        private System.Windows.Forms.RadioButton radioIDK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button unknownAcceptBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox boxHTxt;
        private System.Windows.Forms.Label boxHLab;
    }
}