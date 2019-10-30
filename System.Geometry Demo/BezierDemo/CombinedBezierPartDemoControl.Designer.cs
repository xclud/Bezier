namespace System.Geometry_Demo.BezierDemo
{
    partial class CombinedBezierPartDemoControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedBezierPartDemoControl));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuadraticBezierPartDemoControl = new System.Geometry_Demo.BezierDemo.BezierPartDemoControl();
            this.CubicBezierPartDemoControl = new System.Geometry_Demo.BezierDemo.BezierPartDemoControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(1069, 512);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer2.Size = new System.Drawing.Size(1069, 479);
            this.splitContainer2.SplitterDistance = 386;
            this.splitContainer2.TabIndex = 16;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QuadraticBezierPartDemoControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CubicBezierPartDemoControl);
            this.splitContainer1.Size = new System.Drawing.Size(1069, 386);
            this.splitContainer1.SplitterDistance = 526;
            this.splitContainer1.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1065, 85);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Bezier p =  Bezier.Part(0.25,0.6);\nDrawBezier(e.Graphics,p.Points, Color.Red, Bez" +
    "ierWidth);\nDrawHandles(e.Graphics, p.Points, Color.Green, 10, 1, Color.Green, 1)" +
    ";";
            // 
            // QuadraticBezierPartDemoControl
            // 
            this.QuadraticBezierPartDemoControl.BezierColor = System.Drawing.Color.Black;
            this.QuadraticBezierPartDemoControl.BezierWidth = 2F;
            this.QuadraticBezierPartDemoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuadraticBezierPartDemoControl.HandleSize = ((uint)(15u));
            this.QuadraticBezierPartDemoControl.Location = new System.Drawing.Point(0, 0);
            this.QuadraticBezierPartDemoControl.Name = "QuadraticBezierPartDemoControl";
            this.QuadraticBezierPartDemoControl.Size = new System.Drawing.Size(522, 382);
            this.QuadraticBezierPartDemoControl.TabIndex = 0;
            // 
            // CubicBezierPartDemoControl
            // 
            this.CubicBezierPartDemoControl.BezierColor = System.Drawing.Color.Black;
            this.CubicBezierPartDemoControl.BezierWidth = 2F;
            this.CubicBezierPartDemoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubicBezierPartDemoControl.HandleSize = ((uint)(15u));
            this.CubicBezierPartDemoControl.Location = new System.Drawing.Point(0, 0);
            this.CubicBezierPartDemoControl.Name = "CubicBezierPartDemoControl";
            this.CubicBezierPartDemoControl.Size = new System.Drawing.Size(535, 382);
            this.CubicBezierPartDemoControl.TabIndex = 0;
            // 
            // CombinedBezierPartDemoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Name = "CombinedBezierPartDemoControl";
            this.Size = new System.Drawing.Size(1069, 512);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Windows.Forms.SplitContainer splitContainer3;
        private Windows.Forms.Label label1;
        private Windows.Forms.SplitContainer splitContainer2;
        private Windows.Forms.SplitContainer splitContainer1;
        private Windows.Forms.RichTextBox richTextBox1;
        private BezierPartDemoControl QuadraticBezierPartDemoControl;
        private BezierPartDemoControl CubicBezierPartDemoControl;
    }
}
