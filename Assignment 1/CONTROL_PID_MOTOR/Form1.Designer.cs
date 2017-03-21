namespace CONTROL_PID_MOTOR
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
            this.pCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.iCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.dCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.outputGraphControl = new ZedGraph.ZedGraphControl();
            this.dSlider = new MetroFramework.Controls.MetroTrackBar();
            this.iSlider = new MetroFramework.Controls.MetroTrackBar();
            this.pSlider = new MetroFramework.Controls.MetroTrackBar();
            this.simTimeSlider = new MetroFramework.Controls.MetroTrackBar();
            this.simTimeLabel = new MaterialSkin.Controls.MaterialFlatButton();
            this.angleSlider = new MetroFramework.Controls.MetroTrackBar();
            this.motorAngleLabel = new MaterialSkin.Controls.MaterialFlatButton();
            this.currentMotorThetaLabel = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.peakLabel = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // pCheckBox
            // 
            this.pCheckBox.AutoSize = true;
            this.pCheckBox.Depth = 0;
            this.pCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.pCheckBox.Location = new System.Drawing.Point(280, 78);
            this.pCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.pCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.pCheckBox.Name = "pCheckBox";
            this.pCheckBox.Ripple = true;
            this.pCheckBox.Size = new System.Drawing.Size(61, 30);
            this.pCheckBox.TabIndex = 1;
            this.pCheckBox.Text = "Kp: 0";
            this.pCheckBox.UseVisualStyleBackColor = true;
            this.pCheckBox.CheckedChanged += new System.EventHandler(this.pCheckBox_CheckedChanged);
            // 
            // iCheckBox
            // 
            this.iCheckBox.AutoSize = true;
            this.iCheckBox.Depth = 0;
            this.iCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.iCheckBox.Location = new System.Drawing.Point(280, 115);
            this.iCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.iCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.iCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.iCheckBox.Name = "iCheckBox";
            this.iCheckBox.Ripple = true;
            this.iCheckBox.Size = new System.Drawing.Size(57, 30);
            this.iCheckBox.TabIndex = 2;
            this.iCheckBox.Text = "Ki: 0";
            this.iCheckBox.UseVisualStyleBackColor = true;
            this.iCheckBox.CheckedChanged += new System.EventHandler(this.iCheckBox_CheckedChanged);
            // 
            // dCheckBox
            // 
            this.dCheckBox.AutoSize = true;
            this.dCheckBox.Depth = 0;
            this.dCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.dCheckBox.Location = new System.Drawing.Point(280, 154);
            this.dCheckBox.Margin = new System.Windows.Forms.Padding(0);
            this.dCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.dCheckBox.Name = "dCheckBox";
            this.dCheckBox.Ripple = true;
            this.dCheckBox.Size = new System.Drawing.Size(61, 30);
            this.dCheckBox.TabIndex = 4;
            this.dCheckBox.Text = "Kd: 0";
            this.dCheckBox.UseVisualStyleBackColor = true;
            this.dCheckBox.CheckedChanged += new System.EventHandler(this.dCheckBox_CheckedChanged);
            // 
            // outputGraphControl
            // 
            this.outputGraphControl.Location = new System.Drawing.Point(12, 233);
            this.outputGraphControl.Name = "outputGraphControl";
            this.outputGraphControl.ScrollGrace = 0D;
            this.outputGraphControl.ScrollMaxX = 0D;
            this.outputGraphControl.ScrollMaxY = 0D;
            this.outputGraphControl.ScrollMaxY2 = 0D;
            this.outputGraphControl.ScrollMinX = 0D;
            this.outputGraphControl.ScrollMinY = 0D;
            this.outputGraphControl.ScrollMinY2 = 0D;
            this.outputGraphControl.Size = new System.Drawing.Size(1033, 396);
            this.outputGraphControl.TabIndex = 7;
            this.outputGraphControl.UseExtendedPrintDialog = true;
            // 
            // dSlider
            // 
            this.dSlider.BackColor = System.Drawing.Color.Transparent;
            this.dSlider.Enabled = false;
            this.dSlider.Location = new System.Drawing.Point(21, 161);
            this.dSlider.Name = "dSlider";
            this.dSlider.Size = new System.Drawing.Size(256, 23);
            this.dSlider.TabIndex = 5;
            this.dSlider.Text = "metroTrackBar3";
            this.dSlider.Value = 0;
            this.dSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dSlider_Scroll);
            // 
            // iSlider
            // 
            this.iSlider.BackColor = System.Drawing.Color.Transparent;
            this.iSlider.Enabled = false;
            this.iSlider.Location = new System.Drawing.Point(21, 115);
            this.iSlider.Name = "iSlider";
            this.iSlider.Size = new System.Drawing.Size(256, 23);
            this.iSlider.TabIndex = 3;
            this.iSlider.Text = "metroTrackBar2";
            this.iSlider.Value = 0;
            this.iSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.iSlider_Scroll);
            // 
            // pSlider
            // 
            this.pSlider.BackColor = System.Drawing.Color.Transparent;
            this.pSlider.Enabled = false;
            this.pSlider.Location = new System.Drawing.Point(21, 78);
            this.pSlider.Name = "pSlider";
            this.pSlider.Size = new System.Drawing.Size(256, 23);
            this.pSlider.TabIndex = 0;
            this.pSlider.Text = "metroTrackBar1";
            this.pSlider.Value = 0;
            this.pSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pSlider_Scroll);
            // 
            // simTimeSlider
            // 
            this.simTimeSlider.BackColor = System.Drawing.Color.Transparent;
            this.simTimeSlider.Location = new System.Drawing.Point(420, 105);
            this.simTimeSlider.Maximum = 150;
            this.simTimeSlider.Minimum = 10;
            this.simTimeSlider.Name = "simTimeSlider";
            this.simTimeSlider.Size = new System.Drawing.Size(256, 23);
            this.simTimeSlider.TabIndex = 10;
            this.simTimeSlider.Text = "metroTrackBar1";
            this.simTimeSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.simTimeSlider_Scroll);
            // 
            // simTimeLabel
            // 
            this.simTimeLabel.AutoSize = true;
            this.simTimeLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.simTimeLabel.Depth = 0;
            this.simTimeLabel.Enabled = false;
            this.simTimeLabel.Location = new System.Drawing.Point(420, 137);
            this.simTimeLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.simTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.simTimeLabel.Name = "simTimeLabel";
            this.simTimeLabel.Primary = false;
            this.simTimeLabel.Size = new System.Drawing.Size(151, 36);
            this.simTimeLabel.TabIndex = 12;
            this.simTimeLabel.Text = "simulation time: 50";
            this.simTimeLabel.UseVisualStyleBackColor = true;
            // 
            // angleSlider
            // 
            this.angleSlider.BackColor = System.Drawing.Color.Transparent;
            this.angleSlider.Location = new System.Drawing.Point(732, 105);
            this.angleSlider.Maximum = 180;
            this.angleSlider.Name = "angleSlider";
            this.angleSlider.Size = new System.Drawing.Size(256, 23);
            this.angleSlider.TabIndex = 14;
            this.angleSlider.Text = "metroTrackBar1";
            this.angleSlider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.inputSlider_Scroll);
            // 
            // motorAngleLabel
            // 
            this.motorAngleLabel.AutoSize = true;
            this.motorAngleLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.motorAngleLabel.Depth = 0;
            this.motorAngleLabel.Enabled = false;
            this.motorAngleLabel.Location = new System.Drawing.Point(732, 136);
            this.motorAngleLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.motorAngleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.motorAngleLabel.Name = "motorAngleLabel";
            this.motorAngleLabel.Primary = false;
            this.motorAngleLabel.Size = new System.Drawing.Size(207, 36);
            this.motorAngleLabel.TabIndex = 15;
            this.motorAngleLabel.Text = "motor reference angle: 50";
            this.motorAngleLabel.UseVisualStyleBackColor = true;
            // 
            // currentMotorThetaLabel
            // 
            this.currentMotorThetaLabel.AutoSize = true;
            this.currentMotorThetaLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.currentMotorThetaLabel.Depth = 0;
            this.currentMotorThetaLabel.Enabled = false;
            this.currentMotorThetaLabel.Location = new System.Drawing.Point(21, 188);
            this.currentMotorThetaLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.currentMotorThetaLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.currentMotorThetaLabel.Name = "currentMotorThetaLabel";
            this.currentMotorThetaLabel.Primary = false;
            this.currentMotorThetaLabel.Size = new System.Drawing.Size(122, 36);
            this.currentMotorThetaLabel.TabIndex = 16;
            this.currentMotorThetaLabel.Text = "motor angle: 0";
            this.currentMotorThetaLabel.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(13, 636);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(213, 36);
            this.materialFlatButton1.TabIndex = 17;
            this.materialFlatButton1.Text = "Control Assignment 1, 2017";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(420, 185);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(378, 36);
            this.materialFlatButton2.TabIndex = 18;
            this.materialFlatButton2.Text = "Move the sliders to observe the system response";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // peakLabel
            // 
            this.peakLabel.AutoSize = true;
            this.peakLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.peakLabel.Depth = 0;
            this.peakLabel.Enabled = false;
            this.peakLabel.Location = new System.Drawing.Point(245, 188);
            this.peakLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.peakLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.peakLabel.Name = "peakLabel";
            this.peakLabel.Primary = false;
            this.peakLabel.Size = new System.Drawing.Size(96, 36);
            this.peakLabel.TabIndex = 19;
            this.peakLabel.Text = "peak value: ";
            this.peakLabel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 687);
            this.Controls.Add(this.peakLabel);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.currentMotorThetaLabel);
            this.Controls.Add(this.motorAngleLabel);
            this.Controls.Add(this.angleSlider);
            this.Controls.Add(this.simTimeLabel);
            this.Controls.Add(this.simTimeSlider);
            this.Controls.Add(this.outputGraphControl);
            this.Controls.Add(this.dSlider);
            this.Controls.Add(this.dCheckBox);
            this.Controls.Add(this.iSlider);
            this.Controls.Add(this.iCheckBox);
            this.Controls.Add(this.pCheckBox);
            this.Controls.Add(this.pSlider);
            this.Name = "Form1";
            this.Text = "Control Assignment 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox pCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox iCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox dCheckBox;
        private ZedGraph.ZedGraphControl outputGraphControl;
        private MetroFramework.Controls.MetroTrackBar dSlider;
        private MetroFramework.Controls.MetroTrackBar iSlider;
        private MetroFramework.Controls.MetroTrackBar pSlider;
        private MetroFramework.Controls.MetroTrackBar simTimeSlider;
        private MaterialSkin.Controls.MaterialFlatButton simTimeLabel;
        private MetroFramework.Controls.MetroTrackBar angleSlider;
        private MaterialSkin.Controls.MaterialFlatButton motorAngleLabel;
        private MaterialSkin.Controls.MaterialFlatButton currentMotorThetaLabel;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton peakLabel;
    }
}

