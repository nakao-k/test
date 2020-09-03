Imports GrapeCity.Win.MultiRow

Public Class frm_W0101

    'PG修正
　　

    'SQLバインド変数名用定数
    Private Const SQL_TOKUISAKI_CODE As String = "@tokuisaki_code"                           '得意先
    Private Const SQL_TORIKOMI_SHORI_KAISHI As String = "@torikomi_shori_kaishi"             '取込処理開始
    Private Const SQL_TORIKOMI_SHORI_SHURYO As String = "@torikomi_shori_shuryo"             '取込処理終了


    '枝分かれ－－


#Region "BaseFormのLoad時処理を実装"

    ''' <summary>
    ''' 画面タイトル、ボタンの使用不可を設定
    ''' </summary>
    ''' <remarks>
    ''' 参照モードの場合は選択ボタンを表示
    ''' </remarks>
    Protected Overrides Sub SetInitialControlBefRefresh()

    End Sub

    ''' <summary>
    ''' 画面項目初期値設定処理
    ''' </summary>
    ''' <remarks>
    ''' 画面上のコントロールの初期設定を実装
    ''' </remarks>
    Protected Overrides Sub SetInitialControl()

        MultiRowInit()

    End Sub

    ''' <summary>
    ''' MultiRow設定処理
    ''' </summary>
    ''' <remarks>
    ''' MultiRowのテンプレート設定を記載
    ''' </remarks>
    Private Sub MultiRowInit()

        Dim tmp As New tmp_W0101

        'DataFieldを設定する
        clsMultirow.SetCellDataFeild("tokuisaki_ryakusho", tmp.chctokuisaki_ryakusho, tmp.ctetokusaki_ryakusho)
        clsMultirow.SetCellDataFeild("file_mei", tmp.chctorikomi_file, tmp.ctetorikomi_file)
        clsMultirow.SetCellDataFeild("seijo_kensu", tmp.chcseijo_kensu, tmp.cnbseijo_kensu)
        clsMultirow.SetCellDataFeild("keikoku_kensu", tmp.chcijo_kensu, tmp.cnbijo_kensu)
        clsMultirow.SetCellDataFeild("error_kensu", tmp.chcerror_kensu, tmp.cnberror_kensu)
        clsMultirow.SetCellDataFeild("gokei_kensu", tmp.chcgokei_kensu, tmp.cnbgokei_kensu)
        clsMultirow.SetCellDataFeild("torikomi_bi", tmp.chctorikomi_bi, tmp.ctetorikomi_bi)
        clsMultirow.SetCellDataFeild("shimei", tmp.chcshimei, tmp.cteshimei)

        '隠し列を設定
        tmp.ctetokuisaki_code_hidden.DataField = "tokuisaki_code"
        tmp.ctetorikomi_nichiji_hidden.DataField = "torikomi_nichiji"

        ''※注意※　以下で設定するコントロールはすべて Modifiers = Friend に設定してください
        ''▼テンプレートの設定
        clsMultirow.MRSetTemplate(tmp)

        '文字配置を設定

        'MRにテンプレートを設定
        gmr.Template = tmp.Clone

        Try
            '▼MultiRow編集開始
            gmr.SuspendLayout()

            'MultiRowSheet　初期処理
            clsMultirow.MRInit(gmr, enmMRRowAdd.Impossible, enmMREdit.uneditable)

        Finally
            '▼MultiRow編集終了
            gmr.ResumeLayout()

        End Try

    End Sub

    ''' <summary>
    ''' 初期表示時の初期値を設定
    ''' </summary>
    ''' <remarks>
    ''' 初期表示時の初期値を設定
    ''' </remarks>
    Protected Overrides Sub SetInitialData()

        '取込処理日(開始)の初期値セット
        Dim strNowYMD As String = clsCommon.GetDateNow()
        clsCommon.SetValue(dtytorikomi_shoribi_kaishi, strNowYMD)

    End Sub

#End Region

