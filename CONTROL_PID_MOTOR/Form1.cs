using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace CONTROL_PID_MOTOR
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        double kp = 0, ki = 0, kd = 0;
        int simTime = 50, inputTheta=50;
        LineItem outputCurve, errorCurve, mCurve;
        PointPairList outputList, errorList, inputList;
        const double a = 0.3679, b = 0.2642, c = 1.368;
        private void pCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            pSlider.Enabled = pCheckBox.Checked;
            if (!pCheckBox.Checked)
            {
                kp = 0;
                pCheckBox.Text = "Kp: 0";
                pSlider.Value = 0;
            }
        }

        private void pSlider_Scroll(object sender, ScrollEventArgs e)
        {
            kp = pSlider.Value * 0.1;
            pCheckBox.Text = "Kp: " + kp.ToString();
            drawPlot();
        }

        private void iCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            iSlider.Enabled = iCheckBox.Checked;
            if (!iCheckBox.Checked)
            {
                ki = 0;
                iCheckBox.Text = "Ki: 0";
                iSlider.Value = 0;
            }
        }

        private void iSlider_Scroll(object sender, ScrollEventArgs e)
        {
            ki = iSlider.Value * 0.1;
            iCheckBox.Text = "Ki: " + ki.ToString();
            drawPlot();
        }

        private void dCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dSlider.Enabled = dCheckBox.Checked;
            if(!dCheckBox.Checked)
            {
                kd = 0;
                dCheckBox.Text = "Kd: 0";
                dSlider.Value = 0;
            }
        }

        private void dSlider_Scroll(object sender, ScrollEventArgs e)
        {
            kd = dSlider.Value * 0.1;
            dCheckBox.Text = "Kd: " + kd.ToString();
            drawPlot();
        }


        private void simTimeSlider_Scroll(object sender, ScrollEventArgs e)
        {
            simTime = simTimeSlider.Value;
            simTimeLabel.Text = "simulation time: "+simTime.ToString();
            drawPlot();
        }

        private void inputSlider_Scroll(object sender, ScrollEventArgs e)
        {
            inputTheta = angleSlider.Value;
            motorAngleLabel.Text = "motor reference angle: " + inputTheta.ToString();
            drawPlot();
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            outputCurve.Clear(); //y
            errorCurve.Clear();  //e
            mCurve.Clear();  //m

            outputCurve.AddPoint(0, 0); 
            outputCurve.AddPoint(1, 0);

            errorCurve.AddPoint(0, 0);
            errorCurve.AddPoint(1, 0);

            mCurve.AddPoint(0, 0);
            mCurve.AddPoint(1, 0);


            int i = 2;
            int inp = 0;
            while (i !=simTime)
            {
                double y =a * mCurve[i - 1].Y + b * mCurve[i - 2].Y - a * outputCurve[i - 2].Y + c * outputCurve[i - 1].Y;
                double err = inp - y;
                double m = err * (kp + ki + kd) - (kp + 2 * kd) * errorCurve[i - 1].Y + kd * errorCurve[i - 2].Y + mCurve[i - 1].Y;

                outputCurve.AddPoint(i, y);
                errorCurve.AddPoint(i, err);
                mCurve.AddPoint(i, m);

                i++;
                inp = angleSlider.Value;
                currentMotorThetaLabel.Text = "motor angle: "+ Math.Round (y,4).ToString();
            }
            outputGraphControl.AxisChange();
            outputGraphControl.Refresh();

        }

        void drawPlot()
        {
            outputCurve.Clear(); //y
            errorCurve.Clear();  //e
            mCurve.Clear();  //m

            outputCurve.AddPoint(0, 0);
            outputCurve.AddPoint(1, 0);

            errorCurve.AddPoint(0, 0);
            errorCurve.AddPoint(1, 0);

            mCurve.AddPoint(0, 0);
            mCurve.AddPoint(1, 0);

            double peak = 0;
            int i = 2;
            int inp = 0;
            while (i != simTime)
            {
                double y = a * mCurve[i - 1].Y + b * mCurve[i - 2].Y - a * outputCurve[i - 2].Y + c * outputCurve[i - 1].Y;
                double err = inp - y;
                double m = err * (kp + ki + kd) - (kp + 2 * kd) * errorCurve[i - 1].Y + kd * errorCurve[i - 2].Y + mCurve[i - 1].Y;

                outputCurve.AddPoint(i, y);
                errorCurve.AddPoint(i, err);
                mCurve.AddPoint(i, m);

                i++;
                inp = angleSlider.Value;
                currentMotorThetaLabel.Text = "motor angle: " + Math.Round(y, 4).ToString();
                if (y > peak)
                    peak = y;
            }
            outputGraphControl.AxisChange();
            outputGraphControl.Refresh();
            peakLabel.Text = "Peak value: "+ Math.Round(peak, 4).ToString();
        }

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane myPane = outputGraphControl.GraphPane;
            myPane.Title.Text = "Output and Error relation vs time";
            myPane.XAxis.Title.Text = "Seconds";
            myPane.YAxis.Title.Text = "X-Axis";

            outputCurve = myPane.AddCurve("Output", outputList, Color.Green, SymbolType.Star);

            errorCurve = myPane.AddCurve("Error", errorList, Color.Red, SymbolType.Star);

            mCurve = myPane.AddCurve("Controller output", inputList, Color.Blue, SymbolType.Star);
        }
    }
}
