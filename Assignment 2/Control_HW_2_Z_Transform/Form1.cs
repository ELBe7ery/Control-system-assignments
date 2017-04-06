using MaterialSkin;
using MaterialSkin.Controls;
using MetroFramework.Controls;
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

namespace Control_HW_2_Z_Transform
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        inputSignal inSig = new inputSignal();
        PointPairList optArr, iptArr;
        double[] samplesArr;
        string tagClicked;
        double outputVal;
        LineItem outputCurve,inptCurve;

        public Form1()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red600, Primary.Red700, Primary.Red200, Accent.Blue400, TextShade.WHITE);
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);

            //Event handlers
            //--------------

            /* bar_MouseHover
             * Handels showing the current slider(s) value when mouse left button is released
            */

            mBar.MouseUp += bar_MouseHover;
            fBar.MouseUp += bar_MouseHover;
            sBar.MouseUp += bar_MouseHover;
            tsBar.MouseUp += bar_MouseHover;

            //-----------------------------------------
            /* bar_MouseHover
             * Handels showing the current slider(s) value when mouse enters them
            */

            mBar.MouseEnter += bar_MouseHover;
            fBar.MouseEnter += bar_MouseHover;
            sBar.MouseEnter += bar_MouseHover;
            tsBar.MouseEnter += bar_MouseHover;

            //-----------------------------------------
            /* updateInpSignal_bar
             * Handels updsating the inputSignal object attribute based on
               slider(s) when value is changed
            */

            mBar.ValueChanged += updateInpSignal_bar;
            fBar.ValueChanged += updateInpSignal_bar;
            sBar.ValueChanged += updateInpSignal_bar;
            tsBar.ValueChanged += updateInpSignal_bar;

            //-----------------------------------------
            /* updateInpSignal_radio
             * Handels updsating the inputSignal object attribute based on
               the current selected input radio button
            */

            stepCheck.Click += updateInpSignal_radio;
            sinCheck.Click += updateInpSignal_radio;
            rampCheck.Click += updateInpSignal_radio;
            impulseCheck.Click += updateInpSignal_radio;

            //doPlot
            plotButton.Click += doPlot;

        }
        //---------Event Hands. implementation---------

        private void updateInpSignal_radio(object sender, EventArgs e)
        {
            MaterialRadioButton sendButton = sender as MaterialRadioButton;
            tagClicked = sendButton.Text;
            inSig.init(tagClicked, mBar.Value, fBar.Value, sBar.Value);
        }

        private void updateInpSignal_bar(object sender, EventArgs e)
        {
            MetroTrackBar senderBar = sender as MetroTrackBar;
            inSig.init(tagClicked, mBar.Value, fBar.Value, sBar.Value);
        }

        private void bar_MouseHover(object sender, EventArgs e)
        {
            MetroTrackBar senderBar = sender as MetroTrackBar;
            metroToolTip1.SetToolTip(senderBar, senderBar.Value.ToString());
            
        }

        //-----------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphPane gPane = zedGraphControl1.GraphPane;
            gPane.Title.Text = "System Response";
            gPane.XAxis.Title.Text = "Time";
            gPane.YAxis.Title.Text = "Output";
            
            outputCurve = gPane.AddCurve("Time Response", optArr, Color.Black, SymbolType.None);
            outputCurve.Line.StepType = StepType.ForwardStep;
        }

        private void doPlot(object sender, EventArgs e)
        {
            string[] bElements = bTxt.Text.Split(',');
            string[] aElements = aTxt.Text.Split(',');
            int numSamples = Convert.ToInt32(samplesNumberTextField.Text);
            double samplingTime = 1.0 / tsBar.Value;
            int sampleNumber = 0;
            outputCurve.Clear();

            for (double i = 0; i < numSamples; i+= samplingTime)
            {
                outputVal = 0;
                for (int ib = 0; ib < bElements.Length; ib++)
                {
                    outputVal += Convert.ToDouble(bElements[ib]) * inSig[(sampleNumber - ib) * samplingTime];
                }
                for (int ia = 0; ia < aElements.Length; ia++)
                {
                    if (sampleNumber - ia - 1 >= 0)
                        outputVal -= Convert.ToDouble(aElements[ia]) * outputCurve[sampleNumber - ia - 1].Y;
                }
                outputCurve.AddPoint(i, outputVal);
                sampleNumber++;
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }
    }

}
