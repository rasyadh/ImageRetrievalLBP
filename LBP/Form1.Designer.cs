namespace LBP
{
    partial class LBP
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SelectedPic = new System.Windows.Forms.PictureBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnExtract = new System.Windows.Forms.Button();
            this.BtnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputPic1 = new System.Windows.Forms.PictureBox();
            this.OutputPic2 = new System.Windows.Forms.PictureBox();
            this.OutputPic3 = new System.Windows.Forms.PictureBox();
            this.OutputPic4 = new System.Windows.Forms.PictureBox();
            this.OutputPic5 = new System.Windows.Forms.PictureBox();
            this.OutputPic10 = new System.Windows.Forms.PictureBox();
            this.OutputPic9 = new System.Windows.Forms.PictureBox();
            this.OutputPic8 = new System.Windows.Forms.PictureBox();
            this.OutputPic7 = new System.Windows.Forms.PictureBox();
            this.OutputPic6 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Image";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 43);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 41;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SelectedPic
            // 
            this.SelectedPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectedPic.Location = new System.Drawing.Point(361, 43);
            this.SelectedPic.Name = "SelectedPic";
            this.SelectedPic.Size = new System.Drawing.Size(160, 160);
            this.SelectedPic.TabIndex = 2;
            this.SelectedPic.TabStop = false;
            // 
            // BtnLoad
            // 
            this.BtnLoad.Location = new System.Drawing.Point(198, 71);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(125, 30);
            this.BtnLoad.TabIndex = 3;
            this.BtnLoad.Text = "Load Image";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnExtract
            // 
            this.BtnExtract.Location = new System.Drawing.Point(198, 107);
            this.BtnExtract.Name = "BtnExtract";
            this.BtnExtract.Size = new System.Drawing.Size(125, 30);
            this.BtnExtract.TabIndex = 4;
            this.BtnExtract.Text = "Extract Feature";
            this.BtnExtract.UseVisualStyleBackColor = true;
            this.BtnExtract.Click += new System.EventHandler(this.BtnExtract_Click);
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(198, 143);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(125, 30);
            this.BtnFind.TabIndex = 5;
            this.BtnFind.Text = "Find Similiar Image";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output";
            // 
            // OutputPic1
            // 
            this.OutputPic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic1.Location = new System.Drawing.Point(40, 248);
            this.OutputPic1.Name = "OutputPic1";
            this.OutputPic1.Size = new System.Drawing.Size(140, 140);
            this.OutputPic1.TabIndex = 7;
            this.OutputPic1.TabStop = false;
            // 
            // OutputPic2
            // 
            this.OutputPic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic2.Location = new System.Drawing.Point(186, 248);
            this.OutputPic2.Name = "OutputPic2";
            this.OutputPic2.Size = new System.Drawing.Size(140, 140);
            this.OutputPic2.TabIndex = 8;
            this.OutputPic2.TabStop = false;
            // 
            // OutputPic3
            // 
            this.OutputPic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic3.Location = new System.Drawing.Point(332, 248);
            this.OutputPic3.Name = "OutputPic3";
            this.OutputPic3.Size = new System.Drawing.Size(140, 140);
            this.OutputPic3.TabIndex = 9;
            this.OutputPic3.TabStop = false;
            // 
            // OutputPic4
            // 
            this.OutputPic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic4.Location = new System.Drawing.Point(478, 248);
            this.OutputPic4.Name = "OutputPic4";
            this.OutputPic4.Size = new System.Drawing.Size(140, 140);
            this.OutputPic4.TabIndex = 10;
            this.OutputPic4.TabStop = false;
            // 
            // OutputPic5
            // 
            this.OutputPic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic5.Location = new System.Drawing.Point(624, 248);
            this.OutputPic5.Name = "OutputPic5";
            this.OutputPic5.Size = new System.Drawing.Size(140, 140);
            this.OutputPic5.TabIndex = 11;
            this.OutputPic5.TabStop = false;
            // 
            // OutputPic10
            // 
            this.OutputPic10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic10.Location = new System.Drawing.Point(624, 394);
            this.OutputPic10.Name = "OutputPic10";
            this.OutputPic10.Size = new System.Drawing.Size(140, 140);
            this.OutputPic10.TabIndex = 16;
            this.OutputPic10.TabStop = false;
            // 
            // OutputPic9
            // 
            this.OutputPic9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic9.Location = new System.Drawing.Point(478, 394);
            this.OutputPic9.Name = "OutputPic9";
            this.OutputPic9.Size = new System.Drawing.Size(140, 140);
            this.OutputPic9.TabIndex = 15;
            this.OutputPic9.TabStop = false;
            // 
            // OutputPic8
            // 
            this.OutputPic8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic8.Location = new System.Drawing.Point(332, 394);
            this.OutputPic8.Name = "OutputPic8";
            this.OutputPic8.Size = new System.Drawing.Size(140, 140);
            this.OutputPic8.TabIndex = 14;
            this.OutputPic8.TabStop = false;
            // 
            // OutputPic7
            // 
            this.OutputPic7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic7.Location = new System.Drawing.Point(186, 394);
            this.OutputPic7.Name = "OutputPic7";
            this.OutputPic7.Size = new System.Drawing.Size(140, 140);
            this.OutputPic7.TabIndex = 13;
            this.OutputPic7.TabStop = false;
            // 
            // OutputPic6
            // 
            this.OutputPic6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputPic6.Location = new System.Drawing.Point(40, 394);
            this.OutputPic6.Name = "OutputPic6";
            this.OutputPic6.Size = new System.Drawing.Size(140, 140);
            this.OutputPic6.TabIndex = 12;
            this.OutputPic6.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "List Image";
            // 
            // LBP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 564);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutputPic10);
            this.Controls.Add(this.OutputPic9);
            this.Controls.Add(this.OutputPic8);
            this.Controls.Add(this.OutputPic7);
            this.Controls.Add(this.OutputPic6);
            this.Controls.Add(this.OutputPic5);
            this.Controls.Add(this.OutputPic4);
            this.Controls.Add(this.OutputPic3);
            this.Controls.Add(this.OutputPic2);
            this.Controls.Add(this.OutputPic1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.BtnExtract);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.SelectedPic);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "LBP";
            this.Text = "LBP";
            ((System.ComponentModel.ISupportInitialize)(this.SelectedPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputPic6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox SelectedPic;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnExtract;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox OutputPic1;
        private System.Windows.Forms.PictureBox OutputPic2;
        private System.Windows.Forms.PictureBox OutputPic3;
        private System.Windows.Forms.PictureBox OutputPic4;
        private System.Windows.Forms.PictureBox OutputPic5;
        private System.Windows.Forms.PictureBox OutputPic10;
        private System.Windows.Forms.PictureBox OutputPic9;
        private System.Windows.Forms.PictureBox OutputPic8;
        private System.Windows.Forms.PictureBox OutputPic7;
        private System.Windows.Forms.PictureBox OutputPic6;
        private System.Windows.Forms.Label label3;
    }
}

