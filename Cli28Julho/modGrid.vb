Imports Infragistics.Win
Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win.SupportDialogs.FilterUIProvider
Imports Infragistics.Documents.Reports.Report

Module Grid
  Public Enum gridTipoValor
    ValorNaoDefinido = 0
    ValorNumero = 1
    ValorTexto = 2
    ValorBooelan = 3
  End Enum

  Public Enum gridTipoLinha
    Linha_Filtro = 1
    Linha_Adicionar = 2
    Linha_Dados = 3
  End Enum

  Public Enum grdTipoCalculoTotal
    SomarValor = 1
    QuantidadeLinha = 2
  End Enum

  Private Sub objGrid_AfterCellActivate(sender As Object, e As EventArgs)
    Dim oGrid As Infragistics.Win.UltraWinGrid.UltraGrid

    oGrid = sender

    If Not oGrid.ActiveCell Is Nothing Or oGrid.DisplayLayout.Bands(0).Override.AllowUpdate Then
      If oGrid.ActiveCell.Activation = Activation.AllowEdit Then
        oGrid.PerformAction(UltraGridAction.ToggleEditMode, False, False)
      End If
    End If
  End Sub

  Public Sub objGrid_Inicializar(ByVal oGrid As UltraGrid,
                                 Optional ByVal oAutoAdicionarLinha As AllowAddNew = AllowAddNew.Default,
                                 Optional ByVal oData As Object = Nothing,
                                 Optional ByVal CelulaClique As CellClickAction = CellClickAction.CellSelect,
                                 Optional ByVal PodeAtualizar As DefaultableBoolean = DefaultableBoolean.Default,
                                 Optional ByVal PodeDeletar As DefaultableBoolean = DefaultableBoolean.Default,
                                 Optional ByVal ExibirLinhaFiltro As Boolean = False,
                                 Optional ByVal VisualBand As Infragistics.Win.UltraWinGrid.ViewStyleBand = ViewStyleBand.Horizontal,
                                 Optional ByVal FormataGrid As Infragistics.Win.UltraWinGrid.RowSelectorHeaderStyle = RowSelectorHeaderStyle.ColumnChooserButton,
                                 Optional ByVal TipoSelecaoLinha As Infragistics.Win.UltraWinGrid.SelectType = SelectType.Default,
                                 Optional ByVal FixarCabecalho As Boolean = False,
                                 Optional ByVal AutoFit As AutoFitStyle = AutoFitStyle.None,
                                 Optional ByVal HeaderClickAction As Infragistics.Win.UltraWinGrid.HeaderClickAction = UltraWinGrid.HeaderClickAction.SortMulti,
                                 Optional ByVal PodeModificarLayout As Boolean = True)
    Dim filterUIProvider As New UltraGridFilterUIProvider

    With oGrid
      Dim oAppearance1 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
      Dim oAppearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
      Dim oAppearance3 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
      Dim oAppearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
      Dim oAppearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance

      AddHandler oGrid.AfterCellActivate, AddressOf objGrid_AfterCellActivate

      If Not oData Is Nothing Then
        Select Case TypeName(oData)
          Case "UltraDataSource"
            oData.Band.Columns.Clear()
          Case "DataSet"
            Dim oDS As DataSet

            oDS = oData
            oDS.Tables.Add()
        End Select

        .DataSource = oData
      End If

      'oAppearance1.BackColor = System.Drawing.Color.White
      'oAppearance2.BackColor = System.Drawing.Color.Transparent
      'oAppearance3.BackColor = System.Drawing.Color.FromArgb(CType(89, Byte), CType(135, Byte), CType(214, Byte))
      'oAppearance3.BackColor2 = System.Drawing.Color.FromArgb(CType(7, Byte), CType(59, Byte), CType(150, Byte))
      'oAppearance3.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
      'oAppearance3.FontData.BoldAsString = "True"
      'oAppearance3.FontData.Name = "Arial"
      'oAppearance3.FontData.SizeInPoints = 10.0!
      'oAppearance3.ForeColor = System.Drawing.Color.White
      'oAppearance3.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent
      'oAppearance4.BackColor = System.Drawing.Color.FromArgb(CType(89, Byte), CType(135, Byte), CType(214, Byte))
      'oAppearance4.BackColor2 = System.Drawing.Color.FromArgb(CType(7, Byte), CType(59, Byte), CType(150, Byte))
      'oAppearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
      'oAppearance5.BackColor = System.Drawing.Color.FromArgb(CType(251, Byte), CType(230, Byte), CType(148, Byte))
      'oAppearance5.BackColor2 = System.Drawing.Color.FromArgb(CType(238, Byte), CType(149, Byte), CType(21, Byte))
      'oAppearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical      

      With .DisplayLayout
        .AutoFitStyle = AutoFit
        .CaptionVisible = DefaultableBoolean.False
        If PodeModificarLayout Then
          .UseFixedHeaders = FixarCabecalho
        Else
          .UseFixedHeaders = False
        End If
        .ViewStyleBand = VisualBand

        With .Override
          .AllowMultiCellOperations = AllowMultiCellOperation.Copy
          .CardAreaAppearance = oAppearance2
          .FilterUIProvider = filterUIProvider
          .HeaderAppearance = oAppearance3
          .MaxSelectedRows = 100
          .RowSizing = RowSizing.Free
          .RowSelectorAppearance = oAppearance4
          If PodeModificarLayout Then
            .RowSelectorHeaderStyle = FormataGrid
          Else
            .RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
          End If
          .SelectedRowAppearance = oAppearance5
          .SelectTypeRow = TipoSelecaoLinha
        End With

        .Appearance = oAppearance1

        If Not PodeModificarLayout Then
          .Bands(0).Layout.Override.AllowColMoving = AllowColMoving.NotAllowed
          .Bands(0).Layout.Override.AllowColSizing = AllowColSizing.None
          .Bands(0).Layout.Override.AllowColSwapping = AllowColSwapping.NotAllowed
        End If

        objGrid_Band_Formatar(.Bands(0), CelulaClique, oAutoAdicionarLinha, PodeAtualizar, PodeDeletar,
                                       IIf(ExibirLinhaFiltro, FilterUIType.FilterRow, FilterUIType.Default), ,
                                       TipoSelecaoLinha, HeaderClickAction)
      End With
    End With

    'objGrid_Formatar(oGrid)
  End Sub

  Public Sub objGrid_Configuracao_Gravar(ByVal oGrid_Control As Control, ByVal sNomeTela As String)
    Dim iCont As Integer
    Dim sSqlText As String
    Dim oGrid As UltraGrid

    oGrid = oGrid_Control

    sSqlText = "DELETE FROM TB_SEG_USUARIO_GRID_CONFIGURAR" &
                   " WHERE ID_USUARIO = " & iID_USUARIO &
                     " AND NO_TELA = " & FNC_QuotedStr(sNomeTela) &
                     " AND NO_GRID = " & FNC_QuotedStr(oGrid.Name)
    If Not DBExecutar(sSqlText) Then GoTo Erro

    For iCont = 0 To oGrid.DisplayLayout.Bands(0).Columns.Count - 1
      sSqlText = DBMontar_SP("SP_SEG_USUARIO_GRID_CONFIGURAR_CAD", False, "@ID_USUARIO",
                                                                                "@NO_TELA",
                                                                                "@NO_GRID",
                                                                                "@NR_COLUNA",
                                                                                "@QT_TAMANHO",
                                                                                "@NR_ORDEM",
                                                                                "@IC_ATIVO",
                                                                                "@IC_CABECALHO_FIXO")
      DBExecutar(sSqlText, DBParametro_Montar("ID_USUARIO", iID_USUARIO),
                           DBParametro_Montar("NO_TELA", sNomeTela),
                           DBParametro_Montar("NO_GRID", oGrid.Name),
                           DBParametro_Montar("NR_COLUNA", iCont),
                           DBParametro_Montar("QT_TAMANHO", oGrid.DisplayLayout.Bands(0).Columns(iCont).Width),
                           DBParametro_Montar("NR_ORDEM", oGrid.DisplayLayout.Bands(0).Columns(iCont).Header.VisiblePosition),
                           DBParametro_Montar("IC_ATIVO", IIf(oGrid.DisplayLayout.Bands(0).Columns(iCont).Hidden, "N", "S")),
                           DBParametro_Montar("IC_CABECALHO_FIXO", IIf(oGrid.DisplayLayout.Bands(0).Columns(iCont).Header.Fixed, "S", "N")))
    Next

    Exit Sub

