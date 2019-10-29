namespace System.Geometry_Demo.BezierDemo
{
    partial class BezierDemoForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ConstructorPage = new System.Windows.Forms.TabPage();
            this.newBezierDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierContructorDemoControl();
            this.LineIntersectsPage = new System.Windows.Forms.TabPage();
            this.combinedBezierIntersectsLineDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsLineDemoControl();
            this.IntersectsSelfPage = new System.Windows.Forms.TabPage();
            this.combinedBezierIntersectsSelfDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsSelfDemoControl();
            this.IntersectsCurvePage = new System.Windows.Forms.TabPage();
            this.combinedBezierIntersectsCurveDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsCurveDemoControl();
            this.TangentDemoPage = new System.Windows.Forms.TabPage();
            this.combinedBezierTrangentDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierTangentDemoControl();
            this.NormalPage = new System.Windows.Forms.TabPage();
            this.combinedBezierNormalDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierNormalDemoControl();
            this.SplitPage = new System.Windows.Forms.TabPage();
            this.combinedBezierSplitDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierSplitDemoControl();
            this.PartPage = new System.Windows.Forms.TabPage();
            this.combinedBezierPartDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierPartDemoControl();
            this.InflectionsPage = new System.Windows.Forms.TabPage();
            this.combinedBezierInflectionDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierInflectionDemoControl();
            this.ExtremaPage = new System.Windows.Forms.TabPage();
            this.combinedBezierExtremaDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierExtremaDemoControl();
            this.PositionPage = new System.Windows.Forms.TabPage();
            this.combinedBezierPositionDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierPositionDemoControl();
            this.BoundingBoxPage = new System.Windows.Forms.TabPage();
            this.combinedBezierBoundingBoxDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierBoundingBoxDemoControl();
            this.LengthPage = new System.Windows.Forms.TabPage();
            this.combinedBezierLengthDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLengthDemoControl();
            this.OffsetPage = new System.Windows.Forms.TabPage();
            this.combinedBezierOffsetDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierOffsetDemoControl();
            this.LookupTablePage = new System.Windows.Forms.TabPage();
            this.combinedBezierLUTDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLUTDemoControl();
            this.LUTProjectPage = new System.Windows.Forms.TabPage();
            this.combinedBezierLUTProjectDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLUTProjectDemoControl();
            this.label1 = new System.Windows.Forms.Label();
            this.ReducePage = new System.Windows.Forms.TabPage();
            this.combinedBezierReduceDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierReduceDemoControl();
            this.tabControl1.SuspendLayout();
            this.ConstructorPage.SuspendLayout();
            this.LineIntersectsPage.SuspendLayout();
            this.IntersectsSelfPage.SuspendLayout();
            this.IntersectsCurvePage.SuspendLayout();
            this.TangentDemoPage.SuspendLayout();
            this.NormalPage.SuspendLayout();
            this.SplitPage.SuspendLayout();
            this.PartPage.SuspendLayout();
            this.InflectionsPage.SuspendLayout();
            this.ExtremaPage.SuspendLayout();
            this.PositionPage.SuspendLayout();
            this.BoundingBoxPage.SuspendLayout();
            this.LengthPage.SuspendLayout();
            this.OffsetPage.SuspendLayout();
            this.LookupTablePage.SuspendLayout();
            this.LUTProjectPage.SuspendLayout();
            this.ReducePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.ConstructorPage);
            this.tabControl1.Controls.Add(this.LineIntersectsPage);
            this.tabControl1.Controls.Add(this.IntersectsSelfPage);
            this.tabControl1.Controls.Add(this.IntersectsCurvePage);
            this.tabControl1.Controls.Add(this.TangentDemoPage);
            this.tabControl1.Controls.Add(this.NormalPage);
            this.tabControl1.Controls.Add(this.SplitPage);
            this.tabControl1.Controls.Add(this.PartPage);
            this.tabControl1.Controls.Add(this.InflectionsPage);
            this.tabControl1.Controls.Add(this.ExtremaPage);
            this.tabControl1.Controls.Add(this.PositionPage);
            this.tabControl1.Controls.Add(this.BoundingBoxPage);
            this.tabControl1.Controls.Add(this.LengthPage);
            this.tabControl1.Controls.Add(this.OffsetPage);
            this.tabControl1.Controls.Add(this.LookupTablePage);
            this.tabControl1.Controls.Add(this.LUTProjectPage);
            this.tabControl1.Controls.Add(this.ReducePage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 37);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // ConstructorPage
            // 
            this.ConstructorPage.Controls.Add(this.newBezierDemoControl1);
            this.ConstructorPage.Location = new System.Drawing.Point(4, 55);
            this.ConstructorPage.Name = "ConstructorPage";
            this.ConstructorPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConstructorPage.Size = new System.Drawing.Size(1075, 488);
            this.ConstructorPage.TabIndex = 0;
            this.ConstructorPage.Text = "Bezier Constructor";
            this.ConstructorPage.UseVisualStyleBackColor = true;
            // 
            // newBezierDemoControl1
            // 
            this.newBezierDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBezierDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.newBezierDemoControl1.Name = "newBezierDemoControl1";
            this.newBezierDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.newBezierDemoControl1.TabIndex = 0;
            // 
            // LineIntersectsPage
            // 
            this.LineIntersectsPage.Controls.Add(this.combinedBezierIntersectsLineDemoControl1);
            this.LineIntersectsPage.Location = new System.Drawing.Point(4, 55);
            this.LineIntersectsPage.Name = "LineIntersectsPage";
            this.LineIntersectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.LineIntersectsPage.Size = new System.Drawing.Size(1075, 488);
            this.LineIntersectsPage.TabIndex = 1;
            this.LineIntersectsPage.Text = "Intersects(line)";
            this.LineIntersectsPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierIntersectsLineDemoControl1
            // 
            this.combinedBezierIntersectsLineDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsLineDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsLineDemoControl1.Name = "combinedBezierIntersectsLineDemoControl1";
            this.combinedBezierIntersectsLineDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierIntersectsLineDemoControl1.TabIndex = 0;
            // 
            // IntersectsSelfPage
            // 
            this.IntersectsSelfPage.Controls.Add(this.combinedBezierIntersectsSelfDemoControl1);
            this.IntersectsSelfPage.Location = new System.Drawing.Point(4, 55);
            this.IntersectsSelfPage.Name = "IntersectsSelfPage";
            this.IntersectsSelfPage.Padding = new System.Windows.Forms.Padding(3);
            this.IntersectsSelfPage.Size = new System.Drawing.Size(1075, 488);
            this.IntersectsSelfPage.TabIndex = 2;
            this.IntersectsSelfPage.Text = "IntersectsWithSelf(threshold)";
            this.IntersectsSelfPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierIntersectsSelfDemoControl1
            // 
            this.combinedBezierIntersectsSelfDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsSelfDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsSelfDemoControl1.Name = "combinedBezierIntersectsSelfDemoControl1";
            this.combinedBezierIntersectsSelfDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierIntersectsSelfDemoControl1.TabIndex = 0;
            // 
            // IntersectsCurvePage
            // 
            this.IntersectsCurvePage.Controls.Add(this.combinedBezierIntersectsCurveDemoControl1);
            this.IntersectsCurvePage.Location = new System.Drawing.Point(4, 55);
            this.IntersectsCurvePage.Name = "IntersectsCurvePage";
            this.IntersectsCurvePage.Padding = new System.Windows.Forms.Padding(3);
            this.IntersectsCurvePage.Size = new System.Drawing.Size(1075, 488);
            this.IntersectsCurvePage.TabIndex = 3;
            this.IntersectsCurvePage.Text = "Intersects(curve,treshold)";
            this.IntersectsCurvePage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierIntersectsCurveDemoControl1
            // 
            this.combinedBezierIntersectsCurveDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsCurveDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsCurveDemoControl1.Name = "combinedBezierIntersectsCurveDemoControl1";
            this.combinedBezierIntersectsCurveDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierIntersectsCurveDemoControl1.TabIndex = 0;
            this.combinedBezierIntersectsCurveDemoControl1.Load += new System.EventHandler(this.combinedBezierIntersectsCurveDemoControl1_Load);
            // 
            // TangentDemoPage
            // 
            this.TangentDemoPage.Controls.Add(this.combinedBezierTrangentDemoControl1);
            this.TangentDemoPage.Location = new System.Drawing.Point(4, 55);
            this.TangentDemoPage.Name = "TangentDemoPage";
            this.TangentDemoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TangentDemoPage.Size = new System.Drawing.Size(1075, 488);
            this.TangentDemoPage.TabIndex = 4;
            this.TangentDemoPage.Text = "Tangent(t)";
            this.TangentDemoPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierTrangentDemoControl1
            // 
            this.combinedBezierTrangentDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierTrangentDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierTrangentDemoControl1.Name = "combinedBezierTrangentDemoControl1";
            this.combinedBezierTrangentDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierTrangentDemoControl1.TabIndex = 0;
            // 
            // NormalPage
            // 
            this.NormalPage.Controls.Add(this.combinedBezierNormalDemoControl1);
            this.NormalPage.Location = new System.Drawing.Point(4, 55);
            this.NormalPage.Name = "NormalPage";
            this.NormalPage.Padding = new System.Windows.Forms.Padding(3);
            this.NormalPage.Size = new System.Drawing.Size(1075, 488);
            this.NormalPage.TabIndex = 5;
            this.NormalPage.Text = "Normal(t)";
            this.NormalPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierNormalDemoControl1
            // 
            this.combinedBezierNormalDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierNormalDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierNormalDemoControl1.Name = "combinedBezierNormalDemoControl1";
            this.combinedBezierNormalDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierNormalDemoControl1.TabIndex = 0;
            // 
            // SplitPage
            // 
            this.SplitPage.Controls.Add(this.combinedBezierSplitDemoControl1);
            this.SplitPage.Location = new System.Drawing.Point(4, 55);
            this.SplitPage.Name = "SplitPage";
            this.SplitPage.Padding = new System.Windows.Forms.Padding(3);
            this.SplitPage.Size = new System.Drawing.Size(1075, 488);
            this.SplitPage.TabIndex = 6;
            this.SplitPage.Text = "Split(t)";
            this.SplitPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierSplitDemoControl1
            // 
            this.combinedBezierSplitDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierSplitDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierSplitDemoControl1.Name = "combinedBezierSplitDemoControl1";
            this.combinedBezierSplitDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierSplitDemoControl1.TabIndex = 0;
            // 
            // PartPage
            // 
            this.PartPage.Controls.Add(this.combinedBezierPartDemoControl1);
            this.PartPage.Location = new System.Drawing.Point(4, 55);
            this.PartPage.Name = "PartPage";
            this.PartPage.Padding = new System.Windows.Forms.Padding(3);
            this.PartPage.Size = new System.Drawing.Size(1075, 488);
            this.PartPage.TabIndex = 7;
            this.PartPage.Text = "Part(t1,t2)";
            this.PartPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierPartDemoControl1
            // 
            this.combinedBezierPartDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierPartDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierPartDemoControl1.Name = "combinedBezierPartDemoControl1";
            this.combinedBezierPartDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierPartDemoControl1.TabIndex = 0;
            // 
            // InflectionsPage
            // 
            this.InflectionsPage.Controls.Add(this.combinedBezierInflectionDemoControl1);
            this.InflectionsPage.Location = new System.Drawing.Point(4, 55);
            this.InflectionsPage.Name = "InflectionsPage";
            this.InflectionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.InflectionsPage.Size = new System.Drawing.Size(1075, 488);
            this.InflectionsPage.TabIndex = 8;
            this.InflectionsPage.Text = "Inflections()";
            this.InflectionsPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierInflectionDemoControl1
            // 
            this.combinedBezierInflectionDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierInflectionDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierInflectionDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierInflectionDemoControl1.Name = "combinedBezierInflectionDemoControl1";
            this.combinedBezierInflectionDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierInflectionDemoControl1.TabIndex = 0;
            // 
            // ExtremaPage
            // 
            this.ExtremaPage.Controls.Add(this.combinedBezierExtremaDemoControl1);
            this.ExtremaPage.ForeColor = System.Drawing.Color.Red;
            this.ExtremaPage.Location = new System.Drawing.Point(4, 55);
            this.ExtremaPage.Name = "ExtremaPage";
            this.ExtremaPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExtremaPage.Size = new System.Drawing.Size(1075, 488);
            this.ExtremaPage.TabIndex = 9;
            this.ExtremaPage.Text = "Extrema()";
            this.ExtremaPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierExtremaDemoControl1
            // 
            this.combinedBezierExtremaDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierExtremaDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierExtremaDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierExtremaDemoControl1.Name = "combinedBezierExtremaDemoControl1";
            this.combinedBezierExtremaDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierExtremaDemoControl1.TabIndex = 0;
            // 
            // PositionPage
            // 
            this.PositionPage.Controls.Add(this.combinedBezierPositionDemoControl1);
            this.PositionPage.Location = new System.Drawing.Point(4, 55);
            this.PositionPage.Name = "PositionPage";
            this.PositionPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionPage.Size = new System.Drawing.Size(1075, 488);
            this.PositionPage.TabIndex = 10;
            this.PositionPage.Text = "Position(t)";
            this.PositionPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierPositionDemoControl1
            // 
            this.combinedBezierPositionDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierPositionDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierPositionDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierPositionDemoControl1.Name = "combinedBezierPositionDemoControl1";
            this.combinedBezierPositionDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierPositionDemoControl1.TabIndex = 0;
            // 
            // BoundingBoxPage
            // 
            this.BoundingBoxPage.Controls.Add(this.combinedBezierBoundingBoxDemoControl1);
            this.BoundingBoxPage.Location = new System.Drawing.Point(4, 55);
            this.BoundingBoxPage.Name = "BoundingBoxPage";
            this.BoundingBoxPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoundingBoxPage.Size = new System.Drawing.Size(1075, 488);
            this.BoundingBoxPage.TabIndex = 11;
            this.BoundingBoxPage.Text = "BoundingBox";
            this.BoundingBoxPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierBoundingBoxDemoControl1
            // 
            this.combinedBezierBoundingBoxDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierBoundingBoxDemoControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.combinedBezierBoundingBoxDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierBoundingBoxDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierBoundingBoxDemoControl1.Name = "combinedBezierBoundingBoxDemoControl1";
            this.combinedBezierBoundingBoxDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierBoundingBoxDemoControl1.TabIndex = 0;
            // 
            // LengthPage
            // 
            this.LengthPage.Controls.Add(this.combinedBezierLengthDemoControl1);
            this.LengthPage.Location = new System.Drawing.Point(4, 55);
            this.LengthPage.Name = "LengthPage";
            this.LengthPage.Padding = new System.Windows.Forms.Padding(3);
            this.LengthPage.Size = new System.Drawing.Size(1075, 488);
            this.LengthPage.TabIndex = 12;
            this.LengthPage.Text = "Length";
            this.LengthPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierLengthDemoControl1
            // 
            this.combinedBezierLengthDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLengthDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLengthDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLengthDemoControl1.Name = "combinedBezierLengthDemoControl1";
            this.combinedBezierLengthDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierLengthDemoControl1.TabIndex = 0;
            // 
            // OffsetPage
            // 
            this.OffsetPage.Controls.Add(this.combinedBezierOffsetDemoControl1);
            this.OffsetPage.ForeColor = System.Drawing.Color.Red;
            this.OffsetPage.Location = new System.Drawing.Point(4, 55);
            this.OffsetPage.Name = "OffsetPage";
            this.OffsetPage.Padding = new System.Windows.Forms.Padding(3);
            this.OffsetPage.Size = new System.Drawing.Size(1075, 488);
            this.OffsetPage.TabIndex = 13;
            this.OffsetPage.Text = "Offset(d)";
            this.OffsetPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierOffsetDemoControl1
            // 
            this.combinedBezierOffsetDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierOffsetDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierOffsetDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierOffsetDemoControl1.Name = "combinedBezierOffsetDemoControl1";
            this.combinedBezierOffsetDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierOffsetDemoControl1.TabIndex = 0;
            // 
            // LookupTablePage
            // 
            this.LookupTablePage.Controls.Add(this.combinedBezierLUTDemoControl1);
            this.LookupTablePage.Location = new System.Drawing.Point(4, 55);
            this.LookupTablePage.Name = "LookupTablePage";
            this.LookupTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.LookupTablePage.Size = new System.Drawing.Size(1075, 488);
            this.LookupTablePage.TabIndex = 14;
            this.LookupTablePage.Text = "LookUpTable(bezier, steps)";
            this.LookupTablePage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierLUTDemoControl1
            // 
            this.combinedBezierLUTDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLUTDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLUTDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLUTDemoControl1.Name = "combinedBezierLUTDemoControl1";
            this.combinedBezierLUTDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierLUTDemoControl1.TabIndex = 0;
            // 
            // LUTProjectPage
            // 
            this.LUTProjectPage.Controls.Add(this.combinedBezierLUTProjectDemoControl1);
            this.LUTProjectPage.ForeColor = System.Drawing.Color.Red;
            this.LUTProjectPage.Location = new System.Drawing.Point(4, 55);
            this.LUTProjectPage.Name = "LUTProjectPage";
            this.LUTProjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.LUTProjectPage.Size = new System.Drawing.Size(1075, 488);
            this.LUTProjectPage.TabIndex = 15;
            this.LUTProjectPage.Text = "LookupTable.Project(vector2,out t, out d)";
            this.LUTProjectPage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierLUTProjectDemoControl1
            // 
            this.combinedBezierLUTProjectDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLUTProjectDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLUTProjectDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLUTProjectDemoControl1.Name = "combinedBezierLUTProjectDemoControl1";
            this.combinedBezierLUTProjectDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierLUTProjectDemoControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bezier Demos";
            // 
            // ReducePage
            // 
            this.ReducePage.Controls.Add(this.combinedBezierReduceDemoControl1);
            this.ReducePage.Location = new System.Drawing.Point(4, 55);
            this.ReducePage.Name = "ReducePage";
            this.ReducePage.Padding = new System.Windows.Forms.Padding(3);
            this.ReducePage.Size = new System.Drawing.Size(1075, 488);
            this.ReducePage.TabIndex = 16;
            this.ReducePage.Text = "Reduce()";
            this.ReducePage.UseVisualStyleBackColor = true;
            // 
            // combinedBezierReduceDemoControl1
            // 
            this.combinedBezierReduceDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierReduceDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierReduceDemoControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combinedBezierReduceDemoControl1.Name = "combinedBezierReduceDemoControl1";
            this.combinedBezierReduceDemoControl1.Size = new System.Drawing.Size(1069, 482);
            this.combinedBezierReduceDemoControl1.TabIndex = 0;
            // 
            // BezierDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1105, 626);
            this.Name = "BezierDemoForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ConstructorPage.ResumeLayout(false);
            this.LineIntersectsPage.ResumeLayout(false);
            this.IntersectsSelfPage.ResumeLayout(false);
            this.IntersectsCurvePage.ResumeLayout(false);
            this.TangentDemoPage.ResumeLayout(false);
            this.NormalPage.ResumeLayout(false);
            this.SplitPage.ResumeLayout(false);
            this.PartPage.ResumeLayout(false);
            this.InflectionsPage.ResumeLayout(false);
            this.ExtremaPage.ResumeLayout(false);
            this.PositionPage.ResumeLayout(false);
            this.BoundingBoxPage.ResumeLayout(false);
            this.LengthPage.ResumeLayout(false);
            this.OffsetPage.ResumeLayout(false);
            this.LookupTablePage.ResumeLayout(false);
            this.LUTProjectPage.ResumeLayout(false);
            this.ReducePage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Windows.Forms.TabControl tabControl1;
        private Windows.Forms.TabPage ConstructorPage;
        private Windows.Forms.TabPage LineIntersectsPage;
        private Windows.Forms.TabPage IntersectsSelfPage;
        private Windows.Forms.TabPage IntersectsCurvePage;
        private Windows.Forms.TabPage TangentDemoPage;
        private Windows.Forms.TabPage NormalPage;
        private Windows.Forms.TabPage SplitPage;
        private Windows.Forms.TabPage PartPage;
        private Windows.Forms.TabPage InflectionsPage;
        private Windows.Forms.TabPage ExtremaPage;
        private Windows.Forms.TabPage PositionPage;
        private Windows.Forms.TabPage BoundingBoxPage;
        private Windows.Forms.TabPage LengthPage;
        private Windows.Forms.TabPage OffsetPage;
        private Windows.Forms.Label label1;
        private CombinedBezierContructorDemoControl newBezierDemoControl1;
        private CombinedBezierIntersectsLineDemoControl combinedBezierIntersectsLineDemoControl1;
        private CombinedBezierIntersectsSelfDemoControl combinedBezierIntersectsSelfDemoControl1;
        private CombinedBezierIntersectsCurveDemoControl combinedBezierIntersectsCurveDemoControl1;
        private CombinedBezierTangentDemoControl combinedBezierTrangentDemoControl1;
        private CombinedBezierNormalDemoControl combinedBezierNormalDemoControl1;
        private CombinedBezierSplitDemoControl combinedBezierSplitDemoControl1;
        private CombinedBezierPartDemoControl combinedBezierPartDemoControl1;
        private CombinedBezierInflectionDemoControl combinedBezierInflectionDemoControl1;
        private CombinedBezierExtremaDemoControl combinedBezierExtremaDemoControl1;
        private CombinedBezierPositionDemoControl combinedBezierPositionDemoControl1;
        private CombinedBezierBoundingBoxDemoControl combinedBezierBoundingBoxDemoControl1;
        private CombinedBezierLengthDemoControl combinedBezierLengthDemoControl1;
        private CombinedBezierOffsetDemoControl combinedBezierOffsetDemoControl1;
        private Windows.Forms.TabPage LookupTablePage;
        private CombinedBezierLUTDemoControl combinedBezierLUTDemoControl1;
        private Windows.Forms.TabPage LUTProjectPage;
        private CombinedBezierLUTProjectDemoControl combinedBezierLUTProjectDemoControl1;
        private Windows.Forms.TabPage ReducePage;
        private CombinedBezierReduceDemoControl combinedBezierReduceDemoControl1;
    }
}

