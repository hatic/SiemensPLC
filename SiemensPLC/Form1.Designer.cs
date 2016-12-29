namespace SiemensPLC
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonBalan = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.linearScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleLevelComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.linearScaleComponent3 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleRangeBarComponent1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.linearGauge1 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge();
            this.linearScaleBackgroundLayerComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent();
            this.linearScaleComponent4 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.linearScaleLevelComponent2 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent();
            this.linearScaleComponent5 = new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.digitalGauge1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleRangeBarComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBalan
            // 
            this.buttonBalan.Location = new System.Drawing.Point(88, 25);
            this.buttonBalan.Name = "buttonBalan";
            this.buttonBalan.Size = new System.Drawing.Size(122, 26);
            this.buttonBalan.TabIndex = 0;
            this.buttonBalan.Text = "BAĞLAN";
            this.buttonBalan.UseVisualStyleBackColor = true;
            this.buttonBalan.Click += new System.EventHandler(this.buttonBalan_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // linearScaleComponent1
            // 
            this.linearScaleComponent1.AcceptOrder = 0;
            this.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.linearScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF");
            this.linearScaleComponent1.CustomLogarithmicBase = 2F;
            this.linearScaleComponent1.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 31F);
            this.linearScaleComponent1.MajorTickCount = 6;
            this.linearScaleComponent1.MajorTickmark.AllowTickOverlap = true;
            this.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent1.MajorTickmark.ShapeOffset = 16.5F;
            this.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2;
            this.linearScaleComponent1.MajorTickmark.TextOffset = 36F;
            this.linearScaleComponent1.MaxValue = 500F;
            this.linearScaleComponent1.MinorTickCount = 4;
            this.linearScaleComponent1.MinorTickmark.ShapeOffset = 8.5F;
            this.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2;
            this.linearScaleComponent1.Name = "scale1";
            this.linearScaleComponent1.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F);
            this.linearScaleComponent1.Value = 250F;
            // 
            // linearScaleComponent2
            // 
            this.linearScaleComponent2.AcceptOrder = 0;
            this.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent2.AppearanceTickmarkText.Font = new System.Drawing.Font("Arial Narrow", 9.75F);
            this.linearScaleComponent2.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF");
            this.linearScaleComponent2.CustomLogarithmicBase = 2F;
            this.linearScaleComponent2.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 31F);
            this.linearScaleComponent2.MajorTickCount = 6;
            this.linearScaleComponent2.MajorTickmark.AllowTickOverlap = true;
            this.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent2.MajorTickmark.ShapeOffset = -22F;
            this.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_1;
            this.linearScaleComponent2.MajorTickmark.TextOffset = -35F;
            this.linearScaleComponent2.MaxValue = 50F;
            this.linearScaleComponent2.MinorTickCount = 4;
            this.linearScaleComponent2.MinorTickmark.ShapeOffset = -14F;
            this.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_1;
            this.linearScaleComponent2.Name = "scale2";
            this.linearScaleComponent2.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F);
            // 
            // linearScaleBackgroundLayerComponent1
            // 
            this.linearScaleBackgroundLayerComponent1.AcceptOrder = -1000;
            this.linearScaleBackgroundLayerComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleBackgroundLayerComponent1.Name = "bg1";
            this.linearScaleBackgroundLayerComponent1.ScaleEndPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.12F);
            this.linearScaleBackgroundLayerComponent1.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.855F);
            this.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style2;
            this.linearScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // linearScaleLevelComponent1
            // 
            this.linearScaleLevelComponent1.AcceptOrder = 50;
            this.linearScaleLevelComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleLevelComponent1.Name = "level1";
            this.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style2;
            this.linearScaleLevelComponent1.ZOrder = -50;
            // 
            // linearScaleComponent3
            // 
            this.linearScaleComponent3.AcceptOrder = 0;
            this.linearScaleComponent3.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent3.AppearanceTickmarkText.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.linearScaleComponent3.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C0C0FF");
            this.linearScaleComponent3.CustomLogarithmicBase = 2F;
            this.linearScaleComponent3.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 31F);
            this.linearScaleComponent3.MajorTickCount = 6;
            this.linearScaleComponent3.MajorTickmark.AllowTickOverlap = true;
            this.linearScaleComponent3.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent3.MajorTickmark.ShapeOffset = 16.5F;
            this.linearScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2;
            this.linearScaleComponent3.MajorTickmark.TextOffset = 36F;
            this.linearScaleComponent3.MaxValue = 500F;
            this.linearScaleComponent3.MinorTickCount = 4;
            this.linearScaleComponent3.MinorTickmark.ShapeOffset = 8.5F;
            this.linearScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style2_2;
            this.linearScaleComponent3.Name = "linearScaleComponent1Copy0";
            this.linearScaleComponent3.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F);
            this.linearScaleComponent3.Value = 250F;
            // 
            // linearScaleRangeBarComponent1
            // 
            this.linearScaleRangeBarComponent1.AcceptOrder = 100;
            this.linearScaleRangeBarComponent1.LinearScale = this.linearScaleComponent1;
            this.linearScaleRangeBarComponent1.Name = "linearGauge1_RangeBar1";
            this.linearScaleRangeBarComponent1.ZOrder = -100;
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.linearGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(88, 64);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(258, 137);
            this.gaugeControl1.TabIndex = 2;
            // 
            // linearGauge1
            // 
            this.linearGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent[] {
            this.linearScaleBackgroundLayerComponent2});
            this.linearGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 246, 125);
            this.linearGauge1.Levels.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent[] {
            this.linearScaleLevelComponent2});
            this.linearGauge1.Name = "linearGauge1";
            this.linearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}";
            this.linearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal;
            this.linearGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent[] {
            this.linearScaleComponent4,
            this.linearScaleComponent5});
            // 
            // linearScaleBackgroundLayerComponent2
            // 
            this.linearScaleBackgroundLayerComponent2.LinearScale = this.linearScaleComponent4;
            this.linearScaleBackgroundLayerComponent2.Name = "bg1";
            this.linearScaleBackgroundLayerComponent2.ScaleEndPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.14F);
            this.linearScaleBackgroundLayerComponent2.ScaleStartPos = new DevExpress.XtraGauges.Core.Base.PointF2D(0.505F, 0.85F);
            this.linearScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style14;
            this.linearScaleBackgroundLayerComponent2.ZOrder = 1000;
            // 
            // linearScaleComponent4
            // 
            this.linearScaleComponent4.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent4.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.linearScaleComponent4.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            this.linearScaleComponent4.CustomLogarithmicBase = 2F;
            this.linearScaleComponent4.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F);
            this.linearScaleComponent4.MajorTickCount = 6;
            this.linearScaleComponent4.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent4.MajorTickmark.ShapeOffset = 6F;
            this.linearScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_2;
            this.linearScaleComponent4.MajorTickmark.TextOffset = 35F;
            this.linearScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop;
            this.linearScaleComponent4.MaxValue = 500F;
            this.linearScaleComponent4.MinorTickCount = 4;
            this.linearScaleComponent4.MinorTickmark.ShapeOffset = 6F;
            this.linearScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_1;
            this.linearScaleComponent4.Name = "scale1";
            this.linearScaleComponent4.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            this.linearScaleComponent4.Value = 200F;
            // 
            // linearScaleLevelComponent2
            // 
            this.linearScaleLevelComponent2.LinearScale = this.linearScaleComponent4;
            this.linearScaleLevelComponent2.Name = "level1";
            this.linearScaleLevelComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style14;
            this.linearScaleLevelComponent2.ZOrder = -50;
            // 
            // linearScaleComponent5
            // 
            this.linearScaleComponent5.AppearanceMajorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMajorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMinorTickmark.BorderBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceMinorTickmark.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White");
            this.linearScaleComponent5.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.linearScaleComponent5.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000");
            this.linearScaleComponent5.CustomLogarithmicBase = 2F;
            this.linearScaleComponent5.EndPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 37F);
            this.linearScaleComponent5.MajorTickCount = 6;
            this.linearScaleComponent5.MajorTickmark.FormatString = "{0:F0}";
            this.linearScaleComponent5.MajorTickmark.ShapeOffset = -18F;
            this.linearScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_2;
            this.linearScaleComponent5.MajorTickmark.TextOffset = -32F;
            this.linearScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop;
            this.linearScaleComponent5.MaxValue = 50F;
            this.linearScaleComponent5.MinorTickCount = 4;
            this.linearScaleComponent5.MinorTickmark.ShapeOffset = -12F;
            this.linearScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style14_1;
            this.linearScaleComponent5.Name = "scale2";
            this.linearScaleComponent5.StartPoint = new DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sıcaklık";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nem";
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.digitalGauge1});
            this.gaugeControl2.Location = new System.Drawing.Point(88, 228);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(258, 128);
            this.gaugeControl2.TabIndex = 5;
            // 
            // digitalGauge1
            // 
            this.digitalGauge1.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E3E4E7");
            this.digitalGauge1.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#555B67");
            this.digitalGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent1});
            this.digitalGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 246, 116);
            this.digitalGauge1.DigitCount = 5;
            this.digitalGauge1.Name = "digitalGauge1";
            this.digitalGauge1.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.digitalGauge1.Text = "00,000";
            // 
            // digitalBackgroundLayerComponent1
            // 
            this.digitalBackgroundLayerComponent1.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(265.8125F, 99.9625F);
            this.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style26;
            this.digitalBackgroundLayerComponent1.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 368);
            this.Controls.Add(this.gaugeControl2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gaugeControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBalan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleRangeBarComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleBackgroundLayerComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleLevelComponent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearScaleComponent5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBalan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent3;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent linearScaleRangeBarComponent1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge linearGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent linearScaleBackgroundLayerComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent4;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent linearScaleLevelComponent2;
        private DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent linearScaleComponent5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge digitalGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent1;

    }
}

