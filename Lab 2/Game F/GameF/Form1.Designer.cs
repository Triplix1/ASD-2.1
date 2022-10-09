namespace GameF
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
            this.b00 = new System.Windows.Forms.Button();
            this.b20 = new System.Windows.Forms.Button();
            this.b10 = new System.Windows.Forms.Button();
            this.b11 = new System.Windows.Forms.Button();
            this.b21 = new System.Windows.Forms.Button();
            this.b01 = new System.Windows.Forms.Button();
            this.b12 = new System.Windows.Forms.Button();
            this.b22 = new System.Windows.Forms.Button();
            this.b02 = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.labelMoves = new System.Windows.Forms.Label();
            this.rbfs = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.Button();
            this.bfs = new System.Windows.Forms.Button();
            this.Iter = new System.Windows.Forms.Label();
            this.Angle = new System.Windows.Forms.Label();
            this.Checked = new System.Windows.Forms.Label();
            this.Successors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b00
            // 
            this.b00.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b00.Location = new System.Drawing.Point(143, 47);
            this.b00.Name = "b00";
            this.b00.Size = new System.Drawing.Size(68, 82);
            this.b00.TabIndex = 0;
            this.b00.TabStop = false;
            this.b00.Text = "F";
            this.b00.UseVisualStyleBackColor = true;
            this.b00.Click += new System.EventHandler(this.button1_Click);
            // 
            // b20
            // 
            this.b20.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b20.Location = new System.Drawing.Point(143, 223);
            this.b20.Name = "b20";
            this.b20.Size = new System.Drawing.Size(68, 82);
            this.b20.TabIndex = 2;
            this.b20.TabStop = false;
            this.b20.Text = "F";
            this.b20.UseVisualStyleBackColor = true;
            this.b20.Click += new System.EventHandler(this.button1_Click);
            // 
            // b10
            // 
            this.b10.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b10.Location = new System.Drawing.Point(143, 135);
            this.b10.Name = "b10";
            this.b10.Size = new System.Drawing.Size(68, 82);
            this.b10.TabIndex = 3;
            this.b10.TabStop = false;
            this.b10.Text = "F";
            this.b10.UseVisualStyleBackColor = true;
            this.b10.Click += new System.EventHandler(this.button1_Click);
            // 
            // b11
            // 
            this.b11.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b11.Location = new System.Drawing.Point(217, 135);
            this.b11.Name = "b11";
            this.b11.Size = new System.Drawing.Size(68, 82);
            this.b11.TabIndex = 7;
            this.b11.TabStop = false;
            this.b11.Text = "F";
            this.b11.UseVisualStyleBackColor = true;
            this.b11.Click += new System.EventHandler(this.button1_Click);
            // 
            // b21
            // 
            this.b21.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b21.Location = new System.Drawing.Point(217, 223);
            this.b21.Name = "b21";
            this.b21.Size = new System.Drawing.Size(68, 82);
            this.b21.TabIndex = 6;
            this.b21.TabStop = false;
            this.b21.Text = "F";
            this.b21.UseVisualStyleBackColor = true;
            this.b21.Click += new System.EventHandler(this.button1_Click);
            // 
            // b01
            // 
            this.b01.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b01.Location = new System.Drawing.Point(217, 47);
            this.b01.Name = "b01";
            this.b01.Size = new System.Drawing.Size(68, 82);
            this.b01.TabIndex = 4;
            this.b01.TabStop = false;
            this.b01.Text = "F";
            this.b01.UseVisualStyleBackColor = true;
            this.b01.Click += new System.EventHandler(this.button1_Click);
            // 
            // b12
            // 
            this.b12.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b12.Location = new System.Drawing.Point(291, 135);
            this.b12.Name = "b12";
            this.b12.Size = new System.Drawing.Size(68, 82);
            this.b12.TabIndex = 11;
            this.b12.TabStop = false;
            this.b12.Text = "F";
            this.b12.UseVisualStyleBackColor = true;
            this.b12.Click += new System.EventHandler(this.button1_Click);
            // 
            // b22
            // 
            this.b22.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b22.Location = new System.Drawing.Point(291, 223);
            this.b22.Name = "b22";
            this.b22.Size = new System.Drawing.Size(68, 82);
            this.b22.TabIndex = 10;
            this.b22.TabStop = false;
            this.b22.Text = "F";
            this.b22.UseVisualStyleBackColor = true;
            this.b22.Click += new System.EventHandler(this.button1_Click);
            // 
            // b02
            // 
            this.b02.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b02.Location = new System.Drawing.Point(291, 47);
            this.b02.Name = "b02";
            this.b02.Size = new System.Drawing.Size(68, 82);
            this.b02.TabIndex = 8;
            this.b02.TabStop = false;
            this.b02.Text = "F";
            this.b02.UseVisualStyleBackColor = true;
            this.b02.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonstart.Location = new System.Drawing.Point(200, 311);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(107, 34);
            this.buttonstart.TabIndex = 16;
            this.buttonstart.TabStop = false;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.button16_Click);
            // 
            // labelMoves
            // 
            this.labelMoves.Location = new System.Drawing.Point(217, 9);
            this.labelMoves.Name = "labelMoves";
            this.labelMoves.Size = new System.Drawing.Size(81, 25);
            this.labelMoves.TabIndex = 17;
            this.labelMoves.Text = "Welcome";
            this.labelMoves.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rbfs
            // 
            this.rbfs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbfs.Location = new System.Drawing.Point(312, 356);
            this.rbfs.Name = "rbfs";
            this.rbfs.Size = new System.Drawing.Size(105, 36);
            this.rbfs.TabIndex = 16;
            this.rbfs.TabStop = false;
            this.rbfs.Text = "RBFS";
            this.rbfs.UseVisualStyleBackColor = true;
            this.rbfs.Click += new System.EventHandler(this.rbfs_Click);
            // 
            // Step
            // 
            this.Step.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Step.Location = new System.Drawing.Point(200, 356);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(107, 36);
            this.Step.TabIndex = 18;
            this.Step.Text = "Step";
            this.Step.UseVisualStyleBackColor = true;
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // bfs
            // 
            this.bfs.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bfs.Location = new System.Drawing.Point(89, 357);
            this.bfs.Name = "bfs";
            this.bfs.Size = new System.Drawing.Size(105, 36);
            this.bfs.TabIndex = 19;
            this.bfs.Text = "BFS";
            this.bfs.UseVisualStyleBackColor = true;
            this.bfs.Click += new System.EventHandler(this.bfs_Click);
            // 
            // Iter
            // 
            this.Iter.Location = new System.Drawing.Point(12, 9);
            this.Iter.Name = "Iter";
            this.Iter.Size = new System.Drawing.Size(81, 25);
            this.Iter.TabIndex = 20;
            this.Iter.Text = "Iterations";
            this.Iter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Angle
            // 
            this.Angle.Location = new System.Drawing.Point(12, 47);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(81, 25);
            this.Angle.TabIndex = 21;
            this.Angle.Text = "Angles";
            this.Angle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Checked
            // 
            this.Checked.Location = new System.Drawing.Point(12, 80);
            this.Checked.Name = "Checked";
            this.Checked.Size = new System.Drawing.Size(81, 25);
            this.Checked.TabIndex = 22;
            this.Checked.Text = "Checked";
            this.Checked.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Successors
            // 
            this.Successors.Location = new System.Drawing.Point(12, 125);
            this.Successors.Name = "Successors";
            this.Successors.Size = new System.Drawing.Size(81, 25);
            this.Successors.TabIndex = 23;
            this.Successors.Text = "Successors";
            this.Successors.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 453);
            this.Controls.Add(this.Successors);
            this.Controls.Add(this.Checked);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.Iter);
            this.Controls.Add(this.bfs);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.rbfs);
            this.Controls.Add(this.labelMoves);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.b12);
            this.Controls.Add(this.b22);
            this.Controls.Add(this.b02);
            this.Controls.Add(this.b11);
            this.Controls.Add(this.b21);
            this.Controls.Add(this.b01);
            this.Controls.Add(this.b10);
            this.Controls.Add(this.b20);
            this.Controls.Add(this.b00);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game F";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b00;
        private System.Windows.Forms.Button b20;
        private System.Windows.Forms.Button b10;
        private System.Windows.Forms.Button b11;
        private System.Windows.Forms.Button b21;
        private System.Windows.Forms.Button b01;
        private System.Windows.Forms.Button b12;
        private System.Windows.Forms.Button b22;
        private System.Windows.Forms.Button b02;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Label labelMoves;
        private System.Windows.Forms.Button rbfs;
        private System.Windows.Forms.Button Step;
        private System.Windows.Forms.Button bfs;
        private System.Windows.Forms.Label Iter;
        private System.Windows.Forms.Label Angle;
        private System.Windows.Forms.Label Checked;
        private System.Windows.Forms.Label Successors;
    }
}