Erro:
  End Sub

  Public Sub objGrid_Configuracao_Carregar(ByVal oGrid_Control As Control, ByVal sNomeTela As String)
    Dim iCont As Integer
    Dim SqlText As String
    Dim oGrid As UltraGrid
    Dim oData As DataTable
    Dim CdColuna As Integer

    On Error GoTo Erro

    oGrid = oGrid_Control

    SqlText = "SELECT NR_COLUNA," &
                         "QT_TAMANHO," &
                         "IC_ATIVO," &
                         "NR_ORDEM," &
                         "ISNULL(IC_CABECALHO_FIXO, 'N') AS IC_CABECALHO_FIXO" &
                  " FROM TB_SEG_USUARIO_GRID_CONFIGURAR" &
                  " WHERE ID_USUARIO = " & iID_USUARIO.ToString() &
                    " AND NO_TELA = " & FNC_QuotedStr(sNomeTela) &
                    " AND NO_GRID = " & FNC_QuotedStr(oGrid.Name)
    oData = DBQuery(SqlText)

    For iCont = 0 To oData.Rows.Count - 1
      CdColuna = oData.Rows(iCont).Item("NR_COLUNA")

      With oGrid.DisplayLayout.Bands(0).Columns(CdColuna)
        .Width = oData.Rows(iCont).Item("QT_TAMANHO")
        .Hidden = IIf(oData.Rows(iCont).Item("IC_ATIVO") = "S", False, True)
        .Header.VisiblePosition = oData.Rows(iCont).Item("NR_ORDEM")
        .Header.Fixed = IIf(oData.Rows(iCont).Item("IC_CABECALHO_FIXO") = "N", False, True)
      End With
    Next

    Exit Sub

