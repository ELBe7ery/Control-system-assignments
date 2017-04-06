namespace Control_HW_2_Z_Transform
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.stepCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.sinCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.rampCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.impulseCheck = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.mBar = new MetroFramework.Controls.MetroTrackBar();
            this.fBar = new MetroFramework.Controls.MetroTrackBar();
            this.sBar = new MetroFramework.Controls.MetroTrackBar();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton4 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton5 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton6 = new MaterialSkin.Controls.MaterialFlatButton();
            this.bTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton7 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton8 = new MaterialSkin.Controls.MaterialFlatButton();
            this.aTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialFlatButton9 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tsBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.plotButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton10 = new MaterialSkin.Controls.MaterialFlatButton();
            this.samplesNumberTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 291);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(967, 329);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // stepCheck
            // 
            this.stepCheck.AutoSize = true;
            this.stepCheck.Depth = 0;
            this.stepCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.stepCheck.Location = new System.Drawing.Point(12, 132);
            this.stepCheck.Margin = new System.Windows.Forms.Padding(0);
            this.stepCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.stepCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.stepCheck.Name = "stepCheck";
            this.stepCheck.Ripple = true;
            this.stepCheck.Size = new System.Drawing.Size(57, 30);
            this.stepCheck.TabIndex = 1;
            this.stepCheck.TabStop = true;
            this.stepCheck.Tag = "Step";
            this.stepCheck.Text = "Step";
            this.stepCheck.UseVisualStyleBackColor = true;
            // 
            // sinCheck
            // 
            this.sinCheck.AutoSize = true;
            this.sinCheck.Depth = 0;
            this.sinCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.sinCheck.Location = new System.Drawing.Point(12, 162);
            this.sinCheck.Margin = new System.Windows.Forms.Padding(0);
            this.sinCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.sinCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.sinCheck.Name = "sinCheck";
            this.sinCheck.Ripple = true;
            this.sinCheck.Size = new System.Drawing.Size(48, 30);
            this.sinCheck.TabIndex = 2;
            this.sinCheck.TabStop = true;
            this.sinCheck.Tag = "Sin";
            this.sinCheck.Text = "Sin";
            this.sinCheck.UseVisualStyleBackColor = true;
            // 
            // rampCheck
            // 
            this.rampCheck.AutoSize = true;
            this.rampCheck.Depth = 0;
            this.rampCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.rampCheck.Location = new System.Drawing.Point(12, 192);
            this.rampCheck.Margin = new System.Windows.Forms.Padding(0);
            this.rampCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rampCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.rampCheck.Name = "rampCheck";
            this.rampCheck.Ripple = true;
            this.rampCheck.Size = new System.Drawing.Size(65, 30);
            this.rampCheck.TabIndex = 3;
            this.rampCheck.TabStop = true;
            this.rampCheck.Tag = "Ramp";
            this.rampCheck.Text = "Ramp";
            this.rampCheck.UseVisualStyleBackColor = true;
            // 
            // impulseCheck
            // 
            this.impulseCheck.AutoSize = true;
            this.impulseCheck.Depth = 0;
            this.impulseCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.impulseCheck.Location = new System.Drawing.Point(12, 222);
            this.impulseCheck.Margin = new System.Windows.Forms.Padding(0);
            this.impulseCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.impulseCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.impulseCheck.Name = "impulseCheck";
            this.impulseCheck.Ripple = true;
            this.impulseCheck.Size = new System.Drawing.Size(78, 30);
            this.impulseCheck.TabIndex = 4;
            this.impulseCheck.TabStop = true;
            this.impulseCheck.Tag = "Impulse";
            this.impulseCheck.Text = "Impulse";
            this.impulseCheck.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Enabled = false;
            this.materialFlatButton1.Location = new System.Drawing.Point(12, 90);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(140, 36);
            this.materialFlatButton1.TabIndex = 5;
            this.materialFlatButton1.Text = "Select Input Type";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // mBar
            // 
            this.mBar.BackColor = System.Drawing.Color.Transparent;
            this.mBar.Location = new System.Drawing.Point(322, 152);
            this.mBar.Maximum = 20;
            this.mBar.Minimum = 1;
            this.mBar.Name = "mBar";
            this.mBar.Size = new System.Drawing.Size(221, 23);
            this.mBar.TabIndex = 6;
            this.mBar.Tag = "mBar";
            this.mBar.Text = "mBar";
            this.mBar.Value = 5;
            // 
            // fBar
            // 
            this.fBar.BackColor = System.Drawing.Color.Transparent;
            this.fBar.Location = new System.Drawing.Point(322, 199);
            this.fBar.Minimum = 1;
            this.fBar.Name = "fBar";
            this.fBar.Size = new System.Drawing.Size(221, 23);
            this.fBar.TabIndex = 6;
            this.fBar.Tag = "fBar";
            this.fBar.Text = "fBar";
            // 
            // sBar
            // 
            this.sBar.BackColor = System.Drawing.Color.Transparent;
            this.sBar.Location = new System.Drawing.Point(322, 247);
            this.sBar.Name = "sBar";
            this.sBar.Size = new System.Drawing.Size(221, 23);
            this.sBar.TabIndex = 6;
            this.sBar.Tag = "sBar";
            this.sBar.Text = "sBar";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Enabled = false;
            this.materialFlatButton2.Location = new System.Drawing.Point(175, 90);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(163, 36);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "Set Input attributes";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Enabled = false;
            this.materialFlatButton3.Location = new System.Drawing.Point(175, 139);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(90, 36);
            this.materialFlatButton3.TabIndex = 7;
            this.materialFlatButton3.Text = "Magnitude";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton4
            // 
            this.materialFlatButton4.AutoSize = true;
            this.materialFlatButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton4.Depth = 0;
            this.materialFlatButton4.Enabled = false;
            this.materialFlatButton4.Location = new System.Drawing.Point(175, 186);
            this.materialFlatButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton4.Name = "materialFlatButton4";
            this.materialFlatButton4.Primary = false;
            this.materialFlatButton4.Size = new System.Drawing.Size(89, 36);
            this.materialFlatButton4.TabIndex = 7;
            this.materialFlatButton4.Text = "Frequency";
            this.materialFlatButton4.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton5
            // 
            this.materialFlatButton5.AutoSize = true;
            this.materialFlatButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton5.Depth = 0;
            this.materialFlatButton5.Enabled = false;
            this.materialFlatButton5.Location = new System.Drawing.Point(175, 234);
            this.materialFlatButton5.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton5.Name = "materialFlatButton5";
            this.materialFlatButton5.Primary = false;
            this.materialFlatButton5.Size = new System.Drawing.Size(54, 36);
            this.materialFlatButton5.TabIndex = 7;
            this.materialFlatButton5.Text = "Slope";
            this.materialFlatButton5.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton6
            // 
            this.materialFlatButton6.AutoSize = true;
            this.materialFlatButton6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton6.Depth = 0;
            this.materialFlatButton6.Enabled = false;
            this.materialFlatButton6.Location = new System.Drawing.Point(568, 90);
            this.materialFlatButton6.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton6.Name = "materialFlatButton6";
            this.materialFlatButton6.Primary = false;
            this.materialFlatButton6.Size = new System.Drawing.Size(223, 36);
            this.materialFlatButton6.TabIndex = 7;
            this.materialFlatButton6.Text = "Add controller coefficients \r\nseparated by a \' , \'";
            this.materialFlatButton6.UseVisualStyleBackColor = true;
            // 
            // bTxt
            // 
            this.bTxt.Depth = 0;
            this.bTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTxt.Hint = "";
            this.bTxt.Location = new System.Drawing.Point(596, 152);
            this.bTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.bTxt.Name = "bTxt";
            this.bTxt.PasswordChar = '\0';
            this.bTxt.SelectedText = "";
            this.bTxt.SelectionLength = 0;
            this.bTxt.SelectionStart = 0;
            this.bTxt.Size = new System.Drawing.Size(266, 23);
            this.bTxt.TabIndex = 8;
            this.bTxt.Tag = "bTxt";
            this.bTxt.Text = "0.12,0.3,0.4";
            this.bTxt.UseSystemPasswordChar = false;
            // 
            // materialFlatButton7
            // 
            this.materialFlatButton7.AutoSize = true;
            this.materialFlatButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton7.Depth = 0;
            this.materialFlatButton7.Enabled = false;
            this.materialFlatButton7.Location = new System.Drawing.Point(568, 139);
            this.materialFlatButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton7.Name = "materialFlatButton7";
            this.materialFlatButton7.Primary = false;
            this.materialFlatButton7.Size = new System.Drawing.Size(21, 36);
            this.materialFlatButton7.TabIndex = 7;
            this.materialFlatButton7.Text = "B";
            this.materialFlatButton7.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton8
            // 
            this.materialFlatButton8.AutoSize = true;
            this.materialFlatButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton8.Depth = 0;
            this.materialFlatButton8.Enabled = false;
            this.materialFlatButton8.Location = new System.Drawing.Point(568, 186);
            this.materialFlatButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton8.Name = "materialFlatButton8";
            this.materialFlatButton8.Primary = false;
            this.materialFlatButton8.Size = new System.Drawing.Size(21, 36);
            this.materialFlatButton8.TabIndex = 7;
            this.materialFlatButton8.Text = "A";
            this.materialFlatButton8.UseVisualStyleBackColor = true;
            // 
            // aTxt
            // 
            this.aTxt.Depth = 0;
            this.aTxt.Hint = "";
            this.aTxt.Location = new System.Drawing.Point(596, 199);
            this.aTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.aTxt.Name = "aTxt";
            this.aTxt.PasswordChar = '\0';
            this.aTxt.SelectedText = "";
            this.aTxt.SelectionLength = 0;
            this.aTxt.SelectionStart = 0;
            this.aTxt.Size = new System.Drawing.Size(266, 23);
            this.aTxt.TabIndex = 8;
            this.aTxt.Tag = "aTxt";
            this.aTxt.Text = "0.2,0.3,0.4,0.5";
            this.aTxt.UseSystemPasswordChar = false;
            // 
            // materialFlatButton9
            // 
            this.materialFlatButton9.AutoSize = true;
            this.materialFlatButton9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton9.Depth = 0;
            this.materialFlatButton9.Enabled = false;
            this.materialFlatButton9.Location = new System.Drawing.Point(568, 234);
            this.materialFlatButton9.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton9.Name = "materialFlatButton9";
            this.materialFlatButton9.Primary = false;
            this.materialFlatButton9.Size = new System.Drawing.Size(81, 36);
            this.materialFlatButton9.TabIndex = 7;
            this.materialFlatButton9.Text = "Sampling \r\nFreq";
            this.materialFlatButton9.UseVisualStyleBackColor = true;
            // 
            // tsBar
            // 
            this.tsBar.BackColor = System.Drawing.Color.Transparent;
            this.tsBar.Location = new System.Drawing.Point(656, 247);
            this.tsBar.Maximum = 400;
            this.tsBar.Minimum = 1;
            this.tsBar.Name = "tsBar";
            this.tsBar.Size = new System.Drawing.Size(206, 23);
            this.tsBar.TabIndex = 6;
            this.tsBar.Tag = "tsBar";
            this.tsBar.Text = "tsBar";
            this.tsBar.Value = 1;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Default;
            // 
            // plotButton
            // 
            this.plotButton.Depth = 0;
            this.plotButton.Location = new System.Drawing.Point(884, 222);
            this.plotButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.plotButton.Name = "plotButton";
            this.plotButton.Primary = true;
            this.plotButton.Size = new System.Drawing.Size(85, 36);
            this.plotButton.TabIndex = 9;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton10
            // 
            this.materialFlatButton10.AutoSize = true;
            this.materialFlatButton10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton10.Depth = 0;
            this.materialFlatButton10.Enabled = false;
            this.materialFlatButton10.Location = new System.Drawing.Point(884, 90);
            this.materialFlatButton10.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton10.Name = "materialFlatButton10";
            this.materialFlatButton10.Primary = false;
            this.materialFlatButton10.Size = new System.Drawing.Size(92, 36);
            this.materialFlatButton10.TabIndex = 10;
            this.materialFlatButton10.Text = "Simulation\r\nTime";
            this.materialFlatButton10.UseVisualStyleBackColor = true;
            // 
            // samplesNumberTextField
            // 
            this.samplesNumberTextField.Depth = 0;
            this.samplesNumberTextField.Hint = "";
            this.samplesNumberTextField.Location = new System.Drawing.Point(884, 152);
            this.samplesNumberTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.samplesNumberTextField.Name = "samplesNumberTextField";
            this.samplesNumberTextField.PasswordChar = '\0';
            this.samplesNumberTextField.SelectedText = "";
            this.samplesNumberTextField.SelectionLength = 0;
            this.samplesNumberTextField.SelectionStart = 0;
            this.samplesNumberTextField.Size = new System.Drawing.Size(75, 23);
            this.samplesNumberTextField.TabIndex = 11;
            this.samplesNumberTextField.Text = "50";
            this.samplesNumberTextField.UseSystemPasswordChar = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 632);
            this.Controls.Add(this.samplesNumberTextField);
            this.Controls.Add(this.materialFlatButton10);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.aTxt);
            this.Controls.Add(this.bTxt);
            this.Controls.Add(this.materialFlatButton9);
            this.Controls.Add(this.materialFlatButton5);
            this.Controls.Add(this.materialFlatButton4);
            this.Controls.Add(this.materialFlatButton8);
            this.Controls.Add(this.materialFlatButton7);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton6);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.tsBar);
            this.Controls.Add(this.sBar);
            this.Controls.Add(this.fBar);
            this.Controls.Add(this.mBar);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.impulseCheck);
            this.Controls.Add(this.rampCheck);
            this.Controls.Add(this.sinCheck);
            this.Controls.Add(this.stepCheck);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Control Homework 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private MaterialSkin.Controls.MaterialRadioButton stepCheck;
        private MaterialSkin.Controls.MaterialRadioButton sinCheck;
        private MaterialSkin.Controls.MaterialRadioButton rampCheck;
        private MaterialSkin.Controls.MaterialRadioButton impulseCheck;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MetroFramework.Controls.MetroTrackBar fBar;
        private MetroFramework.Controls.MetroTrackBar sBar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton4;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton6;
        private MaterialSkin.Controls.MaterialSingleLineTextField bTxt;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton7;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton8;
        private MaterialSkin.Controls.MaterialSingleLineTextField aTxt;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton9;
        private MetroFramework.Controls.MetroTrackBar tsBar;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MaterialSkin.Controls.MaterialRaisedButton plotButton;
        private MetroFramework.Controls.MetroTrackBar mBar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton10;
        private MaterialSkin.Controls.MaterialSingleLineTextField samplesNumberTextField;
    }
}

