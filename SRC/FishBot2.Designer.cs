
namespace TheFishBot
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
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // processList
            // 
            this.processList.BackColor = System.Drawing.SystemColors.Menu;
            this.processList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processList.FormattingEnabled = true;
            this.processList.Location = new System.Drawing.Point(9, 28);
            this.processList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.processList.Name = "processList";
            this.processList.Size = new System.Drawing.Size(306, 21);
            this.processList.Sorted = true;
            this.processList.TabIndex = 1;
            // 
            // audioVisualizer
            // 
            this.audioVisualizer.Location = new System.Drawing.Point(9, 81);
            this.audioVisualizer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.audioVisualizer.Maximum = 1000;
            this.audioVisualizer.Name = "audioVisualizer";
            this.audioVisualizer.Size = new System.Drawing.Size(305, 27);
            this.audioVisualizer.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(9, 122);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(113, 28);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Start Bot";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(201, 122);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(113, 28);
            this.stopButton.TabIndex = 13;
            this.stopButton.Text = "Pause Bot";
            this.stopButton.UseMnemonic = false;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click_1);
            // 
            // statStrip
            // 
            this.statStrip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statStrip.Location = new System.Drawing.Point(0, 194);
            this.statStrip.Name = "statStrip";
            this.statStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statStrip.Size = new System.Drawing.Size(327, 22);
            this.statStrip.TabIndex = 14;
            this.statStrip.Text = "statusStrip1";
            // 
            // statLabel
            // 
            this.statLabel.AutoSize = true;
            this.statLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.statLabel.Location = new System.Drawing.Point(7, 198);
            this.statLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statLabel.Name = "statLabel";
            this.statLabel.Size = new System.Drawing.Size(138, 13);
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
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBar1.Location = new System.Drawing.Point(-2, 52);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(327, 45);
            this.trackBar1.SmallChange = 20;
            this.trackBar1.TabIndex = 17;
            this.trackBar1.TickFrequency = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select Audio Out Device:";
            // 
            // casts
            // 
            this.casts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.casts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casts.Location = new System.Drawing.Point(225, 156);
            this.casts.Name = "casts";
            this.casts.Size = new System.Drawing.Size(89, 33);
            this.casts.TabIndex = 19;
            this.casts.Text = "0000";
            this.casts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Number of Casts:";
            // 
            // FishBotForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(327, 216);
            this.Controls.Add(this.audioVisualizer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.casts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statLabel);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.processList);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
    }
}