Erro:
    'TratarErro(,, "MOD_Grid.objGrid_Carrega_Configuracao")
  End Sub

  Public Sub objGrid_Limpar_Linha(ByVal oRow As UltraWinGrid.UltraGridRow)
    Dim iCont As Integer

    For iCont = 0 To oRow.Cells.Count - 1
      oRow.Cells(iCont).Value = System.DBNull.Value
    Next
  End Sub

  Public Sub objGrid_Limpar_Coluna(ByVal oGrid As UltraGrid,
                                     Coluna As Integer)
    Dim iCont As Integer

    For iCont = 0 To oGrid.Rows.Count - 1
      oGrid.Rows(iCont).Cells(Coluna).Value = System.DBNull.Value
    Next
  End Sub

  Public Sub objGrid_Band_AutoAdicionarLinha(ByVal oGrid As UltraGrid,
                                               Optional ByVal oAutoAdicionarLinha As AllowAddNew = AllowAddNew.Default)
    With oGrid.DisplayLayout.Bands(0).Override
      .AllowAddNew = oAutoAdicionarLinha

      If oAutoAdicionarLinha = AllowAddNew.FixedAddRowOnTop Then
        .AddRowAppearance.BackColor = Color.LightYellow
        .AddRowAppearance.ForeColor = Color.Blue
        .SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
        .TemplateAddRowAppearance.BackColor = Color.FromArgb(245, 250, 255)
        .TemplateAddRowAppearance.ForeColor = SystemColors.GrayText
        .TemplateAddRowPrompt = "Clique aqui para adicionar um novo registro..."
        .TemplateAddRowPromptAppearance.FontData.Bold = DefaultableBoolean.True
        .TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
      End If
    End With
  End Sub

  Public Sub objGrid_Band_Formatar(ByVal oBand As UltraGridBand,
                                     Optional ByVal CelulaClique As CellClickAction = CellClickAction.CellSelect,
                                     Optional ByVal oAutoAdicionarLinha As AllowAddNew = AllowAddNew.Default,
                                     Optional ByVal PodeAtualizar As DefaultableBoolean = DefaultableBoolean.Default,
                                     Optional ByVal PodeDeletar As DefaultableBoolean = DefaultableBoolean.Default,
                                     Optional ByVal TipoFiltroGrid As Infragistics.Win.UltraWinGrid.FilterUIType = FilterUIType.FilterRow,
                                     Optional ByVal TipoFiltroBand As Infragistics.Win.UltraWinGrid.FilterUIType = FilterUIType.HeaderIcons,
                                     Optional ByVal TipoSelecaoLinha As Infragistics.Win.UltraWinGrid.SelectType = SelectType.Default,
                                     Optional ByVal HeaderClickAction As Infragistics.Win.UltraWinGrid.HeaderClickAction = UltraWinGrid.HeaderClickAction.SortMulti)
    With oBand.Override
      .AllowUpdate = PodeAtualizar
      .AllowDelete = PodeDeletar
      .ButtonStyle = UIElementButtonStyle.VisualStudio2005Button
      .AllowAddNew = oAutoAdicionarLinha
      .RowSelectors = DefaultableBoolean.True
      .RowSelectorStyle = HeaderStyle.WindowsXPCommand
      .HeaderClickAction = HeaderClickAction
      .HeaderStyle = HeaderStyle.WindowsXPCommand
      .MaxSelectedCells = 1
      .MaxSelectedRows = 1
      .CellClickAction = CelulaClique
      .SelectTypeRow = TipoSelecaoLinha
      .MaxSelectedRows = 100

      .FilterRowPrompt = ""

      If oBand.Index = 0 Then
        .FilterUIType = TipoFiltroGrid
      Else
        .FilterUIType = TipoFiltroBand
      End If

      .SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
      .SpecialRowSeparatorAppearance.BackColor = SystemColors.Control

      If oAutoAdicionarLinha = AllowAddNew.FixedAddRowOnTop Then
        .AddRowAppearance.BackColor = Color.LightYellow
        .AddRowAppearance.ForeColor = Color.Blue
        .SpecialRowSeparator = SpecialRowSeparator.TemplateAddRow
        .TemplateAddRowAppearance.BackColor = Color.FromArgb(245, 250, 255)
        .TemplateAddRowAppearance.ForeColor = SystemColors.GrayText
        .TemplateAddRowPrompt = "Clique aqui para adicionar um novo registro..."
        .TemplateAddRowPromptAppearance.FontData.Bold = DefaultableBoolean.True
        .TemplateAddRowPromptAppearance.ForeColor = Color.Maroon
      End If
    End With
  End Sub

  Public Sub objGrid_Coluna_Limpar(ByVal oGrid As UltraGrid)
    Dim iCont As Integer

    With oGrid.DisplayLayout.Bands(0).Columns
      For iCont = 0 To .Count
        .Remove(0)
      Next
    End With
  End Sub

  Public Function objGrid_LinhaSelecionada(ByRef oGrid As UltraGrid, Optional ByVal IndexBand As Integer = 0) As Integer
    If oGrid.DisplayLayout.ActiveRow Is Nothing Then
      Return -1
    Else
      If oGrid.DisplayLayout.ActiveRow.IsFilterRow Then
        Return -1
      Else
        If oGrid.DisplayLayout.ActiveRow.Band.Index = IndexBand Then
          Return oGrid.DisplayLayout.ActiveRow.Index
        Else
          Return -1
        End If
      End If
    End If
  End Function

  Public Sub objGrid_RetirarSelecaoLinhas(ByRef oGrid As UltraGrid)
    Dim iCont As Integer

    For iCont = 0 To oGrid.Rows.Count - 1
      oGrid.Rows(iCont).Selected = False
      oGrid.Rows(iCont).Activated = False
    Next
  End Sub

  Public Function objGrid_Coluna_Add(ByVal oGrid As UltraGrid,
                                       ByVal Titulo As String,
                                       ByVal TamanhoColuna As Integer,
                                       Optional ByVal ColID As Integer = -1,
                                       Optional ByVal bEditar As Boolean = False,
                                       Optional ByVal Tipo As ColumnStyle = ColumnStyle.Default,
                                       Optional ByVal Lista As ValueList = Nothing,
                                       Optional ByVal Formato As String = "",
                                       Optional ByVal Wrap As DefaultableBoolean = DefaultableBoolean.Default,
                                       Optional ByVal FormataData As Boolean = True,
                                       Optional ByVal QuantidadeCaracter As Integer = 0,
                                       Optional ByVal MaiusculaMinuscula As CharacterCasing = CharacterCasing.Normal,
                                       Optional ByVal MascaraValor As String = "",
                                       Optional ByVal Alinhamento As HAlign = HAlign.Default,
                                       Optional ByVal Hidden As Boolean = False,
                                       Optional ByVal Formula As String = "",
                                       Optional ByVal ValorMinimo As Object = Nothing,
                                       Optional ByVal ValorMaximo As Object = Nothing,
                                       Optional ByVal AdicionarDepoisDe As Integer = 0,
                                       Optional ByVal ToolTip As String = "",
                                       Optional ByVal ExibicaoBotao As UltraWinGrid.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.OnRowActivate,
                                       Optional ByVal ExibiCheckBoxCabechalho As Boolean = True) As UltraGridColumn
    Dim oColuna As UltraGridColumn = Nothing
    Dim bNovaColuna As Boolean
    Dim bSemOrigemDados As Boolean = False

    With oGrid.DisplayLayout
      If ColID = -1 Then
        If oGrid.DataSource Is Nothing Then
          bSemOrigemDados = True
        Else
          Select Case TypeName(oGrid.DataSource)
            Case "UltraDataSource"
              '>>> Com objeto de data source
              Dim oDS As UltraWinDataSource.UltraDataSource

              oDS = oGrid.DataSource

              oColuna = .Bands(0).Columns(oDS.Band.Columns.Add(objGrid_DataColunmKey(Titulo, oDS.Band)).Index)

              If FormataData Then
                If Tipo = ColumnStyle.CheckBox Then
                  oDS.Band.Columns(oDS.Band.Columns.Count - 1).DataType = GetType(System.Decimal)
                Else
                  Select Case Formato
                    Case const_Formato_Data, const_Formato_DataHoraCurta, const_Formato_DataHora, const_Formato_Hora
                      oDS.Band.Columns(oDS.Band.Columns.Count - 1).DataType = GetType(System.DateTime)
                    Case const_Formato_Hora

                    Case const_Formato_Valor, const_Formato_Valor_US, const_Formato_Kilos,
                                           const_Formato_NumeroInteiro, const_Formato_Porcentagem, const_Formato_Fracao_Simples,
                                           const_Formato_Fracao, const_Formato_Fracao_4casas, const_Formato_Fracao_8casas, const_Formato_Fracao_Simples,
                                           const_Formato_Valor_4casas, const_Formato_Valor_US_4casas
                      oDS.Band.Columns(oDS.Band.Columns.Count - 1).DataType = GetType(System.Decimal)
                    Case const_Formato_Imagem
                      oDS.Band.Columns(oDS.Band.Columns.Count - 1).DataType = GetType(System.Object)
                      Formato = ""
                  End Select
                End If
              End If
            Case "DataSet"
              Dim oDS As DataSet

              oDS = oGrid.DataSource

              oDS.Tables(0).Columns.Add()
              oColuna = .Bands(0).Columns(.Bands(0).Columns.Count - 1)

              Select Case Formato
                Case const_Formato_Data, const_Formato_DataHoraCurta, const_Formato_DataHora, const_Formato_Hora
                  oDS.Tables(0).Columns(oDS.Tables(0).Columns.Count - 1).DataType = GetType(System.DateTime)
                Case const_Formato_Valor, const_Formato_Valor_US, const_Formato_Kilos,
                                     const_Formato_NumeroInteiro, const_Formato_Porcentagem, const_Formato_Fracao_Simples,
                                     const_Formato_Fracao
                  oDS.Tables(0).Columns(oDS.Tables(0).Columns.Count - 1).DataType = GetType(System.Decimal)
                Case const_Formato_Imagem
                  oDS.Tables(0).Columns(oDS.Tables(0).Columns.Count - 1).DataType = GetType(System.Object)
                  Formato = ""
              End Select
            Case Else
              bSemOrigemDados = True
          End Select
        End If

        If bSemOrigemDados Then
          '>>> Sem objeto de data source
          bNovaColuna = True

          If .Bands(0).Columns.Count = 1 Then
            If .Bands(0).Columns(0).IsBound And .Tag <> 1 Then
              oColuna = .Bands(0).Columns(0)
              bNovaColuna = False
              .Tag = 1
            End If
          End If

          If bNovaColuna Then
            oColuna = .Bands(0).Columns.Add
          End If
        End If
      Else
        oColuna = .Bands(0).Columns(ColID)
      End If
    End With
    If TamanhoColuna = 0 Then
      oColuna.ExcludeFromColumnChooser = ExcludeFromColumnChooser.True
    End If
    If AdicionarDepoisDe > 0 Then
      oColuna.Header.VisiblePosition = oColuna.Band.Columns(AdicionarDepoisDe).Header.VisiblePosition + 1
    End If

    objGrid_Coluna_Formatar(oGrid, oColuna, Titulo, TamanhoColuna, bEditar, Tipo, Lista, Formato, Wrap, QuantidadeCaracter,
                                MaiusculaMinuscula, MascaraValor, Alinhamento, Hidden, Formula, ValorMinimo, ValorMaximo, ToolTip,
                                ExibicaoBotao, ExibiCheckBoxCabechalho)

    Return oColuna
  End Function

  Private Function objGrid_DataColunmKey(ByVal KeySugerido As String, ByRef oData As UltraWinDataSource.UltraDataBand) As String
    Dim iCont As Integer
    Dim sAux As String = ""
    Dim bAchou As Boolean = False

    For iCont = 0 To oData.Columns.Count - 1
      If UCase(oData.Columns(iCont).Key) = UCase(KeySugerido) Then
        bAchou = True
        Exit For
      End If
    Next

    If bAchou Or Trim(KeySugerido) = "" Then
      sAux = oData.Columns.Count + 1
    Else
      sAux = KeySugerido
    End If

    Return sAux
  End Function

  Public Sub objGrid_Coluna_Formatar(ByVal oGrid As UltraGrid,
                                       ByVal oColuna As UltraGridColumn,
                                       ByVal Titulo As String,
                                       ByVal TamanhoColuna As Integer,
                                       Optional ByVal bEditar As Boolean = False,
                                       Optional ByVal Tipo As ColumnStyle = ColumnStyle.Default,
                                       Optional ByVal Lista As ValueList = Nothing,
                                       Optional ByVal Formato As String = "",
                                       Optional ByVal Wrap As DefaultableBoolean = DefaultableBoolean.Default,
                                       Optional ByVal QuantidadeCaracter As Integer = 0,
                                       Optional ByVal MaiusculaMinuscula As CharacterCasing = CharacterCasing.Normal,
                                       Optional ByVal MascaraValor As String = "",
                                       Optional ByVal Alinhamento As HAlign = HAlign.Default,
                                       Optional ByVal Hidden As Boolean = False,
                                       Optional ByVal Formula As String = "",
                                       Optional ByVal ValorMinimo As Object = Nothing,
                                       Optional ByVal ValorMaximo As Object = Nothing,
                                       Optional ByVal ToolTip As String = "",
                                       Optional ByVal ExibicaoBotao As UltraWinGrid.ButtonDisplayStyle = UltraWinGrid.ButtonDisplayStyle.Always,
                                       Optional ByVal ExibiCheckBoxCabechalho As Boolean = True)
    Dim bSemOrigemDados As Boolean = False

    With oColuna
      .CellMultiLine = Wrap
      .CharacterCasing = MaiusculaMinuscula
      .Hidden = Hidden

      If ToolTip <> "" Then
        .Header.ToolTipText = ToolTip
      End If

      If Trim(MascaraValor) <> "" Then
        .MaskInput = MascaraValor
      End If

      If bEditar Then
        .CellClickAction = CellClickAction.EditAndSelectText
        .CellActivation = Activation.AllowEdit
      Else
        If oGrid.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.RowSelect Or
                   oGrid.DisplayLayout.Bands(0).Override.CellClickAction = CellClickAction.CellSelect Then
          .CellActivation = Activation.NoEdit
        End If
      End If

      If Not Titulo Is Nothing Then
        .Header.Caption = Titulo
      End If

      .Style = Tipo

      If Tipo = ColumnStyle.CheckBox Then
        If ExibiCheckBoxCabechalho Then
          .Header.CheckBoxVisibility = HeaderCheckBoxVisibility.WhenUsingCheckEditor
          .Header.CheckBoxAlignment = HeaderCheckBoxAlignment.Right
          .Header.CheckBoxSynchronization = HeaderCheckBoxSynchronization.RowsCollection
        End If

        .DefaultCellValue = False
      End If

      .ButtonDisplayStyle = ExibicaoBotao

      If Trim(Formato) <> "" Then
        .Format = Formato

        Select Case Formato
          Case const_Formato_Valor, const_Formato_Valor_US, const_Formato_Kilos,
                         const_Formato_NumeroInteiro, const_Formato_Porcentagem, const_Formato_Fracao_Simples,
                         const_Formato_Fracao, const_Formato_Fracao_4casas, const_Formato_Fracao_8casas, const_Formato_Fracao_Simples,
                         const_Formato_Valor_4casas, const_Formato_Valor_US_4casas
            oColuna.CellAppearance.TextHAlign = HAlign.Right
            .MaskInput = FNC_FormatoNumero_Para_MaskInput(Formato)
        End Select
      End If

      If Alinhamento <> HAlign.Default Then
        oColuna.CellAppearance.TextHAlign = Alinhamento
      End If

      If TamanhoColuna = 0 Then
        .Hidden = True
      Else
        .Width = TamanhoColuna
      End If

      If Not Lista Is Nothing Then
        oColuna.ValueList = Lista
      End If

      If QuantidadeCaracter > 0 Then
        .MaxLength = QuantidadeCaracter
      End If

      If Trim(Formula) <> "" Then
        .Formula = Formula
      End If

      If Not ValorMinimo Is Nothing Then
        .MinValue = ValorMinimo
      End If
      If Not ValorMaximo Is Nothing Then
        .MaxValue = ValorMaximo
      End If
    End With
  End Sub

  Public Function objGrid_CheckCol_Valor(ByVal oGrid As UltraGrid, ByVal Coluna As Integer, ByVal Linha As Integer) As String
    If objGrid_CheckBox_Selecionado(oGrid, Coluna, Linha) Then
      Return "S"
    Else
      Return "N"
    End If
  End Function

  Public Function objGrid_CheckBox_Selecionado(ByVal oGrid As UltraGrid,
                                                 ByVal Coluna As Integer,
                                                 ByVal Linha As Integer) As Boolean
    Try
      If FNC_CampoNulo(oGrid.Rows(Linha).Cells(Coluna).Value) Then
        Return False
      Else
        If CStr(oGrid.Rows(Linha).Cells(Coluna).Value) = "1" Or CStr(oGrid.Rows(Linha).Cells(Coluna).Value) = "True" Then
          Return True
        Else
          Return False
        End If
      End If
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Function objGrid_CheckBox_QtdeSelecionado(ByVal oGrid As UltraGrid,
                                                     ByVal Coluna As Integer,
                                                     Optional ByVal Filtro() As Object = Nothing) As Integer
    Dim Acumula As Integer = 0
    Dim iCont01 As Integer
    Dim iCont02 As Integer
    Dim bAchou As Boolean = False

    For iCont01 = 0 To oGrid.Rows.Count - 1
      If Filtro Is Nothing Then
        bAchou = True
      Else
        bAchou = True

        For iCont02 = 0 To UBound(Filtro) Step 2
          If FNC_CampoNulo(oGrid.Rows(iCont01).Cells(Filtro(iCont02)).Value) Then
            bAchou = False
            Exit For
          Else
            If oGrid.Rows(iCont01).Cells(Filtro(iCont02)).Value <> Filtro(iCont02 + 1) Then
              bAchou = False
              Exit For
            End If
          End If
        Next
      End If

      If bAchou Then
        If objGrid_CheckBox_Selecionado(oGrid, Coluna, iCont01) Then
          Acumula = Acumula + 1
        End If
      End If
    Next

    Return Acumula
  End Function

  Public Function objGrid_LinhaPreenchidas(ByVal oGrid As UltraGrid,
                                           ByVal Coluna As Integer) As Integer
    Dim Acumula As Integer = 0
    Dim iCont01 As Integer

    For iCont01 = 0 To oGrid.Rows.Count - 1
      If Not FNC_CampoNulo(oGrid.Rows(iCont01).Cells(Coluna).Value) Then
        Acumula = Acumula + 1
      End If
    Next

    Return Acumula
  End Function

  Public Sub objGrid_SetupPrint(ByVal e As Infragistics.Win.UltraWinGrid.CancelablePrintEventArgs,
                                  ByVal Titulo As String,
                                  ByVal Linhas As Integer,
                                  Optional ByVal TamanhoTitulo As Integer = 20)
    e.PrintLayout.BorderStyle = UIElementBorderStyle.None

    With e.PrintLayout
      .Override.RowSelectorHeaderStyle = RowSelectorHeaderStyle.None
    End With

    With e.PrintDocument
      .PrinterSettings.PrintRange = System.Drawing.Printing.PrintRange.AllPages
      .DefaultPageSettings.Landscape = True
    End With

    With e.DefaultLogicalPageLayoutInfo
      .FitWidthToPages = Linhas / 50
      .PageFooterBorderStyle = UIElementBorderStyle.None
      .PageHeader = Titulo
      .PageHeaderHeight = 40
      .PageHeaderAppearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
      .PageHeaderAppearance.TextHAlign = Infragistics.Win.HAlign.Center
      .PageHeaderAppearance.FontData.SizeInPoints = TamanhoTitulo
    End With
  End Sub

  Public Function objGrid_Posicionar(ByVal oGrid As UltraGrid,
                                       ByVal Coluna() As Integer,
                                       ByVal Valor() As Object) As Boolean
    Dim iLinha As Integer
    Dim iCont As Integer
    Dim bAchou As Boolean

    For iLinha = 0 To oGrid.Rows.Count - 1
      With oGrid.Rows(iCont)
        For iCont = Coluna.GetLowerBound(0) To Coluna.GetUpperBound(0)
          bAchou = True

          If .Cells(Coluna(iCont)).Value <> Valor(iCont) Then
            bAchou = False
            Exit For
          End If
        Next

        If bAchou Then
          Try
            oGrid.Rows(iCont).Activated = True
          Catch ex As Exception
          End Try

          Exit For
        End If
      End With
    Next

    Return bAchou
  End Function

  Public Function objGrid_Carregar(ByVal oGrid As UltraGrid,
                                   ByVal SqlText As String,
                                   ByVal IDColuna() As Integer,
                                   Optional ByVal AjustarTamanhoCelula As Boolean = False,
                                   Optional ByVal AdicionarLinhas As Boolean = False,
                                   Optional ByVal oDataPreenchido As DataTable = Nothing,
                                   Optional ByVal ExibirFilme As Boolean = True) As Boolean
    Dim oData As System.Data.DataTable = New System.Data.DataTable
    Dim oDS As New UltraWinDataSource.UltraDataSource
    Dim oRow As UltraWinDataSource.UltraDataRow = Nothing
    Dim iCont As Integer
    Dim iColuna As Integer
    Dim Array() As System.Data.DataRow = Nothing

    'Limpa filtros
    Dim band As Infragistics.Win.UltraWinGrid.UltraGridBand

    For Each band In oGrid.DisplayLayout.Bands
      band.ColumnFilters.ClearAllFilters()
    Next

    If Not oDataPreenchido Is Nothing Then
      oData = oDataPreenchido
    Else
      oData = DBQuery(SqlText)
    End If

    If DBContemErro() Then
      oData = Nothing
      Return False
    End If

    oDS = oGrid.DataSource
    If Not oDS Is Nothing And Not AdicionarLinhas Then oDS.Rows.Clear()

    If Not objDataTable_Vazio(oData) Then
      'Verifica o tipo da coluna
      For iColuna = 0 To oData.Columns.Count - 1
        With oData.Columns(iColuna)
          If .DataType Is System.Type.GetType("System.Double") Or .DataType Is System.Type.GetType("System.Decimal") Or
                       .DataType Is System.Type.GetType("System.Int16") Or .DataType Is System.Type.GetType("System.Int32") Or
                       .DataType Is System.Type.GetType("System.Int64") Or .DataType Is System.Type.GetType("System.Single") Then
            oDS.Band.Columns(IDColuna(iColuna)).DataType = .DataType
          ElseIf .DataType Is System.Type.GetType("System.DateTime") Then
            oDS.Band.Columns(IDColuna(iColuna)).DataType = .DataType
          End If
        End With
      Next

      For iCont = 0 To oData.Rows.Count - 1
        oRow = oDS.Rows.Add()

        For iColuna = 0 To oData.Columns.Count - 1
          If Not objDataTable_CampoVazio(oData.Rows(iCont).Item(iColuna)) Then
            If oGrid.DisplayLayout.Bands(0).Columns(IDColuna(iColuna)).Style = ColumnStyle.Button Then
              oGrid.Rows(oRow.Index).Cells(IDColuna(iColuna)).Tag = oData.Rows(iCont).Item(iColuna)
            Else
              If oGrid.DisplayLayout.Bands(0).Columns(IDColuna(iColuna)).Format = const_Formato_Data Then
                oRow.SetCellValue(IDColuna(iColuna), Microsoft.VisualBasic.Format(oData.Rows(iCont).Item(iColuna), const_Formato_Data))
              Else
                oRow.SetCellValue(IDColuna(iColuna), oData.Rows(iCont).Item(iColuna))
              End If
            End If

          End If
        Next
      Next
    End If

    'Fazer a auto formatação
    'If AjustarTamanhoCelula Then
    '  For iCont = 0 To oGrid.DisplayLayout.Bands(0).Columns.Count - 1
    '    oGrid.DisplayLayout.Bands(0).Columns(iCont).PerformAutoResize()
    '  Next
    '  For iCont = 0 To oGrid.Rows.Count - 1
    '    oGrid.Rows(iCont).PerformAutoSize()
    '  Next
    'End If

    oData = Nothing

    Return True

