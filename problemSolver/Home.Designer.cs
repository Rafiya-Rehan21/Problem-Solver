namespace problemSolver
{
    partial class Home
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
            this.problemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicMathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleCalcualtionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaVolumeCalculationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trignometryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.problemTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // problemTypeToolStripMenuItem
            // 
            this.problemTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicMathToolStripMenuItem,
            this.trignometryToolStripMenuItem});
            this.problemTypeToolStripMenuItem.Name = "problemTypeToolStripMenuItem";
            this.problemTypeToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.problemTypeToolStripMenuItem.Text = "Problem Calculator";
            // 
            // basicMathToolStripMenuItem
            // 
            this.basicMathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleCalcualtionsToolStripMenuItem,
            this.areaVolumeCalculationsToolStripMenuItem});
            this.basicMathToolStripMenuItem.Name = "basicMathToolStripMenuItem";
            this.basicMathToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.basicMathToolStripMenuItem.Text = "Basic Math";
            this.basicMathToolStripMenuItem.Click += new System.EventHandler(this.basicMathToolStripMenuItem_Click);
            // 
            // simpleCalcualtionsToolStripMenuItem
            // 
            this.simpleCalcualtionsToolStripMenuItem.Name = "simpleCalcualtionsToolStripMenuItem";
            this.simpleCalcualtionsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.simpleCalcualtionsToolStripMenuItem.Text = "Simple Calcualtions";
            this.simpleCalcualtionsToolStripMenuItem.Click += new System.EventHandler(this.simpleCalcualtionsToolStripMenuItem_Click);
            // 
            // areaVolumeCalculationsToolStripMenuItem
            // 
            this.areaVolumeCalculationsToolStripMenuItem.Name = "areaVolumeCalculationsToolStripMenuItem";
            this.areaVolumeCalculationsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.areaVolumeCalculationsToolStripMenuItem.Text = "Area/Volume Calculations";
            this.areaVolumeCalculationsToolStripMenuItem.Click += new System.EventHandler(this.areaVolumeCalculationsToolStripMenuItem_Click);
            // 
            // trignometryToolStripMenuItem
            // 
            this.trignometryToolStripMenuItem.Name = "trignometryToolStripMenuItem";
            this.trignometryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trignometryToolStripMenuItem.Text = "Trigonometry";
            this.trignometryToolStripMenuItem.Click += new System.EventHandler(this.trignometryToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(294, -1);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(170, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Problem Solver";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::problemSolver.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem problemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicMathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trignometryToolStripMenuItem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripMenuItem simpleCalcualtionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaVolumeCalculationsToolStripMenuItem;
    }
}

