﻿namespace System.Geometry_Demo.BezierDemo
{
    partial class CombinedBezierLUTProjectDemoControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CombinedBezierLUTProjectDemoControl));
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuadraticLUTControl = new System.Geometry_Demo.BezierDemo.BezierLUTProjectDemoControl();
            this.CubicLUTControl = new System.Geometry_Demo.BezierDemo.BezierLUTProjectDemoControl();
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
            this.splitContainer3.SplitterDistance = 49;
            this.splitContainer3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 45);
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
            this.splitContainer2.Size = new System.Drawing.Size(1069, 459);
            this.splitContainer2.SplitterDistance = 370;
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
            this.splitContainer1.Panel1.Controls.Add(this.QuadraticLUTControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.CubicLUTControl);
            this.splitContainer1.Size = new System.Drawing.Size(1069, 370);
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
            this.richTextBox1.Size = new System.Drawing.Size(1065, 81);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "Vector2 point = LookUpTable.Project(mousePos, out double t, out double d);\nDrawLi" +
    "ne(e.Graphics,mousePos,point,Color.Red,1);\nDrawPoint(e.Graphics, point, Color.Bl" +
    "ue, 10);";
            // 
            // QuadraticLUTControl
            // 
            this.QuadraticLUTControl.BezierColor = System.Drawing.Color.Black;
            this.QuadraticLUTControl.BezierWidth = 2F;
            this.QuadraticLUTControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuadraticLUTControl.HandleSize = ((uint)(15u));
            this.QuadraticLUTControl.Location = new System.Drawing.Point(0, 0);
            this.QuadraticLUTControl.LookupTableSteps = 10;
            this.QuadraticLUTControl.Name = "QuadraticLUTControl";
            this.QuadraticLUTControl.Size = new System.Drawing.Size(522, 366);
            this.QuadraticLUTControl.TabIndex = 0;
            // 
            // CubicLUTControl
            // 
            this.CubicLUTControl.BezierColor = System.Drawing.Color.Black;
            this.CubicLUTControl.BezierWidth = 2F;
            this.CubicLUTControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubicLUTControl.HandleSize = ((uint)(15u));
            this.CubicLUTControl.Location = new System.Drawing.Point(0, 0);
            this.CubicLUTControl.LookupTableSteps = 10;
            this.CubicLUTControl.Name = "CubicLUTControl";
            this.CubicLUTControl.Size = new System.Drawing.Size(535, 366);
            this.CubicLUTControl.TabIndex = 0;
            // 
            // CombinedBezierLUTProjectDemoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Name = "CombinedBezierLUTProjectDemoControl";
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
        private BezierLUTProjectDemoControl QuadraticLUTControl;
        private BezierLUTProjectDemoControl CubicLUTControl;
    }
}