Erro:
  End Function

  Public Function objGrid_Carregar(ByVal oGrid As UltraGrid,
                                     ByVal SqlText As String,
                                     Optional ByVal CopiarTituloColuna As Boolean = False,
                                     Optional ByVal AjustarTamanhoCelula As Boolean = False) As Boolean
    Dim oData As New System.Data.DataTable
    Dim iCont As Integer = 0

    oData = DBQuery(SqlText)

    If DBContemErro() Then
      oData = Nothing
      Return False
    End If

    oGrid.DataSource = oData
    oGrid.DataBind()

    If AjustarTamanhoCelula Then
      For iCont = 0 To oGrid.Rows.Count - 1
        oGrid.Rows(iCont).PerformAutoSize()
      Next
    End If

    Return True
  End Function

  Public Sub objGrid_ExportarPDF(ByVal oGrid As UltraGrid,
                                 sTitulo As String,
                                 Optional ByVal oBotao As System.Windows.Forms.Button = Nothing)
    Try
      Dim sArquivo As String = ""
      Dim ExportPath As String
      Dim ps As New ProcessStartInfo
      Dim bEnviarEMail As Boolean = False
      Dim oPageSetupDialog As PageSetupDialog

      If Not oBotao Is Nothing Then
        If Not oBotao.ContextMenuStrip Is Nothing Then
          If oBotao.Tag Is Nothing Then
            oBotao.ContextMenuStrip.Show(Control.MousePosition)
            Exit Sub
          End If

          If oBotao.Tag = const_ExportarGrid_EnviarEMail Then
            ExportPath = My.Computer.FileSystem.SpecialDirectories.Temp + "\Exported\"

            If System.IO.Directory.Exists(ExportPath) = False Then
              System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\Exported\")
            End If

            sArquivo = "Arquivo"

            Dim ofrmUserDialogo_Texto As New frmUserDialogo_Texto

            ofrmUserDialogo_Texto.Carregar("Exportação de Relatório", "Informe o nome do arquivo")

            If ofrmUserDialogo_Texto.Cancelado Then
              oBotao.Tag = Nothing
              Exit Sub
            Else
              sArquivo = ofrmUserDialogo_Texto.Texto
            End If

            ofrmUserDialogo_Texto.Dispose()

            sArquivo = sArquivo & ".pdf"

            sArquivo = ExportPath + sArquivo

            If Dir(sArquivo) <> "" Then
              Kill(sArquivo)
            End If

            bEnviarEMail = True
          End If
        End If
      End If

      If Not bEnviarEMail Then
        sArquivo = FNC_Arquivo_Dialogo_Salvar("PDF|*.pdf")
      End If

      If Trim(sArquivo) <> "" Then
        Dim oExport As Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
        Dim oReport As Infragistics.Documents.Reports.Report.Report
        Dim oSection As Infragistics.Documents.Reports.Report.Section.ISection
        Dim oSectionHeader As Infragistics.Documents.Reports.Report.Section.ISectionHeader
        Dim oSectionFooter As Infragistics.Documents.Reports.Report.Section.ISectionFooter
        Dim oImage As Infragistics.Documents.Reports.Graphics.Image

        oPageSetupDialog = FNC_Print_Setup()

        oExport = New Infragistics.Win.UltraWinGrid.DocumentExport.UltraGridDocumentExporter
        oReport = New Infragistics.Documents.Reports.Report.Report
        oExport.TargetPaperOrientation = IIf(oPageSetupDialog.PageSettings.Landscape, Infragistics.Documents.Reports.Report.PageOrientation.Landscape,
                                                                                      Infragistics.Documents.Reports.Report.PageOrientation.Portrait)
        Try
          oImage = New Infragistics.Documents.Reports.Graphics.Image(FNC_Imagem_Redimensionar(System.Drawing.Image.FromFile(sEMPRESA_DS_PATH_IMAGEM), New Size(50, 50)))
        Catch ex As Exception
        End Try

        oSection = oReport.AddSection()
        oSection.PageSize = New PageSize(oPageSetupDialog.PageSettings.PaperSize.Width, oPageSetupDialog.PageSettings.PaperSize.Height)
        oSection.PagePaddings.Top = 5
        oSection.PagePaddings.Left = 5
        oSection.PagePaddings.Right = 5
        oSection.PagePaddings.Bottom = 5

        oSectionHeader = oSection.AddHeader()
        oSectionHeader.Repeat = True
        oSectionHeader.Height = 50
        oSectionHeader.AddImage(oImage, 1, 1)
        Dim oSectionHeaderText As Infragistics.Documents.Reports.Report.Text.IText = oSectionHeader.AddText(0, 0)
        oSectionHeaderText.Alignment = New TextAlignment(Alignment.Center, Alignment.Middle)
        oSectionHeaderText.Height = New RelativeHeight(60)
        oSectionHeaderText.AddContent(sTitulo)

        oExport.Export(oGrid, oSection)

        oSectionFooter = oSection.AddFooter()
        oSectionFooter.Repeat = True
        oSectionFooter.Height = 25

        Dim oSectionFooterText As Infragistics.Documents.Reports.Report.Text.IText = oSectionFooter.AddText(0, 0)
        oSectionFooterText.Paddings.All = 10
        oSectionFooterText.Alignment = New TextAlignment(Alignment.Center, Alignment.Middle)
        oSectionFooterText.Height = New RelativeHeight(100)
        oSectionFooterText.Background = New Background(Infragistics.Documents.Reports.Graphics.Brushes.Gainsboro)
        oSectionFooterText.AddContent(FNC_Sistema_Relatorio_Rodape())

        oReport.Publish(sArquivo, FileFormat.PDF)

        If bEnviarEMail Then
          'EMail_Enviar(cnt_EmailExportacaoRelatorio, _
          '             sUsuario_EMail, _
          '             "Exportação de Consultas", "", _
          '             False, _
          '             cnt_EMail_Servidor_SMTP, _
          '             System.Net.Mail.MailPriority.Normal, _
          '             New String() {sArquivo})
          FNC_Mensagem("Planilha enviada para o seu e-mail")
        Else
          If FNC_Perguntar("Deseja abrir o arquivo exportado?") Then
            ps.UseShellExecute = True
            ps.FileName = sArquivo
            Process.Start(ps)
          End If
        End If
      End If

      If Not oBotao Is Nothing Then
        If Not oBotao.ContextMenuStrip Is Nothing Then
          If oBotao.Tag = const_ExportarGrid_EnviarEMail Or
                     oBotao.Tag = const_ExportarGrid_ExportarComputador Then
            oBotao.Tag = Nothing
            oBotao.ContextMenuStrip.Hide()
          End If
        End If
      End If
    Catch ex As Exception
      FNC_Mensagem(ex.Message)
    End Try
  End Sub

  Public Sub objGrid_ExportarExcell(ByVal oGrid As UltraGrid,
                                      ByVal Nome As String,
                                      Optional ByVal oBotao As System.Windows.Forms.Button = Nothing,
                                      Optional ByRef oExport As Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter = Nothing)
    Dim sArquivo As String = ""
    Dim ps As New ProcessStartInfo
    Dim bEnviarEMail As Boolean = False
    Dim ExportPath As String

    oExport = New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter

    If Not oBotao Is Nothing Then
      If Not oBotao.ContextMenuStrip Is Nothing Then
        If oBotao.Tag Is Nothing Then
          oBotao.ContextMenuStrip.Show(Control.MousePosition)
          Exit Sub
        End If

        If oBotao.Tag = const_ExportarGrid_EnviarEMail Then
          ExportPath = My.Computer.FileSystem.SpecialDirectories.Temp + "\Exported\"

          If System.IO.Directory.Exists(ExportPath) = False Then
            System.IO.Directory.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.Temp + "\Exported\")
          End If

          sArquivo = "Arquivo"

          Dim ofrmUserDialogo_Texto As New frmUserDialogo_Texto

          ofrmUserDialogo_Texto.Carregar("Exportação de Relatório", "Informe o nome do arquivo")

          If ofrmUserDialogo_Texto.Cancelado Then
            oBotao.Tag = Nothing
            Exit Sub
          Else
            sArquivo = ofrmUserDialogo_Texto.Texto
          End If

          ofrmUserDialogo_Texto.Dispose()

          sArquivo = sArquivo & ".xlsx"

          sArquivo = ExportPath + sArquivo

          If Dir(sArquivo) <> "" Then
            Kill(sArquivo)
          End If

          bEnviarEMail = True
        End If
      End If
    End If

    If Not bEnviarEMail Then
      sArquivo = FNC_Arquivo_Dialogo_Salvar("Excell|*.xlsx")
    End If

    If Trim(sArquivo) <> "" Then
      oExport.Export(oGrid, sArquivo, 2)
      oExport.Dispose()

      If bEnviarEMail Then
        'EMail_Enviar(cnt_EmailExportacaoRelatorio, _
        '             sUsuario_EMail, _
        '             "Exportação de Consultas", "", _
        '             False, _
        '             cnt_EMail_Servidor_SMTP, _
        '             System.Net.Mail.MailPriority.Normal, _
        '             New String() {sArquivo})
        FNC_Mensagem("Planilha enviada para o seu e-mail")
      Else
        If FNC_Perguntar("Deseja abrir o arquivo exportado?") Then
          ps.UseShellExecute = True
          ps.FileName = sArquivo
          Process.Start(ps)
        End If
      End If
    End If

    If Not oBotao Is Nothing Then
      If Not oBotao.ContextMenuStrip Is Nothing Then
        If oBotao.Tag = const_ExportarGrid_EnviarEMail Or
                   oBotao.Tag = const_ExportarGrid_ExportarComputador Then
          oBotao.Tag = Nothing
          oBotao.ContextMenuStrip.Hide()
        End If
      End If
    End If
  End Sub

  Public Function objGrid_Valor(ByRef oGrid As UltraGrid,
                                  ByVal Coluna As Integer,
                                  Optional ByVal Linha As Integer = -1,
                                  Optional ByVal ValorPadrao As Object = Nothing,
                                  Optional ByVal Tipo As gridTipoValor = gridTipoValor.ValorNaoDefinido,
                                  Optional ByVal IndexBand As Integer = -1) As Object
    Dim iLinha As Integer
    Dim Valor As Object = Nothing
    Dim oRow As UltraGridRow = Nothing

    If Linha = -1 Then
      If oGrid.DisplayLayout.ActiveRow Is Nothing Then
        iLinha = -1
      Else
        If oGrid.DisplayLayout.ActiveRow.Band.Index = IndexBand Or IndexBand = -1 Then
          oRow = oGrid.DisplayLayout.ActiveRow
        Else
          iLinha = -1
        End If
      End If
    Else
      iLinha = Linha
      oRow = oGrid.Rows(iLinha)
    End If

    If Not oRow Is Nothing Then
      IndexBand = oRow.Band.Index
    End If

    If Coluna = -1 Or iLinha = -1 Then
      Valor = Nothing
      GoTo Sair
    ElseIf iLinha > -1 And (iLinha <= oGrid.Rows.Count - 1 Or IndexBand > 0) And
               Coluna <= oGrid.DisplayLayout.Bands(IndexBand).Columns.Count - 1 Then
      Valor = oRow.Cells(Coluna).Value

      GoTo Sair
    Else
      Err.Raise(-7000, "Celula informada não existe no grid ou linha não existe")
    End If

    Return Nothing

    Exit Function

