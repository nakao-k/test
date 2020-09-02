<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_W0102
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
        Me.lblkensaku_taisho = New GrapeCity.Win.Buttons.GcLabel()
        Me.pnlMR = New System.Windows.Forms.Panel()
        Me.gmr = New GrapeCity.Win.MultiRow.GcMultiRow()
        Me.btnClear = New CommonForm.MsysButton()
        Me.btnSearch = New CommonForm.MsysButton()
        Me.cbxseijo = New GrapeCity.Win.Buttons.GcCheckBox()
        Me.cbxerror = New GrapeCity.Win.Buttons.GcCheckBox()
        CType(Me.txtkousintantousha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txttourokutanrousha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBottom.SuspendLayout()
        Me.pnlMR.SuspendLayout()
        CType(Me.gmr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbtTitle
        '
        Me.lbtTitle.Text = "取込結果詳細"
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
        Me.btnF09.Text = "一括" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "再処理"
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
        'lblkensaku_taisho
        '
        Me.lblkensaku_taisho.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.lblkensaku_taisho.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblkensaku_taisho.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.lblkensaku_taisho.ForeColor = System.Drawing.Color.White
        Me.lblkensaku_taisho.Location = New System.Drawing.Point(12, 46)
        Me.lblkensaku_taisho.Name = "lblkensaku_taisho"
        Me.lblkensaku_taisho.Size = New System.Drawing.Size(108, 24)
        Me.lblkensaku_taisho.TabIndex = 1333
        Me.lblkensaku_taisho.Tag = "1"
        Me.lblkensaku_taisho.Text = "検索対象"
        Me.lblkensaku_taisho.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lblkensaku_taisho.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'pnlMR
        '
        Me.pnlMR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMR.Controls.Add(Me.gmr)
        Me.pnlMR.Location = New System.Drawing.Point(12, 82)
        Me.pnlMR.Name = "pnlMR"
        Me.pnlMR.Size = New System.Drawing.Size(1112, 526)
        Me.pnlMR.TabIndex = 1363
        '
        'gmr
        '
        Me.gmr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.gmr.Location = New System.Drawing.Point(0, 0)
        Me.gmr.Name = "gmr"
        Me.gmr.Size = New System.Drawing.Size(1112, 526)
        Me.gmr.TabIndex = 0
        Me.gmr.Text = "gmr"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(1038, 46)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(86, 24)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "クリア"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(952, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(86, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "検索"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'cbxseijo
        '
        Me.cbxseijo.AutoSize = True
        Me.cbxseijo.Location = New System.Drawing.Point(126, 48)
        Me.cbxseijo.Name = "cbxseijo"
        Me.cbxseijo.Size = New System.Drawing.Size(61, 18)
        Me.cbxseijo.TabIndex = 0
        Me.cbxseijo.Tag = "1"
        Me.cbxseijo.Text = "正常"
        Me.cbxseijo.UseVisualStyleBackColor = True
        '
        'cbxerror
        '
        Me.cbxerror.AutoSize = True
        Me.cbxerror.Location = New System.Drawing.Point(193, 48)
        Me.cbxerror.Name = "cbxerror"
        Me.cbxerror.Size = New System.Drawing.Size(77, 18)
        Me.cbxerror.TabIndex = 2
        Me.cbxerror.Tag = "1"
        Me.cbxerror.Text = "エラー"
        Me.cbxerror.UseVisualStyleBackColor = True
        '
        'frm_W0102
        '
        Me.ClientSize = New System.Drawing.Size(1136, 689)
        Me.Controls.Add(Me.cbxerror)
        Me.Controls.Add(Me.cbxseijo)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.pnlMR)
        Me.Controls.Add(Me.lblkensaku_taisho)
        Me.Name = "frm_W0102"
        Me.Tag = "0"
        Me.Text = "取込結果詳細"
        Me.Controls.SetChildIndex(Me.lblkensaku_taisho, 0)
        Me.Controls.SetChildIndex(Me.lbtTitle, 0)
        Me.Controls.SetChildIndex(Me.pnlBottom, 0)
        Me.Controls.SetChildIndex(Me.lblkousintantousha, 0)
        Me.Controls.SetChildIndex(Me.txttourokutanrousha, 0)
        Me.Controls.SetChildIndex(Me.lbltourokutanrousha, 0)
        Me.Controls.SetChildIndex(Me.txtkousintantousha, 0)
        Me.Controls.SetChildIndex(Me.pnlMR, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnClear, 0)
        Me.Controls.SetChildIndex(Me.cbxseijo, 0)
        Me.Controls.SetChildIndex(Me.cbxerror, 0)
        CType(Me.txtkousintantousha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txttourokutanrousha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlBottom.PerformLayout()
        Me.pnlMR.ResumeLayout(False)
        CType(Me.gmr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblkensaku_taisho As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents pnlMR As Panel
    Friend WithEvents gmr As GrapeCity.Win.MultiRow.GcMultiRow
    Friend WithEvents btnClear As MsysButton
    Friend WithEvents btnSearch As MsysButton
    Friend WithEvents cbxseijo As GrapeCity.Win.Buttons.GcCheckBox
    Friend WithEvents cbxerror As GrapeCity.Win.Buttons.GcCheckBox
End Class
