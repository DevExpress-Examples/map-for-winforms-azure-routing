namespace AzureRouting
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.waypointsListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
            this.travelModeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.calculateRouteButton = new DevExpress.XtraEditors.SimpleButton();
            this.avoidTypesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waypointsListBoxControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelModeComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.layoutControl2);
            this.layoutControl1.Controls.Add(this.mapControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1067, 554);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.waypointsListBoxControl);
            this.layoutControl2.Controls.Add(this.travelModeComboBox);
            this.layoutControl2.Controls.Add(this.calculateRouteButton);
            this.layoutControl2.Controls.Add(this.avoidTypesCheckedListBox);
            this.layoutControl2.Location = new System.Drawing.Point(12, 12);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(274, 530);
            this.layoutControl2.TabIndex = 5;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // waypointsListBoxControl
            // 
            this.waypointsListBoxControl.Location = new System.Drawing.Point(12, 12);
            this.waypointsListBoxControl.Margin = new System.Windows.Forms.Padding(4);
            this.waypointsListBoxControl.Name = "waypointsListBoxControl";
            this.waypointsListBoxControl.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.waypointsListBoxControl.Size = new System.Drawing.Size(250, 176);
            this.waypointsListBoxControl.StyleController = this.layoutControl2;
            this.waypointsListBoxControl.TabIndex = 13;
            // 
            // travelModeComboBox
            // 
            this.travelModeComboBox.EditValue = "Car";
            this.travelModeComboBox.Location = new System.Drawing.Point(100, 192);
            this.travelModeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.travelModeComboBox.Name = "travelModeComboBox";
            this.travelModeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.travelModeComboBox.Properties.Items.AddRange(new object[] {
            "Car",
            "Bicycle",
            "Bus",
            "Motorcycle",
            "Pedestrian",
            "Taxi",
            "Truck",
            "Van"});
            this.travelModeComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.travelModeComboBox.Size = new System.Drawing.Size(162, 22);
            this.travelModeComboBox.StyleController = this.layoutControl2;
            this.travelModeComboBox.TabIndex = 14;
            // 
            // calculateRouteButton
            // 
            this.calculateRouteButton.Location = new System.Drawing.Point(12, 491);
            this.calculateRouteButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateRouteButton.Name = "calculateRouteButton";
            this.calculateRouteButton.Size = new System.Drawing.Size(250, 27);
            this.calculateRouteButton.StyleController = this.layoutControl2;
            this.calculateRouteButton.TabIndex = 22;
            this.calculateRouteButton.Text = "Calculate Route";
            this.calculateRouteButton.Click += new System.EventHandler(this.calculateRouteButton_Click);
            // 
            // avoidTypesCheckedListBox
            // 
            this.avoidTypesCheckedListBox.CheckOnClick = true;
            this.avoidTypesCheckedListBox.FormattingEnabled = true;
            this.avoidTypesCheckedListBox.Items.AddRange(new object[] {
            "AlreadyUsedRoads",
            "BorderCrossings",
            "Carpools",
            "Ferries",
            "Motorways",
            "TollRoads",
            "UnpavedRoads"});
            this.avoidTypesCheckedListBox.Location = new System.Drawing.Point(24, 256);
            this.avoidTypesCheckedListBox.Margin = new System.Windows.Forms.Padding(4);
            this.avoidTypesCheckedListBox.Name = "avoidTypesCheckedListBox";
            this.avoidTypesCheckedListBox.Size = new System.Drawing.Size(226, 208);
            this.avoidTypesCheckedListBox.TabIndex = 23;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem3,
            this.layoutControlGroup2,
            this.layoutControlItem12});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(274, 530);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.waypointsListBoxControl;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(254, 180);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.travelModeComboBox;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 180);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(254, 26);
            this.layoutControlItem3.Text = "Travel Mode:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 16);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 206);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(254, 273);
            this.layoutControlGroup2.Text = "Avoid Types:";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.avoidTypesCheckedListBox;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(230, 223);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.calculateRouteButton;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 479);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(254, 31);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // mapControl
            // 
            this.mapControl.Location = new System.Drawing.Point(290, 12);
            this.mapControl.Margin = new System.Windows.Forms.Padding(4);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(765, 530);
            this.mapControl.TabIndex = 4;
            this.mapControl.Click += new System.EventHandler(this.mapControl_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1067, 554);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(278, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(769, 534);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.layoutControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(278, 534);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.layoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waypointsListBoxControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelModeComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.ListBoxControl waypointsListBoxControl;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.ComboBoxEdit travelModeComboBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton calculateRouteButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private System.Windows.Forms.CheckedListBox avoidTypesCheckedListBox;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}

