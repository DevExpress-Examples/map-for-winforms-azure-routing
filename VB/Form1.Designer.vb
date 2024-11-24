Namespace AzureRouting

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.waypointsListBoxControl = New DevExpress.XtraEditors.ListBoxControl()
            Me.travelModeComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.calculateRouteButton = New DevExpress.XtraEditors.SimpleButton()
            Me.avoidTypesCheckedListBox = New System.Windows.Forms.CheckedListBox()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.waypointsListBoxControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.travelModeComboBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.layoutControl2)
            Me.layoutControl1.Controls.Add(Me.mapControl)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(4)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(1067, 554)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.Controls.Add(Me.waypointsListBoxControl)
            Me.layoutControl2.Controls.Add(Me.travelModeComboBox)
            Me.layoutControl2.Controls.Add(Me.calculateRouteButton)
            Me.layoutControl2.Controls.Add(Me.avoidTypesCheckedListBox)
            Me.layoutControl2.Location = New System.Drawing.Point(12, 12)
            Me.layoutControl2.Margin = New System.Windows.Forms.Padding(4)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup1
            Me.layoutControl2.Size = New System.Drawing.Size(274, 530)
            Me.layoutControl2.TabIndex = 5
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' waypointsListBoxControl
            ' 
            Me.waypointsListBoxControl.Location = New System.Drawing.Point(12, 12)
            Me.waypointsListBoxControl.Margin = New System.Windows.Forms.Padding(4)
            Me.waypointsListBoxControl.Name = "waypointsListBoxControl"
            Me.waypointsListBoxControl.SelectionMode = System.Windows.Forms.SelectionMode.None
            Me.waypointsListBoxControl.Size = New System.Drawing.Size(250, 176)
            Me.waypointsListBoxControl.StyleController = Me.layoutControl2
            Me.waypointsListBoxControl.TabIndex = 13
            ' 
            ' travelModeComboBox
            ' 
            Me.travelModeComboBox.EditValue = "Car"
            Me.travelModeComboBox.Location = New System.Drawing.Point(100, 192)
            Me.travelModeComboBox.Margin = New System.Windows.Forms.Padding(4)
            Me.travelModeComboBox.Name = "travelModeComboBox"
            Me.travelModeComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.travelModeComboBox.Properties.Items.AddRange(New Object() {"Car", "Bicycle", "Bus", "Motorcycle", "Pedestrian", "Taxi", "Truck", "Van"})
            Me.travelModeComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.travelModeComboBox.Size = New System.Drawing.Size(162, 22)
            Me.travelModeComboBox.StyleController = Me.layoutControl2
            Me.travelModeComboBox.TabIndex = 14
            ' 
            ' calculateRouteButton
            ' 
            Me.calculateRouteButton.Location = New System.Drawing.Point(12, 491)
            Me.calculateRouteButton.Margin = New System.Windows.Forms.Padding(4)
            Me.calculateRouteButton.Name = "calculateRouteButton"
            Me.calculateRouteButton.Size = New System.Drawing.Size(250, 27)
            Me.calculateRouteButton.StyleController = Me.layoutControl2
            Me.calculateRouteButton.TabIndex = 22
            Me.calculateRouteButton.Text = "Calculate Route"
            AddHandler Me.calculateRouteButton.Click, New System.EventHandler(AddressOf Me.calculateRouteButton_Click)
            ' 
            ' avoidTypesCheckedListBox
            ' 
            Me.avoidTypesCheckedListBox.CheckOnClick = True
            Me.avoidTypesCheckedListBox.FormattingEnabled = True
            Me.avoidTypesCheckedListBox.Items.AddRange(New Object() {"AlreadyUsedRoads", "BorderCrossings", "Carpools", "Ferries", "Motorways", "TollRoads", "UnpavedRoads"})
            Me.avoidTypesCheckedListBox.Location = New System.Drawing.Point(24, 256)
            Me.avoidTypesCheckedListBox.Margin = New System.Windows.Forms.Padding(4)
            Me.avoidTypesCheckedListBox.Name = "avoidTypesCheckedListBox"
            Me.avoidTypesCheckedListBox.Size = New System.Drawing.Size(226, 208)
            Me.avoidTypesCheckedListBox.TabIndex = 23
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem3, Me.layoutControlGroup2, Me.layoutControlItem12})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(274, 530)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.waypointsListBoxControl
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(254, 180)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.travelModeComboBox
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 180)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(254, 26)
            Me.layoutControlItem3.Text = "Travel Mode:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(76, 16)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 206)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(254, 273)
            Me.layoutControlGroup2.Text = "Avoid Types:"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.avoidTypesCheckedListBox
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(230, 223)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.calculateRouteButton
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 479)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Size = New System.Drawing.Size(254, 31)
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem12.TextVisible = False
            ' 
            ' mapControl
            ' 
            Me.mapControl.Location = New System.Drawing.Point(290, 12)
            Me.mapControl.Margin = New System.Windows.Forms.Padding(4)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(765, 530)
            Me.mapControl.TabIndex = 4
            AddHandler Me.mapControl.Click, New System.EventHandler(AddressOf Me.mapControl_Click)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(1067, 554)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl
            Me.layoutControlItem1.Location = New System.Drawing.Point(278, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(769, 534)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.layoutControl2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(278, 534)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1067, 554)
            Me.Controls.Add(Me.layoutControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.waypointsListBoxControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.travelModeComboBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mapControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private mapControl As DevExpress.XtraMap.MapControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private waypointsListBoxControl As DevExpress.XtraEditors.ListBoxControl

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private travelModeComboBox As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private calculateRouteButton As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private avoidTypesCheckedListBox As System.Windows.Forms.CheckedListBox

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
