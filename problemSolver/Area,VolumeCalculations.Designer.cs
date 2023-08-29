namespace problemSolver
{
    partial class Area_VolumeCalculations
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.cbxShape = new System.Windows.Forms.ComboBox();
            this.lblShape = new System.Windows.Forms.Label();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.pnlParameters = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(663, 161);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(70, 30);
            this.btnEnter.TabIndex = 29;
            this.btnEnter.Text = "Enter";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cbxShape
            // 
            this.cbxShape.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxShape.FormattingEnabled = true;
            this.cbxShape.Location = new System.Drawing.Point(102, 70);
            this.cbxShape.Name = "cbxShape";
            this.cbxShape.Size = new System.Drawing.Size(148, 28);
            this.cbxShape.TabIndex = 34;
            this.cbxShape.SelectedIndexChanged += new System.EventHandler(this.cbxShape_SelectedIndexChanged);
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.BackColor = System.Drawing.Color.Transparent;
            this.lblShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShape.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShape.Location = new System.Drawing.Point(9, 69);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(87, 26);
            this.lblShape.TabIndex = 35;
            this.lblShape.Text = "Shape:";
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(355, 60);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(419, 38);
            this.txtDisplay.TabIndex = 36;
            // 
            // pnlParameters
            // 
            this.pnlParameters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.pnlParameters.ColumnCount = 2;
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlParameters.Location = new System.Drawing.Point(14, 154);
            this.pnlParameters.Name = "pnlParameters";
            this.pnlParameters.RowCount = 1;
            this.pnlParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlParameters.Size = new System.Drawing.Size(440, 293);
            this.pnlParameters.TabIndex = 37;
            this.pnlParameters.Visible = false;
            // 
            // Area_VolumeCalculations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::problemSolver.Properties.Resources.tg;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.pnlParameters);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.cbxShape);
            this.Controls.Add(this.btnEnter);
            this.Name = "Area_VolumeCalculations";
            this.Text = "Area_VolumeCalculations";
            this.Load += new System.EventHandler(this.Area_VolumeCalculations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cbxShape;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TableLayoutPanel pnlParameters;
    }
}