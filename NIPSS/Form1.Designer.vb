<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DateYearField1 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
        Dim DateLiteralField1 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateMonthField1 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
        Dim DateLiteralField2 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateDayField1 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
        Dim DateLiteralField3 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateHourField1 As GrapeCity.Win.Editors.Fields.DateHourField = New GrapeCity.Win.Editors.Fields.DateHourField()
        Dim DateLiteralField4 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateMinuteField1 As GrapeCity.Win.Editors.Fields.DateMinuteField = New GrapeCity.Win.Editors.Fields.DateMinuteField()
        Dim DateLiteralField5 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateSecondField1 As GrapeCity.Win.Editors.Fields.DateSecondField = New GrapeCity.Win.Editors.Fields.DateSecondField()
        Me.GcButton1 = New GrapeCity.Win.Buttons.GcButton()
        Me.GcCheckBox1 = New GrapeCity.Win.Buttons.GcCheckBox()
        Me.GcComboBox1 = New GrapeCity.Win.Editors.GcComboBox(Me.components)
        Me.DropDownButton1 = New GrapeCity.Win.Editors.DropDownButton()
        Me.GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
        Me.GcDateTime1 = New GrapeCity.Win.Editors.GcDateTime(Me.components)
        Me.DropDownButton2 = New GrapeCity.Win.Editors.DropDownButton()
        Me.GcNumber1 = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.DropDownButton3 = New GrapeCity.Win.Editors.DropDownButton()
        Me.GcTextBox1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.GcIme1 = New GrapeCity.Win.Editors.GcIme()
        Me.GcLabel1 = New GrapeCity.Win.Buttons.GcLabel()
        Me.GcListBox1 = New GrapeCity.Win.Editors.GcListBox()
        Me.GcMultiRow1 = New GrapeCity.Win.MultiRow.GcMultiRow()
        Me.GcResize1 = New GrapeCity.Win.Components.GcResize(Me.components)
        Me.GcShortcut2 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
        Me.GcTabControl1 = New GrapeCity.Win.Containers.GcTabControl()
        Me.GcTabPage1 = New GrapeCity.Win.Containers.GcTabPage()
        Me.GcTabPage2 = New GrapeCity.Win.Containers.GcTabPage()
        Me.Viewer1 = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.PdfExport1 = New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport()
        CType(Me.GcComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcDateTime1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcNumber1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcResize1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GcTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GcTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GcButton1
        '
        Me.GcButton1.Location = New System.Drawing.Point(68, 84)
        Me.GcButton1.Name = "GcButton1"
        Me.GcButton1.Size = New System.Drawing.Size(75, 23)
        Me.GcButton1.TabIndex = 0
        Me.GcButton1.Text = "GcButton1"
        Me.GcButton1.UseVisualStyleBackColor = True
        '
        'GcCheckBox1
        '
        Me.GcCheckBox1.AutoSize = True
        Me.GcCheckBox1.Location = New System.Drawing.Point(98, 182)
        Me.GcCheckBox1.Name = "GcCheckBox1"
        Me.GcCheckBox1.Size = New System.Drawing.Size(99, 16)
        Me.GcCheckBox1.TabIndex = 1
        Me.GcCheckBox1.Text = "GcCheckBox1"
        Me.GcCheckBox1.UseVisualStyleBackColor = True
        '
        'GcComboBox1
        '
        Me.GcComboBox1.ListHeaderPane.Height = 19
        Me.GcComboBox1.Location = New System.Drawing.Point(9, 218)
        Me.GcComboBox1.Name = "GcComboBox1"
        Me.GcShortcut1.SetShortcuts(Me.GcComboBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.GcComboBox1, Object), CType(Me.GcComboBox1, Object)}, New String() {"ShortcutClear", "ApplyRecommendedValue"}))
        Me.GcComboBox1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.DropDownButton1})
        Me.GcComboBox1.Size = New System.Drawing.Size(120, 20)
        Me.GcComboBox1.TabIndex = 2
        '
        'DropDownButton1
        '
        Me.DropDownButton1.Name = "DropDownButton1"
        '
        'GcDateTime1
        '
        DateLiteralField1.Text = "/"
        DateLiteralField2.Text = "/"
        DateLiteralField4.Text = ":"
        DateLiteralField5.Text = ":"
        Me.GcDateTime1.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField1, DateLiteralField1, DateMonthField1, DateLiteralField2, DateDayField1, DateLiteralField3, DateHourField1, DateLiteralField4, DateMinuteField1, DateLiteralField5, DateSecondField1})
        Me.GcDateTime1.Location = New System.Drawing.Point(68, 192)
        Me.GcDateTime1.Name = "GcDateTime1"
        Me.GcShortcut1.SetShortcuts(Me.GcDateTime1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.F5, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.GcDateTime1, Object), CType(Me.GcDateTime1, Object), CType(Me.GcDateTime1, Object)}, New String() {"ShortcutClear", "SetNow", "ApplyRecommendedValue"}))
        Me.GcDateTime1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.DropDownButton2})
        Me.GcDateTime1.Size = New System.Drawing.Size(120, 20)
        Me.GcDateTime1.TabIndex = 3
        Me.GcDateTime1.Value = New Date(2018, 4, 25, 11, 18, 46, 0)
        '
        'DropDownButton2
        '
        Me.DropDownButton2.Name = "DropDownButton2"
        '
        'GcNumber1
        '
        Me.GcNumber1.Fields.IntegerPart.MinDigits = 1
        Me.GcNumber1.Location = New System.Drawing.Point(68, 108)
        Me.GcNumber1.Name = "GcNumber1"
        Me.GcShortcut1.SetShortcuts(Me.GcNumber1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.Subtract, System.Windows.Forms.Keys.OemMinus, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)}, New Object() {CType(Me.GcNumber1, Object), CType(Me.GcNumber1, Object), CType(Me.GcNumber1, Object), CType(Me.GcNumber1, Object)}, New String() {"SetZero", "SwitchSign", "SwitchSign", "ApplyRecommendedValue"}))
        Me.GcNumber1.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.DropDownButton3})
        Me.GcNumber1.Size = New System.Drawing.Size(120, 20)
        Me.GcNumber1.TabIndex = 7
        '
        'DropDownButton3
        '
        Me.DropDownButton3.Name = "DropDownButton3"
        '
        'GcTextBox1
        '
        Me.GcTextBox1.Location = New System.Drawing.Point(-58, 146)
        Me.GcTextBox1.Name = "GcTextBox1"
        Me.GcShortcut1.SetShortcuts(Me.GcTextBox1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.F2}, New Object() {CType(Me.GcTextBox1, Object)}, New String() {"ShortcutClear"}))
        Me.GcTextBox1.Size = New System.Drawing.Size(120, 20)
        Me.GcTextBox1.TabIndex = 9
        '
        'GcLabel1
        '
        Me.GcLabel1.AutoSize = True
        Me.GcLabel1.Location = New System.Drawing.Point(68, 181)
        Me.GcLabel1.Name = "GcLabel1"
        Me.GcLabel1.Size = New System.Drawing.Size(55, 16)
        Me.GcLabel1.TabIndex = 4
        Me.GcLabel1.Text = "GcLabel1"
        '
        'GcListBox1
        '
        Me.GcListBox1.ListHeaderPane.Height = 19
        Me.GcListBox1.Location = New System.Drawing.Point(87, 146)
        Me.GcListBox1.Name = "GcListBox1"
        Me.GcListBox1.Size = New System.Drawing.Size(120, 96)
        Me.GcListBox1.TabIndex = 5
        '
        'GcMultiRow1
        '
        Me.GcMultiRow1.Location = New System.Drawing.Point(68, 134)
        Me.GcMultiRow1.Name = "GcMultiRow1"
        Me.GcMultiRow1.Size = New System.Drawing.Size(240, 150)
        Me.GcMultiRow1.TabIndex = 6
        Me.GcMultiRow1.Text = "GcMultiRow1"
        '
        'GcResize1
        '
        Me.GcResize1.Target = Me
        '
        'GcTabControl1
        '
        Me.GcTabControl1.Location = New System.Drawing.Point(155, 52)
        Me.GcTabControl1.Name = "GcTabControl1"
        Me.GcTabControl1.Size = New System.Drawing.Size(200, 100)
        Me.GcTabControl1.TabIndex = 8
        Me.GcTabControl1.TabPages.Add(Me.GcTabPage1)
        Me.GcTabControl1.TabPages.Add(Me.GcTabPage2)
        '
        'GcTabPage1
        '
        Me.GcTabPage1.Location = New System.Drawing.Point(4, 24)
        Me.GcTabPage1.Name = "GcTabPage1"
        Me.GcTabPage1.Size = New System.Drawing.Size(192, 72)
        Me.GcTabPage1.TabIndex = 0
        Me.GcTabPage1.Text = "GcTabPage1"
        Me.GcTabPage1.UseVisualStyleBackColor = True
        '
        'GcTabPage2
        '
        Me.GcTabPage2.Location = New System.Drawing.Point(4, 24)
        Me.GcTabPage2.Name = "GcTabPage2"
        Me.GcTabPage2.Size = New System.Drawing.Size(192, 72)
        Me.GcTabPage2.TabIndex = 1
        Me.GcTabPage2.Text = "GcTabPage2"
        Me.GcTabPage2.UseVisualStyleBackColor = True
        '
        'Viewer1
        '
        Me.Viewer1.CurrentPage = 0
        Me.Viewer1.Location = New System.Drawing.Point(136, 4)
        Me.Viewer1.Name = "Viewer1"
        Me.Viewer1.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.Viewer1.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.ParametersPanel.Text = "パラメータ"
        Me.Viewer1.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.Viewer1.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.SearchPanel.Text = "検索"
        Me.Viewer1.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.Viewer1.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.ThumbnailsPanel.Text = "サムネイル"
        Me.Viewer1.Sidebar.ThumbnailsPanel.Width = 200
        Me.Viewer1.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.Viewer1.Sidebar.TocPanel.ContextMenu = Nothing
        Me.Viewer1.Sidebar.TocPanel.Expanded = True
        Me.Viewer1.Sidebar.TocPanel.Text = "見出しマップラベル"
        Me.Viewer1.Sidebar.TocPanel.Width = 200
        Me.Viewer1.Sidebar.Width = 200
        Me.Viewer1.Size = New System.Drawing.Size(824, 441)
        Me.Viewer1.TabIndex = 10
        '
        'PdfExport1
        '
        Me.PdfExport1.Pagination = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Viewer1)
        Me.Controls.Add(Me.GcTextBox1)
        Me.Controls.Add(Me.GcTabControl1)
        Me.Controls.Add(Me.GcNumber1)
        Me.Controls.Add(Me.GcMultiRow1)
        Me.Controls.Add(Me.GcListBox1)
        Me.Controls.Add(Me.GcLabel1)
        Me.Controls.Add(Me.GcDateTime1)
        Me.Controls.Add(Me.GcComboBox1)
        Me.Controls.Add(Me.GcCheckBox1)
        Me.Controls.Add(Me.GcButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GcComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcDateTime1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcNumber1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcListBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcMultiRow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcResize1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GcTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GcTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GcButton1 As GrapeCity.Win.Buttons.GcButton
    Friend WithEvents GcCheckBox1 As GrapeCity.Win.Buttons.GcCheckBox
    Friend WithEvents GcComboBox1 As GrapeCity.Win.Editors.GcComboBox
    Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
    Friend WithEvents DropDownButton1 As GrapeCity.Win.Editors.DropDownButton
    Friend WithEvents GcDateTime1 As GrapeCity.Win.Editors.GcDateTime
    Friend WithEvents DropDownButton2 As GrapeCity.Win.Editors.DropDownButton
    Friend WithEvents GcIme1 As GrapeCity.Win.Editors.GcIme
    Friend WithEvents GcLabel1 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents GcListBox1 As GrapeCity.Win.Editors.GcListBox
    Friend WithEvents GcMultiRow1 As GrapeCity.Win.MultiRow.GcMultiRow
    Friend WithEvents GcNumber1 As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents DropDownButton3 As GrapeCity.Win.Editors.DropDownButton
    Friend WithEvents GcResize1 As GrapeCity.Win.Components.GcResize
    Friend WithEvents GcTextBox1 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents GcTabControl1 As GrapeCity.Win.Containers.GcTabControl
    Friend WithEvents GcTabPage1 As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents GcTabPage2 As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents GcShortcut2 As GrapeCity.Win.Editors.GcShortcut
    Friend WithEvents Viewer1 As GrapeCity.ActiveReports.Viewer.Win.Viewer
    Friend WithEvents PdfExport1 As GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
End Class
