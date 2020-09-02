<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_W0101
    Inherits CommonForm.BaseForm

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DateMonthField1 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
        Dim DateYearField1 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
        Dim DateLiteralField1 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateLiteralField2 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateDayField1 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
        Dim DateMonthField2 As GrapeCity.Win.Editors.Fields.DateMonthField = New GrapeCity.Win.Editors.Fields.DateMonthField()
        Dim DateYearField2 As GrapeCity.Win.Editors.Fields.DateYearField = New GrapeCity.Win.Editors.Fields.DateYearField()
        Dim DateLiteralField3 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateLiteralField4 As GrapeCity.Win.Editors.Fields.DateLiteralField = New GrapeCity.Win.Editors.Fields.DateLiteralField()
        Dim DateDayField2 As GrapeCity.Win.Editors.Fields.DateDayField = New GrapeCity.Win.Editors.Fields.DateDayField()
        Me.pnlMR = New System.Windows.Forms.Panel()
        Me.gmr = New GrapeCity.Win.MultiRow.GcMultiRow()
        Me.btnClear = New CommonForm.MsysButton()
        Me.btnSearch = New CommonForm.MsysButton()
        Me.btntokuisaki_code = New CommonForm.MsysButton()
        Me.txttokuisaki_meisho = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.GcLabel14 = New GrapeCity.Win.Buttons.GcLabel()
        Me.dtytorikomi_shoribi_shuryo = New GrapeCity.Win.Editors.GcDateTime(Me.components)
        Me.SideButton2 = New GrapeCity.Win.Editors.SideButton()
        Me.dtytorikomi_shoribi_kaishi = New GrapeCity.Win.Editors.GcDateTime(Me.components)
        Me.SideButton1 = New GrapeCity.Win.Editors.SideButton()
        Me.lbltokuisaki = New GrapeCity.Win.Buttons.GcLabel()
        Me.txttokuisaki_code = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.lbltorikomi_shori_bi = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbltaisho_data = New GrapeCity.Win.Buttons.GcLabel()
        Me.rdojuchu = New GrapeCity.Win.Buttons.GcRadioButton()
        Me.rdokanban = New GrapeCity.Win.Buttons.GcRadioButton()
        CType(Me.txtkousintantousha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttourokutanrousha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.pnlMR.SuspendLayout()
        CType(Me.gmr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttokuisaki_meisho, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtytorikomi_shoribi_shuryo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtytorikomi_shoribi_kaishi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttokuisaki_code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbtTitle
        '
        Me.lbtTitle.TabIndex = 0
        Me.lbtTitle.Text = "取込結果照会"
        '
        'btnF01
        '
        Me.btnF01.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF06
        '
        Me.btnF06.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF02
        '
        Me.btnF02.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        Me.btnF02.Text = "詳細"
        '
        'btnF05
        '
        Me.btnF05.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        Me.btnF05.Text = "検索"
        '
        'btnF07
        '
        Me.btnF07.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF03
        '
        Me.btnF03.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF04
        '
        Me.btnF04.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF12
        '
        Me.btnF12.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        Me.btnF12.Text = "閉じる"
        '
        'btnF10
        '
        Me.btnF10.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF09
        '
        Me.btnF09.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'btnF08
        '
        Me.btnF08.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        Me.btnF08.Text = "一覧" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "コピー"
        '
        'btnF11
        '
        Me.btnF11.FlatStyle = GrapeCity.Win.Common.FlatStyleEx.Standard
        '
        'pnlMR
        '
        Me.pnlMR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMR.Controls.Add(Me.gmr)
        Me.pnlMR.Location = New System.Drawing.Point(12, 108)
        Me.pnlMR.Name = "pnlMR"
        Me.pnlMR.Size = New System.Drawing.Size(1112, 500)
        Me.pnlMR.TabIndex = 1331
        '
        'gmr
        '
        Me.gmr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gmr.Location = New System.Drawing.Point(0, 0)
        Me.gmr.Name = "gmr"
        Me.gmr.Size = New System.Drawing.Size(1112, 497)
        Me.gmr.TabIndex = 0
        Me.gmr.Text = "gmr"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1038, 72)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 24)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(952, 72)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 24)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btntokuisaki_code
        '
        Me.btntokuisaki_code.Location = New System.Drawing.Point(537, 72)
        Me.btntokuisaki_code.Name = "btntokuisaki_code"
        Me.btntokuisaki_code.Size = New System.Drawing.Size(49, 24)
        Me.btntokuisaki_code.TabIndex = 5
        Me.btntokuisaki_code.Text = "選択"
        Me.btntokuisaki_code.UseVisualStyleBackColor = True
        '
        'txttokuisaki_meisho
        '
        Me.txttokuisaki_meisho.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txttokuisaki_meisho.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.txttokuisaki_meisho.Location = New System.Drawing.Point(587, 72)
        Me.txttokuisaki_meisho.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttokuisaki_meisho.Name = "txttokuisaki_meisho"
        Me.txttokuisaki_meisho.ReadOnly = True
        Me.txttokuisaki_meisho.Size = New System.Drawing.Size(337, 24)
        Me.txttokuisaki_meisho.TabIndex = 6
        Me.txttokuisaki_meisho.Tag = "9"
        '
        'GcLabel14
        '
        Me.GcLabel14.AutoSize = True
        Me.GcLabel14.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.GcLabel14.ForeColor = System.Drawing.Color.Black
        Me.GcLabel14.Location = New System.Drawing.Point(225, 75)
        Me.GcLabel14.Name = "GcLabel14"
        Me.GcLabel14.Size = New System.Drawing.Size(22, 19)
        Me.GcLabel14.TabIndex = 63
        Me.GcLabel14.Text = "～"
        '
        'dtytorikomi_shoribi_shuryo
        '
        Me.dtytorikomi_shoribi_shuryo.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.dtytorikomi_shoribi_shuryo.DefaultActiveField = DateMonthField1
        DateLiteralField1.Text = "/"
        DateLiteralField2.Text = "/"
        Me.dtytorikomi_shoribi_shuryo.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField1, DateLiteralField1, DateMonthField1, DateLiteralField2, DateDayField1})
        Me.dtytorikomi_shoribi_shuryo.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.dtytorikomi_shoribi_shuryo.HighlightText = GrapeCity.Win.Editors.HighlightText.All
        Me.dtytorikomi_shoribi_shuryo.Location = New System.Drawing.Point(251, 72)
        Me.dtytorikomi_shoribi_shuryo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtytorikomi_shoribi_shuryo.Name = "dtytorikomi_shoribi_shuryo"
        Me.dtytorikomi_shoribi_shuryo.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.SideButton2})
        Me.dtytorikomi_shoribi_shuryo.Size = New System.Drawing.Size(112, 24)
        Me.dtytorikomi_shoribi_shuryo.Spin.AllowSpin = False
        Me.dtytorikomi_shoribi_shuryo.TabIndex = 3
        Me.dtytorikomi_shoribi_shuryo.Tag = "1"
        Me.dtytorikomi_shoribi_shuryo.Value = Nothing
        '
        'SideButton2
        '
        Me.SideButton2.ButtonWidth = 25
        Me.SideButton2.Name = "SideButton2"
        '
        'dtytorikomi_shoribi_kaishi
        '
        Me.dtytorikomi_shoribi_kaishi.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.dtytorikomi_shoribi_kaishi.DefaultActiveField = DateMonthField2
        DateLiteralField3.Text = "/"
        DateLiteralField4.Text = "/"
        Me.dtytorikomi_shoribi_kaishi.Fields.AddRange(New GrapeCity.Win.Editors.Fields.DateField() {DateYearField2, DateLiteralField3, DateMonthField2, DateLiteralField4, DateDayField2})
        Me.dtytorikomi_shoribi_kaishi.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.dtytorikomi_shoribi_kaishi.HighlightText = GrapeCity.Win.Editors.HighlightText.All
        Me.dtytorikomi_shoribi_kaishi.Location = New System.Drawing.Point(110, 72)
        Me.dtytorikomi_shoribi_kaishi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtytorikomi_shoribi_kaishi.Name = "dtytorikomi_shoribi_kaishi"
        Me.dtytorikomi_shoribi_kaishi.SideButtons.AddRange(New GrapeCity.Win.Editors.SideButtonBase() {Me.SideButton1})
        Me.dtytorikomi_shoribi_kaishi.Size = New System.Drawing.Size(112, 24)
        Me.dtytorikomi_shoribi_kaishi.Spin.AllowSpin = False
        Me.dtytorikomi_shoribi_kaishi.TabIndex = 2
        Me.dtytorikomi_shoribi_kaishi.Tag = "1"
        Me.dtytorikomi_shoribi_kaishi.Value = Nothing
        '
        'SideButton1
        '
        Me.SideButton1.ButtonWidth = 25
        Me.SideButton1.Name = "SideButton1"
        '
        'lbltokuisaki
        '
        Me.lbltokuisaki.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lbltokuisaki.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltokuisaki.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.lbltokuisaki.ForeColor = System.Drawing.Color.White
        Me.lbltokuisaki.Location = New System.Drawing.Point(394, 72)
        Me.lbltokuisaki.Name = "lbltokuisaki"
        Me.lbltokuisaki.Size = New System.Drawing.Size(97, 24)
        Me.lbltokuisaki.TabIndex = 55
        Me.lbltokuisaki.Tag = "1"
        Me.lbltokuisaki.Text = "得意先"
        Me.lbltokuisaki.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbltokuisaki.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'txttokuisaki_code
        '
        Me.txttokuisaki_code.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txttokuisaki_code.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!)
        Me.txttokuisaki_code.Location = New System.Drawing.Point(492, 72)
        Me.txttokuisaki_code.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttokuisaki_code.Name = "txttokuisaki_code"
        Me.txttokuisaki_code.Size = New System.Drawing.Size(44, 24)
        Me.txttokuisaki_code.TabIndex = 4
        Me.txttokuisaki_code.Tag = "1"
        Me.txttokuisaki_code.Text = "123"
        '
        'lbltorikomi_shori_bi
        '
        Me.lbltorikomi_shori_bi.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lbltorikomi_shori_bi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltorikomi_shori_bi.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.lbltorikomi_shori_bi.ForeColor = System.Drawing.Color.White
        Me.lbltorikomi_shori_bi.Location = New System.Drawing.Point(12, 72)
        Me.lbltorikomi_shori_bi.Name = "lbltorikomi_shori_bi"
        Me.lbltorikomi_shori_bi.Size = New System.Drawing.Size(97, 24)
        Me.lbltorikomi_shori_bi.TabIndex = 47
        Me.lbltorikomi_shori_bi.Tag = "1"
        Me.lbltorikomi_shori_bi.Text = "取込処理日"
        Me.lbltorikomi_shori_bi.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbltorikomi_shori_bi.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbltaisho_data
        '
        Me.lbltaisho_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lbltaisho_data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltaisho_data.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.lbltaisho_data.ForeColor = System.Drawing.Color.White
        Me.lbltaisho_data.Location = New System.Drawing.Point(12, 46)
        Me.lbltaisho_data.Name = "lbltaisho_data"
        Me.lbltaisho_data.Size = New System.Drawing.Size(97, 24)
        Me.lbltaisho_data.TabIndex = 44
        Me.lbltaisho_data.Tag = "2"
        Me.lbltaisho_data.Text = "対象データ"
        Me.lbltaisho_data.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbltaisho_data.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'rdojuchu
        '
        Me.rdojuchu.AutoSize = True
        Me.rdojuchu.Location = New System.Drawing.Point(115, 46)
        Me.rdojuchu.Name = "rdojuchu"
        Me.rdojuchu.Size = New System.Drawing.Size(61, 18)
        Me.rdojuchu.TabIndex = 0
        Me.rdojuchu.TabStop = True
        Me.rdojuchu.Text = "受注"
        Me.rdojuchu.UseVisualStyleBackColor = True
        '
        'rdokanban
        '
        Me.rdokanban.AutoSize = True
        Me.rdokanban.Location = New System.Drawing.Point(182, 46)
        Me.rdokanban.Name = "rdokanban"
        Me.rdokanban.Size = New System.Drawing.Size(93, 18)
        Me.rdokanban.TabIndex = 1
        Me.rdokanban.TabStop = True
        Me.rdokanban.Text = "かんばん"
        Me.rdokanban.UseVisualStyleBackColor = True
        '
        'frm_W0101
        '
        Me.ClientSize = New System.Drawing.Size(1136, 689)
        Me.Controls.Add(Me.rdokanban)
        Me.Controls.Add(Me.rdojuchu)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btntokuisaki_code)
        Me.Controls.Add(Me.lbltaisho_data)
        Me.Controls.Add(Me.pnlMR)
        Me.Controls.Add(Me.dtytorikomi_shoribi_kaishi)
        Me.Controls.Add(Me.dtytorikomi_shoribi_shuryo)
        Me.Controls.Add(Me.lbltorikomi_shori_bi)
        Me.Controls.Add(Me.lbltokuisaki)
        Me.Controls.Add(Me.txttokuisaki_code)
        Me.Controls.Add(Me.txttokuisaki_meisho)
        Me.Controls.Add(Me.GcLabel14)
        Me.Name = "frm_W0101"
        Me.Tag = "0"
        Me.Text = "取込結果照会"
        Me.Controls.SetChildIndex(Me.GcLabel14, 0)
        Me.Controls.SetChildIndex(Me.txttokuisaki_meisho, 0)
        Me.Controls.SetChildIndex(Me.txttokuisaki_code, 0)
        Me.Controls.SetChildIndex(Me.lbltokuisaki, 0)
        Me.Controls.SetChildIndex(Me.lbltorikomi_shori_bi, 0)
        Me.Controls.SetChildIndex(Me.dtytorikomi_shoribi_shuryo, 0)
        Me.Controls.SetChildIndex(Me.dtytorikomi_shoribi_kaishi, 0)
        Me.Controls.SetChildIndex(Me.pnlMR, 0)
        Me.Controls.SetChildIndex(Me.lbtTitle, 0)
        Me.Controls.SetChildIndex(Me.pnlBottom, 0)
        Me.Controls.SetChildIndex(Me.lblkousintantousha, 0)
        Me.Controls.SetChildIndex(Me.lbltaisho_data, 0)
        Me.Controls.SetChildIndex(Me.btntokuisaki_code, 0)
        Me.Controls.SetChildIndex(Me.txttourokutanrousha, 0)
        Me.Controls.SetChildIndex(Me.lbltourokutanrousha, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.txtkousintantousha, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.rdojuchu, 0)
        Me.Controls.SetChildIndex(Me.rdokanban, 0)
        CType(Me.txtkousintantousha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttourokutanrousha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlMR.ResumeLayout(False)
        CType(Me.gmr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttokuisaki_meisho, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtytorikomi_shoribi_shuryo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtytorikomi_shoribi_kaishi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttokuisaki_code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlMR As Panel
    Friend WithEvents gmr As GrapeCity.Win.MultiRow.GcMultiRow
    Friend WithEvents txttokuisaki_meisho As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents GcLabel14 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents dtytorikomi_shoribi_shuryo As GrapeCity.Win.Editors.GcDateTime
    Friend WithEvents dtytorikomi_shoribi_kaishi As GrapeCity.Win.Editors.GcDateTime
    Friend WithEvents lbltokuisaki As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents txttokuisaki_code As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents lbltorikomi_shori_bi As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbltaisho_data As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents btntokuisaki_code As MsysButton
    Friend WithEvents btnClear As MsysButton
    Friend WithEvents btnSearch As MsysButton
    Friend WithEvents SideButton1 As GrapeCity.Win.Editors.SideButton
    Friend WithEvents SideButton2 As GrapeCity.Win.Editors.SideButton
    Friend WithEvents rdojuchu As GrapeCity.Win.Buttons.GcRadioButton
    Friend WithEvents rdokanban As GrapeCity.Win.Buttons.GcRadioButton
End Class
