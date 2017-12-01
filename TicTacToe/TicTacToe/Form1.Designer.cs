namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1Btn = new System.Windows.Forms.Button();
            this.A2Btn = new System.Windows.Forms.Button();
            this.A3Btn = new System.Windows.Forms.Button();
            this.B1Btn = new System.Windows.Forms.Button();
            this.B2Btn = new System.Windows.Forms.Button();
            this.B3Btn = new System.Windows.Forms.Button();
            this.C1Btn = new System.Windows.Forms.Button();
            this.C2Btn = new System.Windows.Forms.Button();
            this.C3Btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1Btn
            // 
            this.A1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1Btn.Location = new System.Drawing.Point(76, 124);
            this.A1Btn.Name = "A1Btn";
            this.A1Btn.Size = new System.Drawing.Size(200, 200);
            this.A1Btn.TabIndex = 1;
            this.A1Btn.UseVisualStyleBackColor = true;
            this.A1Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // A2Btn
            // 
            this.A2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2Btn.Location = new System.Drawing.Point(298, 124);
            this.A2Btn.Name = "A2Btn";
            this.A2Btn.Size = new System.Drawing.Size(200, 200);
            this.A2Btn.TabIndex = 1;
            this.A2Btn.UseVisualStyleBackColor = true;
            this.A2Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // A3Btn
            // 
            this.A3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3Btn.Location = new System.Drawing.Point(521, 124);
            this.A3Btn.Name = "A3Btn";
            this.A3Btn.Size = new System.Drawing.Size(200, 200);
            this.A3Btn.TabIndex = 1;
            this.A3Btn.UseVisualStyleBackColor = true;
            this.A3Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // B1Btn
            // 
            this.B1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1Btn.Location = new System.Drawing.Point(76, 348);
            this.B1Btn.Name = "B1Btn";
            this.B1Btn.Size = new System.Drawing.Size(200, 200);
            this.B1Btn.TabIndex = 1;
            this.B1Btn.UseVisualStyleBackColor = true;
            this.B1Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // B2Btn
            // 
            this.B2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2Btn.Location = new System.Drawing.Point(298, 348);
            this.B2Btn.Name = "B2Btn";
            this.B2Btn.Size = new System.Drawing.Size(200, 200);
            this.B2Btn.TabIndex = 1;
            this.B2Btn.UseVisualStyleBackColor = true;
            this.B2Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // B3Btn
            // 
            this.B3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3Btn.Location = new System.Drawing.Point(521, 348);
            this.B3Btn.Name = "B3Btn";
            this.B3Btn.Size = new System.Drawing.Size(200, 200);
            this.B3Btn.TabIndex = 1;
            this.B3Btn.UseVisualStyleBackColor = true;
            this.B3Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // C1Btn
            // 
            this.C1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1Btn.Location = new System.Drawing.Point(76, 581);
            this.C1Btn.Name = "C1Btn";
            this.C1Btn.Size = new System.Drawing.Size(200, 200);
            this.C1Btn.TabIndex = 1;
            this.C1Btn.UseVisualStyleBackColor = true;
            this.C1Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // C2Btn
            // 
            this.C2Btn.AccessibleDescription = "";
            this.C2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2Btn.Location = new System.Drawing.Point(298, 581);
            this.C2Btn.Name = "C2Btn";
            this.C2Btn.Size = new System.Drawing.Size(200, 200);
            this.C2Btn.TabIndex = 1;
            this.C2Btn.UseVisualStyleBackColor = true;
            this.C2Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // C3Btn
            // 
            this.C3Btn.AccessibleDescription = "";
            this.C3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3Btn.Location = new System.Drawing.Point(521, 581);
            this.C3Btn.Name = "C3Btn";
            this.C3Btn.Size = new System.Drawing.Size(200, 200);
            this.C3Btn.TabIndex = 1;
            this.C3Btn.UseVisualStyleBackColor = true;
            this.C3Btn.Click += new System.EventHandler(this.Button_Clicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 856);
            this.Controls.Add(this.C3Btn);
            this.Controls.Add(this.B3Btn);
            this.Controls.Add(this.A3Btn);
            this.Controls.Add(this.C2Btn);
            this.Controls.Add(this.B2Btn);
            this.Controls.Add(this.A2Btn);
            this.Controls.Add(this.C1Btn);
            this.Controls.Add(this.B1Btn);
            this.Controls.Add(this.A1Btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1Btn;
        private System.Windows.Forms.Button A2Btn;
        private System.Windows.Forms.Button A3Btn;
        private System.Windows.Forms.Button B1Btn;
        private System.Windows.Forms.Button B2Btn;
        private System.Windows.Forms.Button B3Btn;
        private System.Windows.Forms.Button C1Btn;
        private System.Windows.Forms.Button C2Btn;
        private System.Windows.Forms.Button C3Btn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

