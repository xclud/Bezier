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
            this.InfoPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConstructorPage = new System.Windows.Forms.TabPage();
            this.LineIntersectsPage = new System.Windows.Forms.TabPage();
            this.IntersectsSelfPage = new System.Windows.Forms.TabPage();
            this.IntersectsCurvePage = new System.Windows.Forms.TabPage();
            this.TangentDemoPage = new System.Windows.Forms.TabPage();
            this.NormalPage = new System.Windows.Forms.TabPage();
            this.SplitPage = new System.Windows.Forms.TabPage();
            this.PartPage = new System.Windows.Forms.TabPage();
            this.InflectionsPage = new System.Windows.Forms.TabPage();
            this.ExtremaPage = new System.Windows.Forms.TabPage();
            this.PositionPage = new System.Windows.Forms.TabPage();
            this.BoundingBoxPage = new System.Windows.Forms.TabPage();
            this.LengthPage = new System.Windows.Forms.TabPage();
            this.AlignPage = new System.Windows.Forms.TabPage();
            this.OffsetPage = new System.Windows.Forms.TabPage();
            this.ReducePage = new System.Windows.Forms.TabPage();
            this.HullPage = new System.Windows.Forms.TabPage();
            this.LookupTablePage = new System.Windows.Forms.TabPage();
            this.LUTProjectPage = new System.Windows.Forms.TabPage();
            this.InfoBezierControl = new System.Geometry_Demo.BezierDemo.BezierIntersectsCurveDemoControl();
            this.newBezierDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierContructorDemoControl();
            this.combinedBezierIntersectsLineDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsLineDemoControl();
            this.combinedBezierIntersectsSelfDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsSelfDemoControl();
            this.combinedBezierIntersectsCurveDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierIntersectsCurveDemoControl();
            this.combinedBezierTrangentDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierTangentDemoControl();
            this.combinedBezierNormalDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierNormalDemoControl();
            this.combinedBezierSplitDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierSplitDemoControl();
            this.combinedBezierPartDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierPartDemoControl();
            this.combinedBezierInflectionDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierInflectionDemoControl();
            this.combinedBezierExtremaDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierExtremaDemoControl();
            this.combinedBezierPositionDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierPositionDemoControl();
            this.combinedBezierBoundingBoxDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierBoundingBoxDemoControl();
            this.combinedBezierLengthDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLengthDemoControl();
            this.combinedBezierAlignDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierAlignDemoControl();
            this.combinedBezierOffsetDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierOffsetDemoControl();
            this.combinedBezierReduceDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierReduceDemoControl();
            this.combinedBezierHullDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierHullDemoControl();
            this.combinedBezierLUTDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLUTDemoControl();
            this.combinedBezierLUTProjectDemoControl1 = new System.Geometry_Demo.BezierDemo.CombinedBezierLUTProjectDemoControl();
            this.tabControl1.SuspendLayout();
            this.InfoPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.AlignPage.SuspendLayout();
            this.OffsetPage.SuspendLayout();
            this.ReducePage.SuspendLayout();
            this.HullPage.SuspendLayout();
            this.LookupTablePage.SuspendLayout();
            this.LUTProjectPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.InfoPage);
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
            this.tabControl1.Controls.Add(this.AlignPage);
            this.tabControl1.Controls.Add(this.OffsetPage);
            this.tabControl1.Controls.Add(this.ReducePage);
            this.tabControl1.Controls.Add(this.HullPage);
            this.tabControl1.Controls.Add(this.LookupTablePage);
            this.tabControl1.Controls.Add(this.LUTProjectPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1089, 587);
            this.tabControl1.TabIndex = 0;
            // 
            // InfoPage
            // 
            this.InfoPage.Controls.Add(this.splitContainer1);
            this.InfoPage.Location = new System.Drawing.Point(4, 55);
            this.InfoPage.Name = "InfoPage";
            this.InfoPage.Padding = new System.Windows.Forms.Padding(3);
            this.InfoPage.Size = new System.Drawing.Size(1081, 528);
            this.InfoPage.TabIndex = 19;
            this.InfoPage.Text = "Information";
            this.InfoPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InfoBezierControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.InfoRichTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 522);
            this.splitContainer1.SplitterDistance = 541;
            this.splitContainer1.TabIndex = 0;
            // 
            // InfoRichTextBox
            // 
            this.InfoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.InfoRichTextBox.Name = "InfoRichTextBox";
            this.InfoRichTextBox.ReadOnly = true;
            this.InfoRichTextBox.Size = new System.Drawing.Size(526, 518);
            this.InfoRichTextBox.TabIndex = 0;
            this.InfoRichTextBox.Text = "";
            this.InfoRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.InfoRichTextBox_LinkClicked);
            // 
            // ConstructorPage
            // 
            this.ConstructorPage.Controls.Add(this.newBezierDemoControl1);
            this.ConstructorPage.Location = new System.Drawing.Point(4, 55);
            this.ConstructorPage.Name = "ConstructorPage";
            this.ConstructorPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConstructorPage.Size = new System.Drawing.Size(1081, 528);
            this.ConstructorPage.TabIndex = 0;
            this.ConstructorPage.Text = "Bezier Constructor";
            this.ConstructorPage.UseVisualStyleBackColor = true;
            // 
            // LineIntersectsPage
            // 
            this.LineIntersectsPage.Controls.Add(this.combinedBezierIntersectsLineDemoControl1);
            this.LineIntersectsPage.Location = new System.Drawing.Point(4, 55);
            this.LineIntersectsPage.Name = "LineIntersectsPage";
            this.LineIntersectsPage.Padding = new System.Windows.Forms.Padding(3);
            this.LineIntersectsPage.Size = new System.Drawing.Size(1081, 528);
            this.LineIntersectsPage.TabIndex = 1;
            this.LineIntersectsPage.Text = "Intersects(line)";
            this.LineIntersectsPage.UseVisualStyleBackColor = true;
            // 
            // IntersectsSelfPage
            // 
            this.IntersectsSelfPage.Controls.Add(this.combinedBezierIntersectsSelfDemoControl1);
            this.IntersectsSelfPage.Location = new System.Drawing.Point(4, 55);
            this.IntersectsSelfPage.Name = "IntersectsSelfPage";
            this.IntersectsSelfPage.Padding = new System.Windows.Forms.Padding(3);
            this.IntersectsSelfPage.Size = new System.Drawing.Size(1081, 528);
            this.IntersectsSelfPage.TabIndex = 2;
            this.IntersectsSelfPage.Text = "IntersectsWithSelf(threshold)";
            this.IntersectsSelfPage.UseVisualStyleBackColor = true;
            // 
            // IntersectsCurvePage
            // 
            this.IntersectsCurvePage.Controls.Add(this.combinedBezierIntersectsCurveDemoControl1);
            this.IntersectsCurvePage.Location = new System.Drawing.Point(4, 55);
            this.IntersectsCurvePage.Name = "IntersectsCurvePage";
            this.IntersectsCurvePage.Padding = new System.Windows.Forms.Padding(3);
            this.IntersectsCurvePage.Size = new System.Drawing.Size(1081, 528);
            this.IntersectsCurvePage.TabIndex = 3;
            this.IntersectsCurvePage.Text = "Intersects(curve,treshold)";
            this.IntersectsCurvePage.UseVisualStyleBackColor = true;
            // 
            // TangentDemoPage
            // 
            this.TangentDemoPage.Controls.Add(this.combinedBezierTrangentDemoControl1);
            this.TangentDemoPage.Location = new System.Drawing.Point(4, 55);
            this.TangentDemoPage.Name = "TangentDemoPage";
            this.TangentDemoPage.Padding = new System.Windows.Forms.Padding(3);
            this.TangentDemoPage.Size = new System.Drawing.Size(1081, 528);
            this.TangentDemoPage.TabIndex = 4;
            this.TangentDemoPage.Text = "Tangent(t)";
            this.TangentDemoPage.UseVisualStyleBackColor = true;
            // 
            // NormalPage
            // 
            this.NormalPage.Controls.Add(this.combinedBezierNormalDemoControl1);
            this.NormalPage.Location = new System.Drawing.Point(4, 55);
            this.NormalPage.Name = "NormalPage";
            this.NormalPage.Padding = new System.Windows.Forms.Padding(3);
            this.NormalPage.Size = new System.Drawing.Size(1081, 528);
            this.NormalPage.TabIndex = 5;
            this.NormalPage.Text = "Normal(t)";
            this.NormalPage.UseVisualStyleBackColor = true;
            // 
            // SplitPage
            // 
            this.SplitPage.Controls.Add(this.combinedBezierSplitDemoControl1);
            this.SplitPage.Location = new System.Drawing.Point(4, 55);
            this.SplitPage.Name = "SplitPage";
            this.SplitPage.Padding = new System.Windows.Forms.Padding(3);
            this.SplitPage.Size = new System.Drawing.Size(1081, 528);
            this.SplitPage.TabIndex = 6;
            this.SplitPage.Text = "Split(t)";
            this.SplitPage.UseVisualStyleBackColor = true;
            // 
            // PartPage
            // 
            this.PartPage.Controls.Add(this.combinedBezierPartDemoControl1);
            this.PartPage.Location = new System.Drawing.Point(4, 55);
            this.PartPage.Name = "PartPage";
            this.PartPage.Padding = new System.Windows.Forms.Padding(3);
            this.PartPage.Size = new System.Drawing.Size(1081, 528);
            this.PartPage.TabIndex = 7;
            this.PartPage.Text = "Part(t1,t2)";
            this.PartPage.UseVisualStyleBackColor = true;
            // 
            // InflectionsPage
            // 
            this.InflectionsPage.Controls.Add(this.combinedBezierInflectionDemoControl1);
            this.InflectionsPage.Location = new System.Drawing.Point(4, 55);
            this.InflectionsPage.Name = "InflectionsPage";
            this.InflectionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.InflectionsPage.Size = new System.Drawing.Size(1081, 528);
            this.InflectionsPage.TabIndex = 8;
            this.InflectionsPage.Text = "Inflections()";
            this.InflectionsPage.UseVisualStyleBackColor = true;
            // 
            // ExtremaPage
            // 
            this.ExtremaPage.Controls.Add(this.combinedBezierExtremaDemoControl1);
            this.ExtremaPage.ForeColor = System.Drawing.Color.Red;
            this.ExtremaPage.Location = new System.Drawing.Point(4, 55);
            this.ExtremaPage.Name = "ExtremaPage";
            this.ExtremaPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExtremaPage.Size = new System.Drawing.Size(1081, 528);
            this.ExtremaPage.TabIndex = 9;
            this.ExtremaPage.Text = "Extrema()";
            this.ExtremaPage.UseVisualStyleBackColor = true;
            // 
            // PositionPage
            // 
            this.PositionPage.Controls.Add(this.combinedBezierPositionDemoControl1);
            this.PositionPage.Location = new System.Drawing.Point(4, 55);
            this.PositionPage.Name = "PositionPage";
            this.PositionPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionPage.Size = new System.Drawing.Size(1081, 528);
            this.PositionPage.TabIndex = 10;
            this.PositionPage.Text = "Position(t)";
            this.PositionPage.UseVisualStyleBackColor = true;
            // 
            // BoundingBoxPage
            // 
            this.BoundingBoxPage.Controls.Add(this.combinedBezierBoundingBoxDemoControl1);
            this.BoundingBoxPage.Location = new System.Drawing.Point(4, 55);
            this.BoundingBoxPage.Name = "BoundingBoxPage";
            this.BoundingBoxPage.Padding = new System.Windows.Forms.Padding(3);
            this.BoundingBoxPage.Size = new System.Drawing.Size(1081, 528);
            this.BoundingBoxPage.TabIndex = 11;
            this.BoundingBoxPage.Text = "BoundingBox";
            this.BoundingBoxPage.UseVisualStyleBackColor = true;
            // 
            // LengthPage
            // 
            this.LengthPage.Controls.Add(this.combinedBezierLengthDemoControl1);
            this.LengthPage.Location = new System.Drawing.Point(4, 55);
            this.LengthPage.Name = "LengthPage";
            this.LengthPage.Padding = new System.Windows.Forms.Padding(3);
            this.LengthPage.Size = new System.Drawing.Size(1081, 528);
            this.LengthPage.TabIndex = 12;
            this.LengthPage.Text = "Length";
            this.LengthPage.UseVisualStyleBackColor = true;
            // 
            // AlignPage
            // 
            this.AlignPage.Controls.Add(this.combinedBezierAlignDemoControl1);
            this.AlignPage.Location = new System.Drawing.Point(4, 55);
            this.AlignPage.Name = "AlignPage";
            this.AlignPage.Padding = new System.Windows.Forms.Padding(3);
            this.AlignPage.Size = new System.Drawing.Size(1081, 528);
            this.AlignPage.TabIndex = 18;
            this.AlignPage.Text = "Align(line)";
            this.AlignPage.UseVisualStyleBackColor = true;
            // 
            // OffsetPage
            // 
            this.OffsetPage.Controls.Add(this.combinedBezierOffsetDemoControl1);
            this.OffsetPage.ForeColor = System.Drawing.Color.Red;
            this.OffsetPage.Location = new System.Drawing.Point(4, 55);
            this.OffsetPage.Name = "OffsetPage";
            this.OffsetPage.Padding = new System.Windows.Forms.Padding(3);
            this.OffsetPage.Size = new System.Drawing.Size(1081, 528);
            this.OffsetPage.TabIndex = 13;
            this.OffsetPage.Text = "Offset(d)";
            this.OffsetPage.UseVisualStyleBackColor = true;
            // 
            // ReducePage
            // 
            this.ReducePage.Controls.Add(this.combinedBezierReduceDemoControl1);
            this.ReducePage.Location = new System.Drawing.Point(4, 55);
            this.ReducePage.Name = "ReducePage";
            this.ReducePage.Padding = new System.Windows.Forms.Padding(3);
            this.ReducePage.Size = new System.Drawing.Size(1081, 528);
            this.ReducePage.TabIndex = 16;
            this.ReducePage.Text = "Reduce()";
            this.ReducePage.UseVisualStyleBackColor = true;
            // 
            // HullPage
            // 
            this.HullPage.Controls.Add(this.combinedBezierHullDemoControl1);
            this.HullPage.Location = new System.Drawing.Point(4, 55);
            this.HullPage.Name = "HullPage";
            this.HullPage.Padding = new System.Windows.Forms.Padding(3);
            this.HullPage.Size = new System.Drawing.Size(1081, 528);
            this.HullPage.TabIndex = 17;
            this.HullPage.Text = "Hull(t)";
            this.HullPage.UseVisualStyleBackColor = true;
            // 
            // LookupTablePage
            // 
            this.LookupTablePage.Controls.Add(this.combinedBezierLUTDemoControl1);
            this.LookupTablePage.Location = new System.Drawing.Point(4, 55);
            this.LookupTablePage.Name = "LookupTablePage";
            this.LookupTablePage.Padding = new System.Windows.Forms.Padding(3);
            this.LookupTablePage.Size = new System.Drawing.Size(1081, 528);
            this.LookupTablePage.TabIndex = 14;
            this.LookupTablePage.Text = "LookUpTable(bezier, steps)";
            this.LookupTablePage.UseVisualStyleBackColor = true;
            // 
            // LUTProjectPage
            // 
            this.LUTProjectPage.Controls.Add(this.combinedBezierLUTProjectDemoControl1);
            this.LUTProjectPage.ForeColor = System.Drawing.Color.Red;
            this.LUTProjectPage.Location = new System.Drawing.Point(4, 55);
            this.LUTProjectPage.Name = "LUTProjectPage";
            this.LUTProjectPage.Padding = new System.Windows.Forms.Padding(3);
            this.LUTProjectPage.Size = new System.Drawing.Size(1081, 528);
            this.LUTProjectPage.TabIndex = 15;
            this.LUTProjectPage.Text = "LookupTable.Project(vector2,out t, out d)";
            this.LUTProjectPage.UseVisualStyleBackColor = true;
            // 
            // InfoBezierControl
            // 
            this.InfoBezierControl.BezierColor = System.Drawing.Color.Black;
            this.InfoBezierControl.BezierWidth = 2F;
            this.InfoBezierControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBezierControl.HandleSize = ((uint)(15u));
            this.InfoBezierControl.Location = new System.Drawing.Point(0, 0);
            this.InfoBezierControl.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBezierControl.Name = "InfoBezierControl";
            this.InfoBezierControl.Size = new System.Drawing.Size(537, 518);
            this.InfoBezierControl.TabIndex = 0;
            // 
            // newBezierDemoControl1
            // 
            this.newBezierDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newBezierDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.newBezierDemoControl1.Name = "newBezierDemoControl1";
            this.newBezierDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.newBezierDemoControl1.TabIndex = 0;
            // 
            // combinedBezierIntersectsLineDemoControl1
            // 
            this.combinedBezierIntersectsLineDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsLineDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsLineDemoControl1.Name = "combinedBezierIntersectsLineDemoControl1";
            this.combinedBezierIntersectsLineDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierIntersectsLineDemoControl1.TabIndex = 0;
            // 
            // combinedBezierIntersectsSelfDemoControl1
            // 
            this.combinedBezierIntersectsSelfDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsSelfDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsSelfDemoControl1.Name = "combinedBezierIntersectsSelfDemoControl1";
            this.combinedBezierIntersectsSelfDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierIntersectsSelfDemoControl1.TabIndex = 0;
            // 
            // combinedBezierIntersectsCurveDemoControl1
            // 
            this.combinedBezierIntersectsCurveDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierIntersectsCurveDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierIntersectsCurveDemoControl1.Name = "combinedBezierIntersectsCurveDemoControl1";
            this.combinedBezierIntersectsCurveDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierIntersectsCurveDemoControl1.TabIndex = 0;
            this.combinedBezierIntersectsCurveDemoControl1.Load += new System.EventHandler(this.combinedBezierIntersectsCurveDemoControl1_Load);
            // 
            // combinedBezierTrangentDemoControl1
            // 
            this.combinedBezierTrangentDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierTrangentDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierTrangentDemoControl1.Name = "combinedBezierTrangentDemoControl1";
            this.combinedBezierTrangentDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierTrangentDemoControl1.TabIndex = 0;
            // 
            // combinedBezierNormalDemoControl1
            // 
            this.combinedBezierNormalDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierNormalDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierNormalDemoControl1.Name = "combinedBezierNormalDemoControl1";
            this.combinedBezierNormalDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierNormalDemoControl1.TabIndex = 0;
            // 
            // combinedBezierSplitDemoControl1
            // 
            this.combinedBezierSplitDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierSplitDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierSplitDemoControl1.Name = "combinedBezierSplitDemoControl1";
            this.combinedBezierSplitDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierSplitDemoControl1.TabIndex = 0;
            // 
            // combinedBezierPartDemoControl1
            // 
            this.combinedBezierPartDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierPartDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierPartDemoControl1.Name = "combinedBezierPartDemoControl1";
            this.combinedBezierPartDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierPartDemoControl1.TabIndex = 0;
            // 
            // combinedBezierInflectionDemoControl1
            // 
            this.combinedBezierInflectionDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierInflectionDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierInflectionDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierInflectionDemoControl1.Name = "combinedBezierInflectionDemoControl1";
            this.combinedBezierInflectionDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierInflectionDemoControl1.TabIndex = 0;
            // 
            // combinedBezierExtremaDemoControl1
            // 
            this.combinedBezierExtremaDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierExtremaDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierExtremaDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierExtremaDemoControl1.Name = "combinedBezierExtremaDemoControl1";
            this.combinedBezierExtremaDemoControl1.Size = new System.Drawing.Size(1075, 549);
            this.combinedBezierExtremaDemoControl1.TabIndex = 0;
            // 
            // combinedBezierPositionDemoControl1
            // 
            this.combinedBezierPositionDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierPositionDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierPositionDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierPositionDemoControl1.Name = "combinedBezierPositionDemoControl1";
            this.combinedBezierPositionDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierPositionDemoControl1.TabIndex = 0;
            // 
            // combinedBezierBoundingBoxDemoControl1
            // 
            this.combinedBezierBoundingBoxDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierBoundingBoxDemoControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.combinedBezierBoundingBoxDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierBoundingBoxDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierBoundingBoxDemoControl1.Name = "combinedBezierBoundingBoxDemoControl1";
            this.combinedBezierBoundingBoxDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierBoundingBoxDemoControl1.TabIndex = 0;
            // 
            // combinedBezierLengthDemoControl1
            // 
            this.combinedBezierLengthDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLengthDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLengthDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLengthDemoControl1.Name = "combinedBezierLengthDemoControl1";
            this.combinedBezierLengthDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierLengthDemoControl1.TabIndex = 0;
            // 
            // combinedBezierAlignDemoControl1
            // 
            this.combinedBezierAlignDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierAlignDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierAlignDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierAlignDemoControl1.Name = "combinedBezierAlignDemoControl1";
            this.combinedBezierAlignDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierAlignDemoControl1.TabIndex = 0;
            // 
            // combinedBezierOffsetDemoControl1
            // 
            this.combinedBezierOffsetDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierOffsetDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierOffsetDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierOffsetDemoControl1.Name = "combinedBezierOffsetDemoControl1";
            this.combinedBezierOffsetDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierOffsetDemoControl1.TabIndex = 0;
            // 
            // combinedBezierReduceDemoControl1
            // 
            this.combinedBezierReduceDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierReduceDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierReduceDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierReduceDemoControl1.Name = "combinedBezierReduceDemoControl1";
            this.combinedBezierReduceDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierReduceDemoControl1.TabIndex = 0;
            // 
            // combinedBezierHullDemoControl1
            // 
            this.combinedBezierHullDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierHullDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierHullDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierHullDemoControl1.Name = "combinedBezierHullDemoControl1";
            this.combinedBezierHullDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierHullDemoControl1.TabIndex = 0;
            // 
            // combinedBezierLUTDemoControl1
            // 
            this.combinedBezierLUTDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLUTDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLUTDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLUTDemoControl1.Name = "combinedBezierLUTDemoControl1";
            this.combinedBezierLUTDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierLUTDemoControl1.TabIndex = 0;
            // 
            // combinedBezierLUTProjectDemoControl1
            // 
            this.combinedBezierLUTProjectDemoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.combinedBezierLUTProjectDemoControl1.Location = new System.Drawing.Point(3, 3);
            this.combinedBezierLUTProjectDemoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.combinedBezierLUTProjectDemoControl1.Name = "combinedBezierLUTProjectDemoControl1";
            this.combinedBezierLUTProjectDemoControl1.Size = new System.Drawing.Size(1075, 522);
            this.combinedBezierLUTProjectDemoControl1.TabIndex = 0;
            // 
            // BezierDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 587);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1105, 626);
            this.Name = "BezierDemoForm";
            this.Text = "System.Geometry / Bezier Demos";
            this.tabControl1.ResumeLayout(false);
            this.InfoPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
            this.AlignPage.ResumeLayout(false);
            this.OffsetPage.ResumeLayout(false);
            this.ReducePage.ResumeLayout(false);
            this.HullPage.ResumeLayout(false);
            this.LookupTablePage.ResumeLayout(false);
            this.LUTProjectPage.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private Windows.Forms.TabPage HullPage;
        private CombinedBezierHullDemoControl combinedBezierHullDemoControl1;
        private Windows.Forms.TabPage AlignPage;
        private CombinedBezierAlignDemoControl combinedBezierAlignDemoControl1;
        private Windows.Forms.TabPage InfoPage;
        private Windows.Forms.SplitContainer splitContainer1;
        private Windows.Forms.RichTextBox InfoRichTextBox;
        private BezierIntersectsCurveDemoControl InfoBezierControl;
    }
}

