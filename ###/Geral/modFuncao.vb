Imports SC = System.Configuration
Imports System.Windows.Forms
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Imports System
Imports BOOL = System.Boolean
Imports DWORD = System.UInt32
Imports LPWSTR = System.String
Imports NET_API_STATUS = System.UInt32
Imports System.Drawing.Text

Imports System.Drawing.Printing

Module modFuncao
  Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
  Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

  Private Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Long) As Long
  Private Declare Function ShellExecuteForExplore Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hWnd As Long, ByVal lpOperation As String, ByVal lpFile As String, lpParameters As Object, lpDirectory As Object, ByVal nShowCmd As Long) As Long

  Public Enum EShellShowConstants
    essSW_HIDE = 0
    essSW_MAXIMIZE = 3
    essSW_MINIMIZE = 6
    essSW_SHOWMAXIMIZED = 3
    essSW_SHOWMINIMIZED = 2
    essSW_SHOWNORMAL = 1
    essSW_SHOWNOACTIVATE = 4
    essSW_SHOWNA = 8
    essSW_SHOWMINNOACTIVE = 7
    essSW_SHOWDEFAULT = 10
    essSW_RESTORE = 9
    essSW_SHOW = 5
  End Enum

  Private Const ERROR_FILE_NOT_FOUND = 2
  Private Const ERROR_PATH_NOT_FOUND = 3
  Private Const ERROR_BAD_FORMAT = 11
  Private Const SE_ERR_ACCESSDENIED = 5 ' access denied 
  Private Const SE_ERR_ASSOCINCOMPLETE = 27
  Private Const SE_ERR_DDEBUSY = 30
  Private Const SE_ERR_DDEFAIL = 29
  Private Const SE_ERR_DDETIMEOUT = 28
  Private Const SE_ERR_DLLNOTFOUND = 32
  Private Const SE_ERR_FNF = 2 ' file not found 
  Private Const SE_ERR_NOASSOC = 31
  Private Const SE_ERR_PNF = 3 ' path not found 
  Private Const SE_ERR_OOM = 8 ' out of memory 
  Private Const SE_ERR_SHARE = 26

  Dim sal() As Byte = {&H0, &H1, &H2, &H3, &H4, &H5, &H6, &H5, &H4, &H3, &H2, &H1, &H0}

  Public Sub FNC_Pausa()
    Application.DoEvents()
    Application.DoEvents()
    Application.DoEvents()
    Application.DoEvents()
  End Sub

  Public Function FNC_FormatarTelefone(sTelefone As String) As String
    sTelefone = FNC_SoNumero(sTelefone)
    sTelefone = sTelefone.Trim().Replace("-", "").Replace("(", "").Replace(")", "")

    If sTelefone.Substring(0, 2) <> "55" Then
      sTelefone = "55" + sTelefone
    End If

    If Len(sTelefone) = 10 Or Len(sTelefone) = 9 Then

      If sTelefone.Length = 12 Then
        sTelefone = sTelefone.Substring(0, 4) + "9" + sTelefone.Substring(4)
      End If
    End If

    Return sTelefone
  End Function

  Public Function FNC_DBDataToString(oData As Object) As String
    Dim iAno As Integer = 0
    Dim iMes As Integer = 0
    Dim iDia As Integer = 0
    Dim sAux As String = ""

    If IsDate(oData) Then
      iAno = oData.Year
      iMes = oData.Month
      iDia = oData.Day
      sAux = FNC_StrZero(iDia, 2) + "/" + FNC_StrZero(iMes, 2) + "/" + FNC_StrZero(iAno, 4)
    End If

    Return sAux
  End Function

  Public Function FNC_Formatar_CEP(sCEP As String) As String
    If FNC_SoNumero(sCEP).Length = 8 And sCEP.Trim <> "" Then
      Return sCEP.Substring(0, 2) + "." + sCEP.Substring(2, 3) + "-" + sCEP.Substring(5, 3)
    Else
      Return sCEP
    End If
  End Function

  Public Sub FNC_Abrir_PaginaInternet(sPaginaInternet As String)
    Try
      If sPaginaInternet.Trim() = "" Then
        FNC_Mensagem("É necessário informar o endereço de internet")
      Else
        System.Diagnostics.Process.Start(sPaginaInternet.Trim())
      End If
    Catch ex As Exception
      FNC_Mensagem("[PaginaInternet]" + ex.Message)
    End Try
  End Sub

  Function FNC_CalculoSimples(n1 As Double, n2 As Double, Signe As Integer) As Double
    Dim bRet As Double

    Select Case Signe
      Case 43 ' +  
        bRet = n1 + n2
      Case 45 ' -  
        bRet = n1 - n2
      Case 42 ' *  
        bRet = n1 * n2
      Case 47 ' /  
        bRet = n1 / n2
        'Aqui, adicionar outro cálculo...  
    End Select

    Return bRet
  End Function

  Function FNC_Avaliar(ByVal Txt As String) As String
    Dim i As Integer, oNB As Integer, fNB As Integer
    Dim P1 As Integer, P2 As Integer
    Dim Buff As String

    'Para os cálculos botar um ponto no lugar da vírgula  
    Txt = Replace(Txt, ",", ".")
    'Ver se há "( " 
    For i = 1 To Len(Txt)
      If Mid(Txt, i, 1) = "(" Then oNB = oNB + 1
    Next i
    'Se houver "(" (de abertura), ver se foram validados por ")" (de fechamento)  
    If oNB > 0 Then
      For i = 1 To Len(Txt)
        If Mid(Txt, i, 1) = ")" Then fNB = fNB + 1
      Next i
    Else
      'Sem parênteses, Avalia o cálculo diretamente 
      Return FNC_EvalueExpression(Txt)
      Exit Function
    End If
    If oNB <> fNB Then
      'Os parênteses não são concordantes, pôr mensagem de erro entre parênteses
      Exit Function
    End If

    While oNB > 0
      'busca o último parêntese de abertura   
      P1 = InStrRev(Txt, "(")
      'busca o parêntese de fechamento da expressão  
      P2 = InStr(Mid(Txt, P1 + 1), ")")
      'Avalia a expressão que está entre parênteses  
      Buff = FNC_EvalueExpression(Mid(Txt, P1 + 1, P2 - 1))
      'Substituir a expressão pelo resultado e tirar os parênteses  
      Txt = Left(Txt, P1 - 1) & Buff & Mid(Txt, P1 + P2 + 1)
      oNB = oNB - 1
    End While
    'sem parêntese, avaliar a última expressão  
    Return FNC_EvalueExpression(Txt)
  End Function

  Public Function FNC_Computador_Nome() As String
    Dim sComputadorNome As String

    sComputadorNome = System.Net.Dns.GetHostName

    Return sComputadorNome
  End Function

  Public Function FNC_ValorPraTexto(dValor As Double) As String
    Return Replace(dValor.ToString(), ",", ".")
  End Function

  Function FNC_EvalueExpression(A As String) As String
    Dim T As Integer, S As Integer
    Dim i As Integer, C As Boolean
    Dim c1 As Double, c2 As Double, Signe As Integer
    Dim R As String = "", Fim As Boolean

    'remover os espaços 
    A = Replace(A, " ", "")

    While Not Fim
      For i = 1 To Len(A)
        T = Asc(Mid(A, i, 1))
        If T < 48 And T <> 46 Or i = Len(A) Then
          If C Then 'avaliar  
            If i = Len(A) Then
              c2 = Val(Mid(A, S))
            Else
              c2 = Val(Mid(A, S, i - S))
            End If
            R = Str(FNC_CalculoSimples(c1, c2, Signe))
            If i = Len(A) Then
              Fim = True
            Else
              A = Trim(R & Mid(A, i))
              C = False
            End If
            Exit For
          Else 'separa o 1° número  
            c1 = Val(Left(A, i - 1))
            Signe = T
            S = i + 1
            C = True
          End If
        End If
      Next i
    End While
    'substituir a expressão pelo resultado  
    Return Trim(R)
  End Function

  Public Function FNC_IntPixToTwips(oForm As Form, ByVal intValInPix As Integer) As Integer
    Dim g As Graphics = oForm.CreateGraphics()

    Return intValInPix / g.DpiX * 1440
    g.Dispose()
  End Function

  Public Function FNC_In(oValor As Object, ParamArray oValores() As Object)
    Dim bOk As Boolean = False
    Dim iCont As Integer

    If Not oValores Is Nothing Then
      For iCont = 0 To oValores.Length - 1
        If oValor = oValores(iCont) Then
          bOk = True
          Exit For
        End If
      Next
    End If

    Return bOk
  End Function

  Public Function FNC_Contem(oValor As Object, ParamArray oValores() As Object)
    Dim bOk As Boolean = False
    Dim iCont As Integer

    If Not oValores Is Nothing Then
      For iCont = 0 To oValores.Length - 1
        If InStr(oValor, oValores(iCont)) > 0 Then
          bOk = True
          Exit For
        End If
      Next
    End If

    Return bOk
  End Function

  Public Function FNC_RichTextBox_CriarTabela(oColuna As Object,
                                              oLinha As Object,
                                              Optional aTamanhoColuna() As Integer = Nothing,
                                              Optional oFont() As Font = Nothing,
                                              Optional oCores As Object = Nothing) As String

    Const const_TamanhoPadrao As Integer = 1500
    Dim sRet As String
    Dim Fonte As String = "{\fonttbl{\f0\fnil\fcharset0 Arial;}{\f1\fnil\fcharset0 Castellar;}"
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim iColuna As Integer
    Dim iLinha As Integer
    Dim iTamanhoColuna As Integer
    Dim iTamanhoAcumulado As Integer = 0

    If IsArray(oColuna) Then iColuna = oColuna.Length Else iColuna = oColuna
    If IsArray(oLinha) Then iLinha = oLinha.Length Else iLinha = oLinha

    sRet = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1046\deflangfe1046\deftab708" & vbCrLf &
            Fonte & "{\f1\fswiss\fprq2\fcharset0 Calibri;}}" & vbCrLf &
            "{\colortbl ;\red255\green255\blue0;\red0\green255\blue0;}" & vbCrLf &
            "{\*\generator Riched20 10.0.14393}" & vbCrLf &
            "{\*\mmathPr\mnaryLim0\mdispDef1\mwrapIndent1440 }" & vbCrLf &
            "\viewkind4\uc1" & vbCrLf &
            "\trowd\trgaph70\trleft5\trqc\trrh240" & vbCrLf &
            "\trbrdrl\brdrs\brdrw10" & vbCrLf &
            "\trbrdrt\brdrs\brdrw10" & vbCrLf &
            "\trbrdrr\brdrs\brdrw10" & vbCrLf &
            "\trbrdrb\brdrs\brdrw10" & vbCrLf &
            "\trpaddl70\trpaddr70\trpaddfl3\trpaddfr3" & vbCrLf

    For iCont_01 = 1 To iColuna
      If aTamanhoColuna Is Nothing Then
        iTamanhoColuna = const_TamanhoPadrao
      Else
        If aTamanhoColuna(iCont_01 - 1) = 0 Then
          iTamanhoColuna = const_TamanhoPadrao
        Else
          iTamanhoColuna = aTamanhoColuna(iCont_01 - 1)
        End If
      End If

      iTamanhoAcumulado = iTamanhoAcumulado + iTamanhoColuna

      FNC_Str_Adicionar(sRet, "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx" & iTamanhoAcumulado.ToString, vbCrLf)
    Next

    FNC_Str_Adicionar(sRet, "\pard\intbl\widctlpar\cf0\highlight1\b1\f0\fs22", "")

    If IsArray(oColuna) Then
      'FNC_Str_Adicionar(sRet, "\pard\intbl\widctlpar\cf0\highlight1\b1\f0\fs22", "")

      For iCont_01 = 0 To oColuna.Length - 1
        FNC_Str_Adicionar(sRet, " " + oColuna(iCont_01) + "\cell", "")
      Next

      'FNC_Str_Adicionar(sRet, "\row", vbCrLf)
    End If

    FNC_Str_Adicionar(sRet, "\row", vbCrLf)

    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4251" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6375" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8499" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9499" & _
    '"\pard\intbl\widctlpar\cf2\highlight1\b0\f0\fs22 Nome\cell Rua\cell Cor\cell Sexo\cell\ Idade\cell\row" & _

    FNC_Str_Adicionar(sRet, "\trowd\trgaph70\trleft5\trqc\trrh240", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trbrdrl\brdrs\brdrw10", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trbrdrt\brdrs\brdrw10", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trbrdrr\brdrs\brdrw10", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trbrdrb\brdrs\brdrw10", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trbrdrb\brdrs\brdrw10", vbCrLf)
    FNC_Str_Adicionar(sRet, "\trpaddl70\trpaddr70\trpaddfl3\trpaddfr3", vbCrLf)

    iTamanhoAcumulado = 0

    For iCont_01 = 1 To iColuna
      If aTamanhoColuna Is Nothing Then
        iTamanhoColuna = const_TamanhoPadrao
      Else
        If aTamanhoColuna(iCont_01 - 1) = 0 Then
          iTamanhoColuna = const_TamanhoPadrao
        Else
          iTamanhoColuna = aTamanhoColuna(iCont_01 - 1)
        End If
      End If

      iTamanhoAcumulado = iTamanhoAcumulado + iTamanhoColuna

      FNC_Str_Adicionar(sRet, "\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx" & iTamanhoAcumulado.ToString, vbCrLf)
    Next

    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx4251" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx6375" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx8499" & _
    '"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs \cellx9499" & _

    For iCont_01 = 0 To iLinha - 1
      FNC_Str_Adicionar(sRet, "\pard\intbl\widctlpar\cf0\highlight0\b0\f0\fs20", "")

      For iCont_02 = 0 To iColuna - 1
        If IsArray(oLinha) Then
          FNC_Str_Adicionar(sRet, " " + oLinha(iCont_01)(iCont_02) + "\cell", "")
        Else
          FNC_Str_Adicionar(sRet, " \cell", "")
        End If
      Next

      FNC_Str_Adicionar(sRet, "\row", vbCrLf)
    Next


    '"\pard\intbl\widctlpar\cf0\highlight0\b\f1\fs20 Jomar\cell Morador de Rua\cell Preto\cell Masculino\cell\24\cell\row"

    FNC_Str_Adicionar(sRet, "\pard\widctlpar\sa160\sl252\slmult1\par}", "")

    Return sRet
  End Function

  Public Function FNC_ExecutarArquivo(sArquivo As String) As Boolean
    Try
      Dim oPS As New ProcessStartInfo

      oPS.UseShellExecute = True
      oPS.FileName = FNC_DiretorioSistema_AdicionarPath(sArquivo)
      Process.Start(oPS)

      oPS = Nothing

      Return True
    Catch ex As Exception
      Return False
    End Try
  End Function

  Public Function FNC_ExecutarArquivo(ByVal sFIle As String,
                                      Optional ByVal eShowCmd As EShellShowConstants = EShellShowConstants.essSW_SHOWDEFAULT,
                                      Optional ByVal sParameters As String = "",
                                      Optional ByVal sDefaultDir As String = "",
                                      Optional sOperation As String = "open",
                                      Optional Owner As Long = 0) As Boolean
    Dim lR As Long
    Dim lErr As Long, sErr As Long

    If InStr(UCase$(sFIle), ".EXE") = 0 Then
      eShowCmd = 0
    End If

    On Error Resume Next

    If (sParameters = "") And (sDefaultDir = "") Then
      lR = ShellExecuteForExplore(Owner, sOperation, sFIle, 0, 0, EShellShowConstants.essSW_SHOWNORMAL)
    Else
      lR = ShellExecute(Owner, sOperation, sFIle, sParameters, sDefaultDir, eShowCmd)
    End If

    If lR = 32 Then
      Return True
    Else
      ' raise an appropriate error: 
      lErr = vbObjectError + 1048 + lR
      Select Case lR
        Case 0
          lErr = 7 : sErr = "Out of memory"
        Case ERROR_FILE_NOT_FOUND
          lErr = 53 : sErr = "File not found"
        Case ERROR_PATH_NOT_FOUND
          lErr = 76 : sErr = "Path not found"
        Case ERROR_BAD_FORMAT
          sErr = "The executable file is invalid or corrupt"
        Case SE_ERR_ACCESSDENIED
          lErr = 75 : sErr = "Path/file access error"
        Case SE_ERR_ASSOCINCOMPLETE
          sErr = "This file type does not have a valid file association."
        Case SE_ERR_DDEBUSY
          lErr = 285 : sErr = "The file could not be opened because the target application is busy. Please try again in a moment."
        Case SE_ERR_DDEFAIL
          lErr = 285 : sErr = "The file could not be opened because the DDE transaction failed. Please try again in a moment."
        Case SE_ERR_DDETIMEOUT
          lErr = 286 : sErr = "The file could not be opened due to time out. Please try again in a moment."
        Case SE_ERR_DLLNOTFOUND
          lErr = 48 : sErr = "The specified dynamic-link library was not found."
        Case SE_ERR_FNF
          lErr = 53 : sErr = "File not found"
        Case SE_ERR_NOASSOC
          sErr = "No application is associated with this file type."
        Case SE_ERR_OOM
          lErr = 7 : sErr = "Out of memory"
        Case SE_ERR_PNF
          lErr = 76 : sErr = "Path not found"
        Case SE_ERR_SHARE
          lErr = 75 : sErr = "A sharing violation occurred."
        Case Else
          sErr = "An error occurred occurred whilst trying to open or print the selected file."
      End Select

      Err.Raise(lErr, , Application.ProductName & ".GShell", sErr)
      Return False
    End If
  End Function

  Private Function FNC_StartupPath() As String
    Try
      If FNC_NVL(FNC_ConfiguracaoAplicacao("StartupPath"), "") = "" Then
        Return Application.StartupPath
      Else
        Return FNC_ConfiguracaoAplicacao("StartupPath")
      End If
    Catch ex As Exception
      Return Application.StartupPath
    End Try
  End Function

  Public Sub FNC_Aviso(oParent As Form, sMensagem As String)
    Dim oForm As New frmUserDialogo_Aviso

    oForm.Mensagem = sMensagem

    FNC_AbriTela(oForm, , True)
  End Sub

  Public Function FNC_Valor_SeparadorCentavoVirgula() As Boolean
    Return (Math.Sign(InStr(Microsoft.VisualBasic.Format(0.1, "0.0"), ",")) = 1)
  End Function

  Public Function FNC_Relatorio_CarregarArquivo(sNomeRelatorio) As String
    Dim sRetorno As String

    If Trim(FNC_ConfiguracaoAplicacao("PATH_Relatorio")) = "" Then
      GoTo PathSistema
    Else
      If Dir(FNC_Diretorio_Tratar(FNC_ConfiguracaoAplicacao("PATH_Relatorio")) & sNomeRelatorio) = "" Then
        GoTo PathSistema
      Else
        sRetorno = FNC_Diretorio_Tratar(FNC_ConfiguracaoAplicacao("PATH_Relatorio")) & sNomeRelatorio
      End If
    End If

    GoTo Sair

PathSistema:
    sRetorno = FNC_Diretorio_Tratar(sPathSistema) & sNomeRelatorio

Sair:
    If Dir(sRetorno) = "" Then
      FNC_Mensagem(sRetorno & " não encontrado")
      Return ""
    Else
      Return sRetorno
    End If
  End Function

  Public Sub FNC_EdicaoGrid_Botoes(bEdicao As Boolean, oCmdNovo As Button, oCmdAlterar As Button, oCmdExcluir As Button)
    If bEdicao Then
      oCmdNovo.Visible = False
      oCmdAlterar.Text = "G"
      oCmdAlterar.Tag = enBotaoEdicao.Gravar
      oCmdExcluir.Text = "C"
      oCmdExcluir.Tag = enBotaoEdicao.Cancelar
    Else
      oCmdNovo.Visible = False
      oCmdAlterar.Text = "A"
      oCmdAlterar.Tag = enBotaoEdicao.Alterar
      oCmdExcluir.Text = "E"
      oCmdExcluir.Tag = enBotaoEdicao.Excluir
    End If
  End Sub

  Public Function FNC_Porcentagem(dValor As Double,
                                  dFator As Double,
                                  Optional iCasasDecimal As Integer = 2) As Double
    If dFator = 0 Or dValor = 0 Then
      Return 0
    Else
      Return Math.Round(dValor * dFator / 100, iCasasDecimal)
    End If
  End Function

  Public Function FNC_Print_Setup() As PageSetupDialog
    Dim setupDlg As PageSetupDialog = New PageSetupDialog()

    setupDlg.AllowMargins = True
    setupDlg.AllowOrientation = True
    setupDlg.AllowPaper = True
    setupDlg.AllowPrinter = False
    setupDlg.Reset()
    setupDlg.PageSettings = New PageSettings()

    setupDlg.ShowDialog()

    Return setupDlg
  End Function

  Public Function FNC_TipoCampo_ValorPadrao(oTipo As Object) As Object
    Select Case oTipo.GetType.ToString
      Case "System.String"
        Return ""
      Case "System.Int", "System.Int16", "System.Int32", "System.Int64"
        Return 0
      Case Else
        Return Nothing
    End Select
  End Function

  Public Function FNC_FormatoNumero_Para_MaskInput(sFormato As String) As String
    Dim iCont As Integer
    Dim sAux As String = ""

    For iCont = 1 To Len(sFormato)
      If Mid(sFormato, iCont, 1) = "#" Or Mid(sFormato, iCont, 1) = "0" Or Mid(sFormato, iCont, 1) = "." Then
        sAux = sAux & Mid(sFormato, iCont, 1)
      End If
    Next

    If InStr(sAux, ".") > 0 Then
      Return "{double:" & Len(Mid(sAux, 1, InStr(sAux, ".") - 1)) & "." & Len(Mid(sAux, InStr(sAux, ".") + 1)) & "}"
    Else
      Return "{double:" & Len(sAux) & ".0}"
    End If
  End Function

  Public Function FNC_GerarArray(ByVal ParamArray Valor() As Object) As Object
    Return Valor
  End Function

  Public Sub FNC_Mensagem(sMensagem As String, Optional TipoMensagem As enTipoMensagem = enTipoMensagem.Informacao)
    MessageBox.Show(sMensagem, "", MessageBoxButtons.OK, IIf(TipoMensagem = enTipoMensagem.Informacao, MessageBoxIcon.Information, MessageBoxIcon.Error))
    End Sub

  Public Function FNC_Perguntar(ByVal sMens As String) As Boolean
    Return MsgBox(sMens, MsgBoxStyle.YesNo Or
                         MsgBoxStyle.Question Or
                         MsgBoxStyle.DefaultButton2,
                  const_Sistema_Nome) = MsgBoxResult.Yes
  End Function

  Public Function FNC_NuloString(ByVal Valor As Object, Optional bTexto As Boolean = True) As Object
    If FNC_CampoNulo(Valor) Then
      If bTexto Then
        Return "Null"
      Else
        Return Nothing
      End If
    Else
      If Trim(Valor) = "" Or Valor = FNC_QuotedStr("") Then
        If bTexto Then
          Return "Null"
        Else
          Return Nothing
        End If
      Else
        Return Valor
      End If
    End If
  End Function

  Public Function FNC_NuloData(dData As Date) As Object
    Dim dAux As Date = Nothing

    If dData = dAux Then
      Return Nothing
    Else
      Return dData
    End If
  End Function

  Public Function FNC_NuloZero(ByVal Valor As Object, Optional bTexto As Boolean = True) As Object
    Dim iValor As Double

    Valor = FNC_NVL(Valor, 0)

    If IsNumeric(Valor) Then
      iValor = Valor
    Else
      iValor = Val(Valor)
    End If

    If iValor = 0 Then
      If bTexto Then
        Return "Null"
      Else
        Return Nothing
      End If
    Else
      Return Valor
    End If
  End Function

  Public Sub FNC_CarregarImagem(sArquivo As String, oPic As PictureBox, Optional bImagemSistema As Boolean = True)
    If Trim(sArquivo) <> "" Then
      If InStr(sArquivo, "\") = 0 Then
        If bImagemSistema And Mid(sArquivo, Len(FNC_Diretorio_Tratar(sPathRepositorioArquivo))) <> FNC_Diretorio_Tratar(sPathRepositorioArquivo) Then
          sArquivo = FNC_Diretorio_Tratar(sPathRepositorioArquivo) & sArquivo
        End If
      End If

      If Dir(sArquivo) = "" Then
        FNC_Mensagem("O arquivo de imagem não existe mais")
      Else
        oPic.ImageLocation = sArquivo
        oPic.Tag = sArquivo
      End If
    End If
  End Sub

  Public Function FNC_ConfiguracaoAplicacao(sCampo As String) As String
    Return SC.ConfigurationSettings.AppSettings(sCampo)
  End Function

  Public Function FNC_Criptografia(Text As String) As String
    Dim strTempChar As String = ""

    For i = 1 To Len(Text)
      If Asc(Mid$(Text, i, 1)) < 128 Then
        strTempChar = Asc(Mid$(Text, i, 1)) + 128
      ElseIf Asc(Mid$(Text, i, 1)) > 128 Then
        strTempChar = Asc(Mid$(Text, i, 1)) - 128
      End If

      Mid$(Text, i, 1) = Chr(strTempChar)
    Next i

    Return Text
  End Function

  Public Function FNC_Arquivo_Dialogo_Salvar(Optional ByVal sExtensao As String = "") As String
    Dim oDialogoSalvar As New SaveFileDialog
    Dim sArquivo As String

    With oDialogoSalvar
      .CheckPathExists = True
      .Filter = sExtensao
      .ShowDialog()
      sArquivo = .FileName
      .Dispose()
    End With

    Return sArquivo
  End Function

  Public Function FNC_Image_Para_ImageDB(oImage As Image) As Object
    Dim oMS As New IO.MemoryStream

    Try
      oImage.Save(oMS, System.Drawing.Imaging.ImageFormat.Jpeg)

      Dim byteArray = oMS.ToArray

      Return byteArray
    Catch ex As Exception
      Return Nothing
    End Try
  End Function

  Public Function FNC_Imagem_Para_Image(sPathImagem As String) As Byte()
    Try
      Dim fsFoto As FileStream = New FileStream(sPathImagem, FileMode.Open)
      Dim fiFoto As FileInfo = New FileInfo(sPathImagem)
      Dim Temp As Long = fiFoto.Length
      Dim lung As Long = Convert.ToInt32(Temp)
      Dim picture(lung) As Byte

      fsFoto.Read(picture, 0, lung)
      fsFoto.Close()

      Return picture
    Catch ex As Exception
      MessageBox.Show(ex.Message)
      Return Nothing
    End Try
  End Function

  Public Function FNC_Imagem_Redimensionar(ByVal sourceImage As System.Drawing.Image, ByVal size As System.Drawing.Size) As System.Drawing.Image
    Dim resizedImageHeight, resizedImageWidth As Decimal, sourceImageHeight As Decimal = sourceImage.Height, sourceImageWidth As Decimal = sourceImage.Width

    If sourceImageHeight > sourceImageWidth Then

      If sourceImageHeight > size.Height Then
        resizedImageHeight = size.Height
      Else
        resizedImageHeight = sourceImageHeight
      End If

      resizedImageWidth = (resizedImageHeight / sourceImageHeight) * sourceImageWidth
    Else

      If sourceImageWidth > size.Width Then
        resizedImageWidth = size.Width
      Else
        resizedImageWidth = sourceImageWidth
      End If

      resizedImageHeight = (resizedImageWidth / sourceImageWidth) * sourceImageHeight
    End If

    Dim resizedImage As System.Drawing.Image = sourceImage.GetThumbnailImage(Convert.ToInt32(resizedImageWidth), Convert.ToInt32(resizedImageHeight), Nothing, IntPtr.Zero)
    Return resizedImage
  End Function

  Public Function FNC_CarregarFoto(oPicFoto As PictureBox) As String
    Dim sArquivo As String

    sArquivo = FNC_Arquivo_Dialogo_Abrir(enTipoArquivo.eImagem)

    If Trim(sArquivo) <> "" Then oPicFoto.ImageLocation = sArquivo

    Return sArquivo
  End Function

  Public Function FNC_Arquivo_Local_Temporario(sNome As String) As String
    Dim sArquivo As String

    sArquivo = FNC_Diretorio_Tratar(FNC_Diretorio_Temporario()) & sNome

    If System.IO.File.Exists(sArquivo) Then
      System.IO.File.Delete(sArquivo)
    End If

    Return sArquivo
  End Function

  Public Function FNC_Arquivo_Dialogo_Abrir(Optional TipoArquivo As enTipoArquivo = enTipoArquivo.eTodos) As String
    Dim oDialogoAbrir As New OpenFileDialog
    Dim sArquivo As String = ""

    Select Case TipoArquivo
      Case enTipoArquivo.eImagem
        oDialogoAbrir.Title = "Inserir Imagem"
        oDialogoAbrir.Filter = "Bitmap|*.bmp|JPEG|*.jpg|GIF|*.gif|PNG|*.png|Várias imagens(Bitmap,JPEG,GIF,PNG)|*.png;*.bmp;*.jpg;*.gif;*.png"
        oDialogoAbrir.FilterIndex = 5
      Case enTipoArquivo.eXML
        oDialogoAbrir.Title = "Carregar arquivo XML"
        oDialogoAbrir.DefaultExt = "xml"
        oDialogoAbrir.Filter = "XML|*.xml"
    End Select

    oDialogoAbrir.InitialDirectory = sPathSistema
    oDialogoAbrir.ShowDialog()

    If oDialogoAbrir.FileName <> "" Then
      Try
        sArquivo = oDialogoAbrir.FileName
      Catch ex As Exception
      End Try
    End If

    Return sArquivo
  End Function

  Public Function FNC_Pasta_Dialogo_Abrir() As String
    Dim oDialogoAbrir As New FolderBrowserDialog
    Dim sPasta As String = ""

    oDialogoAbrir.Description = "Inserir Imagem"
    oDialogoAbrir.ShowDialog()

    If oDialogoAbrir.SelectedPath <> "" Then
      Try
        sPasta = oDialogoAbrir.SelectedPath
      Catch ex As Exception
      End Try
    End If

    Return sPasta
  End Function

  Public Function FNC_DiretorioSistema_Existe(sArquivo As String) As Boolean
    If Mid(sArquivo, 1, Len(sPathRepositorioArquivo)) = sPathRepositorioArquivo Then
      Return Dir(Mid(sArquivo, 1, Len(sPathRepositorioArquivo)) = sPathRepositorioArquivo) <> ""
    Else
      Return False
    End If
  End Function

  Public Function FNC_DiretorioSistema_NovoArquivo(sExtensao As String) As String
    Return FNC_Diretorio_Tratar(sPathRepositorioArquivo) & Now.Year.ToString() &
                                                           FNC_StrZero(Now.Month.ToString(), 2) &
                                                           FNC_StrZero(Now.Day.ToString(), 2) & "-" &
                                                           Guid.NewGuid.ToString & sExtensao
  End Function

  Public Function FNC_DiretorioSistema_GuardarArquivo(sArquivo As String) As Object
    Dim iCont As Integer
    Dim sExtensao As String = ""
    Dim sNovoArquivo As String

    If Mid(sArquivo, 1, Len(sPathRepositorioArquivo)) = sPathRepositorioArquivo Then
      Return sArquivo
    Else
      If Dir(FNC_DiretorioSistema_AdicionarPath(sArquivo)) <> "" Then
        Return Dir(FNC_DiretorioSistema_AdicionarPath(sArquivo))
      Else
        For iCont = Len(sArquivo) To 1 Step -1
          If Mid(sArquivo, iCont, 1) = "." Then
            sExtensao = Mid(sArquivo, iCont)
            Exit For
          End If
        Next

        sNovoArquivo = FNC_DiretorioSistema_NovoArquivo(sExtensao)

        FileCopy(sArquivo, sNovoArquivo)

        Return sNovoArquivo
      End If
    End If
  End Function

  Public Sub FNC_DiretorioSistema_BaixarArquivo(sArquivo As String, Optional sNome As String = "", Optional ExibirMensagemSucesso As Boolean = True)
    Dim iCont As Integer
    Dim sExtensao As String = ""

    If Dir(FNC_DiretorioSistema_AdicionarPath(sArquivo)) = "" Then
      FNC_Mensagem("Arquivo não encontrado")
    Else
      sArquivo = FNC_DiretorioSistema_AdicionarPath(sArquivo)

      If sNome = "" Then
        For iCont = Len(sArquivo) To 1 Step -1
          If Mid(sArquivo, iCont, 1) = "." Then
            sExtensao = Mid(sArquivo, iCont)
            Exit For
          End If
        Next

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Arquivo (*" & sExtensao & ")|*" & sExtensao
        saveFileDialog1.FilterIndex = 1
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
          sNome = saveFileDialog1.FileName
        End If
      End If

      If sNome <> "" Then
        Try
          FileCopy(sArquivo, sNome)

          If ExibirMensagemSucesso Then FNC_Mensagem("Arquivo baixado")
        Catch ex As Exception
          FNC_Mensagem(ex.Message)
        End Try
      End If
    End If
  End Sub

  Public Function FNC_DiretorioSistema_RemoverPath(sArquivo As String) As String
    If Trim(sArquivo) = "" Or sArquivo Is Nothing Then
      Return sArquivo
    Else
      If Mid(sArquivo, 1, Len(sPathRepositorioArquivo)) = sPathRepositorioArquivo Then
        Return Mid(sArquivo, Len(FNC_Diretorio_Tratar(sPathRepositorioArquivo)) + 1)
      Else
        Return sArquivo
      End If
    End If
  End Function

  Public Function FNC_DiretorioSistema_AdicionarPath(sArquivo As String) As String
    If Trim(sArquivo) = "" Or sPathRepositorioArquivo = "" Then
      Return ""
    Else
      If Mid(sArquivo, Len(sPathRepositorioArquivo)) = sPathRepositorioArquivo Then
        Return sArquivo
      Else
        Return FNC_Diretorio_Tratar(sPathRepositorioArquivo) & sArquivo
      End If
    End If
  End Function

  Public Function FNC_PictureBox_GuardarArquivo(oPic As PictureBox, Optional bGravarBanco As Boolean = True) As Object
    If FNC_NVL(oPic.ImageLocation, "") = "" Or oPic.Image Is Nothing Then
      Return Nothing
    Else
      If Trim(FNC_NVL(oPic.Tag, "")) = "" Then
        oPic.Tag = FNC_DiretorioSistema_GuardarArquivo(oPic.ImageLocation)
      Else
        If Dir(oPic.Tag) <> "" And oPic.ImageLocation <> oPic.Tag Then Kill(oPic.Tag)

        If oPic.ImageLocation <> oPic.Tag Then FileCopy(oPic.ImageLocation, oPic.Tag)
      End If

      If bGravarBanco Then
        Return FNC_DiretorioSistema_RemoverPath(oPic.Tag)
      Else
        Return oPic.Tag
      End If
    End If
  End Function

  Public Sub FNC_AbriTela(ByRef oForm As Form,
                          Optional ByVal NovaInstancia As Boolean = False,
                          Optional bModal As Boolean = False,
                          Optional ByVal bCentralizado As Boolean = False,
                          Optional ByVal ValidarTipoTela As Boolean = False,
                          Optional iTipoTela As Integer = -1)
    If Not oFormMDI Is Nothing And Not bModal Then
      If NovaInstancia = False Then
        Dim oFormAchado As Form
        Dim bExiste As Boolean

        If ValidarTipoTela Then
          bExiste = FNC_Form_Existe(oFormMDI, oForm.Name, True, iTipoTela, oFormAchado)
        Else
          bExiste = FNC_Form_Existe(oFormMDI, oForm.Name, , , oFormAchado)
        End If

        If bExiste Then
          If Not oFormAchado Is Nothing Then oForm = oFormAchado
          Exit Sub
        End If
      End If
    End If

    oForm.Tag = iTipoTela

    If Not oFormMDI Is Nothing And Not bModal Then
      oForm.MdiParent = oFormMDI
    End If

    FNC_Form_IdentificarControles(oForm)
    'FNC_Form_Cor(oForm)

    If bCentralizado Then
      oForm.StartPosition = FormStartPosition.CenterScreen
    End If

    If bModal Then
      oForm.ShowDialog()
    Else
      oForm.Show()
    End If

    oForm.BringToFront()

    If oForm.KeyPreview Then
      AddHandler oForm.KeyDown, AddressOf FNC_Form_KeyDown
    End If

    If Not oFormMDI Is Nothing Then
      oFormMDI.LayoutMdi(MdiLayout.Cascade)
    End If
  End Sub

  Private Sub FNC_Form_KeyDown(sender As Object, e As KeyEventArgs)

  End Sub

  Public Sub FNC_Form_IdentificarControles(ByVal oForm As Form)
    'Dim iCont As Integer

    ''Identifica os controles do form
    'FNC_Form_Container_IdentificarControles(oForm.Controls)

    'For iCont = 0 To oForm.Controls.Count - 1
    '  'Identifica os controles container do form 
    '  If oForm.Controls(iCont).Controls.Count > 0 Then
    '    FNC_Form_Container_IdentificarControles(oForm.Controls(iCont).Controls)
    '  End If
    'Next

    'If oForm.Controls.Count > 0 Then
    '  If oForm.Controls(0).Controls.Count > 0 Then
    '    If oForm.Controls(0).Controls(0).Controls.Count > 0 Then
    '      FNC_Form_Container_IdentificarControles(oForm.Controls(0).Controls(0).Controls)
    '    End If
    '  End If
    'End If
  End Sub

  Public Sub FNC_Form_HabilitarControles(ByVal oControles As Control.ControlCollection, bHabilitar As Boolean)
    Dim iCont As Integer

    For iCont = 0 To oControles.Count - 1
      Try
        oControles(iCont).Enabled = bHabilitar
      Catch ex As Exception
      End Try
    Next
  End Sub

  Private Function FNC_Form_Existe(ByVal oFormMDI As Form, ByVal sForm As String,
                                   Optional ByVal ValidarTipoTela As Boolean = False,
                                   Optional ByVal iTipo As Integer = -1,
                                   Optional ByRef oForm As Form = Nothing) As Boolean
    Dim iCont As Integer
    Dim bOk As Boolean = False

    For iCont = 0 To UBound(oFormMDI.MdiChildren)
      If UCase(oFormMDI.MdiChildren(iCont).Name) = UCase(sForm) Then
        oForm = oFormMDI.MdiChildren(iCont)

        If ValidarTipoTela Then
          If oFormMDI.MdiChildren(iCont).Tag = iTipo Then
            oFormMDI.MdiChildren(iCont).BringToFront()

            bOk = True
            Exit For
          End If
        Else
          oFormMDI.MdiChildren(iCont).BringToFront()

          bOk = True
          Exit For
        End If
      End If
    Next

    Return bOk
  End Function

  Public Sub FNC_Form_FecharTodos(ByVal oFormMDI As Form)
    Dim iCont As Integer
    Dim bOk As Boolean = False
    Dim oForm As Form

    If oFormMDI.MdiChildren.Count > 0 Then
      For iCont = 0 To UBound(oFormMDI.MdiChildren)
        oForm = oFormMDI.MdiChildren(iCont)
        oForm.Close()
        oForm.Dispose()
      Next
    End If
  End Sub

  Public Function FNC_TratarErro(Optional ByVal sErro As String = "",
                                 Optional ByVal bExibirErro As Boolean = True,
                                 Optional ByVal LocalErro As String = "",
                                 Optional ByVal ErroComplemento As String = "") As String
    Dim Msg As String

    DBUsarTransacao = False

    Msg = Err.Description

    If Trim(sErro) <> "" And Trim(sErro) <> Trim(Msg) Then Msg = Msg & vbCrLf & sErro

    If bExibirErro And Trim(Msg) <> "" Then
      FNC_Mensagem(Msg)
    End If

    Try
      If Trim(Msg) <> "" Then
        'EnvioEmail("ERRO - " & Application.ProductName, _
        '           "Máquina Logada: " & My.Computer.Name & vbCrLf & _
        '           "Usuário Logado: " & sAcesso_UsuarioLogado & " - " & sAcesso_NomeUsuarioLogado & vbCrLf & _
        '           "Data/Hora do Erro: " & Now.ToString & vbCrLf & _
        '           "Data da Versão do Sistema: " & FileDateTime(Application.ExecutablePath).ToString & vbCrLf & _
        '           "Origem do Erro: " & NVL(Err.Source, "Não identificado") & vbCrLf & _
        '           "Form do Erro: " & Form_Ativo() & vbCrLf & _
        '           "Local do Erro: " & LocalErro & vbCrLf & vbCrLf & _
        '            Msg & _
        '           IIf(Trim(ErroComplemento) = "", "", _
        '               vbCrLf & "<<< COMPLEMENTO DO ERRO >>>" & _
        '               vbCrLf & ErroComplemento), _
        '           Nothing, _
        '           New String() {sEMail_SuporteTecnico})
      End If
    Catch ex As Exception
    End Try

    Return Msg
  End Function

  Public Function FNC_Check_Aspas(ByVal texto As String) As String
    Dim cont As Integer
    Dim retorno As String = ""

    cont = 1

    Do Until cont > Len(texto)
      If Mid(texto, cont, 1) = "'" Then
        retorno = retorno & "''"
      Else
        retorno = retorno & Mid(texto, cont, 1)
      End If
      cont = cont + 1
    Loop

    Return retorno
  End Function

  Public Function FNC_AspasDupla(sTexto As String) As String
    If sTexto.Trim() = "" Then
      Return ""
    Else
      Return Chr(34) + sTexto + Chr(34)
    End If
  End Function

  Public Function FNC_QuotedStr(ByVal vValor As Object) As String
    Return "'" & FNC_Check_Aspas(vValor) & "'"
  End Function

  Public Function FNC_SoNumero(ByVal sValor As String) As String
    Dim iCont As Integer
    Dim sAux As String = ""

    For iCont = 1 To Len(sValor)
      If IsNumeric(Mid(sValor, iCont, 1)) Then
        sAux = sAux & Mid(sValor, iCont, 1)
      End If
    Next

    Return sAux
  End Function

  Public Function FNC_Endereco_TratarNumero(Valor As Object) As String
    If FNC_CampoNulo(Valor) Then
      Return "S/N"
    Else
      If (Valor.ToString().Trim().ToUpper() = "SN") Then
        Return "S/N"
      Else
        Return Valor.ToString().Trim()
      End If
    End If
  End Function

  Public Function FNC_Configuracao_DePara(sString As String, sValor As String) As Object
    Dim oConfiguracao() As String = sString.Split(";")
    Dim iCont As Integer
    Dim sRet As String = ""

    sValor = sValor.Trim()

    If sValor.Trim() = "" Then
      sRet = ""
    Else
      Try
        For iCont = 0 To oConfiguracao.Length - 1 Step 2
          If oConfiguracao(iCont) = sValor Then
            sRet = oConfiguracao(iCont + 1).Trim()
            Exit For
          End If
        Next
      Catch ex As Exception
        sRet = ""
      End Try
    End If

    Return sRet
  End Function

  Public Function FNC_NuloSe(ByVal oValor As Object, ByVal oValorSe As Object) As Object
    Try
      If oValor = oValorSe Then
        Return Nothing
      Else
        Return oValor
      End If
    Catch ex As Exception
      Return oValor
    End Try
  End Function

  Public Function FNC_SQL_FormatarLike(ByVal sCampo As String) As String
    Do While True
      If InStr(sCampo, " ") > 0 Then
        sCampo = Left(sCampo, InStr(sCampo, " ") - 1) & "%" &
                     Mid(sCampo, InStr(sCampo, " ") + 1)
      Else
        Exit Do
      End If
    Loop

    Return FNC_QuotedStr("%" & Replace(UCase(sCampo), "'", "''") & "%") & " COLLATE Latin1_General_CI_AI"
  End Function

  Public Sub FNC_Str_Adicionar(ByRef vVariavel As String, ByVal sValor As String, ByVal sSeparador As Object)
    If Trim(sValor) <> "" Then
      If Trim(vVariavel) <> "" Then vVariavel = vVariavel & sSeparador
      vVariavel = vVariavel & sValor
    End If
  End Sub

  Public Function FNC_CampoNulo(ByVal oValor As Object) As Boolean
    Try
      If oValor Is Nothing Then
        Return True
      ElseIf oValor Is System.DBNull.Value Then
        Return True
      ElseIf oValor = Nothing Then
        Return True
      Else
        Return False
      End If
    Catch ex As Exception
      Return False
    End Try
  End Function

  'Public Function FNC_CampoVazio(oCampo As Object, sMensagem As String) As Boolean
  '  Dim bCampoVazio As Boolean

  '  If TypeOf oCampo Is System.Windows.Forms.ComboBox Then
  '    bCampoVazio = Not ComboBox_Selecionado(oCampo)
  '  End If

  '  If bCampoVazio Then
  '    FNC_Mensagem(sMensagem)
  '  End If

  '  Return bCampoVazio
  'End Function

  Public Function FNC_ConvValorFormatoAmericano(ByVal Valor As String) As String
    Dim iCont As Integer
    Dim sAux As String
    Dim sRet As String = ""

    sAux = Valor.ToString

    If InStr(sAux, ",") = 0 Then
      sAux = Replace(sAux, ".", ",")
    End If

    For iCont = 1 To Len(Trim(sAux))
      If IsNumeric(Mid(Trim(sAux), iCont, 1)) Or
         Mid(Trim(sAux), iCont, 1) = "-" Or
         Mid(Trim(sAux), iCont, 1) = "." Or
         Mid(Trim(sAux), iCont, 1) = "," Then
        If Mid(Trim(sAux), iCont, 1) = "," Then
          sRet = sRet & "."
        ElseIf Mid(Trim(sAux), iCont, 1) = "." Then
          sRet = sRet
        Else
          sRet = sRet & Mid(Trim(sAux), iCont, 1)
        End If
      End If
    Next

    If Trim(sRet) = "" Then sRet = "0"

    Return sRet
  End Function

  Public Function FNC_NVL(ByVal Valor1 As Object, ByVal Valor2 As Object) As Object
    If FNC_CampoNulo(Valor1) Then
      Return Valor2
    Else
      Return Valor1
    End If
  End Function

  Public Function FNC_Data_ProximaHora(ByVal dData As Date, ByVal sHora As String) As Date
    If CDate(Microsoft.VisualBasic.Format(dData, "dd/MM/yyyy") + " " + sHora) < Now Then
      Return DateAdd(DateInterval.Day, 1, CDate(Microsoft.VisualBasic.Format(dData, "dd/MM/yyyy") + " " + sHora))
    Else
      Return CDate(Microsoft.VisualBasic.Format(dData, "dd/MM/yyyy") + " " + sHora)
    End If
  End Function

  Public Function FNC_Data_HoraValida(dData As Date) As Boolean
    Dim bOk As Boolean = False

    If Not (dData.Year <= 1753) Then
      bOk = True
    End If

    Return bOk
  End Function

  Public Function FNC_Data_HoraValida(sHora As String) As Boolean
    Dim bOk As Boolean = True

    Try
      If InStr(sHora, ":") = 0 Then
        bOk = False
      Else
        If IsNumeric(Replace(sHora, ":", "")) Then
          If Val(Mid(sHora, 1, InStr(sHora, ":") - 1)) < 0 Or Val(Mid(sHora, 1, InStr(sHora, ":") - 1)) > 23 Then
            bOk = False
          Else
            If Val(Mid(sHora, InStr(sHora, ":") + 1)) < 0 Or Val(Mid(sHora, InStr(sHora, ":") + 1)) > 59 Then
              bOk = False
            End If
          End If
        Else
          bOk = False
        End If
      End If
    Catch ex As Exception
      bOk = False
    End Try

    Return bOk
  End Function

  Public Function FNC_Hora_HHMM(dData As Date) As Date
    Return New Date(dData.Year, dData.Month, dData.Day, dData.Hour, dData.Minute, 0)
  End Function

  Public Function FNC_Hora(sHora As String, Optional dData As Date = Nothing) As Date
    Dim dDataRet As Date

    If dData = Nothing Then
      dData = Now
    End If

    Try
      dDataRet = New Date(dData.Year, dData.Month, dData.Day, Mid(sHora, 1, InStr(sHora, ":") - 1), Mid(sHora, InStr(sHora, ":") + 1), 0)
    Catch ex As Exception
    End Try

    Return dDataRet
  End Function

  Public Function FNC_Data_AdicionarHora(ByVal dData As Date, ByVal sHora As String) As Date
    If Len(sHora) = 2 Then
      sHora = sHora & ":00:00"
    ElseIf Len(sHora) = 5 Then
      sHora = sHora & ":00"
    Else
      sHora = sHora & "00:00:00"
    End If

    Return New Date(dData.Year, dData.Month, dData.Day, Mid(sHora, 1, 2), Mid(sHora, 4, 2), Mid(sHora, 7, 2))
  End Function

  Public Function FNC_Date_TratarBancoDados(ByVal Data As String) As Date
    Dim iPonteiro As Integer
    Dim iMes As Integer
    Dim sMes As String
    Dim iDia As Integer
    Dim Hora As String = ""
    Dim iAno As Integer
    Dim iHora As Integer
    Dim iMinuto As Integer
    Dim iSegundo As Integer

    If Trim(Data) = "" Then
      Return Nothing
      Exit Function
    End If

    'Formatação data e hora
    If Len(Data) > 10 Then
      'Separacao hora
      iHora = CDate(Data).Hour
      iMinuto = CDate(Data).Minute
      iSegundo = CDate(Data).Second

      Hora = FNC_StrZero(CDate(Data).Hour, 2) & ":" &
             FNC_StrZero(CDate(Data).Minute, 2) & ":" &
             FNC_StrZero(CDate(Data).Second, 2)
    End If

    'Separacao data
    iPonteiro = InStr(Data, "/") + 1

    iDia = Left(Data, iPonteiro - 2)

    iMes = Val(Mid(Data, iPonteiro, InStr(iPonteiro, Data, "/") - iPonteiro))

    sMes = Choose(iMes, "JAN", "FEB", "MAR", "APR", "MAY", "JUN",
                        "JUL", "AUG", "SEP", "OCT", "NOV", "DEC")

    iPonteiro = InStr(iPonteiro, Data, "/")

    iAno = Mid(Data, iPonteiro + 1, 4)

    If Trim(Hora) = "" Then
      Return New Date(iAno, iMes, iDia)
    Else
      Return New Date(iAno, iMes, iDia, iHora, iMinuto, iSegundo)
    End If
  End Function

  Public Function FNC_Data_TratarAAAAMMDD(ByVal sData As String) As DateTime
    '2016-08-24T11:18:00-03:00
    '123456789012345678901234

    If Trim(sData) = "" Then
      Return Nothing
    Else
      If Not IsDate(sData) Then
        Return Nothing
      Else
        If Trim(Mid(sData, 12, 2)) = "" Then
          Return New Date(Mid(sData, 1, 4), Mid(sData, 6, 2), Mid(sData, 9, 2))
        Else
          Return New Date(Mid(sData, 1, 4), Mid(sData, 6, 2), Mid(sData, 9, 2), Mid(sData, 12, 2), Mid(sData, 15, 2), Mid(sData, 18, 2))
        End If
      End If
    End If
  End Function

  Public Function FNC_StrZero(ByVal Numero As Long, ByVal Tamanho As Long) As String
    Dim x As String
    If Numero = Nothing Then
      Return FNC_StrReplicate(Tamanho, "0")
    Else
      x = Microsoft.VisualBasic.Format(Numero, FNC_StrReplicate(Tamanho, "0"))
      Return FNC_StrReplicate(Tamanho - Len(x), "0") & x
    End If
  End Function

  Public Function FNC_StrReplicate(ByVal Numero As Integer, ByVal Caracter As String) As String
    Dim iCont As Integer
    Dim sAux As String = ""

    For iCont = 1 To Numero
      sAux = sAux & Caracter
    Next

    Return Microsoft.VisualBasic.Left(sAux, Numero * Len(Caracter))
  End Function

  Public Function FNC_Hora_Extenso(dData As Date, bSegundos As Boolean) As String
    Dim sRet As String


    sRet = dData.Hour.ToString & " hora" & IIf(dData.Hour = 1, "", "s") & " e " &
           dData.Minute.ToString & " minuto" & IIf(dData.Minute = 1, "", "s")

    If bSegundos Then
      sRet = sRet & " e " & dData.Second.ToString & " segundo" & IIf(dData.Second = 1, "", "s")
    End If

    Return sRet
  End Function

  Public Function FNC_Data_Extenso(dData As Date, Optional eIncluirHora As enFormatoHora = enFormatoHora.SemHoras) As String
    Dim sRet As String

    sRet = dData.Day.ToString & " de " &
           Choose(dData.Month.ToString, "janeiro", "fevereiro", "março", "abril", "maio", "junho",
                                        "julho", "agosto", "setembro", "outubro", "novembro", "dezembro") & " de " &
           dData.Year.ToString

    Select Case eIncluirHora
      Case enFormatoHora.HHMM
        sRet = sRet & " às " & FNC_StrZero(dData.Hour, 2) & ":" & FNC_StrZero(dData.Minute, 2)
      Case enFormatoHora.HHMM_Extenso
        sRet = sRet & " às " & FNC_Hora_Extenso(dData, False)
      Case enFormatoHora.HHMMSS
        sRet = sRet & " às " & FNC_StrZero(dData.Hour, 2) & ":" & FNC_StrZero(dData.Minute, 2) & ":" & FNC_StrZero(dData.Second, 2)
      Case enFormatoHora.HHMMSS_Extenso
        sRet = sRet & " às " & FNC_Hora_Extenso(dData, True)
    End Select

    Return sRet
  End Function

  Public Function FNC_DateDiff_Extenso(dDataInicial As Date, dDataFinal As Date) As String
    Dim iAno As Integer = 0
    Dim iMes As Integer = 0
    Dim iDia As Integer = 0
    Dim sRet As String

    If dDataInicial.AddMonths(DateDiff(DateInterval.Month, dDataInicial.Date, dDataFinal.Date)) > dDataFinal Then
      dDataFinal = dDataInicial.AddMonths(DateDiff(DateInterval.Month, dDataInicial.Date, dDataFinal.Date)).AddMonths(-1)
    Else
      If dDataFinal.Month = 2 And dDataInicial.Day > 28 Then
        dDataFinal = New Date(dDataFinal.Year, dDataFinal.Month, 1).AddMonths(1).AddDays(-1)
      Else
        dDataFinal = New Date(dDataFinal.Year, dDataFinal.Month, dDataInicial.Day)
      End If
    End If

    iMes = DateDiff(DateInterval.Month, dDataInicial.Date, dDataFinal.Date)
    If dDataInicial.Month = dDataFinal.Month And dDataInicial.Day > dDataFinal.Day Then
      iMes = iMes - 1
    End If
    iAno = Int(iMes / 12)
    iMes = iMes - (iAno * 12)

    iDia = DateDiff(DateInterval.Day, dDataFinal, Now.Date)

    sRet = IIf(iAno = 0, "", iAno.ToString + IIf(iAno = 1, " ano", " anos"))
    FNC_Str_Adicionar(sRet, IIf(iMes = 0, "", iMes.ToString + IIf(iMes = 1, " mês", " meses")), IIf(iDia = 0, " e ", ", "))
    FNC_Str_Adicionar(sRet, IIf(iDia = 0, "", iDia.ToString + IIf(iDia = 1, " dia", " dias")), " e ")

    Return sRet
  End Function

  Public Sub FNC_Array_Add(ByRef oArray() As String,
                           ByVal Valor As Object,
                           Optional ByVal Distinto As Boolean = False)
    Dim iCont As Integer
    Dim bExiste As Boolean = False

    If Distinto And Not oArray Is Nothing Then
      For iCont = LBound(oArray) To UBound(oArray)
        If oArray(iCont) = Valor Then
          bExiste = True
          Exit For
        End If
      Next
    End If

    If Not bExiste Then
      If oArray Is Nothing Then
        ReDim oArray(0)
      Else
        ReDim Preserve oArray(UBound(oArray) + 1)
      End If

      oArray(UBound(oArray)) = Valor
    End If
  End Sub

  Public Function FNC_Array_Para_Lista(ByRef oArray() As String,
                                       Optional ByVal sSeparador As String = ",",
                                       Optional ByVal bQuotedStr As Boolean = False) As String
    Dim iCont As Integer
    Dim sAux As String = ""

    If FNC_Array_Preenchido(oArray) Then
      For iCont = LBound(oArray) To UBound(oArray)
        If bQuotedStr Then
          FNC_Str_Adicionar(sAux, FNC_QuotedStr(oArray(iCont)), sSeparador)
        Else
          FNC_Str_Adicionar(sAux, oArray(iCont), sSeparador)
        End If
      Next

      Return sAux
    Else
      Return ""
    End If
  End Function

  Public Sub FNC_Array_Mesclar(ByVal oArray_Origem() As String,
                               ByRef oArray_Destino() As String,
                               Optional ByVal Distinto As Boolean = False)
    Dim iCont_01 As Integer
    Dim iCont_02 As Integer
    Dim bExiste As Boolean = False

    For iCont_01 = LBound(oArray_Origem) To UBound(oArray_Origem)
      bExiste = False

      For iCont_02 = LBound(oArray_Destino) To UBound(oArray_Destino)
        If UCase(oArray_Origem(iCont_01)) = UCase(oArray_Destino(iCont_02)) Then
          bExiste = True
          Exit For
        End If
      Next

      If Not bExiste Then
        FNC_Array_Add(oArray_Destino, oArray_Origem(iCont_01), Distinto)
      End If
    Next
  End Sub

  Public Sub FNC_ArrayO_Add(ByRef oArray() As Object,
                            ByVal Valor As Object,
                            Optional ByVal Distinto As Boolean = False)
    Dim iCont As Integer
    Dim bExiste As Boolean = False

    If Distinto And Not oArray Is Nothing Then
      For iCont = LBound(oArray) To UBound(oArray)
        If oArray(iCont) = Valor Then
          bExiste = True
          Exit For
        End If
      Next
    End If

    If Not bExiste Then
      If oArray Is Nothing Then
        ReDim oArray(0)
      Else
        ReDim Preserve oArray(UBound(oArray) + 1)
      End If

      oArray(UBound(oArray)) = Valor
    End If
  End Sub

  Public Sub FNC_Array_Distinto(ByRef oArray() As String)
    Dim iCont As Integer
    Dim oArray_Destino() As String = Nothing

    For iCont = LBound(oArray) To UBound(oArray)
      FNC_Array_Add(oArray_Destino, oArray(iCont), True)
    Next

    oArray = oArray_Destino
  End Sub

  Public Function FNC_Array_Preenchido(ByVal Variavel As Object) As Boolean
    If IsArray(Variavel) Then
      Return (LBound(Variavel) >= 0)
    Else
      Return False
    End If
  End Function

  Public Function FNC_Collection_Preenchido(ByVal Variavel As Collection) As Boolean
    If Variavel Is Nothing Then
      Return False
    Else
      Return (Variavel.Count > 0)
    End If
  End Function

  Public Function FNC_Collection_Para_Lista(ByVal Variavel As Collection,
                                            Optional ByVal Separador As String = ",") As String
    Dim iCont As Integer
    Dim sAux As String = ""

    If Variavel Is Nothing Then
      sAux = ""
    Else
      If Variavel.Count = 0 Then
        sAux = ""
      Else
        For iCont = 1 To Variavel.Count
          FNC_Str_Adicionar(sAux, Variavel(iCont), Separador)
        Next
      End If
    End If

    Return sAux
  End Function

  Public Function FNC_Diretorio_Selecionar() As String
    Dim oFolderBrowserDialog As New FolderBrowserDialog
    Dim sDiretorio As String = ""

    oFolderBrowserDialog.Description = "Selecione um diretório"
    oFolderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer
    oFolderBrowserDialog.ShowNewFolderButton = True

    If oFolderBrowserDialog.ShowDialog = DialogResult.OK Then
      sDiretorio = oFolderBrowserDialog.SelectedPath
    End If

    Return sDiretorio
  End Function

  Public Function FNC_Diretorio_Existe(sPath As String) As Boolean
    Return True
  End Function

  Public Function FNC_Diretorio_Tratar(sPath As String) As String
    If Right(Trim(sPath), 1) <> "\" Then
      Return Trim(sPath) & "\"
    Else
      Return Trim(sPath)
    End If
  End Function

  Public Function FNC_Diretorio_Temporario(Optional sSubPasta As String = "") As String
    Dim sDir As String

    'sDir = FNC_Diretorio_Tratar(Path.GetTempPath())
    sDir = FNC_Diretorio_Tratar(sPathSistema) & "Temp"

    If Not System.IO.Directory.Exists(sDir) Then
      System.IO.Directory.CreateDirectory(sDir)
    End If

    If sSubPasta.Trim() <> "" Then
      sDir = FNC_Diretorio_Tratar(sDir) + sSubPasta

      If Not System.IO.Directory.Exists(sDir) Then
        System.IO.Directory.CreateDirectory(sDir)
      End If
    End If

    Return FNC_Diretorio_Tratar(sDir)
  End Function


  Public Function FNC_Path_Arquivo(sArquivo As String) As String
    Dim iCont As Integer
    Dim sRet As String = ""

    For iCont = Len(sArquivo) To 1 Step -1
      If Mid(sArquivo, iCont, 1) = "\" Then
        sRet = Mid(sArquivo, 1, iCont - 1)
        Exit For
      End If
    Next

    Return sRet
  End Function

  Public Function FNC_Imagem_Minuatura(sArquivoImagem As String, Optional iLargura As Integer = 50, Optional iAltura As Integer = 50) As Image
    Try
      Dim Miniatura As Image

      Dim Imagem As New Bitmap(sArquivoImagem)
      Miniatura = Imagem.GetThumbnailImage(iLargura, iAltura, Nothing, Nothing)

      Return Miniatura
    Catch ex As Exception
      FNC_Mensagem(ex.Message)

      Return Nothing
    End Try
  End Function

  Public Function FNC_Arquivo_Tipo(ByVal sExtensao As String) As String
    Dim sArquivo_Tipo As String
    Dim sTipoExtensao As String

    sTipoExtensao = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\" & sExtensao, "", "ExtensionNotFound")

    Try
      sArquivo_Tipo = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\" & sTipoExtensao, "", "ExtensionNotFound")
    Catch ex As Exception
      sArquivo_Tipo = sTipoExtensao
    End Try

    Return sArquivo_Tipo
  End Function

  Public Function FNC_FontToString(oFont As Font) As String
    Dim sRet As String

    sRet = oFont.ToString

    '[Font: Name=Comic Sans MS, Size=8,25, Units=3, GdiCharSet=0, GdiVerticalFont=False]

    sRet = Replace(sRet, "]", ", Bold=" & oFont.Bold.ToString & "]")
    sRet = Replace(sRet, "]", ", Underline=" & oFont.Underline.ToString & "]")
    sRet = Replace(sRet, "]", ", Italic=" & oFont.Italic.ToString & "]")
    sRet = Replace(sRet, "]", ", Strikeout=" & oFont.Strikeout.ToString & "]")

    Return sRet
  End Function

  Public Function FNC_Fonte(Optional oFont As Font = Nothing,
                            Optional FontSize As Single = 10,
                            Optional bBold As Boolean = False,
                            Optional bUnderline As Boolean = False,
                            Optional bItalic As Boolean = False,
                            Optional bStrikeout As Boolean = False) As Font
    Dim FontStyle As FontStyle = Drawing.FontStyle.Regular
    Dim FontUnit As GraphicsUnit = GraphicsUnit.Point

    If Not oFont Is Nothing Then
      FontStyle = oFont.Style
      FontSize = oFont.Size
      FontUnit = oFont.Unit
    End If
    If FontSize = 0 Then FontSize = 10

    If bBold Then FontStyle = FontStyle + Drawing.FontStyle.Bold
    If bUnderline Then FontStyle = FontStyle + Drawing.FontStyle.Underline
    If bItalic Then FontStyle = FontStyle + Drawing.FontStyle.Italic
    If bStrikeout Then FontStyle = FontStyle + Drawing.FontStyle.Strikeout

    If oFont Is Nothing Then
      oFont = New Font("Arial", FontSize, FontStyle, FontUnit)
    Else
      oFont = New Font(oFont.Name, FontSize, FontStyle, FontUnit)
    End If

    Return oFont
  End Function

  Public Function FNC_StringToFont(ByVal sFont As String) As Font
    sFont = sFont.Substring(1, sFont.Length - 2)
    sFont = Replace(sFont, "Font:", vbNullString)

    Dim sElement() As String = Split(sFont, ", ")
    Dim sSingle() As String
    Dim sValue As String
    Dim FontName As String = ""
    Dim FontSize As Single
    Dim FontStyle As FontStyle = Drawing.FontStyle.Regular
    Dim FontUnit As GraphicsUnit = GraphicsUnit.Point
    Dim gdiCharSet As Byte
    Dim gdiVerticalFont As Boolean
    Dim bBold As Boolean
    Dim bUnderline As Boolean
    Dim bItalic As Boolean
    Dim bStrikeout As Boolean

    For Each sValue In sElement
      sValue = Trim(sValue)
      sSingle = Split(sValue, "=")
      If sSingle.GetUpperBound(0) > 0 Then
        If sSingle(0) = "Name" Then
          FontName = sSingle(1)
        ElseIf sSingle(0) = "Size" Then
          FontSize = CSng(sSingle(1))
        ElseIf sSingle(0) = "Units" Then
          FontUnit = CInt(sSingle(1))
        ElseIf sSingle(0) = "GdiCharSet" Then
          gdiCharSet = CByte(sSingle(1))
        ElseIf sSingle(0) = "GdiVerticalFont" Then
          gdiVerticalFont = CBool(sSingle(1))
        ElseIf sSingle(0) = "Bold" Then
          bBold = CBool(sSingle(1))
        ElseIf sSingle(0) = "Underline" Then
          bUnderline = CBool(sSingle(1))
        ElseIf sSingle(0) = "Italic" Then
          bItalic = CBool(sSingle(1))
        ElseIf sSingle(0) = "Strikeout" Then
          bStrikeout = CBool(sSingle(1))
        End If
      End If
    Next

    If bBold Then FontStyle = FontStyle + Drawing.FontStyle.Bold
    If bUnderline Then FontStyle = FontStyle + Drawing.FontStyle.Underline
    If bItalic Then FontStyle = FontStyle + Drawing.FontStyle.Italic
    If bStrikeout Then FontStyle = FontStyle + Drawing.FontStyle.Strikeout

    Return New Font(FontName, FontSize, FontStyle, FontUnit, gdiCharSet, gdiVerticalFont)
  End Function

  Public Function FNC_Criptografar(sTexto As String) As String
    Dim chave As New Rfc2898DeriveBytes(const_Sistema_Chave, sal)
    ' criptografa os dados
    Dim algoritmo = New RijndaelManaged()
    Dim textoCifrado As Byte()

    algoritmo.Key = chave.GetBytes(16)
    algoritmo.IV = chave.GetBytes(16)

    Dim fonteBytes() As Byte = New System.Text.UnicodeEncoding().GetBytes(sTexto)

    Using StreamFonte = New MemoryStream(fonteBytes)
      Using StreamDestino As New MemoryStream()
        Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateEncryptor(), CryptoStreamMode.Read)
          moveBytes(crypto, StreamDestino)
          textoCifrado = StreamDestino.ToArray()
        End Using
      End Using
    End Using

    Return +Convert.ToBase64String(textoCifrado)
  End Function

  Private Sub moveBytes(ByVal fonte As Stream, ByVal destino As Stream)
    Dim bytes(2048) As Byte
    Dim contador = fonte.Read(bytes, 0, bytes.Length - 1)
    While (0 <> contador)
      destino.Write(bytes, 0, contador)
      contador = fonte.Read(bytes, 0, bytes.Length - 1)
    End While
  End Sub

  Public Function FNC_Descriptografar(sTexto As String) As String
    Dim textoCifrado As Byte()

    If (sTexto = "") Then
      MessageBox.Show("Os dados não estão criptografados!")
      Return ""
    End If

    textoCifrado = Convert.FromBase64String(sTexto)

    Dim chave As New Rfc2898DeriveBytes(const_Sistema_Chave, sal)
    Dim algoritmo = New RijndaelManaged()

    algoritmo.Key = chave.GetBytes(16)
    algoritmo.IV = chave.GetBytes(16)
    Using StreamFonte = New MemoryStream(textoCifrado)
      Using StreamDestino As New MemoryStream()
        Using crypto As New CryptoStream(StreamFonte, algoritmo.CreateDecryptor(), CryptoStreamMode.Read)
          moveBytes(crypto, StreamDestino)
          Dim bytesDescriptografados() As Byte = StreamDestino.ToArray()
          Dim mensagemDescriptografada = New UnicodeEncoding().GetString(bytesDescriptografados)
          Return mensagemDescriptografada
        End Using
      End Using
    End Using
  End Function

  Public Function FNC_TreeView_BuscaPorChave(oNodes As TreeNodeCollection, sChave As String) As TreeNode
    Dim oNode As TreeNode = Nothing

    If oNodes.IndexOfKey(sChave) > -1 Then
      oNode = oNodes(oNodes.IndexOfKey(sChave))
    Else
      Dim iCont As Integer

      For iCont = 0 To oNodes.Count - 1
        oNode = FNC_TreeView_BuscaPorChave(oNodes(iCont).Nodes, sChave)

        If Not oNode Is Nothing Then
          Exit For
        End If
      Next
    End If

    Return oNode
  End Function

  Public Function FNC_ArquivoINI_Ler(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String
    Const MAX_LENGTH As Integer = 500

    Dim string_builder As New StringBuilder(MAX_LENGTH)

    GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)

    Return string_builder.ToString()
  End Function

  Public Sub FNC_ArquivoINI_Gravar(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal value As String)
    WritePrivateProfileString(section_name, key_name, value, file_name)
  End Sub

  Public Sub FNC_ArquivoINIFromString_Criar(sArquivo As String, sTexto As String)
    If Dir(sArquivo) <> "" Then Kill(sArquivo)

    Using sw As StreamWriter = New StreamWriter(sArquivo, False)
      sw.WriteLine(sTexto)
    End Using
  End Sub

  '    Public Function FNC_MapDrive(ByVal UNCPath As String) As Boolean
  '        Dim nr As NETRESOURCE
  '        Dim strUsername As String
  '        Dim strPassword As String
  '        Dim CONNECT_UPDATE_PROFILE As Int32 = &H1

  '        sGerenciadorArquivo_DriveMap = FNC_DriveLivre()
  '        sGerenciadorArquivo_DriveUnMap = sGerenciadorArquivo_DriveMap

  '        If Trim(sGerenciadorArquivo_DriveMap) = "" Then
  '            Return False
  '        Else
  '            FNC_UnMapDrive()

  '            nr = New NETRESOURCE
  '            nr.lpRemoteName = UNCPath
  '            nr.lpLocalName = sGerenciadorArquivo_DriveMap & ":"
  '            nr.dwScope = 2
  '            nr.dwType = RESOURCETYPE_DISK
  '            nr.dwDisplayType = 3
  '            nr.dwUsage = 1

  '            strUsername = sGerenciadorArquivo_Usuario
  '            strPassword = sGerenciadorArquivo_Senha
  '            nr.dwType = RESOURCETYPE_DISK

  '            Dim result As Integer
  '            result = WNetAddConnection2(nr, strPassword, strUsername, 0)

  '            If result > 0 Then
  '                Throw New System.ComponentModel.Win32Exception(result)
  '                Return False
  '            Else
  '                Return True
  '            End If
  '        End If
  '    End Function

  '    Private Function FNC_DriveLivre() As String
  '        Dim iCont As Integer
  '        Dim Aux As String = ""
  '        Dim bAchou As Boolean = False

  '        For iCont = 5 To 23
  '            If Not IO.Directory.Exists(Chr(65 + iCont) & ":\") Then
  '                bAchou = True
  '                Aux = Chr(65 + iCont)
  '                Exit For
  '            End If
  '        Next

  '        If bAchou Then
  '            Return Aux
  '        Else
  '            Return ""
  '        End If
  '    End Function

  '    Public Function FNC_UnMapDrive() As Boolean
  '        Dim WshNetwork As Object
  '        Dim oDrives As Object
  '        Dim i As Integer

  '        On Error GoTo deupau

  '        WshNetwork = CreateObject("WScript.Network")
  '        oDrives = WshNetwork.EnumNetworkDrives

  '        If Trim(sGerenciadorArquivo_DriveUnMap) <> "" Then
  '            For i = 0 To oDrives.Count - 1 Step 2
  '                If oDrives.item(i) = sGerenciadorArquivo_DriveUnMap & ":" Then
  '                    WshNetwork.RemoveNetworkDrive(oDrives.item(i), True)
  '                    Return True
  '                End If
  '            Next
  '        End If

  '        Return False

  'deupau:
  '        MsgBox("Ocorreu um erro. Numero: " & Err.Number & vbCrLf & "Descrição: " & Err.Description, vbCritical, "Atenção - Erro")
  '    End Function

  'public function fnc_validacpf(byval cpf as string) as boolean

  '    dim i, x, n1, n2 as integer

  '    cpf = cpf.trim
  '    for i = 0 to dadosarray.length - 1
  '        if cpf.length <> 14 or dadosarray(i).equals(cpf) then
  '            return false
  '        end if
  '    next
  '    'remove a maskara
  '    cpf = cpf.substring(0, 3) + cpf.substring(4, 3) + cpf.substring(8, 3) + cpf.substring(12)
  '    for x = 0 to 1
  '        n1 = 0
  '        for i = 0 to 8 + x
  '            n1 = n1 + val(cpf.substring(i, 1)) * (10 + x - i)
  '        next
  '        n2 = 11 - (n1 - (int(n1 / 11) * 11))
  '        if n2 = 10 or n2 = 11 then n2 = 0

  '        if n2 <> val(cpf.substring(9 + x, 1)) then
  '            return false
  '        end if
  '    next

  '    return true
  'end function

  'public function fnc_validacnpj(byval cnpj as string) as boolean

  '    dim i as integer
  '    dim valida as boolean
  '    cnpj = cnpj.trim

  '    for i = 0 to dadosarray.length - 1
  '        if cnpj.length <> 18 or dadosarray(i).equals(cnpj) then
  '            return false
  '        end if
  '    next

  '    'remove a maskara
  '    cnpj = cnpj.substring(0, 2) + cnpj.substring(3, 3) + cnpj.substring(7, 3) + cnpj.substring(11, 4) + cnpj.substring(16)
  '    valida = efetivavalidacao(cnpj)

  '    if valida then
  '        validacnpj = true
  '    else
  '        validacnpj = false
  '    end if

  'end function

  'private function efetivavalidacao(byval cnpj as string)
  '    dim numero(13) as integer
  '    dim soma as integer
  '    dim i as integer
  '    dim valida as boolean
  '    dim resultado1 as integer
  '    dim resultado2 as integer
  '    for i = 0 to numero.length - 1
  '        numero(i) = cint(cnpj.substring(i, 1))
  '    next
  '    soma = numero(0) * 5 + numero(1) * 4 + numero(2) * 3 + numero(3) * 2 + numero(4) * 9 + numero(5) * 8 + numero(6) * 7 + _
  '               numero(7) * 6 + numero(8) * 5 + numero(9) * 4 + numero(10) * 3 + numero(11) * 2
  '    soma = soma - (11 * (int(soma / 11)))
  '    if soma = 0 or soma = 1 then
  '        resultado1 = 0
  '    else
  '        resultado1 = 11 - soma
  '    end if

  '    if resultado1 = numero(12) then
  '        soma = numero(0) * 6 + numero(1) * 5 + numero(2) * 4 + numero(3) * 3 + numero(4) * 2 + numero(5) * 9 + numero(6) * 8 + _
  '                     numero(7) * 7 + numero(8) * 6 + numero(9) * 5 + numero(10) * 4 + numero(11) * 3 + numero(12) * 2
  '        soma = soma - (11 * (int(soma / 11)))
  '        if soma = 0 or soma = 1 then
  '            resultado2 = 0
  '        else
  '            resultado2 = 11 - soma
  '        end if
  '        if resultado2 = numero(13) then
  '            return true
  '        else
  '            return false
  '        end if
  '    else
  '        return false
  '    end if
  'end function
End Module

Module Validacao
  Private dadosArray() As String = {"111.111.111-11", "222.222.222-22", "333.333.333-33", "444.444.444-44",
                                    "555.555.555-55", "666.666.666-66", "777.777.777-77", "888.888.888-88", "999.999.999-99"}

  Public Function FNC_ValidarCPF_CNPJ(ByVal sCPF_CNPJ As String) As Boolean
    If Len(Trim(FNC_SoNumero(sCPF_CNPJ))) = 11 Then
      Return FNC_ValidarCPF(sCPF_CNPJ)
    Else
      Return FNC_ValidarCNPJ(sCPF_CNPJ)
    End If
  End Function

  Private Function FNC_ValidarCPF(ByVal CPF As String) As Boolean
    Dim i, x, n1, n2 As Integer
    Dim bOk As Boolean = True

    CPF = CPF.Trim

    For i = 0 To dadosArray.Length - 1
      'se a avaliação da primeira expressão for true a avaliação final sera true
      'nao importando o valor da segunda expressão
      If CPF.Length <> 14 OrElse dadosArray(i).Equals(CPF) Then
        Return False
      End If
    Next

    'remove a maskara
    CPF = CPF.Substring(0, 3) + CPF.Substring(4, 3) + CPF.Substring(8, 3) + CPF.Substring(12)

    For x = 0 To 1
      n1 = 0

      For i = 0 To 8 + x
        n1 = n1 + Val(CPF.Substring(i, 1)) * (10 + x - i)
      Next

      n2 = 11 - (n1 - (Int(n1 / 11) * 11))

      If n2 = 10 OrElse n2 = 11 Then
        n2 = 0
      End If

      If Not n2.Equals(Val(CPF.Substring(9 + x, 1))) Then
        bOk = False
        Exit For
      End If
    Next

    Return bOk
  End Function

  Private Function FNC_ValidarCNPJ(ByVal CNPJ As String) As Boolean
    Dim i As Integer
    Dim valida As Boolean

    'RecebeCNPJ = Trim(CNPJ)
    CNPJ = CNPJ.Trim

    For i = 0 To dadosArray.Length - 1
      If CNPJ.Length <> 18 OrElse dadosArray(i).Equals(CNPJ) Then
        Return False
      End If
    Next

    'remove a maskara
    CNPJ = CNPJ.Substring(0, 2) + CNPJ.Substring(3, 3) + CNPJ.Substring(7, 3) + CNPJ.Substring(11, 4) + CNPJ.Substring(16)
    valida = efetivaValidacao(CNPJ)

    Return valida
  End Function

  Private Function efetivaValidacao(ByVal cnpj As String)
    Dim Numero(13) As Integer
    Dim soma As Integer
    Dim i As Integer
    Dim valida As Boolean
    Dim resultado1 As Integer
    Dim resultado2 As Integer

    For i = 0 To Numero.Length - 1
      Numero(i) = CInt(cnpj.Substring(i, 1))
    Next

    soma = Numero(0) * 5 + Numero(1) * 4 + Numero(2) * 3 + Numero(3) * 2 + Numero(4) * 9 + Numero(5) * 8 + Numero(6) * 7 + Numero(7) * 6 + Numero(8) * 5 + Numero(9) * 4 + Numero(10) * 3 + Numero(11) * 2
    soma = soma - (11 * (Int(soma / 11)))

    If soma = 0 OrElse soma = 1 Then
      resultado1 = 0
    Else
      resultado1 = 11 - soma
    End If

    If resultado1 = Numero(12) Then
      soma = Numero(0) * 6 + Numero(1) * 5 + Numero(2) * 4 + Numero(3) * 3 + Numero(4) * 2 + Numero(5) * 9 + Numero(6) * 8 + Numero(7) * 7 + Numero(8) * 6 + Numero(9) * 5 + Numero(10) * 4 + Numero(11) * 3 + Numero(12) * 2
      soma = soma - (11 * (Int(soma / 11)))

      If soma = 0 OrElse soma = 1 Then
        resultado2 = 0
      Else
        resultado2 = 11 - soma
      End If

      If resultado2.Equals(Numero(13)) Then
        Return True
      Else
        Return False
      End If
    Else
      Return False
    End If
  End Function
End Module


Namespace ConnectUNCWithCredentials
  Public Class UNCAccessWithCredentials
    Implements IDisposable

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Friend Structure USE_INFO_2
      Friend ui2_local As LPWSTR
      Friend ui2_remote As LPWSTR
      Friend ui2_password As LPWSTR
      Friend ui2_status As DWORD
      Friend ui2_asg_type As DWORD
      Friend ui2_refcount As DWORD
      Friend ui2_usecount As DWORD
      Friend ui2_username As LPWSTR
      Friend ui2_domainname As LPWSTR
    End Structure

    <DllImport("NetApi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
    Friend Shared Function NetUseAdd(ByVal UncServerName As LPWSTR, ByVal Level As DWORD, ByRef Buf As USE_INFO_2, ByVal ParmError As DWORD) As NET_API_STATUS
    End Function

    <DllImport("NetApi32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> _
    Friend Shared Function NetUseDel(ByVal UncServerName As LPWSTR, ByVal UseName As LPWSTR, ByVal ForceCond As DWORD) As NET_API_STATUS
    End Function

    Private disposed As Boolean = False

    Private sUNCPath As String
    Private sUser As String
    Private sPassword As String
    Private sDomain As String
    Private iLastError As Integer

    ''' <summary>
    ''' A disposeable class that allows access to a UNC resource with credentials.
    ''' </summary>
    Public Sub New()
    End Sub

    ''' <summary>
    ''' The last system error code returned from NetUseAdd or NetUseDel.  Success = 0
    ''' </summary>
    Public ReadOnly Property LastError() As Integer
      Get
        Return iLastError
      End Get
    End Property

    ''' <summary>
    ''' Connects to a UNC path using the credentials supplied.
    ''' </summary>
    ''' <param name="UNCPath">Fully qualified domain name UNC path</param>
    ''' <param name="User">A user with sufficient rights to access the path.</param>
    ''' <param name="Domain">Domain of User.</param>
    ''' <param name="Password">Password of User</param>
    ''' <returns>True if mapping succeeds.  Use LastError to get the system error code.</returns>
    Public Function NetUseWithCredentials(ByVal UNCPath As String, ByVal User As String, ByVal Domain As String, ByVal Password As String) As Boolean
      Dim bOk As Boolean

      Try
        Dir(FNC_Diretorio_Tratar(UNCPath) & "*.*")
        bOk = True
      Catch ex As Exception
        bOk = False
      End Try

      If Not bOk Then
        sUNCPath = UNCPath
        sUser = User
        sPassword = Password
        sDomain = Domain
        bOk = NetUseWithCredentials()
      End If

      Return bOk
    End Function

    Private Function NetUseWithCredentials() As Boolean
      Dim returncode As UInteger
      Try
        Dim useinfo As New USE_INFO_2()

        useinfo.ui2_remote = sUNCPath
        useinfo.ui2_username = sUser
        useinfo.ui2_domainname = sDomain
        useinfo.ui2_password = sPassword
        useinfo.ui2_asg_type = 0
        useinfo.ui2_usecount = 1
        Dim paramErrorIndex As UInteger
        returncode = NetUseAdd(Nothing, 2, useinfo, paramErrorIndex)
        iLastError = CInt(returncode)
        Return returncode = 0
      Catch
        iLastError = Marshal.GetLastWin32Error()
        Return False
      End Try
    End Function

    ''' <summary>
    ''' Ends the connection to the remote resource
    ''' </summary>
    ''' <returns>True if it succeeds.  Use LastError to get the system error code</returns>
    Public Function NetUseDelete() As Boolean
      Dim returncode As UInteger
      Try
        returncode = NetUseDel(Nothing, sUNCPath, 2)
        iLastError = CInt(returncode)
        Return (returncode = 0)
      Catch
        iLastError = Marshal.GetLastWin32Error()
        Return False
      End Try
    End Function

    Protected Overrides Sub Finalize()
      Try
        Dispose()
      Finally
        MyBase.Finalize()
      End Try
    End Sub
#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not Me.disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
      Dispose(True)
      GC.SuppressFinalize(Me)
    End Sub
#End Region

  End Class
End Namespace