#Region "検索ボタン押下処理"

    ''' <summary>
    ''' 検索処理
    ''' </summary>
    ''' <remarks>
    ''' 検索処理を行う。
    ''' </remarks>
    Private Sub Syori_Search()

        Try

            'ボタンにフォーカス設定 
            btnSearch.Focus()

            '入力チェック
            If Not InputCheck() Then
                Exit Sub
            End If

            '実行前処理 
            SyoriStart()

            '検索条件退避 
            SetToTai()

            '一覧表示 
            IchiranHyoji(True)

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼ 
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲ 

        Finally
            '実行後処理 
            SyoriEnd()

        End Try

    End Sub

    ''' <summary>
    ''' 検索条件退避処理
    ''' </summary>
    ''' <param name="strtokuisaki_code"></param>
    ''' <remarks>
    ''' 検索条件の対比処理を行う。
    ''' </remarks>
    Private Sub SetToTai(Optional ByVal strtokuisaki_code As String = "")

        '変数をクリア（Clearメソッドではアイテムが削除されるので、新規登録後再索引する際にエラーが発生する）
        For Each strKey In fdicSearch.Keys.ToArray
            fdicSearch(strKey) = ""
        Next

        '詳細画面で更新処理が行われた場合

        '取込処理日開始
        fdicSearch(dtytorikomi_shoribi_kaishi.Name.ToString()) = clsCommon.GetValue(dtytorikomi_shoribi_kaishi)
        '取込処理日終了
        fdicSearch(dtytorikomi_shoribi_shuryo.Name.ToString()) = clsCommon.GetValue(dtytorikomi_shoribi_shuryo)
        '得意先コード
        fdicSearch(txttokuisaki_code.Name.ToString()) = clsCommon.GetValue(txttokuisaki_code)

    End Sub

    ''' <summary>
    ''' 一覧表示
    ''' </summary>
    ''' <param name="blnDoExistCheck"></param>
    ''' <remarks>
    ''' 一覧の表示を行う
    ''' </remarks>
    Private Sub IchiranHyoji(ByVal blnDoExistCheck As Boolean)

        Dim dsPara As New DataSet
        Dim stbSQL As New System.Text.StringBuilder

        Try
            '---実行前処理 
            SyoriStart()

            'データテーブル設定 
            clsCommon.SetDataSet_FromDataTable(dsPara)

            'SQL文作成 
            If rdojuchu.Checked Then
                CreateSQL_Juchu_ShowData(stbSQL, dsPara)
            ElseIf rdokanban.Checked Then
                CreateSQL_Kanban_ShowData(stbSQL, dsPara)
            End If

            If Not gstrNotKensuCheckFrmName.Contains(Me.Name) Then

                If blnDoExistCheck Then

                    '件数チェック 
                    If Not clsCommon.CheckDataCount(stbSQL, dsPara, "tokuisaki_code", fstrPrjName, gmr) Then
                        Exit Sub
                    End If

                Else

                    '最大表示件数取得用SQL文作成 
                    clsCommon.SetSQL_TOP(stbSQL)

                End If

            End If

            'MultiRow編集 
            MultiRowEdit(stbSQL, dsPara)

        Finally
            clsCommon.TerminateData(dsPara)
            stbSQL = Nothing
            '---実行後処理 
            SyoriEnd()

        End Try

    End Sub

    ''' <summary>
    ''' MultiRow編集処理
    ''' </summary>
    ''' <param name="stbSQL"></param>
    ''' <param name="dsPara"></param>
    ''' <remarks>
    ''' 検索条件に該当するデータを、データテーブルに格納し、MultiRowとデータをバインドする 
    ''' </remarks>
    Private Sub MultiRowEdit(ByVal stbSQL As System.Text.StringBuilder, ByVal dsPara As DataSet)

        Dim ds As New DataSet
        Dim blnRet As Boolean

        Try

            gmr.SuspendLayout()

            'データの取得 
            blnRet = clsCommon.GetData_Para(stbSQL.ToString(), ds, dsPara, fstrPrjName, Me)

            '必要な場合のみPrefixを設定する

            'データソースを設定 
            gmr.DataSource = ds

            '表示するデータメンバーを設定 
            gmr.DataMember = DATTABLE_WEBSVC

            'データが存在する場合 
            If blnRet Then

                'フォーカスを設定 
                gmr.Focus()

            Else
                '入力画面から戻って該当データが存在しない場合一覧削除 
                clsMultirow.MRClear(gmr)
            End If

        Finally
            clsCommon.TerminateData(ds)

            '一覧編集後処理 
            clsMultirow.MRDataEditEndProcess(gmr)

            gmr.ResumeLayout()

        End Try

    End Sub

