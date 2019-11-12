namespace Text_process_translation
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitleTrans = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbTrans = new System.Windows.Forms.Label();
            this.lbUnTrans = new System.Windows.Forms.Label();
            this.lbTitleUnTrans = new System.Windows.Forms.Label();
            this.pbDone = new AltoControls.AltoPB();
            this.btnOpen = new AltoControls.AltoButton();
            this.pnLoading = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbNumtile = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "po";
            this.openFileDialog1.FileName = "United text.po";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pnLoading);
            this.panel1.Controls.Add(this.lbTitleTrans);
            this.panel1.Controls.Add(this.lbTrans);
            this.panel1.Controls.Add(this.lbNum);
            this.panel1.Controls.Add(this.lbUnTrans);
            this.panel1.Controls.Add(this.lbNumtile);
            this.panel1.Controls.Add(this.lbTitleUnTrans);
            this.panel1.Controls.Add(this.pbDone);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 132);
            this.panel1.TabIndex = 1;
            // 
            // lbTitleTrans
            // 
            this.lbTitleTrans.AutoSize = true;
            this.lbTitleTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(27)))));
            this.lbTitleTrans.Location = new System.Drawing.Point(249, 91);
            this.lbTitleTrans.Name = "lbTitleTrans";
            this.lbTitleTrans.Size = new System.Drawing.Size(243, 24);
            this.lbTitleTrans.TabIndex = 6;
            this.lbTitleTrans.Text = "Number of translated text";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Salmon;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(547, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(28, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbTrans
            // 
            this.lbTrans.AutoSize = true;
            this.lbTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(83)))), ((int)(((byte)(27)))));
            this.lbTrans.Location = new System.Drawing.Point(520, 91);
            this.lbTrans.Name = "lbTrans";
            this.lbTrans.Size = new System.Drawing.Size(21, 24);
            this.lbTrans.TabIndex = 4;
            this.lbTrans.Text = "0";
            // 
            // lbUnTrans
            // 
            this.lbUnTrans.AutoSize = true;
            this.lbUnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbUnTrans.ForeColor = System.Drawing.Color.Brown;
            this.lbUnTrans.Location = new System.Drawing.Point(520, 67);
            this.lbUnTrans.Name = "lbUnTrans";
            this.lbUnTrans.Size = new System.Drawing.Size(21, 24);
            this.lbUnTrans.TabIndex = 4;
            this.lbUnTrans.Text = "0";
            // 
            // lbTitleUnTrans
            // 
            this.lbTitleUnTrans.AutoSize = true;
            this.lbTitleUnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitleUnTrans.ForeColor = System.Drawing.Color.Brown;
            this.lbTitleUnTrans.Location = new System.Drawing.Point(249, 67);
            this.lbTitleUnTrans.Name = "lbTitleUnTrans";
            this.lbTitleUnTrans.Size = new System.Drawing.Size(261, 24);
            this.lbTitleUnTrans.TabIndex = 3;
            this.lbTitleUnTrans.Text = "Number of un translate text";
            // 
            // pbDone
            // 
            this.pbDone.ForeColor = System.Drawing.Color.LimeGreen;
            this.pbDone.Location = new System.Drawing.Point(12, 84);
            this.pbDone.MaxValue = 100;
            this.pbDone.MinValue = 0;
            this.pbDone.Name = "pbDone";
            this.pbDone.ProgressColor = System.Drawing.Color.LightBlue;
            this.pbDone.Size = new System.Drawing.Size(231, 31);
            this.pbDone.TabIndex = 1;
            this.pbDone.Text = "pbTransProcess";
            this.pbDone.Value = 0;
            // 
            // btnOpen
            // 
            this.btnOpen.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btnOpen.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(237)))), ((int)(((byte)(235)))));
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOpen.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            this.btnOpen.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(252)))));
            this.btnOpen.Location = new System.Drawing.Point(12, 47);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Radius = 10;
            this.btnOpen.Size = new System.Drawing.Size(231, 31);
            this.btnOpen.Stroke = false;
            this.btnOpen.StrokeColor = System.Drawing.Color.Gray;
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File";
            this.btnOpen.Transparency = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnLoading
            // 
            this.pnLoading.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnLoading.Controls.Add(this.btnExit);
            this.pnLoading.Controls.Add(this.lbTitle);
            this.pnLoading.Location = new System.Drawing.Point(0, 0);
            this.pnLoading.Name = "pnLoading";
            this.pnLoading.Size = new System.Drawing.Size(587, 30);
            this.pnLoading.TabIndex = 7;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(91, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(380, 24);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "CHECK THE TRANSLATION PROCESS";
            // 
            // lbNumtile
            // 
            this.lbNumtile.AutoSize = true;
            this.lbNumtile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNumtile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.lbNumtile.Location = new System.Drawing.Point(249, 43);
            this.lbNumtile.Name = "lbNumtile";
            this.lbNumtile.Size = new System.Drawing.Size(147, 24);
            this.lbNumtile.TabIndex = 3;
            this.lbNumtile.Text = "Number of text";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(26)))), ((int)(((byte)(95)))));
            this.lbNum.Location = new System.Drawing.Point(520, 43);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(21, 24);
            this.lbNum.TabIndex = 4;
            this.lbNum.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 132);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnLoading.ResumeLayout(false);
            this.pnLoading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private AltoControls.AltoButton btnOpen;
        private AltoControls.AltoPB pbDone;
        private System.Windows.Forms.Label lbUnTrans;
        private System.Windows.Forms.Label lbTitleUnTrans;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbTitleTrans;
        private System.Windows.Forms.Label lbTrans;
        private System.Windows.Forms.Panel pnLoading;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbNum;
        private System.Windows.Forms.Label lbNumtile;
    }
}

