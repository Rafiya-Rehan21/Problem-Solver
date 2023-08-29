using System;
using System.Collections.Generic;
using System.Windows.Forms;
using problemSolver.BL;

namespace problemSolver
{
    public partial class Area_VolumeCalculations : Form
    {
        private Shape currentShape = null;

        public Area_VolumeCalculations()
        {
            InitializeComponent();
        }

        private void Area_VolumeCalculations_Load(object sender, EventArgs e)
        {
            List<Type> shapes = new List<Type> { 
                typeof(Circle), typeof(Cone), typeof(Cylinder), typeof(Parallelogram), typeof(BL.Rectangle), typeof(Square), typeof(Trapezium), typeof(Triangle) 
            };

            cbxShape.DataSource = shapes;
            cbxShape.DisplayMember = "Name";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < pnlParameters.RowCount; row++)
            {
                Label lbl = (Label)pnlParameters.GetControlFromPosition(0, row);
                NumericUpDown num = (NumericUpDown)pnlParameters.GetControlFromPosition(1, row);

                currentShape.SetParameter(lbl.Text.Substring(0, lbl.Text.Length - 1), (float)num.Value);
            }

            txtDisplay.Text = $"Area: {currentShape.calcualteArea()}, Volume: {currentShape.calcualteVolume()}";
        }

        private void cbxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShape = (Shape)Activator.CreateInstance((Type)cbxShape.SelectedItem);

            pnlParameters.Visible = false;
            pnlParameters.RowCount = 0;
            pnlParameters.RowStyles.Clear();
            pnlParameters.Controls.Clear();

            foreach (string parameter in currentShape.GetParameters())
            {
                pnlParameters.RowCount++;
                pnlParameters.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                pnlParameters.Controls.Add(new Label() { Text = parameter + ":", Anchor = AnchorStyles.Right }, 0, pnlParameters.RowCount - 1);
                pnlParameters.Controls.Add(new NumericUpDown() { Minimum = 0.01M, Maximum = 99999999, DecimalPlaces = 2, Anchor = AnchorStyles.Left }, 1, pnlParameters.RowCount - 1);
            }

            pnlParameters.Visible = true;
        }
    }
}
