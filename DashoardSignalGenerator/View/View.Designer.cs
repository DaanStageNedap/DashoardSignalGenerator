
namespace DashoardSignalGenerator
{
    partial class View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelstatus = new System.Windows.Forms.Label();
            this.CheckBoxAutomatic = new System.Windows.Forms.CheckBox();
            this.buttonstartt = new System.Windows.Forms.Button();
            this.TxtSpeedSecondsFreq = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtBoxIncreaseFreq = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtStopFreq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartFreq = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.lblIndex);
            this.panel1.Controls.Add(this.labelstatus);
            this.panel1.Controls.Add(this.CheckBoxAutomatic);
            this.panel1.Controls.Add(this.buttonstartt);
            this.panel1.Controls.Add(this.TxtSpeedSecondsFreq);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtBoxIncreaseFreq);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.TxtStopFreq);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtStartFreq);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 709);
            this.panel1.TabIndex = 0;
            // 
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(515, 185);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(61, 13);
            this.labelstatus.TabIndex = 28;
            this.labelstatus.Text = "Labelstatus";
            // 
            // CheckBoxAutomatic
            // 
            this.CheckBoxAutomatic.AutoSize = true;
            this.CheckBoxAutomatic.Location = new System.Drawing.Point(711, 290);
            this.CheckBoxAutomatic.Name = "CheckBoxAutomatic";
            this.CheckBoxAutomatic.Size = new System.Drawing.Size(73, 17);
            this.CheckBoxAutomatic.TabIndex = 27;
            this.CheckBoxAutomatic.Text = "Automatic";
            this.CheckBoxAutomatic.UseVisualStyleBackColor = true;
            // 
            // buttonstartt
            // 
            this.buttonstartt.Location = new System.Drawing.Point(700, 345);
            this.buttonstartt.Name = "buttonstartt";
            this.buttonstartt.Size = new System.Drawing.Size(110, 37);
            this.buttonstartt.TabIndex = 25;
            this.buttonstartt.Text = "Active program automtic";
            this.buttonstartt.UseVisualStyleBackColor = true;
            this.buttonstartt.Click += new System.EventHandler(this.buttonstartt_Click);
            // 
            // TxtSpeedSecondsFreq
            // 
            this.TxtSpeedSecondsFreq.Location = new System.Drawing.Point(495, 445);
            this.TxtSpeedSecondsFreq.Name = "TxtSpeedSecondsFreq";
            this.TxtSpeedSecondsFreq.Size = new System.Drawing.Size(128, 20);
            this.TxtSpeedSecondsFreq.TabIndex = 23;
            this.TxtSpeedSecondsFreq.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(247, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(247, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Set speed seconds per frequency step (default 3s):";
            // 
            // TxtBoxIncreaseFreq
            // 
            this.TxtBoxIncreaseFreq.Location = new System.Drawing.Point(495, 395);
            this.TxtBoxIncreaseFreq.Name = "TxtBoxIncreaseFreq";
            this.TxtBoxIncreaseFreq.ReadOnly = true;
            this.TxtBoxIncreaseFreq.Size = new System.Drawing.Size(128, 20);
            this.TxtBoxIncreaseFreq.TabIndex = 21;
            this.TxtBoxIncreaseFreq.Tag = "";
            this.TxtBoxIncreaseFreq.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Set step size increase frequency (default 1%):";
            // 
            // TxtStopFreq
            // 
            this.TxtStopFreq.Location = new System.Drawing.Point(495, 345);
            this.TxtStopFreq.Name = "TxtStopFreq";
            this.TxtStopFreq.Size = new System.Drawing.Size(128, 20);
            this.TxtStopFreq.TabIndex = 19;
            this.TxtStopFreq.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(300, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Set Stop Frequency (default 1000MHz):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Set Start Frequency (default 80MHz):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Level (V/M):";
            // 
            // txtStartFreq
            // 
            this.txtStartFreq.Location = new System.Drawing.Point(495, 291);
            this.txtStartFreq.Name = "txtStartFreq";
            this.txtStartFreq.Size = new System.Drawing.Size(128, 20);
            this.txtStartFreq.TabIndex = 15;
            this.txtStartFreq.Text = "82";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(495, 244);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(128, 20);
            this.txtLevel.TabIndex = 14;
            this.txtLevel.Text = "3";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(880, 482);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(515, 148);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(43, 13);
            this.lblIndex.TabIndex = 30;
            this.lblIndex.Text = "lblIndex";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 721);
            this.Controls.Add(this.panel1);
            this.Name = "View";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonstartt;
        private System.Windows.Forms.TextBox TxtSpeedSecondsFreq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtBoxIncreaseFreq;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtStopFreq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStartFreq;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CheckBoxAutomatic;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.Label lblIndex;
    }
}