Sair:
    If FNC_CampoNulo(Valor) And Not ValorPadrao Is Nothing Then
      Valor = ValorPadrao
    End If

    Select Case Tipo
      Case gridTipoValor.ValorTexto
        Return Valor
      Case Else
        If IsNumeric(Valor) Then
          Return FNC_ConvValorFormatoAmericano(Valor)
        Else
          Return Valor
        End If
    End Select
  End Function

  Public Function objGrid_Valor_SN(ByRef oGrid As UltraGrid, ByVal Coluna As Integer,
                                     Optional ByVal Linha As Integer = -1) As Boolean
    Dim iLinha As Integer
    Dim Valor As Boolean

    If Linha = -1 Then
      If oGrid.DisplayLayout.ActiveRow Is Nothing Then
        iLinha = -1
      Else
        iLinha = oGrid.DisplayLayout.ActiveRow.Index
      End If
    Else
      iLinha = Linha
    End If

    If Coluna = -1 Then
      Valor = False
    ElseIf iLinha > -1 And iLinha <= oGrid.Rows.Count - 1 And Coluna <= oGrid.DisplayLayout.Bands(0).Columns.Count - 1 Then
      Valor = (oGrid.Rows(iLinha).Cells(Coluna).Value = "S" Or UCase(oGrid.Rows(iLinha).Cells(Coluna).Value) = "SIM")
    Else
      Err.Raise(-7000, "Celula informada não existe no grid ou linha não existe")
    End If

    Return Valor
  End Function

  Public Sub objGrid_ExcluirLinha(ByRef oGrid As UltraGrid,
                                    Optional ByVal Linha As Integer = -1)
    Dim iLinha As Integer
    Dim Valor As Object = Nothing

    If Linha = -1 Then
      If oGrid.DisplayLayout.ActiveRow Is Nothing Then
        iLinha = -1
      Else
        iLinha = oGrid.DisplayLayout.ActiveRow.Index
      End If
    Else
      iLinha = Linha
    End If

    oGrid.Rows(iLinha).Delete(False)
  End Sub

  Public Function objGrid_Linha_Add(ByRef oGrid As UltraGrid,
                                    ByVal Coluna_Valor() As Object) As UltraWinDataSource.UltraDataRow
    Dim oDS As UltraWinDataSource.UltraDataSource
    Dim iCont As Integer

    oDS = oGrid.DataSource

    If Not oDS Is Nothing Then
      Dim oRow As UltraWinDataSource.UltraDataRow

      oRow = oDS.Rows.Add()

      For iCont = 0 To UBound(Coluna_Valor) Step 2
        If oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Double") _
                 Or oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Decimal") _
                 Or oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Int16") _
                 Or oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Int32") _
                 Or oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Int64") _
                 Or oRow.Band.Columns(Coluna_Valor(iCont)).DataType Is System.Type.GetType("System.Single") Then
          oRow.SetCellValue(Coluna_Valor(iCont), Val(Coluna_Valor(iCont + 1)))
        Else
          oRow.SetCellValue(Coluna_Valor(iCont), Coluna_Valor(iCont + 1))
        End If
      Next

      Return oRow
    Else
      Return Nothing
    End If
  End Function

  Public Sub objGrid_AlterarValor(ByRef oGrid As UltraGrid, ByVal Coluna As Integer,
                                    ByVal Linha As Integer, ByVal Valor As Object)
    Dim oDs As UltraWinDataSource.UltraDataSource
    Dim iLinha As Integer

    If Linha = -1 Then
      If oGrid.DisplayLayout.ActiveRow Is Nothing Then
        iLinha = -1
      Else
        iLinha = oGrid.DisplayLayout.ActiveRow.Index
      End If
    Else
      iLinha = Linha
    End If

    oDs = oGrid.DataSource

    If Not oDs Is Nothing Then
      If oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Double") _
            Or oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Decimal") _
            Or oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Int16") _
            Or oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Int32") _
            Or oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Int64") _
            Or oDs.Rows(iLinha).Band.Columns(Coluna).DataType Is System.Type.GetType("System.Single") Then
        oDs.Rows(iLinha).SetCellValue(Coluna, Val(Valor))
      Else
        oDs.Rows(iLinha).SetCellValue(Coluna, Valor)
      End If
    End If
  End Sub

  Public Function objGrid_Coluna_ProcurarValor(ByRef oGrid As UltraGrid,
                                                 ByVal aValor() As Object,
                                                 Optional ByVal ExcetoLinha As Integer = -1) As Integer
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim bAchou As Boolean
    Dim Valor As Object

    For iCont_01 = 0 To oGrid.Rows.Count - 1
      If iCont_01 <> ExcetoLinha Or ExcetoLinha = -1 Then
        For iCont_02 = 0 To UBound(aValor) Step 2
          bAchou = False

          With oGrid.Rows(iCont_01).Cells(aValor(iCont_02))
            Valor = aValor(iCont_02 + 1)

            If IsDate(Valor) Or IsNumeric(Valor) Then
              If Trim(.Value) = Valor Then
                bAchou = True
              End If
            Else
              If UCase(Trim(FNC_NVL(.Value, Nothing))) = UCase(Trim(Valor)) Then
                bAchou = True
              End If
            End If
          End With

          If Not bAchou Then Exit For
        Next

        If bAchou Then Exit For
      End If
    Next

