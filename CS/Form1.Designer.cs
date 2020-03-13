namespace TreemapColorizerValueProvider {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraTreeMap.TreeMapGradientColorizer treeMapGradientColorizer1 = new DevExpress.XtraTreeMap.TreeMapGradientColorizer();
            DevExpress.XtraTreeMap.TreeMapFlatDataAdapter treeMapFlatDataAdapter1 = new DevExpress.XtraTreeMap.TreeMapFlatDataAdapter();
            this.treeMapControl1 = new DevExpress.XtraTreeMap.TreeMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeMapControl1
            // 
            treeMapGradientColorizer1.EndColor = System.Drawing.Color.Red;
            treeMapGradientColorizer1.StartColor = System.Drawing.Color.Lime;
            this.treeMapControl1.Colorizer = treeMapGradientColorizer1;
            treeMapFlatDataAdapter1.LabelDataMember = "Country";
            treeMapFlatDataAdapter1.ValueDataMember = "Population";
            this.treeMapControl1.DataAdapter = treeMapFlatDataAdapter1;
            this.treeMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMapControl1.Location = new System.Drawing.Point(0, 0);
            this.treeMapControl1.Name = "treeMapControl1";
            this.treeMapControl1.Size = new System.Drawing.Size(800, 450);
            this.treeMapControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.treeMapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeMap.TreeMapControl treeMapControl1;
    }
}

