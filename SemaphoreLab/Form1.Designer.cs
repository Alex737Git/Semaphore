namespace SemaphoreLab
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
            this.lbCreatedThreads = new System.Windows.Forms.ListBox();
            this.lbWaitingThreads = new System.Windows.Forms.ListBox();
            this.lbWorkingThreads = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.nUDNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lCreatedThreads = new System.Windows.Forms.Label();
            this.lWaitingThreads = new System.Windows.Forms.Label();
            this.lWorkingThreads = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCreatedThreads
            // 
            this.lbCreatedThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCreatedThreads.FormattingEnabled = true;
            this.lbCreatedThreads.ItemHeight = 20;
            this.lbCreatedThreads.Location = new System.Drawing.Point(554, 37);
            this.lbCreatedThreads.Name = "lbCreatedThreads";
            this.lbCreatedThreads.Size = new System.Drawing.Size(218, 204);
            this.lbCreatedThreads.TabIndex = 0;
            this.lbCreatedThreads.DoubleClick += new System.EventHandler(this.lbCreatedThreads_DoubleClick);
            // 
            // lbWaitingThreads
            // 
            this.lbWaitingThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWaitingThreads.FormattingEnabled = true;
            this.lbWaitingThreads.ItemHeight = 20;
            this.lbWaitingThreads.Location = new System.Drawing.Point(292, 37);
            this.lbWaitingThreads.Name = "lbWaitingThreads";
            this.lbWaitingThreads.Size = new System.Drawing.Size(220, 204);
            this.lbWaitingThreads.TabIndex = 1;
            // 
            // lbWorkingThreads
            // 
            this.lbWorkingThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWorkingThreads.FormattingEnabled = true;
            this.lbWorkingThreads.ItemHeight = 20;
            this.lbWorkingThreads.Location = new System.Drawing.Point(25, 37);
            this.lbWorkingThreads.Name = "lbWorkingThreads";
            this.lbWorkingThreads.Size = new System.Drawing.Size(220, 204);
            this.lbWorkingThreads.TabIndex = 2;
            this.lbWorkingThreads.DoubleClick += new System.EventHandler(this.lbWorkingThreads_DoubleClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(292, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(480, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Creat Thread";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 379);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // nUDNumber
            // 
            this.nUDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nUDNumber.Location = new System.Drawing.Point(73, 321);
            this.nUDNumber.Name = "nUDNumber";
            this.nUDNumber.Size = new System.Drawing.Size(117, 34);
            this.nUDNumber.TabIndex = 5;
            this.nUDNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUDNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of places\r\nin the Semaphore";
            // 
            // lCreatedThreads
            // 
            this.lCreatedThreads.AutoSize = true;
            this.lCreatedThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCreatedThreads.Location = new System.Drawing.Point(608, 9);
            this.lCreatedThreads.Name = "lCreatedThreads";
            this.lCreatedThreads.Size = new System.Drawing.Size(134, 20);
            this.lCreatedThreads.TabIndex = 7;
            this.lCreatedThreads.Text = "Created Threads";
            // 
            // lWaitingThreads
            // 
            this.lWaitingThreads.AutoSize = true;
            this.lWaitingThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWaitingThreads.Location = new System.Drawing.Point(345, 9);
            this.lWaitingThreads.Name = "lWaitingThreads";
            this.lWaitingThreads.Size = new System.Drawing.Size(131, 20);
            this.lWaitingThreads.TabIndex = 8;
            this.lWaitingThreads.Text = "Waiting Threads";
            // 
            // lWorkingThreads
            // 
            this.lWorkingThreads.AutoSize = true;
            this.lWorkingThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lWorkingThreads.Location = new System.Drawing.Point(69, 9);
            this.lWorkingThreads.Name = "lWorkingThreads";
            this.lWorkingThreads.Size = new System.Drawing.Size(136, 20);
            this.lWorkingThreads.TabIndex = 9;
            this.lWorkingThreads.Text = "Working Threads";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 379);
            this.Controls.Add(this.lWorkingThreads);
            this.Controls.Add(this.lWaitingThreads);
            this.Controls.Add(this.lCreatedThreads);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nUDNumber);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbWorkingThreads);
            this.Controls.Add(this.lbWaitingThreads);
            this.Controls.Add(this.lbCreatedThreads);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nUDNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCreatedThreads;
        private System.Windows.Forms.ListBox lbWaitingThreads;
        private System.Windows.Forms.ListBox lbWorkingThreads;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.NumericUpDown nUDNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lCreatedThreads;
        private System.Windows.Forms.Label lWaitingThreads;
        private System.Windows.Forms.Label lWorkingThreads;
    }
}

