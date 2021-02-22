namespace FishBot2
{
    partial class FishBotForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishBotForm1));
            this.processList = new System.Windows.Forms.ComboBox();
            this.audioVisualizer = new System.Windows.Forms.ProgressBar();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.statLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tt_main = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.casts = new System.Windows.Forms.Label();
            this.peakIndicator = new System.Windows.Forms.ProgressBar();
            this.resetBarButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.reCastTimeInput = new System.Windows.Forms.TextBox();
            this.setRecast = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.resetTotal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.processList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(11, 32);
            this.processList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(356, 23);
            this.processList.Sorted = true;
            this.processList.TabIndex = 1;
            // 
            // audioVisualizer
            // 
            this.audioVisualizer.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.audioVisualizer.Location = new System.Drawing.Point(14, 96);
            this.audioVisualizer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.audioVisualizer.Maximum = 1000;
            this.audioVisualizer.Name = "audioVisualizer";
            this.audioVisualizer.Size = new System.Drawing.Size(356, 26);
            this.audioVisualizer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.audioVisualizer.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startButton.Location = new System.Drawing.Point(267, 136);
            this.startButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(103, 32);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start Bot";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.stopButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.stopButton.Location = new System.Drawing.Point(267, 172);
            this.stopButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(103, 32);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Pause Bot";
            this.stopButton.UseMnemonic = false;
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // statStrip
            // 
            this.statStrip.AutoSize = false;
            this.statStrip.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statStrip.Location = new System.Drawing.Point(0, 214);
            this.statStrip.Name = "statStrip";
            this.statStrip.Padding = new System.Windows.Forms.Padding(1, 0, 11, 0);
            this.statStrip.Size = new System.Drawing.Size(384, 21);
            this.statStrip.TabIndex = 14;
            this.statStrip.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.statLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statLabel.Location = new System.Drawing.Point(5, 216);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(149, 15);
            this.statLabel.TabIndex = 15;
            this.statLabel.Text = "No Output Device Selected";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick_1);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.LightCoral;
            this.trackBar1.Location = new System.Drawing.Point(2, 68);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(382, 45);
            this.trackBar1.SmallChange = 20;
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select Audio Out Device:";
            // 
            // casts
            // 
            this.casts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.casts.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.casts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.casts.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.casts.Location = new System.Drawing.Point(327, 216);
            this.casts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.casts.Name = "casts";
            this.casts.Size = new System.Drawing.Size(40, 18);
            this.casts.TabIndex = 19;
            this.casts.Text = "0000";
            this.casts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // peakIndicator
            // 
            this.peakIndicator.BackColor = System.Drawing.Color.LightSeaGreen;
            this.peakIndicator.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.peakIndicator.Location = new System.Drawing.Point(14, 91);
            this.peakIndicator.Maximum = 1000;
            this.peakIndicator.Name = "peakIndicator";
            this.peakIndicator.Size = new System.Drawing.Size(356, 10);
            this.peakIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.peakIndicator.TabIndex = 21;
            // 
            // resetBarButton
            // 
            this.resetBarButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.resetBarButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetBarButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetBarButton.Location = new System.Drawing.Point(123, 136);
            this.resetBarButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetBarButton.Name = "resetBarButton";
            this.resetBarButton.Size = new System.Drawing.Size(50, 68);
            this.resetBarButton.TabIndex = 22;
            this.resetBarButton.Text = "Reset Sound Bar";
            this.resetBarButton.UseMnemonic = false;
            this.resetBarButton.UseVisualStyleBackColor = false;
            this.resetBarButton.Click += new System.EventHandler(this.resetBarButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(267, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Total Casts:";
            // 
            // reCastTimeInput
            // 
            this.reCastTimeInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.reCastTimeInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reCastTimeInput.ForeColor = System.Drawing.SystemColors.InfoText;
            this.reCastTimeInput.Location = new System.Drawing.Point(20, 141);
            this.reCastTimeInput.Name = "reCastTimeInput";
            this.reCastTimeInput.Size = new System.Drawing.Size(34, 23);
            this.reCastTimeInput.TabIndex = 24;
            this.reCastTimeInput.Text = "2";
            this.reCastTimeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // setRecast
            // 
            this.setRecast.BackColor = System.Drawing.Color.LightSeaGreen;
            this.setRecast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setRecast.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.setRecast.Location = new System.Drawing.Point(14, 164);
            this.setRecast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.setRecast.Name = "setRecast";
            this.setRecast.Size = new System.Drawing.Size(103, 40);
            this.setRecast.TabIndex = 25;
            this.setRecast.Text = "Set Recast Delay";
            this.setRecast.UseMnemonic = false;
            this.setRecast.UseVisualStyleBackColor = false;
            this.setRecast.Click += new System.EventHandler(this.setRecast_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(14, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 26;
            this.button1.Text = "Seconds  ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // resetTotal
            // 
            this.resetTotal.BackColor = System.Drawing.Color.LightSeaGreen;
            this.resetTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetTotal.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.resetTotal.Location = new System.Drawing.Point(179, 136);
            this.resetTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resetTotal.Name = "resetTotal";
            this.resetTotal.Size = new System.Drawing.Size(50, 68);
            this.resetTotal.TabIndex = 27;
            this.resetTotal.Text = "Reset Total Casts";
            this.resetTotal.UseMnemonic = false;
            this.resetTotal.UseVisualStyleBackColor = false;
            this.resetTotal.Click += new System.EventHandler(this.resetTotal_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel1.Location = new System.Drawing.Point(235, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 113);
            this.panel1.TabIndex = 28;
            // 
            // FishBotForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(384, 235);
            this.Controls.Add(this.resetTotal);
            this.Controls.Add(this.setRecast);
            this.Controls.Add(this.reCastTimeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetBarButton);
            this.Controls.Add(this.peakIndicator);
            this.Controls.Add(this.audioVisualizer);
            this.Controls.Add(this.casts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FishBotForm1";
            this.Text = "Elstinko\'s Fish Bot";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FishBotForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox processList;
        private System.Windows.Forms.ProgressBar audioVisualizer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.Label statLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip tt_main;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label casts;
        private System.Windows.Forms.ProgressBar peakIndicator;
        private System.Windows.Forms.Button resetBarButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reCastTimeInput;
        private System.Windows.Forms.Button setRecast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button resetTotal;
        private System.Windows.Forms.Panel panel1;
    }
}