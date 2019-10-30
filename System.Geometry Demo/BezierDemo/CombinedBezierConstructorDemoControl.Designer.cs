namespace System.Geometry_Demo.BezierDemo
{
    partial class CombinedBezierContructorDemoControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cubicBezier = new System.Geometry_Demo.BezierDemo.BezierDemoControl();
            this.quadraticBezier = new System.Geometry_Demo.BezierDemo.BezierDemoControl();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linearBezier = new System.Geometry_Demo.BezierDemo.BezierDemoControl();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(716, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cubic Bezier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quadratic Bezier";
            // 
            // cubicBezier
            // 
            this.cubicBezier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cubicBezier.BezierColor = System.Drawing.Color.Black;
            this.cubicBezier.BezierWidth = 2F;
            this.cubicBezier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cubicBezier.HandleSize = ((uint)(15u));
            this.cubicBezier.Location = new System.Drawing.Point(716, 83);
            this.cubicBezier.Name = "cubicBezier";
            this.cubicBezier.Size = new System.Drawing.Size(350, 445);
            this.cubicBezier.TabIndex = 7;
            // 
            // quadraticBezier
            // 
            this.quadraticBezier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.quadraticBezier.BezierColor = System.Drawing.Color.Black;
            this.quadraticBezier.BezierWidth = 2F;
            this.quadraticBezier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quadraticBezier.HandleSize = ((uint)(15u));
            this.quadraticBezier.Location = new System.Drawing.Point(360, 83);
            this.quadraticBezier.Name = "quadraticBezier";
            this.quadraticBezier.Size = new System.Drawing.Size(350, 445);
            this.quadraticBezier.TabIndex = 6;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(360, 534);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(350, 150);
            this.richTextBox2.TabIndex = 14;
            this.richTextBox2.Text = "new Bezier(150, 40, 80, 30, 105, 150);\nnew Bezier(new Vector2(150, 40), new Vecto" +
    "r2(80, 30), new Vector2(105, 150));";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(716, 534);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(350, 150);
            this.richTextBox3.TabIndex = 15;
            this.richTextBox3.Text = "new Bezier(100, 25, 10, 90, 110, 100, 150, 195);\nnew Bezier(new Vector2(100, 25)," +
    " new Vector2(10, 90), new Vector2(110, 100), new Vector2(150, 195));";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bezier Constructor";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(4, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1060, 42);
            this.label5.TabIndex = 17;
            this.label5.Text = "The Bezier class supports cunstructors for quadratic, cubic and linar (internaly " +
    "represented as cubic curves) beziers.";
            // 
            // linearBezier
            // 
            this.linearBezier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linearBezier.BezierColor = System.Drawing.Color.Black;
            this.linearBezier.BezierWidth = 2F;
            this.linearBezier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linearBezier.HandleSize = ((uint)(15u));
            this.linearBezier.Location = new System.Drawing.Point(4, 83);
            this.linearBezier.Name = "linearBezier";
            this.linearBezier.Size = new System.Drawing.Size(350, 445);
            this.linearBezier.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Linear Bezier";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 534);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(350, 150);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "new Bezier(150, 40, 105, 150);\nnew Bezier(new Vector2(150, 40), new Vector2(105, " +
    "150));";
            // 
            // NewBezierDemoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linearBezier);
            this.Controls.Add(this.cubicBezier);
            this.Controls.Add(this.quadraticBezier);
            this.Name = "NewBezierDemoControl";
            this.Size = new System.Drawing.Size(1073, 687);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.Label label4;
        private Windows.Forms.Label label3;
        private BezierDemoControl cubicBezier;
        private BezierDemoControl quadraticBezier;
        private Windows.Forms.RichTextBox richTextBox2;
        private Windows.Forms.RichTextBox richTextBox3;
        private Windows.Forms.Label label1;
        private Windows.Forms.Label label5;
        private BezierDemoControl linearBezier;
        private Windows.Forms.Label label2;
        private Windows.Forms.RichTextBox richTextBox1;
    }
}
