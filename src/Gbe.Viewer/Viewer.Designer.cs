namespace Gbe.Viewer
{
    partial class Viewer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberOfEntities = new System.Windows.Forms.TextBox();
            this.txtNumberOfRules = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFPS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurrentFrame = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of entities:";
            // 
            // txtNumberOfEntities
            // 
            this.txtNumberOfEntities.Enabled = false;
            this.txtNumberOfEntities.Location = new System.Drawing.Point(113, 6);
            this.txtNumberOfEntities.Name = "txtNumberOfEntities";
            this.txtNumberOfEntities.ReadOnly = true;
            this.txtNumberOfEntities.Size = new System.Drawing.Size(75, 20);
            this.txtNumberOfEntities.TabIndex = 2;
            this.txtNumberOfEntities.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumberOfRules
            // 
            this.txtNumberOfRules.Enabled = false;
            this.txtNumberOfRules.Location = new System.Drawing.Point(113, 35);
            this.txtNumberOfRules.Name = "txtNumberOfRules";
            this.txtNumberOfRules.ReadOnly = true;
            this.txtNumberOfRules.Size = new System.Drawing.Size(75, 20);
            this.txtNumberOfRules.TabIndex = 4;
            this.txtNumberOfRules.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of rules:";
            // 
            // txtFPS
            // 
            this.txtFPS.Enabled = false;
            this.txtFPS.Location = new System.Drawing.Point(113, 61);
            this.txtFPS.Name = "txtFPS";
            this.txtFPS.ReadOnly = true;
            this.txtFPS.Size = new System.Drawing.Size(75, 20);
            this.txtFPS.TabIndex = 6;
            this.txtFPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "FPS:";
            // 
            // txtCurrentFrame
            // 
            this.txtCurrentFrame.Enabled = false;
            this.txtCurrentFrame.Location = new System.Drawing.Point(113, 88);
            this.txtCurrentFrame.Name = "txtCurrentFrame";
            this.txtCurrentFrame.ReadOnly = true;
            this.txtCurrentFrame.Size = new System.Drawing.Size(75, 20);
            this.txtCurrentFrame.TabIndex = 8;
            this.txtCurrentFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current frame:";
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Enabled = false;
            this.txtElapsedTime.Location = new System.Drawing.Point(113, 114);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.ReadOnly = true;
            this.txtElapsedTime.Size = new System.Drawing.Size(75, 20);
            this.txtElapsedTime.TabIndex = 10;
            this.txtElapsedTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Elapsed time:";
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 297);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCurrentFrame);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFPS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumberOfRules);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumberOfEntities);
            this.Controls.Add(this.label1);
            this.Name = "Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GBE Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyUp);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Viewer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberOfEntities;
        private System.Windows.Forms.TextBox txtNumberOfRules;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurrentFrame;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtElapsedTime;
        private System.Windows.Forms.Label label5;
    }
}