Sair:
    Return IIf(bAchou, iCont_01, -1)
  End Function

  'Public Sub objGrid_Linha_Remover(ByRef oGrid As UltraGrid, _
  '                                 Optional ByVal Linha As Integer = -1)
  '    Dim iLinha As Integer
  '    Dim oDS As UltraWinDataSource.UltraDataSource

  '    If Linha = -1 Then
  '        If oGrid.DisplayLayout.ActiveRow Is Nothing Then
  '            iLinha = -1
  '        Else
  '            iLinha = oGrid.DisplayLayout.ActiveRow.Index
  '        End If
  '    Else
  '        iLinha = Linha
  '    End If

  '    oDS = oGrid.DataSource
  '    oDS.Rows.Remove(oDS.Rows(iLinha))
  'End Sub

  Public Sub objGrid_ExibirTotal(ByVal oGrid As UltraGrid,
                                   ByVal iNivel As Integer,
                                   ByVal ParamArray ColunasTotal() As Integer)
    objGrid_ExibirCalculado(oGrid, iNivel, SummaryType.Sum, False, ColunasTotal)
  End Sub

  Public Sub objGrid_ExibirTotal(ByVal oGrid As UltraGrid,
                                 ByVal ParamArray ColunasTotal() As Integer)
    objGrid_ExibirCalculado(oGrid, 0, SummaryType.Sum, False, ColunasTotal)
  End Sub

  Public Sub objGrid_ExibirTotal(ByVal oGrid As UltraGrid,
                                   ByVal AdicionarMesmoQueExista As Boolean,
                                   ByVal ParamArray ColunasTotal() As Integer)
    objGrid_ExibirCalculado(oGrid, 0, SummaryType.Sum, AdicionarMesmoQueExista, ColunasTotal)
  End Sub

  Public Sub objGrid_ExibirMedia(ByVal oGrid As UltraGrid,
                                   ByVal AdicionarMesmoQueExista As Boolean,
                                   ByVal ParamArray ColunasTotal() As Integer)
    objGrid_ExibirCalculado(oGrid, 0, SummaryType.Average, AdicionarMesmoQueExista, ColunasTotal)
  End Sub

  Public Sub objGrid_ExibirCalculado(ByVal oGrid As UltraGrid,
                                       ByVal iNivel As Integer,
                                       ByVal TipoSumario As Infragistics.Win.UltraWinGrid.SummaryType,
                                       ByVal AdicionarMesmoQueExista As Boolean,
                                       ByVal ParamArray ColunasTotal() As Integer)
    Dim iCont As Integer
    Dim oSumario As Infragistics.Win.UltraWinGrid.SummarySettings
    Dim ColFormat As String = ""
    Dim newSummaryDisplayArea As SummaryDisplayAreas

    newSummaryDisplayArea = SummaryDisplayAreas.Bottom Or SummaryDisplayAreas.InGroupByRows

    With oGrid
      With .DisplayLayout
        With .Bands(iNivel)
          If .Summaries.Count = 0 Or AdicionarMesmoQueExista Then
            For iCont = LBound(ColunasTotal) To UBound(ColunasTotal)
              Select Case TipoSumario
                Case SummaryType.Formula
                  oSumario = .Summaries.Add(.Columns(ColunasTotal(iCont)).Header.Caption & Trim(iCont),
                                                              SummaryType.Formula,
                                                              .Columns(ColunasTotal(iCont)),
                                                              SummaryPosition.UseSummaryPositionColumn)
                  oSumario.Formula = ""
                  With oSumario
                    .DisplayFormat = "{0:" + ColFormat + "}"
                    .Appearance.TextHAlign = HAlign.Right
                    .SummaryDisplayArea = newSummaryDisplayArea
                  End With
                Case Else
                  oSumario = .Summaries.Add(.Columns(ColunasTotal(iCont)).Header.Caption & Trim(iCont),
                                                               TipoSumario,
                                                              .Columns(ColunasTotal(iCont)),
                                                              SummaryPosition.UseSummaryPositionColumn)

                  ColFormat = .Columns(ColunasTotal(iCont)).Format

                  If ColFormat = Nothing Then
                    ColFormat = "###,###,##0.00"
                  End If

                  With oSumario
                    .DisplayFormat = "{0:" + ColFormat + "}"
                    .Appearance.TextHAlign = HAlign.Right
                    .SummaryDisplayArea = newSummaryDisplayArea
                  End With
              End Select
            Next
          End If

          Select Case TipoSumario
            Case SummaryType.Average
              .SummaryFooterCaption = "Média"
            Case SummaryType.Sum
              .SummaryFooterCaption = "Total"
            Case SummaryType.Count
              .SummaryFooterCaption = "Quantidade"
          End Select

          .Override.SummaryFooterCaptionVisible = DefaultableBoolean.False
          .Override.SummaryDisplayArea = SummaryDisplayAreas.Bottom
          .Override.SpecialRowSeparator = SpecialRowSeparator.SummaryRow
        End With
      End With
    End With
  End Sub

  Public Sub objGrid_ExibirCalculadoFormula(ByVal oGrid As UltraGrid,
                                              ByVal AdicionarMesmoQueExista As Boolean,
                                              ByVal Formula As String,
                                              ByVal FooterCaption As String,
                                              ByVal ColunaTotal As Integer,
                                              Optional ByVal Formato As String = "")
    Dim iCont As Integer
    Dim oSumario As Infragistics.Win.UltraWinGrid.SummarySettings
    Dim ColFormat As String
    Dim newSummaryDisplayArea As SummaryDisplayAreas

    newSummaryDisplayArea = SummaryDisplayAreas.Bottom Or SummaryDisplayAreas.InGroupByRows

    With oGrid
      With .DisplayLayout
        With .Bands(0)
          If .Summaries.Count = 0 Or AdicionarMesmoQueExista Then
            oSumario = .Summaries.Add(.Columns(ColunaTotal).Header.Caption & Trim(iCont),
                                                  SummaryType.Formula,
                                                  .Columns(ColunaTotal),
                                                  SummaryPosition.UseSummaryPositionColumn)

            If Trim(Formato) = "" Then
              ColFormat = .Columns(ColunaTotal).Format
            Else
              ColFormat = Formato
            End If

            oSumario.Formula = Formula
            With oSumario
              .DisplayFormat = "{0:" + ColFormat + "}"
              .Appearance.TextHAlign = HAlign.Right
              .SummaryDisplayArea = newSummaryDisplayArea
            End With
          End If

          .SummaryFooterCaption = FooterCaption

          .Override.SummaryDisplayArea = SummaryDisplayAreas.Bottom
          .Override.SpecialRowSeparator = SpecialRowSeparator.SummaryRow
        End With
      End With
    End With
  End Sub

  Public Function objGridBand_Index(ByVal oRow As Infragistics.Win.UltraWinGrid.UltraGridRow) As Integer
    If oRow.ParentRow Is Nothing Then
      Return -1
    Else
      Return oRow.ParentRow.Band.Index
    End If
  End Function

  'Public Sub objGrid_Coluna_AddOption(ByRef oGrid As UltraGrid, _
  '                                    ByVal oDS As UltraWinDataSource.UltraDataSource, _
  '                                    ByVal Coluna As Integer, _
  '                                    ByVal Valores() As Object)
  '    Dim EditorSettings As DefaultEditorOwnerSettings = Nothing
  '    Dim ValueList As ValueList = Nothing
  '    Dim Editor As EmbeddableEditorBase
  '    Dim iCont As Integer
  '    Dim Valor As Object

  '    oDS.Band.Columns(Coluna).DataType = GetType(Object)

  '    EditorSettings = New DefaultEditorOwnerSettings()
  '    EditorSettings.DataType = GetType(Object)
  '    EditorSettings.ButtonStyle = UIElementButtonStyle.Flat

  '    ValueList = New ValueList()

  '    For iCont = LBound(Valores) To UBound(Valores) Step 2
  '        ValueList.ValueListItems.Add(Valores(iCont + 1), Valores(iCont))
  '    Next

  '    EditorSettings.ValueList = ValueList
  '    Editor = New OptionSetEditor(New DefaultEditorOwner(EditorSettings))

  '    For iCont = 0 To oGrid.Rows.Count - 1
  '        Valor = oGrid.Rows(iCont).Cells(Coluna).Value
  '        oGrid.Rows(iCont).Cells(Coluna).Editor = Editor
  '        oGrid.Rows(iCont).Cells(Coluna).Value = Valor
  '    Next
  'End Sub

  Public Function objGrid_TipoLinha(ByRef oGrid As UltraGrid) As gridTipoLinha
    If oGrid.ActiveRow.IsAddRow Then
      Return gridTipoLinha.Linha_Filtro
    ElseIf oGrid.ActiveRow.IsFilterRow Then
      Return gridTipoLinha.Linha_Filtro
    ElseIf oGrid.ActiveRow.IsDataRow Then
      Return gridTipoLinha.Linha_Dados
    Else
      Return gridTipoLinha.Linha_Dados
    End If
  End Function

  Public Function objGrid_CalcularTotalColuna(ByVal oGrid As UltraGrid,
                                                Optional Coluna As Integer = -1,
                                                Optional TipoCalculoTotal As grdTipoCalculoTotal = grdTipoCalculoTotal.SomarValor,
                                                Optional ByVal Filtro() As Object = Nothing,
                                                Optional CasasDecimais As Integer = 4) As Double
    Dim iCont01 As Integer
    Dim iCont02 As Integer
    Dim Quantidade As Double = 0
    Dim bAchou As Boolean

    For iCont01 = 0 To oGrid.Rows.Count - 1
      If Filtro Is Nothing Then
        bAchou = True
      Else
        bAchou = True

        For iCont02 = 0 To UBound(Filtro) Step 2
          If FNC_CampoNulo(oGrid.Rows(iCont01).Cells(Filtro(iCont02)).Value) Then
            bAchou = False
            Exit For
          Else
            If Not FNC_CampoNulo(oGrid.Rows(iCont01).Cells(Filtro(iCont02)).Value) And Not FNC_CampoNulo(Filtro(iCont02 + 1)) Then
              If oGrid.Rows(iCont01).Cells(Filtro(iCont02)).Value <> Filtro(iCont02 + 1) Then
                bAchou = False
                Exit For
              End If
            End If
          End If
        Next
      End If

      If bAchou Then
        Select Case TipoCalculoTotal
          Case grdTipoCalculoTotal.QuantidadeLinha
            Quantidade = Quantidade + 1
          Case grdTipoCalculoTotal.SomarValor
            Quantidade = Quantidade + FNC_NVL(oGrid.Rows(iCont01).Cells(Coluna).Value, 0)
        End Select
      End If
    Next

    Return Math.Round(Quantidade, CasasDecimais)
  End Function

  Public Function objGrid_ListarSelecionados(ByVal oGrid As UltraGrid,
                                               ByVal Separador As Object,
                                               ByVal Colunas() As Object,
                                               Optional ByVal Where() As Object = Nothing) As String
    Dim sLista As String = ""
    Dim sAux As String = ""
    Dim iLinha As Integer
    Dim iWhere As Integer
    Dim iCont As Integer
    Dim bValido As Boolean

    For iLinha = 0 To oGrid.Rows.Count - 1
      sAux = ""

      With oGrid.Rows(iLinha)
        For iCont = Colunas.GetLowerBound(0) To Colunas.GetUpperBound(0)
          If IsNumeric(Colunas(iCont)) Then
            If Where Is Nothing Then
              bValido = True
            Else
              bValido = True

              For iWhere = Where.GetLowerBound(0) To Where.GetUpperBound(0) Step 2
                If Not .Cells(Where(iWhere)).Value = Where(iWhere + 1) Then
                  bValido = False
                  Exit For
                End If
              Next
            End If

            If bValido Then
              sAux = sAux & Trim(FNC_NVL(.Cells(Colunas(iCont)).Value, ""))
            End If
          Else
            sAux = sAux & " " & Trim(Colunas(iCont)) & " "
          End If
        Next
      End With

      If Trim(sAux) <> "" Then
        FNC_Str_Adicionar(sLista, Trim(sAux), Separador)
      End If
    Next

    Return sLista
  End Function

  'Private Function objGrid_DataColunmKey(ByVal KeySugerido As String, ByRef oData As UltraWinDataSource.UltraDataBand) As String
  '    Dim iCont As Integer
  '    Dim sAux As String = ""
  '    Dim bAchou As Boolean = False

  '    For iCont = 0 To oData.Columns.Count - 1
  '        If UCase(oData.Columns(iCont).Key) = UCase(KeySugerido) Then
  '            bAchou = True
  '            Exit For
  '        End If
  '    Next

  '    If bAchou Or Trim(KeySugerido) = "" Then
  '        sAux = oData.Columns.Count + 1
  '    Else
  '        sAux = KeySugerido
  '    End If

  '    Return sAux
  'End Function

  Public Function objGrid_Grupo_Criar(ByVal oBand As UltraGridBand,
                                        Optional ByVal Titulo As String = "") As UltraGridGroup
    Dim oGrupo As UltraGridGroup

    oGrupo = oBand.Groups.Add

    If Trim(Titulo) <> "" Then
      oGrupo.Header.Caption = Titulo
    End If

    With oGrupo.Header.Appearance
      .BackColor = System.Drawing.Color.FromArgb(CType(70, Byte), CType(143, Byte), CType(161, Byte))
      .ForeColor = Color.White
      .BackGradientStyle = GradientStyle.VerticalBump
      .BackColor2 = System.Drawing.Color.FromArgb(CType(29, Byte), CType(99, Byte), CType(125, Byte))
    End With

    Return oGrupo
  End Function

  Public Function objGrid_Colunas_Tamanhos(oGrid As UltraWinGrid.UltraGrid) As String
    Dim sRet As String = ""
    Dim iCont As Integer

    For iCont = 0 To oGrid.DisplayLayout.Bands(0).Columns.Count - 1
      FNC_Str_Adicionar(sRet, oGrid.DisplayLayout.Bands(0).Columns(iCont).Header.Caption & " - " & oGrid.DisplayLayout.Bands(0).Columns(iCont).Width, vbCrLf & " - ")
    Next

    Return sRet
  End Function

  'Public Sub objGrid_Imprimir(ByVal oGrid As UltraGrid, Optional ByVal Titulo As String = "")
  '    Dim oPrintPreviewDialog As New Infragistics.Win.Printing.UltraPrintPreviewDialog
  '    Dim oGridPrint As New Infragistics.Win.UltraWinGrid.UltraGridPrintDocument
  '    Dim TamanhoGrid As Integer
  '    Dim iCont As Integer

  '    For iCont = 0 To oGrid.DisplayLayout.Bands(0).Columns.Count - 1
  '        TamanhoGrid = TamanhoGrid + oGrid.DisplayLayout.Bands(0).Columns(iCont).Width
  '    Next


  '    With oGridPrint
  '        .Grid = oGrid
  '        .DefaultPageSettings.Landscape = True
  '        .DefaultPageSettings.Margins.Left = 30
  '        .DefaultPageSettings.Margins.Right = 30
  '        .DefaultPageSettings.Margins.Top = 30
  '        .DefaultPageSettings.Margins.Bottom = 30


  '        If Titulo <> "" Then
  '            .Header.TextCenter = Titulo
  '            .Header.Height = 40
  '            .Header.Appearance.FontData.Bold = DefaultableBoolean.True
  '            .Header.Appearance.FontData.SizeInPoints = 20
  '            oGridPrint.FitWidthToPages = Math.Ceiling(TamanhoGrid / 1200)
  '        End If
  '    End With

  '    With oPrintPreviewDialog
  '        .Document = oGridPrint
  '        .ShowDialog()
  '        ' .Dispose()
  '    End With

  '    ' oPrintPreviewDialog = Nothing
  'End Sub
End Module