#Region "チェック関連"

    ''' <summary>
    ''' 入力チェック
    ''' </summary>
    ''' <returns>
    ''' True:入力ＯＫ,False:入力エラー
    ''' </returns>
    ''' <remarks>
    ''' 入力チェックを行い、入力エラーメッセージを表示する。 
    ''' </remarks>
    Private Function InputCheck() As Boolean

        '戻り値の初期化 
        InputCheck = False

        If Not rdojuchu.Checked AndAlso Not rdokanban.Checked Then
            Exit Function
        End If

        'エラーがなかった場合 
        InputCheck = True

    End Function

#End Region

#Region "SQL文作成"
    ''' <summary>
    ''' SQL文作成処理（受注）
    ''' </summary>
    ''' <param name="stbSQL"></param>
    ''' <param name="dsPara"></param>
    ''' <remarks>
    ''' MultiRow編集用のSQL文を作成する。 
    ''' </remarks>
    Private Sub CreateSQL_Juchu_ShowData(ByRef stbSQL As System.Text.StringBuilder, ByRef dsPara As DataSet)

        Dim stbSQL_Select As New System.Text.StringBuilder

        Try
            stbSQL_Select.AppendLine(" SELECT ")
            stbSQL_Select.AppendLine("        tokuisaki.tokuisaki_ryakusho  ")
            stbSQL_Select.AppendLine("       ,edi_juchu.tokuisaki_code  ")
            stbSQL_Select.AppendLine("       ,CONVERT(varchar,edi_juchu.torikomi_nichiji,111) + ' ' + CONVERT(varchar,edi_juchu.torikomi_nichiji,114) AS torikomi_nichiji  ")
            stbSQL_Select.AppendLine("       ,edi_juchu.file_mei  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.seijo_kensu,0) AS seijo_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.keikoku_kensu ,0) AS keikoku_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.error_kensu ,0) AS error_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.gokei_kensu ,0) AS gokei_kensu  ")
            stbSQL_Select.AppendLine("       ,CONVERT(varchar,edi_juchu.torikomi_nichiji,111) AS torikomi_bi  ")
            stbSQL_Select.AppendLine("       ,ms.shimei  ")
            stbSQL_Select.AppendLine(" FROM  ")
            stbSQL_Select.AppendLine("       t_edi_juchu_torikomi_rireki AS edi_juchu  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")
            stbSQL_Select.AppendLine("       m_tokuisaki AS tokuisaki  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_juchu.tokuisaki_code = tokuisaki.tokuisaki_code  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")
            stbSQL_Select.AppendLine("       m_shain AS ms  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_juchu.created_by = ms.shain_bango  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")

            '各件数
            stbSQL_Select.AppendLine("       (  ")
            stbSQL_Select.AppendLine("       SELECT ")
            'stbSQL_Select.AppendLine("              t_juchu_meisai.tokuisaki_code  ")
            stbSQL_Select.AppendLine("              t_juchu_meisai.torikomi_nichiji  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_juchu_meisai.error_kubun = '0' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS seijo_kensu  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_juchu_meisai.error_kubun = '1' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS keikoku_kensu  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_juchu_meisai.error_kubun = '2' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS error_kensu  ")
            stbSQL_Select.AppendLine("             ,COUNT(torikomi_nichiji) AS gokei_kensu  ")
            stbSQL_Select.AppendLine("       FROM  ")
            stbSQL_Select.AppendLine("             t_juchu_meisai  ")
            stbSQL_Select.AppendLine("       GROUP BY  ")
            stbSQL_Select.AppendLine("             t_juchu_meisai.torikomi_nichiji  ")
            stbSQL_Select.AppendLine("       ) AS kensu  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_juchu.torikomi_nichiji = kensu.torikomi_nichiji  ")
            'stbSQL_Select.AppendLine("       AND edi_juchu.tokuisaki_code = kensu.tokuisaki_code  ")

            '【WHERE句】
            stbSQL_Select.AppendLine(CreateSQL_Juchu_Where(dsPara))

            '【ORDER BY句】
            stbSQL_Select.AppendLine(" ORDER BY  ")
            stbSQL_Select.AppendLine("        edi_juchu.torikomi_nichiji DESC  ")
            stbSQL_Select.AppendLine("       ,edi_juchu.tokuisaki_code ASC  ")

            stbSQL.Append(stbSQL_Select.ToString)

        Finally
            stbSQL_Select = Nothing
        End Try

    End Sub

    ''' <summary>
    ''' WHERE句作成処理
    ''' </summary>
    ''' <param name="dsPara">データセット</param>
    ''' <returns>
    ''' WHERE句
    ''' </returns>
    ''' <remarks>
    ''' 各条件に応じたWHERE句を作成する。 
    ''' </remarks>
    Private Function CreateSQL_Juchu_Where(ByRef dsPara As DataSet) As String

        Dim stbWhere As New System.Text.StringBuilder  'Where句 

        Try

            '戻り値の初期化 
            CreateSQL_Juchu_Where = ""

            '【検索条件…入力項目が空でなければ条件に含める】 
            '※退避した検索条件を使用する 

            '得意先コード
            If clsCommon.GetDicValue(fdicSearch, txttokuisaki_code.Name.ToString) <> "" Then
                '検索条件を追加
                If stbWhere.ToString <> "" Then stbWhere.AppendLine(" And ")
                stbWhere.AppendLine(" edi_juchu.tokuisaki_code = " & SQL_TOKUISAKI_CODE & " ")
                clsCommon.SetDataTable_ForParameter(dsPara, SQL_TOKUISAKI_CODE, t_edi_juchu_torikomi_rireki.tokuisaki_code__varchar__4.ToString, clsCommon.GetDicValue(fdicSearch, txttokuisaki_code.Name.ToString))
            End If

            '取込処理日
            If clsCommon.GetDicValue(fdicSearch, dtytorikomi_shoribi_kaishi.Name.ToString()) <> "" OrElse clsCommon.GetDicValue(fdicSearch, dtytorikomi_shoribi_shuryo.Name.ToString()) <> "" Then
                '検索条件を追加
                If stbWhere.ToString <> "" Then stbWhere.AppendLine(" And ")

                stbWhere.AppendLine(clsCommon.GetSqlWhereYMD(dsPara, t_edi_juchu_torikomi_rireki.torikomi_nichiji__varchar__23.ToString, "CAST(edi_juchu.torikomi_nichiji AS DATE)",
                                    SQL_TORIKOMI_SHORI_KAISHI, SQL_TORIKOMI_SHORI_SHURYO, Trim(fdicSearch(dtytorikomi_shoribi_kaishi.Name.ToString)), Trim(fdicSearch(dtytorikomi_shoribi_shuryo.Name.ToString))))
            End If

            '条件が一件以上設定されているとき 
            If stbWhere.ToString <> "" Then
                stbWhere.Insert(0, " WHERE ")
            End If

            '戻り値の設定 
            CreateSQL_Juchu_Where = stbWhere.ToString

        Finally
            stbWhere = Nothing
        End Try

    End Function

    ''' <summary>
    ''' SQL文作成処理（かんばん）
    ''' </summary>
    ''' <param name="stbSQL"></param>
    ''' <param name="dsPara"></param>
    ''' <remarks>
    ''' MultiRow編集用のSQL文を作成する。 
    ''' </remarks>
    Private Sub CreateSQL_Kanban_ShowData(ByRef stbSQL As System.Text.StringBuilder, ByRef dsPara As DataSet)

        Dim stbSQL_Select As New System.Text.StringBuilder

        Try
            stbSQL_Select.AppendLine(" SELECT ")
            stbSQL_Select.AppendLine("        tokuisaki.tokuisaki_ryakusho  ")
            stbSQL_Select.AppendLine("       ,edi_kanban.tokuisaki_code  ")
            stbSQL_Select.AppendLine("       ,CONVERT(varchar,edi_kanban.torikomi_nichiji,111) + ' ' + CONVERT(varchar,edi_kanban.torikomi_nichiji,114) AS torikomi_nichiji  ")
            stbSQL_Select.AppendLine("       ,edi_kanban.file_mei  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.seijo_kensu,0) AS seijo_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.keikoku_kensu ,0) AS keikoku_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.error_kensu ,0) AS error_kensu  ")
            stbSQL_Select.AppendLine("       ,ISNULL(kensu.gokei_kensu ,0) AS gokei_kensu  ")
            stbSQL_Select.AppendLine("       ,CONVERT(varchar,edi_kanban.torikomi_nichiji,111) AS torikomi_bi  ")
            stbSQL_Select.AppendLine("       ,ms.shimei  ")
            stbSQL_Select.AppendLine(" FROM  ")
            stbSQL_Select.AppendLine("       t_edi_kanban_torikomi_rireki AS edi_kanban  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")
            stbSQL_Select.AppendLine("       m_tokuisaki AS tokuisaki  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_kanban.tokuisaki_code = tokuisaki.tokuisaki_code  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")
            stbSQL_Select.AppendLine("       m_shain AS ms  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_kanban.created_by = ms.shain_bango  ")
            stbSQL_Select.AppendLine(" LEFT JOIN  ")

            '各件数
            stbSQL_Select.AppendLine("       (  ")
            stbSQL_Select.AppendLine("       SELECT ")
            'stbSQL_Select.AppendLine("              t_kanban.tokuisaki_code  ")
            stbSQL_Select.AppendLine("              t_kanban_meisai.torikomi_nichiji  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_kanban_meisai.error_kubun = '0' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS seijo_kensu  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_kanban_meisai.error_kubun = '1' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS keikoku_kensu  ")
            stbSQL_Select.AppendLine("             ,SUM(CASE  ")
            stbSQL_Select.AppendLine("                       WHEN t_kanban_meisai.error_kubun = '2' THEN 1  ")
            stbSQL_Select.AppendLine("                       ELSE 0  ")
            stbSQL_Select.AppendLine("                  END) AS error_kensu  ")
            stbSQL_Select.AppendLine("             ,COUNT(t_kanban_meisai.torikomi_nichiji) AS gokei_kensu  ")
            stbSQL_Select.AppendLine("       FROM  ")
            stbSQL_Select.AppendLine("             t_kanban  ")
            stbSQL_Select.AppendLine("       INNER JOIN t_kanban_meisai ")
            stbSQL_Select.AppendLine("             ON t_kanban.kanban_id = t_kanban_meisai.kanban_id  ")
            stbSQL_Select.AppendLine("       GROUP BY  ")
            stbSQL_Select.AppendLine("             t_kanban_meisai.torikomi_nichiji  ")
            stbSQL_Select.AppendLine("       ) AS kensu  ")
            stbSQL_Select.AppendLine(" ON  ")
            stbSQL_Select.AppendLine("           edi_kanban.torikomi_nichiji = kensu.torikomi_nichiji  ")
            'stbSQL_Select.AppendLine("       AND edi_kanban.tokuisaki_code = kensu.tokuisaki_code  ")

            '【WHERE句】
            stbSQL_Select.AppendLine(CreateSQL_Kanban_Where(dsPara))

            '【ORDER BY句】
            stbSQL_Select.AppendLine(" ORDER BY  ")
            stbSQL_Select.AppendLine("        edi_kanban.torikomi_nichiji DESC  ")
            stbSQL_Select.AppendLine("       ,edi_kanban.tokuisaki_code ASC  ")

            stbSQL.Append(stbSQL_Select.ToString)

        Finally
            stbSQL_Select = Nothing
        End Try

    End Sub

    ''' <summary>
    ''' WHERE句作成処理
    ''' </summary>
    ''' <param name="dsPara">データセット</param>
    ''' <returns>
    ''' WHERE句
    ''' </returns>
    ''' <remarks>
    ''' 各条件に応じたWHERE句を作成する。 
    ''' </remarks>
    Private Function CreateSQL_Kanban_Where(ByRef dsPara As DataSet) As String

        Dim stbWhere As New System.Text.StringBuilder  'Where句 

        Try

            '戻り値の初期化 
            CreateSQL_Kanban_Where = ""

            '【検索条件…入力項目が空でなければ条件に含める】 
            '※退避した検索条件を使用する 

            '得意先コード
            If clsCommon.GetDicValue(fdicSearch, txttokuisaki_code.Name.ToString) <> "" Then
                '検索条件を追加
                If stbWhere.ToString <> "" Then stbWhere.AppendLine(" And ")
                stbWhere.AppendLine(" edi_kanban.tokuisaki_code = " & SQL_TOKUISAKI_CODE & " ")
                clsCommon.SetDataTable_ForParameter(dsPara, SQL_TOKUISAKI_CODE, t_edi_kanban_torikomi_rireki.tokuisaki_code__varchar__4.ToString, clsCommon.GetDicValue(fdicSearch, txttokuisaki_code.Name.ToString))
            End If

            '取込処理日
            If clsCommon.GetDicValue(fdicSearch, dtytorikomi_shoribi_kaishi.Name.ToString()) <> "" OrElse clsCommon.GetDicValue(fdicSearch, dtytorikomi_shoribi_shuryo.Name.ToString()) <> "" Then
                '検索条件を追加
                If stbWhere.ToString <> "" Then stbWhere.AppendLine(" And ")
                stbWhere.AppendLine(clsCommon.GetSqlWhereYMD(dsPara, t_edi_kanban_torikomi_rireki.torikomi_nichiji__varchar__23.ToString, "CAST(edi_kanban.torikomi_nichiji AS DATE)",
                                    SQL_TORIKOMI_SHORI_KAISHI, SQL_TORIKOMI_SHORI_SHURYO, Trim(fdicSearch(dtytorikomi_shoribi_kaishi.Name.ToString)), Trim(fdicSearch(dtytorikomi_shoribi_shuryo.Name.ToString))))
            End If

            '条件が一件以上設定されているとき 
            If stbWhere.ToString <> "" Then
                stbWhere.Insert(0, " WHERE ")
            End If

            '戻り値の設定 
            CreateSQL_Kanban_Where = stbWhere.ToString

        Finally
            stbWhere = Nothing
        End Try

    End Function

#End Region

#End Region

#Region "検索クリア押下処理"
    ''' <summary>
    ''' 検索クリア処理
    ''' </summary>
    ''' <remarks>
    ''' 検索クリア処理を行う。
    ''' </remarks>
    Private Sub Syori_Clear()

        Try

            'ボタンにフォーカス設定 
            btnClear.Focus()

            '編集フラグをクリア
            fblnChange = False

            '画面項目初期化 
            ClearInit()

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼ 
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲ 

        End Try

    End Sub

#End Region

#Region "新規/詳細ボタン押下処理"

    ''' <summary>
    ''' フォーム表示
    ''' </summary>
    ''' <param name="strFormMode"></param>
    ''' <remarks>
    ''' 別フォームを表示する。
    ''' </remarks>
    Private Sub Form_Open(ByVal strFormMode As String)

        Dim tmp As tmp_W0101 = gmr.Template

        Try

            'ボタンにフォーカス設定 
            Select Case strFormMode
                Case enmFORMMODE.INSERT : btnF01.Focus()  'フォーム表示（新規登録） 
                Case enmFORMMODE.UPDATE : btnF02.Focus()  'フォーム表示（修正） 
            End Select

            '新規登録時以外は存在チェック 
            If strFormMode <> enmFORMMODE.INSERT Then
                'データが選択されていないとき 
                If gmr.RowCount = 0 Then
                    clsCommon.MsgShow(I01001, fstrPrjName)
                    Exit Sub
                End If

            End If

            '操作不可にする 
            Me.Enabled = False

            '子画面をモーダル表示する 
            Dim frm As New frm_W0102
            frm.fstrFormMode = strFormMode

            If strFormMode <> enmFORMMODE.INSERT Then
                '新規モード以外の場合はキーデータを設定 
                If rdojuchu.Checked Then
                    frm.fstrshori_kubun = enmTaishoData.EDI_juchu_torikomi_rireki
                ElseIf rdokanban.Checked Then
                    frm.fstrshori_kubun = enmTaishoData.EDI_kanban_torikomi_rireki
                End If
                frm.fstrtokuisaki_code = clsCommon.GetValue(gmr.Rows(gmr.CurrentRow.Index).Cells(tmp.ctetokuisaki_code_hidden.Name))
                frm.fstrtorikomi_nichiji = clsCommon.GetValue(gmr.Rows(gmr.CurrentRow.Index).Cells(tmp.ctetorikomi_nichiji_hidden.Name))
            End If

            '子画面Closedイベントハンドラ作成 
            AddHandler frm.Closed, AddressOf Form_Closed

            '表示する 
            frm.Show()

            '表示するフォーム(詳細画面)を最前面に表示する 
            Me.AddOwnedForm(frm)

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼ 
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲ 

        End Try

    End Sub

    ''' <summary>
    ''' FormClosed後の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' Formを閉じたあとの処理を行う。
    ''' </remarks>
    Private Sub Form_Closed(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim frm As frm_W0102 = CType(sender, frm_W0102)
        Dim tmp As tmp_W0101 = gmr.Template
        Dim ds As DataSet = Nothing

        Try

            '子画面で更新処理が行われた場合 
            If frm.fstrUpdateKBN <> "" Then

                '一覧表示 
                IchiranHyoji(False)

                clsMultirow.MR_Sort(gmr)

                'データソースを退避 
                ds = gmr.DataSource

                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    '更新された行が画面の左上に表示されるように設定        
                    If ds.Tables(0).Rows(i).Item(gmr.Rows(0).Cells(tmp.ctetokuisaki_code_hidden.Name).DataField) = Trim(frm.fstrtokuisaki_code) AndAlso
                       ds.Tables(0).Rows(i).Item(gmr.Rows(0).Cells(tmp.ctetorikomi_nichiji_hidden.Name).DataField) = Trim(frm.fstrtorikomi_nichiji) Then
                        gmr.CurrentCellPosition = New GrapeCity.Win.MultiRow.CellPosition(i, gmr.CurrentCell.CellIndex)
                        gmr.FirstDisplayedCellPosition = gmr.CurrentCellPosition
                        gmr.Focus()
                        Exit For
                    End If
                Next

            End If

            '---フォームのロック解除 
            Me.Enabled = True

            '--フォームをアクティブにし、そのフォームにフォーカスを移す
            Me.Activate()

        Catch Err As Exception

            '子画面の解放（Me.Closeを行う際に、親画面と子画面のイベントが混乱しないように） 
            '(親画面に記述された子画面のCloseイベントのみ処理記述） 
            frm.Dispose()

            '▼▽▼エラー処理▼▽▼ 
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲ 

        Finally
            clsCommon.TerminateData(ds)

        End Try

    End Sub

#End Region

#Region "一覧コピーボタン押下処理"

    ''' <summary>
    ''' 一覧コピー処理
    ''' </summary>
    ''' <remarks>
    ''' 一覧コピーを実行する。
    ''' </remarks>
    Private Sub Syori_IchiranCopy()

        Try
            btnF08.Focus()

            '隠しセルが存在する場合は、第3引数読み込み終了列を指定する
            clsMultirow.GetMRSDataCopy(gmr, fstrPrjName)

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼ 
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲ 

        End Try

    End Sub

#End Region

#Region "参照画面表示処理"

    ''' <summary>
    ''' 参照画面表示処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' 対象ボタン押下時に対象項目の参照画面を表示する。
    ''' </remarks>
    Private Sub Hyoji_Sansyo(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim frm As BaseFormSmall = Nothing

        Try

            Select Case sender.Name

                Case btntokuisaki_code.Name

                    '【得意先照会画面】
                    frm = New frm_W9006

                    'Closedイベントハンドラ作成
                    AddHandler frm.Closed, AddressOf frm_Sansyo_Closed

                Case Else
                    Exit Sub

            End Select

            '操作不可にする
            Me.Enabled = False

            '表示する
            frm.Show()

            '表示するフォーム(詳細画面)を最前面に表示する 
            Me.AddOwnedForm(frm)

        Catch err As Exception
            '▼▽▼エラー処理▼▽▼
            clsCommon.ErrProc(Me, err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲
        End Try

    End Sub

    ''' <summary>
    ''' 子画面Close時処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>
    ''' 子画面がCloseされた時の処理を行う
    ''' </remarks>
    Private Sub frm_Sansyo_Closed(ByVal sender As Object, ByVal e As System.EventArgs)

        Try
            '操作可能にする
            Me.Enabled = True

            Select Case DirectCast(sender, BaseFormSmall).Name

                Case PGID_W9006

                    Dim frm As frm_W9006 = DirectCast(sender, frm_W9006)

                    'フォーカス処理
                    txttokuisaki_code.Focus()
                    '検索画面を閉じて元の画面に
                    If frm.fstrtokuisaki_code <> "" Then

                        'CD設定
                        clsCommon.SetValue(txttokuisaki_code, Trim(frm.fstrtokuisaki_code))
                        '次のコントロールへフォーカスを移動
                        SelectNextControl(ActiveControl, True, True, True, True)

                    End If

            End Select

            '--フォームをアクティブにし、そのフォームにフォーカスを移す
            Me.Activate()

            '再表示
            Me.Refresh()

        Catch Err As Exception
            '▼▽▼エラー処理▼▽▼
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲
        End Try

    End Sub

#End Region

#Region "イベント処理"

#Region "リーブイベント"

    '●得意先
    Private Sub txttokuisaki_code_Leave(sender As Object, e As EventArgs) Handles txttokuisaki_code.Leave

        Try
            If clsCommon.GetValue(sender) <> "" Then

                '得意先CD設定  
                clsCommon.SetValue(txttokuisaki_code, clsLib.MaeZero(clsCommon.GetValue(txttokuisaki_code), txttokuisaki_code.MaxLength))

                '得意先設定  
                clsCommon.SetValue(txttokuisaki_meisho, clsCommon.GetDataName(CHECK_TBL.m_tokuisaki, "tokuisaki_ryakusho", clsCommon.GetValue(txttokuisaki_code), fstrPrjName))

            Else
                '空白設定  
                clsCommon.SetValue(txttokuisaki_meisho, "")

            End If

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲

        End Try

    End Sub

#End Region

#Region "CheckedChanged"

    Private Sub radioButton_ChackedChanged(sender As Object, e As EventArgs) Handles rdojuchu.CheckedChanged, rdokanban.CheckedChanged

        Try

            'ラジオボタンが編集された場合一覧削除 
            clsMultirow.MRClear(gmr)

        Catch Err As Exception

            '▼▽▼エラー処理▼▽▼
            clsCommon.ErrProc(Me, Err, fstrPrjName, True)
            '▲△▲エラー処理▲△▲

        End Try

    End Sub

#End Region

#Region "クリックイベント"

    ''' <summary>
    ''' MultiRowのダブルクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub gmr_CellDoubleClick(ByVal sender As Object, ByVal e As GrapeCity.Win.MultiRow.CellEventArgs) Handles gmr.CellDoubleClick
        If e.Scope = GrapeCity.Win.MultiRow.CellScope.Row Then
            'フォーム表示（修正）
            Form_Open(enmFORMMODE.UPDATE)
        End If
    End Sub

    ''' <summary>
    ''' 変更ボタンクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnF02_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF02.Click
        '詳細ボタン実行
        Form_Open(enmFORMMODE.UPDATE)
    End Sub

    ''' <summary>
    ''' 検索ボタンクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF05.Click, btnSearch.Click
        '検索処理実行
        Syori_Search()
    End Sub

    ''' <summary>
    ''' 検索クリアクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        '検索クリア実行
        Syori_Clear()
    End Sub

    ''' <summary>
    ''' 得意先参照ボタンクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btntokuisaki_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntokuisaki_code.Click
        '得意先参照画面を立ち上げる
        Hyoji_Sansyo(sender, e)
    End Sub

    ''' <summary>
    ''' 一覧コピーボタンクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnF08_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnF08.Click
        '一覧コピー処理
        Syori_IchiranCopy()
    End Sub

    ''' <summary>
    ''' 閉じるボタンクリック時の処理
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnF12_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnF12.Click
        '閉じるボタン押下処理
        Syori_Close()
    End Sub

#End Region

#End Region


End Class
