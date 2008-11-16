namespace Gbe.Editor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.editorSurface = new SdlDotNet.Windows.SurfaceControl();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listPoints = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.editorSurface)).BeginInit();
            this.SuspendLayout();
            // 
            // editorSurface
            // 
            this.editorSurface.AccessibleDescription = "SdlDotNet SurfaceControl";
            this.editorSurface.AccessibleName = "SurfaceControl";
            this.editorSurface.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            this.editorSurface.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editorSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editorSurface.Image = ((System.Drawing.Image)(resources.GetObject("editorSurface.Image")));
            this.editorSurface.InitialImage = ((System.Drawing.Image)(resources.GetObject("editorSurface.InitialImage")));
            this.editorSurface.Location = new System.Drawing.Point(12, 12);
            this.editorSurface.Name = "editorSurface";
            this.editorSurface.Size = new System.Drawing.Size(440, 520);
            this.editorSurface.TabIndex = 0;
            this.editorSurface.TabStop = false;
            this.editorSurface.MouseMove += new System.Windows.Forms.MouseEventHandler(this.editorSurface_MouseMove);
            this.editorSurface.MouseUp += new System.Windows.Forms.MouseEventHandler(this.editorSurface_MouseUp);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(545, 12);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(71, 29);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listPoints
            // 
            this.listPoints.FormattingEnabled = true;
            this.listPoints.Location = new System.Drawing.Point(473, 116);
            this.listPoints.Name = "listPoints";
            this.listPoints.Size = new System.Drawing.Size(244, 355);
            this.listPoints.TabIndex = 2;
            this.listPoints.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listPoints_MouseMove);
            this.listPoints.SelectedValueChanged += new System.EventHandler(this.listPoints_SelectedValueChanged);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 616);
            this.Controls.Add(this.listPoints);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.editorSurface);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editorSurface)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SdlDotNet.Windows.SurfaceControl editorSurface;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListBox listPoints;
    }
}

