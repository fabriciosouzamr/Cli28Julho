Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Win

Public Class uscQuestionario_Formulario
  Private Class cControle
    Public SQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO As Integer
    Public ID_QUESTIONARIO_VERSAO_ITEM As Integer
    Public ID_QUESTIONARIO_VERSAO_CONTAINER As Integer
    Public ID_LEGENDA_ITEM As Integer
    Public ID_OPT_TIPOCOMPONENTE As Integer
    Public ID_OPT_TIPOCAMPO As Integer
    Public LEGENDA_ITEM As Boolean
  End Class

  Dim iSQ_QUESTIONARIO As Integer
  Dim iSQ_QUESTIONARIO_VERSAO As Integer
  Dim iSQ_QUESTIONARIO_RESPOSTA As Integer
  Dim iID_PESSOA As Integer
  Dim iID_ATENDIMENTO As Integer
  Dim iID_PESSOA_PROFISSIONAL As Integer
  Dim bPodeEditar As Boolean = True
  Dim sComentario As String = ""

  Property Comentario As String
    Get
      Return sComentario
    End Get
    Set(value As String)
      sComentario = value
    End Set
  End Property

  Public Property PodeEditar As Boolean
    Get
      Return bPodeEditar
    End Get
    Set(value As Boolean)
      bPodeEditar = value
    End Set
  End Property

  Public Property ID_ATENDIMENTO As Integer
    Get
      Return iID_ATENDIMENTO
    End Get
    Set(value As Integer)
      iID_ATENDIMENTO = value
    End Set
  End Property

  Public Property ID_PESSOA_PROFISSIONAL As Integer
    Get
      Return iID_PESSOA_PROFISSIONAL
    End Get
    Set(value As Integer)
      iID_PESSOA_PROFISSIONAL = value
    End Set
  End Property

  Public Property ID_PESSOA As Integer
    Get
      Return iID_PESSOA
    End Get
    Set(value As Integer)
      iID_PESSOA = value
    End Set
  End Property

  Public Property SQ_QUESTIONARIO_RESPOSTA As Integer
    Get
      Return iSQ_QUESTIONARIO_RESPOSTA
    End Get
    Set(value As Integer)
      iSQ_QUESTIONARIO_RESPOSTA = value
    End Set
  End Property

  Public Property SQ_QUESTIONARIO_VERSAO As Integer
    Get
      Return iSQ_QUESTIONARIO_VERSAO
    End Get
    Set(value As Integer)
      iSQ_QUESTIONARIO_VERSAO = value
    End Set
  End Property

  Public Property SQ_QUESTIONARIO As Integer
    Get
      Return iSQ_QUESTIONARIO
    End Get
    Set(value As Integer)
      iSQ_QUESTIONARIO = value
    End Set
  End Property

  Public ReadOnly Property ControlePreenchido As Boolean
    Get
      Return Controle_Preenchido(Me, False)
    End Get
  End Property

  Public Sub CarregarDados()
    Dim oData_01 As DataTable
    Dim oData_02 As DataTable
    Dim sSqlText As String
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim iSQ_QUESTIONARIO_VERSAO_CONTAINER As Integer
    Dim iMaxTop As Integer = 0

    If iSQ_QUESTIONARIO = 0 Then Exit Sub

    If iSQ_QUESTIONARIO_VERSAO = 0 Then
      sSqlText = "SELECT QU.*, QV.SQ_QUESTIONARIO_VERSAO" & _
                 " FROM TB_QUESTIONARIO QU" & _
                  " LEFT JOIN TB_QUESTIONARIO_VERSAO QV ON QU.SQ_QUESTIONARIO = QV.ID_QUESTIONARIO" & _
                                                     " AND QV.DT_FIM_USO IS NULL" & _
                 " WHERE QU.SQ_QUESTIONARIO = " & iSQ_QUESTIONARIO
      oData_01 = DBQuery(sSqlText)

      If Not objDataTable_Vazio(oData_01) Then
        iSQ_QUESTIONARIO_VERSAO = oData_01.Rows(0).Item("SQ_QUESTIONARIO_VERSAO")
      End If
    End If

    If iSQ_QUESTIONARIO_VERSAO > 0 Then
      Dim oContainer As Control = Nothing
      Dim oControl As Object = Nothing
      Dim oControle As cControle = Nothing

      'Carregar Container
      sSqlText = "SELECT * FROM TB_QUESTIONARIO_VERSAO_CONTAINER WHERE ID_QUESTIONARIO_VERSAO = " & iSQ_QUESTIONARIO_VERSAO
      oData_01 = DBQuery(sSqlText)

      For iCont_01 = 0 To oData_01.Rows.Count - 1
        With oData_01.Rows(iCont_01)
          Select Case .Item("ID_OPT_TIPOCONTAINER")
            Case enOpcoes.Questionario_TipoPainel_Painel_Main.GetHashCode
              oContainer = Me
            Case enOpcoes.Questionario_TipoPainel_Painel.GetHashCode
              oContainer = New Panel
            Case enOpcoes.Questionario_TipoPainel_GroupBox.GetHashCode
              oContainer = New GroupBox
              oContainer.Text = FNC_NVL(.Item("DS_TEXTO"), "")
            Case enOpcoes.Questionario_TipoPainel_TabAba.GetHashCode
              oContainer = New TabControl
          End Select

          If .Item("ID_OPT_TIPOCONTAINER") <> enOpcoes.Questionario_TipoPainel_Painel_Main.GetHashCode Then
            oContainer.Parent = Me
            oContainer.Left = Mid(.Item("NR_CAMPO_LOCALIZACAO"), 1, InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") - 1)
            oContainer.Top = Mid(.Item("NR_CAMPO_LOCALIZACAO"), InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") + 1)
            oContainer.Height = Mid(.Item("NR_DIMENSAO"), 1, InStr(.Item("NR_DIMENSAO"), ".") - 1)
            oContainer.Width = Mid(.Item("NR_DIMENSAO"), InStr(.Item("NR_DIMENSAO"), ".") + 1)
            oContainer.TabIndex = Val("1" & FNC_StrZero(oContainer.Top.ToString, 4) + FNC_StrZero(oContainer.Left.ToString, 5))

            If iMaxTop < (oContainer.Top + oContainer.Height) Then iMaxTop = oContainer.Top + oContainer.Height
          End If

          iSQ_QUESTIONARIO_VERSAO_CONTAINER = .Item("SQ_QUESTIONARIO_VERSAO_CONTAINER")
        End With

        sSqlText = "SELECT * FROM TB_QUESTIONARIO_VERSAO_CONTAINER_ELEMENTO" & _
                   " WHERE ID_QUESTIONARIO_VERSAO_CONTAINER = " & iSQ_QUESTIONARIO_VERSAO_CONTAINER
        oData_02 = DBQuery(sSqlText)

        For iCont_02 = 0 To oData_02.Rows.Count - 1
          With oData_02.Rows(iCont_02)
            Select Case .Item("ID_OPT_TIPOCAMPO")
              Case enOpcoes.Questionario_TipoRespostaExplicacao_Numero.GetHashCode, _
                   enOpcoes.TipoCampo_Numero.GetHashCode
                oControl = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
                oControl.ReadOnly = (Not bPodeEditar)
              Case enOpcoes.Questionario_TipoRespostaExplicacao_Texto.GetHashCode, _
                   enOpcoes.TipoCampo_Texto.GetHashCode
                oControl = New TextBox
                oControl.ReadOnly = (Not bPodeEditar)
              Case enOpcoes.TipoCampo_Data.GetHashCode
                oControl = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
                oControl.ReadOnly = (Not bPodeEditar)
              Case enOpcoes.TipoCampo_Legenda_MultiplaOpcao.GetHashCode, _
                   enOpcoes.TipoCampo_Marcacao.GetHashCode
                oControl = New CheckBox
                oControl.Enabled = bPodeEditar
              Case enOpcoes.TipoCampo_Legenda_UnicaOpcao.GetHashCode
                oControl = New RadioButton
                oControl.Enabled = bPodeEditar
              Case enOpcoes.Questionario_TipoPainel_Label.GetHashCode
                oControl = New Label
            End Select

            oControl.Parent = oContainer

            Try
              oControl.Text = Trim(FNC_NVL(.Item("DS_TEXTO"), ""))
            Catch ex As Exception
            End Try
            Try
              oControl.Font = FNC_StringToFont(.Item("DS_FONTE"))
            Catch ex As Exception
            End Try

            oControl.Left = Mid(.Item("NR_CAMPO_LOCALIZACAO"), 1, InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") - 1)
            oControl.Top = Mid(.Item("NR_CAMPO_LOCALIZACAO"), InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") + 1)

            If .Item("ID_OPT_TIPOCAMPO") = enOpcoes.Questionario_TipoPainel_Label.GetHashCode Then
              oControl.AutoSize = True
            Else
              oControl.Height = Mid(.Item("NR_DIMENSAO"), 1, InStr(.Item("NR_DIMENSAO"), ".") - 1)
              oControl.Width = Mid(.Item("NR_DIMENSAO"), InStr(.Item("NR_DIMENSAO"), ".") + 1)
            End If

            If iMaxTop < (oControl.Top + oControl.Height) Then iMaxTop = oControl.Top + oControl.Height
          End With
        Next

        sSqlText = "SELECT DISTINCT *" & _
                   " FROM FC_QUESTIONARIO_VERSAO_ITEM_ELEMENTO(" & iSQ_QUESTIONARIO_RESPOSTA & ") IT" & _
                   " WHERE ID_QUESTIONARIO_VERSAO_CONTAINER = " & iSQ_QUESTIONARIO_VERSAO_CONTAINER & _
                     " AND (ID_QUESTIONARIO_RESPOSTA = " & iSQ_QUESTIONARIO_RESPOSTA & " OR ID_QUESTIONARIO_RESPOSTA IS NULL)"
        oData_02 = DBQuery(sSqlText)

        For iCont_02 = 0 To oData_02.Rows.Count - 1
          With oData_02.Rows(iCont_02)
            If FNC_NVL(.Item("ID_QUESTIONARIO_VERSAO_ITEM"), 0) = 206 Then
              iCont_02 = iCont_02
            End If
            oControle = New cControle
            oControle.SQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO = FNC_NVL(.Item("SQ_QUESTIONARIO_VERSAO_ITEM_ELEMENTO"), 0)
            oControle.ID_QUESTIONARIO_VERSAO_ITEM = FNC_NVL(.Item("ID_QUESTIONARIO_VERSAO_ITEM"), 0)
            oControle.ID_QUESTIONARIO_VERSAO_CONTAINER = FNC_NVL(.Item("ID_QUESTIONARIO_VERSAO_CONTAINER"), 0)
            oControle.ID_LEGENDA_ITEM = FNC_NVL(.Item("ID_LEGENDA_ITEM"), 0)
            oControle.ID_OPT_TIPOCOMPONENTE = FNC_NVL(.Item("ID_OPT_TIPOCOMPONENTE"), 0)
            oControle.ID_OPT_TIPOCAMPO = FNC_NVL(.Item("ID_OPT_TIPOCAMPO"), 0)
            oControle.LEGENDA_ITEM = (Not objDataTable_CampoVazio(.Item("ID_LEGENDA_ITEM")))

            Select Case .Item("ID_OPT_TIPOCAMPO")
              Case enOpcoes.Questionario_TipoRespostaExplicacao_Numero.GetHashCode
                oControl = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
                oControl.Value = Nothing
                oControl.ReadOnly = (Not bPodeEditar)
                If Not objDataTable_CampoVazio(.Item("QT_EXPLICACAO")) Then oControl.Value = .Item("QT_EXPLICACAO")
              Case enOpcoes.TipoCampo_Numero.GetHashCode
                oControl = New Infragistics.Win.UltraWinEditors.UltraNumericEditor
                oControl.Value = Nothing
                oControl.ReadOnly = (Not bPodeEditar)
                If Not objDataTable_CampoVazio(.Item("NR_RESPOSTA")) Then oControl.Value = .Item("NR_RESPOSTA")

                If .Item("ID_OPT_TIPOCOMPONENTE") = enOpcoes.Questionario_TipoComponente_CampoExplicacao.GetHashCode Then
                  If Not objDataTable_CampoVazio(.Item("QT_EXPLICACAO")) Then oControl.Value = .Item("QT_EXPLICACAO")
                End If
              Case enOpcoes.Questionario_TipoRespostaExplicacao_Texto.GetHashCode
                oControl = New TextBox
                oControl.ReadOnly = (Not bPodeEditar)
                If Not objDataTable_CampoVazio(.Item("DS_EXPLICACAO")) Then oControl.Text = .Item("DS_EXPLICACAO")
              Case enOpcoes.TipoCampo_Texto.GetHashCode
                oControl = New TextBox
                oControl.ReadOnly = (Not bPodeEditar)
                If Not objDataTable_CampoVazio(.Item("DS_RESPOSTA")) Then oControl.Text = .Item("DS_RESPOSTA")

                If .Item("ID_OPT_TIPOCOMPONENTE") = enOpcoes.Questionario_TipoComponente_CampoExplicacao.GetHashCode Then
                  If Not objDataTable_CampoVazio(.Item("DS_EXPLICACAO")) Then oControl.Text = .Item("DS_EXPLICACAO")
                End If
              Case enOpcoes.TipoCampo_Data.GetHashCode
                oControl = New Infragistics.Win.UltraWinEditors.UltraDateTimeEditor
                oControl.Value = Nothing
                oControl.ReadOnly = (Not bPodeEditar)
                If Not objDataTable_CampoVazio(.Item("DT_RESPOSTA")) Then oControl.Value = .Item("DT_RESPOSTA")
              Case enOpcoes.TipoCampo_Legenda_MultiplaOpcao.GetHashCode, _
                   enOpcoes.TipoCampo_Marcacao.GetHashCode
                oControl = New CheckBox
                oControl.Enabled = bPodeEditar
                oControl.Checked = False
                If FNC_NVL(.Item("ID_OPT_TIPOCAMPO"), 0) = enOpcoes.TipoCampo_Marcacao.GetHashCode Then
                  If Not objDataTable_CampoVazio(.Item("ID_QUESTIONARIO_RESPOSTA")) Then oControl.Checked = True
                Else
                  If FNC_NVL(.Item("ID_LEGENDA_ITEM"), 0) = FNC_NVL(.Item("ID_LEGENDA_ITEM_RESPOSTA"), 0) Then oControl.Checked = True
                End If
                oControl.Text = FNC_NVL(.Item("DS_TEXTO"), .Item("DS_PERGUNTA"))
              Case enOpcoes.TipoCampo_Legenda_UnicaOpcao.GetHashCode
                oControl = New RadioButton
                oControl.Enabled = bPodeEditar
                oControl.Checked = False
                If .Item("ID_LEGENDA_ITEM") = FNC_NVL(.Item("ID_LEGENDA_ITEM_RESPOSTA"), 0) Then oControl.Checked = True
              Case enOpcoes.Questionario_TipoPainel_Label.GetHashCode
                oControl = New Label

                Select Case .Item("ID_OPT_TIPOCOMPONENTE")
                  Case enOpcoes.Questionario_TipoComponente_RotuloPergunta.GetHashCode
                    oControl.Text = Trim(FNC_NVL(.Item("DS_TEXTO"), .Item("DS_PERGUNTA")))
                  Case enOpcoes.Questionario_TipoComponente_RotuloExplicacao.GetHashCode
                    oControl.Text = Trim(.Item("DS_ROTULO_EXPLICACAO"))
                End Select
            End Select

            oControl.Parent = oContainer
            oControl.Tag = oControle

            If .Item("ID_OPT_TIPOCAMPO") = enOpcoes.TipoCampo_Legenda_MultiplaOpcao.GetHashCode Or _
               .Item("ID_OPT_TIPOCAMPO") = enOpcoes.TipoCampo_Legenda_UnicaOpcao.GetHashCode Then
              Try
                oControl.Text = Trim(FNC_NVL(.Item("DS_TEXTO"), ""))
              Catch ex As Exception
              End Try
            End If
            Try
              oControl.Font = FNC_StringToFont(.Item("DS_FONTE"))
            Catch ex As Exception
            End Try

            oControl.Left = Mid(.Item("NR_CAMPO_LOCALIZACAO"), 1, InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") - 1)
            oControl.Top = Mid(.Item("NR_CAMPO_LOCALIZACAO"), InStr(.Item("NR_CAMPO_LOCALIZACAO"), ".") + 1)

            If .Item("ID_OPT_TIPOCAMPO") = enOpcoes.Questionario_TipoPainel_Label.GetHashCode Then
              oControl.AutoSize = True
            Else
              If TypeOf oControl Is TextBox And Val(Mid(.Item("NR_DIMENSAO"), 1, InStr(.Item("NR_DIMENSAO"), ".") - 1)) > 21 Then
                Dim oTextBox As TextBox

                oTextBox = oControl
                oTextBox.Multiline = True
              End If

              oControl.Height = Mid(.Item("NR_DIMENSAO"), 1, InStr(.Item("NR_DIMENSAO"), ".") - 1)
              oControl.Width = Mid(.Item("NR_DIMENSAO"), InStr(.Item("NR_DIMENSAO"), ".") + 1)
            End If

            Try
              oControl.TabIndex = Val("1" & FNC_StrZero(oControl.Top.ToString, 4) + FNC_StrZero(oControl.Left.ToString, 5))
              oControl.TabStop = True
            Catch ex As Exception
              oControl = oControl
            End Try
          End With

          If oContainer.Name = Me.Name Then
            If iMaxTop < (oControl.Top + oControl.Height) Then iMaxTop = oControl.Top + oControl.Height
          End If
        Next
      Next

      Dim oLabel As New Label

      oLabel.Parent = Me
      oLabel.Visible = True
      oLabel.Text = sComentario
      oLabel.TextAlign = ContentAlignment.MiddleCenter
      oLabel.AutoSize = True
      oLabel.Top = iMaxTop + 20
      oLabel.Left = (Me.Width - oLabel.Width) / 2
    End If
  End Sub

  Public Function Gravar(Optional bMensagemGravacaoEfetuada As Boolean = True) As Boolean
    Dim bOk As Boolean

    If Not bPodeEditar Then
      FNC_Mensagem("Esse questionário não está habilitado para gravação")
      GoTo Sair
    End If
    If iID_PESSOA = 0 And iID_ATENDIMENTO = 0 Then
      FNC_Mensagem("Informe um atendimento ou pessoa referente a esse questionário")
      GoTo Sair
    End If

    Dim sSqlText As String

    sSqlText = DBMontar_SP("SP_QUESTIONARIO_RESPOSTA_ITEMS_DEL", False, "@SQ_QUESTIONARIO_RESPOSTA")
    DBExecutar(sSqlText, DBParametro_Montar("SQ_QUESTIONARIO_RESPOSTA", iSQ_QUESTIONARIO_RESPOSTA))

    If FNC_Questionario_Resposta_Gravar(iSQ_QUESTIONARIO_RESPOSTA, _
                                        iSQ_QUESTIONARIO_VERSAO, _
                                        iID_PESSOA, _
                                        iID_ATENDIMENTO, _
                                        iID_PESSOA_PROFISSIONAL) Then
      If Controle_Preenchido(Me, True) Then
        bOk = True
        If bMensagemGravacaoEfetuada Then FNC_Mensagem("Gravação Efetuada")
      End If
    End If

Sair:
    Return bOk
  End Function

  Private Function Controle_Preenchido(oContainer As Control, bGravarBancoDados As Boolean) As Boolean
    Dim sSqlText As String
    Dim iCont As Integer
    Dim bOk As Boolean

    Dim oID_LEGENDA_ITEM As DBParamentro
    Dim oDS_RESPOSTA As DBParamentro
    Dim oNR_RESPOSTA As DBParamentro
    Dim oDT_RESPOSTA As DBParamentro
    Dim oIC_RESPOSTA As DBParamentro
    Dim oDS_EXPLICACAO As DBParamentro
    Dim oQT_EXPLICACAO As DBParamentro
    Dim bGravar As Boolean
    Dim bControlePreenchido As Boolean

    For iCont = 0 To oContainer.Controls.Count - 1
      If oContainer.Controls(iCont).Controls.Count > 0 Then
        bOk = Controle_Preenchido(oContainer.Controls(iCont), bGravarBancoDados)
      Else
        bGravar = False
        oID_LEGENDA_ITEM = New DBParamentro
        oDS_RESPOSTA = New DBParamentro
        oNR_RESPOSTA = New DBParamentro
        oDT_RESPOSTA = New DBParamentro
        oIC_RESPOSTA = New DBParamentro
        oDS_EXPLICACAO = New DBParamentro
        oQT_EXPLICACAO = New DBParamentro

        If Not oContainer.Controls(iCont).Tag Is Nothing Then
          oID_LEGENDA_ITEM = DBParametro_Montar("ID_LEGENDA_ITEM", Nothing)
          oDS_RESPOSTA = DBParametro_Montar("DS_RESPOSTA", Nothing)
          oNR_RESPOSTA = DBParametro_Montar("NR_RESPOSTA", Nothing)
          oDT_RESPOSTA = DBParametro_Montar("DT_RESPOSTA", Nothing)
          oIC_RESPOSTA = DBParametro_Montar("IC_RESPOSTA", Nothing)
          oDS_EXPLICACAO = DBParametro_Montar("DS_EXPLICACAO", Nothing)
          oQT_EXPLICACAO = DBParametro_Montar("QT_EXPLICACAO", Nothing)

          With oContainer.Controls(iCont)
            Select Case .Tag.ID_OPT_TIPOCOMPONENTE
              Case enOpcoes.Questionario_TipoComponente_CampoPergunta.GetHashCode
                Select Case .Tag.ID_OPT_TIPOCAMPO
                  Case enOpcoes.TipoCampo_Texto.GetHashCode
                    bGravar = (Trim(.Text) <> "")
                    oDS_RESPOSTA = DBParametro_Montar("DS_RESPOSTA", .Text)
                  Case enOpcoes.TipoCampo_Numero.GetHashCode
                    Dim oNumero As Infragistics.Win.UltraWinEditors.UltraNumericEditor

                    oNumero = oContainer.Controls(iCont)
                    bGravar = (Not oNumero.Value Is Nothing)
                    oNR_RESPOSTA = DBParametro_Montar("NR_RESPOSTA", oNumero.Value)
                  Case enOpcoes.TipoCampo_Data.GetHashCode
                    Dim oData As Infragistics.Win.UltraWinEditors.UltraDateTimeEditor

                    oData = oContainer.Controls(iCont)
                    bGravar = (Not oData.Value Is Nothing)
                    oDT_RESPOSTA = DBParametro_Montar("DT_RESPOSTA", oData.Value)
                  Case enOpcoes.TipoCampo_Marcacao.GetHashCode
                    Dim oCheckBox As CheckBox

                    oCheckBox = oContainer.Controls(iCont)
                    If oCheckBox.Checked Then
                      bGravar = True
                    End If
                End Select
              Case enOpcoes.Questionario_TipoComponente_CampoExplicacao.GetHashCode
                bGravar = True

                oID_LEGENDA_ITEM = DBParametro_Montar("ID_LEGENDA_ITEM", -1)

                Select Case .Tag.ID_OPT_TIPOCAMPO
                  Case enOpcoes.TipoCampo_Texto.GetHashCode
                    bGravar = (Trim(.Text) <> "")
                    oDS_EXPLICACAO = DBParametro_Montar("DS_EXPLICACAO", .Text)
                  Case enOpcoes.TipoCampo_Numero.GetHashCode
                    Dim oNumero As Infragistics.Win.UltraWinEditors.UltraNumericEditor

                    oNumero = oContainer.Controls(iCont)
                    bGravar = (Not oNumero.Value Is Nothing)
                    oQT_EXPLICACAO = DBParametro_Montar("QT_EXPLICACAO", oNumero.Value)
                End Select
              Case enOpcoes.Questionario_TipoComponente_LegendaItem.GetHashCode
                Select Case .Tag.ID_OPT_TIPOCAMPO
                  Case enOpcoes.TipoCampo_Legenda_UnicaOpcao.GetHashCode
                    Dim oRadioButton As RadioButton

                    oRadioButton = oContainer.Controls(iCont)
                    If oRadioButton.Checked Then
                      bGravar = True
                      oIC_RESPOSTA = DBParametro_Montar("IC_RESPOSTA", IIf(.Tag.ID_LEGENDA_ITEM = enLegendaItem.SimNao_Sim.GetHashCode, "S", "N"))
                      oID_LEGENDA_ITEM = DBParametro_Montar("ID_LEGENDA_ITEM", .Tag.ID_LEGENDA_ITEM)
                    End If
                  Case enOpcoes.TipoCampo_Legenda_MultiplaOpcao.GetHashCode, _
                       enOpcoes.TipoCampo_Marcacao.GetHashCode
                    Dim oCheckBox As CheckBox

                    oCheckBox = oContainer.Controls(iCont)
                    If oCheckBox.Checked Then
                      bGravar = True
                      oID_LEGENDA_ITEM = DBParametro_Montar("ID_LEGENDA_ITEM", .Tag.ID_LEGENDA_ITEM)
                    End If
                End Select
            End Select

            bControlePreenchido = (bControlePreenchido Or bGravar)

            If bGravar And bGravarBancoDados Then
              sSqlText = DBMontar_SP("SP_QUESTIONARIO_RESPOSTA_ITEM_CAD", False, "@ID_QUESTIONARIO_RESPOSTA", _
                                                                                 "@ID_QUESTIONARIO_VERSAO_ITEM", _
                                                                                 "@ID_LEGENDA_ITEM", _
                                                                                 "@DS_RESPOSTA", _
                                                                                 "@NR_RESPOSTA", _
                                                                                 "@DT_RESPOSTA", _
                                                                                 "@IC_RESPOSTA", _
                                                                                 "@DS_EXPLICACAO", _
                                                                                 "@QT_EXPLICACAO")
              bOk = DBExecutar(sSqlText, DBParametro_Montar("ID_QUESTIONARIO_RESPOSTA", iSQ_QUESTIONARIO_RESPOSTA), _
                                         DBParametro_Montar("ID_QUESTIONARIO_VERSAO_ITEM", .Tag.ID_QUESTIONARIO_VERSAO_ITEM), _
                                         oID_LEGENDA_ITEM, _
                                         oDS_RESPOSTA, _
                                         oNR_RESPOSTA, _
                                         oDT_RESPOSTA, _
                                         oIC_RESPOSTA, _
                                         oDS_EXPLICACAO, _
                                         oQT_EXPLICACAO)
            End If
          End With
        End If
      End If
    Next

    Return IIf(bGravarBancoDados, bOk, bControlePreenchido)
  End Function
End Class
