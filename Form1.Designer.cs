
namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.PictureBox();
            this.snakeTailTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tailTimer = new System.Windows.Forms.Timer(this.components);
            this.appleBox = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.head.Image = ((System.Drawing.Image)(resources.GetObject("head.Image")));
            this.head.Location = new System.Drawing.Point(238, 238);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(28, 28);
            this.head.TabIndex = 1;
            this.head.TabStop = false;
            this.head.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.head_PreviewKeyDown);
            // 
            // snakeTailTimer
            // 
            this.snakeTailTimer.Enabled = true;
            this.snakeTailTimer.Tick += new System.EventHandler(this.HandleEvents_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1803, 498);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // tailTimer
            // 
            this.tailTimer.Tick += new System.EventHandler(this.tailTimer_Tick);
            // 
            // appleBox
            // 
            this.appleBox.Image = ((System.Drawing.Image)(resources.GetObject("appleBox.Image")));
            this.appleBox.Location = new System.Drawing.Point(434, 42);
            this.appleBox.Name = "appleBox";
            this.appleBox.Size = new System.Drawing.Size(28, 28);
            this.appleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.appleBox.TabIndex = 3;
            this.appleBox.TabStop = false;
            this.appleBox.Click += new System.EventHandler(this.appleBox_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(6, 495);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(93, 36);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 531);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.appleBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.head);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox head;
        private System.Windows.Forms.Timer snakeTailTimer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tailTimer;
        private System.Windows.Forms.PictureBox appleBox;
        private System.Windows.Forms.Label scoreLabel;
    }
}

