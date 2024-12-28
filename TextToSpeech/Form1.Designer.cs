namespace TextToSpeech
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SpeakButton = new System.Windows.Forms.Button();
            this.SoundTrackBar = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.Label();
            this.Speed = new System.Windows.Forms.Label();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.PersonComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(422, 287);
            this.textBox1.TabIndex = 0;
            // 
            // SpeakButton
            // 
            this.SpeakButton.Location = new System.Drawing.Point(12, 10);
            this.SpeakButton.Name = "SpeakButton";
            this.SpeakButton.Size = new System.Drawing.Size(80, 40);
            this.SpeakButton.TabIndex = 1;
            this.SpeakButton.Text = "Speak";
            this.SpeakButton.UseVisualStyleBackColor = true;
            this.SpeakButton.Click += new System.EventHandler(this.SpeakButton_Click);
            // 
            // SoundTrackBar
            // 
            this.SoundTrackBar.Location = new System.Drawing.Point(314, 358);
            this.SoundTrackBar.Maximum = 100;
            this.SoundTrackBar.Name = "SoundTrackBar";
            this.SoundTrackBar.Size = new System.Drawing.Size(120, 69);
            this.SoundTrackBar.TabIndex = 2;
            this.SoundTrackBar.Value = 75;
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(223, 375);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(63, 20);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(8, 375);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(56, 20);
            this.Speed.TabIndex = 5;
            this.Speed.Text = "Speed";
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(66, 358);
            this.SpeedTrackBar.Minimum = -10;
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(120, 69);
            this.SpeedTrackBar.TabIndex = 4;
            // 
            // PersonComboBox
            // 
            this.PersonComboBox.FormattingEnabled = true;
            this.PersonComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PersonComboBox.Location = new System.Drawing.Point(314, 12);
            this.PersonComboBox.Name = "PersonComboBox";
            this.PersonComboBox.Size = new System.Drawing.Size(121, 28);
            this.PersonComboBox.TabIndex = 6;
            this.PersonComboBox.Text = "Male";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 466);
            this.Controls.Add(this.PersonComboBox);
            this.Controls.Add(this.Speed);
            this.Controls.Add(this.SpeedTrackBar);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.SoundTrackBar);
            this.Controls.Add(this.SpeakButton);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text To Speech";
            ((System.ComponentModel.ISupportInitialize)(this.SoundTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SpeakButton;
        private System.Windows.Forms.TrackBar SoundTrackBar;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.ComboBox PersonComboBox;
    }
}

