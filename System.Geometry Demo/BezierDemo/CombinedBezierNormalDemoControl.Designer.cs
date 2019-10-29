namespace System.Geometry_Demo.BezierDemo
{
    partial class CombinedBezierNormalDemoControl
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuadraticBezierNormalDemoControl = new System.Geometry_Demo.BezierDemo.BezierNormalDemoControl();
            this.CubicBezierNormalDemoControl = new System.Geometry_Demo.BezierDemo.BezierNormalDemoControl();
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
            this.label1.Text = "Calculates the curve normal at the specified t value. Note that this yields a nor" +
    "malised vector.\r\nThe normal is simply the normalised tangent vector, rotated by " +
    "a quarter turn.\r\n";
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
            this.splitContainer1.Panel1.Controls.Add(this.QuadraticBezierNormalDemoControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CubicBezierNormalDemoControl);
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
            this.richTextBox1.Text = "for (double t = 0; t <= 1; t += 0.1)\n{\n    Vector2 pt = Bezier.Position(t);\n    V" +
    "ector2 nv = Bezier.Normal(t);\n    DrawLine(e.Graphics, pt, pt + nv * 40, Color.R" +
    "ed, 1);\n}";
            // 
            // QuadraticBezierNormalDemoControl
            // 
            this.QuadraticBezierNormalDemoControl.BezierColor = System.Drawing.Color.Black;
            this.QuadraticBezierNormalDemoControl.BezierWidth = 2F;
            this.QuadraticBezierNormalDemoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuadraticBezierNormalDemoControl.HandleSize = ((uint)(15u));
            this.QuadraticBezierNormalDemoControl.Location = new System.Drawing.Point(0, 0);
            this.QuadraticBezierNormalDemoControl.Name = "QuadraticBezierNormalDemoControl";
            this.QuadraticBezierNormalDemoControl.Size = new System.Drawing.Size(522, 382);
            this.QuadraticBezierNormalDemoControl.TabIndex = 0;
            // 
            // CubicBezierNormalDemoControl
            // 
            this.CubicBezierNormalDemoControl.BezierColor = System.Drawing.Color.Black;
            this.CubicBezierNormalDemoControl.BezierWidth = 2F;
            this.CubicBezierNormalDemoControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubicBezierNormalDemoControl.HandleSize = ((uint)(15u));
            this.CubicBezierNormalDemoControl.Location = new System.Drawing.Point(0, 0);
            this.CubicBezierNormalDemoControl.Name = "CubicBezierNormalDemoControl";
            this.CubicBezierNormalDemoControl.Size = new System.Drawing.Size(535, 382);
            this.CubicBezierNormalDemoControl.TabIndex = 0;
            // 
            // CombinedBezierNormalDemoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Name = "CombinedBezierNormalDemoControl";
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
        private BezierNormalDemoControl QuadraticBezierNormalDemoControl;
        private BezierNormalDemoControl CubicBezierNormalDemoControl;
    }
}
