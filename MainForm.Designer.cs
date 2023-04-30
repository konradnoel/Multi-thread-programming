namespace MultiThreadedApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bBike1 = new Button();
            bStart = new Button();
            pTarget = new Panel();
            bBike2 = new Button();
            bBike3 = new Button();
            pStart = new Panel();
            bStep1 = new Button();
            pDepoPanel = new Panel();
            bStep2 = new Button();
            bCounter = new Button();
            SuspendLayout();
            // 
            // bBike1
            // 
            bBike1.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike1.Location = new Point(12, 12);
            bBike1.Name = "bBike1";
            bBike1.Size = new Size(110, 74);
            bBike1.TabIndex = 0;
            bBike1.Text = "b";
            bBike1.UseVisualStyleBackColor = true;
            bBike1.Click += bBike1_Click;
            // 
            // bStart
            // 
            bStart.Location = new Point(12, 283);
            bStart.Name = "bStart";
            bStart.Size = new Size(96, 34);
            bStart.TabIndex = 1;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // pTarget
            // 
            pTarget.BackColor = Color.LightSteelBlue;
            pTarget.ForeColor = SystemColors.ControlText;
            pTarget.Location = new Point(547, 12);
            pTarget.Name = "pTarget";
            pTarget.Size = new Size(109, 265);
            pTarget.TabIndex = 2;
            // 
            // bBike2
            // 
            bBike2.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike2.Location = new Point(12, 108);
            bBike2.Name = "bBike2";
            bBike2.Size = new Size(110, 74);
            bBike2.TabIndex = 3;
            bBike2.Text = "b";
            bBike2.UseVisualStyleBackColor = true;
            bBike2.Click += bBike1_Click;
            // 
            // bBike3
            // 
            bBike3.Font = new Font("Webdings", 32F, FontStyle.Regular, GraphicsUnit.Point);
            bBike3.Location = new Point(12, 204);
            bBike3.Name = "bBike3";
            bBike3.Size = new Size(110, 73);
            bBike3.TabIndex = 4;
            bBike3.Text = "b";
            bBike3.UseVisualStyleBackColor = true;
            bBike3.Click += bBike1_Click;
            // 
            // pStart
            // 
            pStart.BackColor = Color.SlateGray;
            pStart.ForeColor = SystemColors.ControlText;
            pStart.Location = new Point(160, 12);
            pStart.Name = "pStart";
            pStart.Size = new Size(117, 265);
            pStart.TabIndex = 5;
            // 
            // bStep1
            // 
            bStep1.Location = new Point(170, 283);
            bStep1.Name = "bStep1";
            bStep1.Size = new Size(96, 34);
            bStep1.TabIndex = 6;
            bStep1.Text = "Step1";
            bStep1.UseVisualStyleBackColor = true;
            bStep1.Click += bStep1_Click;
            // 
            // pDepoPanel
            // 
            pDepoPanel.BackColor = Color.LightSkyBlue;
            pDepoPanel.ForeColor = SystemColors.ControlText;
            pDepoPanel.Location = new Point(353, 12);
            pDepoPanel.Name = "pDepoPanel";
            pDepoPanel.Size = new Size(117, 265);
            pDepoPanel.TabIndex = 6;
            // 
            // bStep2
            // 
            bStep2.Location = new Point(365, 283);
            bStep2.Name = "bStep2";
            bStep2.Size = new Size(96, 34);
            bStep2.TabIndex = 7;
            bStep2.Text = "Step2";
            bStep2.UseVisualStyleBackColor = true;
            bStep2.Click += bStep2_Click;
            // 
            // bCounter
            // 
            bCounter.Location = new Point(554, 283);
            bCounter.Name = "bCounter";
            bCounter.Size = new Size(96, 34);
            bCounter.TabIndex = 8;
            bCounter.Text = "Counter";
            bCounter.UseVisualStyleBackColor = true;
            bCounter.Click += bCounter_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 327);
            Controls.Add(bCounter);
            Controls.Add(bStep2);
            Controls.Add(bBike3);
            Controls.Add(bBike2);
            Controls.Add(bStart);
            Controls.Add(bBike1);
            Controls.Add(bStep1);
            Controls.Add(pStart);
            Controls.Add(pTarget);
            Controls.Add(pDepoPanel);
            Name = "MainForm";
            Text = "Tour de France - II5OPD";
            ResumeLayout(false);
        }

        #endregion

        private Button bBike1;
        private Button bStart;
        private Panel pTarget;
        private Button bBike2;
        private Button bBike3;
        private Panel pStart;
        private Button bStep1;
        private Panel pDepoPanel;
        private Button bStep2;
        private Button bCounter;
    }
}