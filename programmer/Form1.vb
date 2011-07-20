Imports System.Runtime.InteropServices

Public Class FormMain
    Dim AutoClose As Boolean = False
    Dim NoErrors As Boolean = True

    Private Sub FormMain_Load() Handles MyBase.Load
        LabelVersion.Text = String.Format("Version {0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        If My.Application.CommandLineArgs.Count > 0 Then
            If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(0)) Then
                TextBoxFile.Text = My.Application.CommandLineArgs.Item(0)
                TextBoxFile.Enabled = False
                ButtonBrowse.Enabled = False
                AutoClose = True
            End If
            Dim SetChipType As Boolean = False
            Try
                For I = 1 To My.Application.CommandLineArgs.Count
                    If My.Application.CommandLineArgs.Item(I) = "--elab6" And Not SetChipType Then
                        ComboChipType.SelectedItem = "eLab6"
                        SetChipType = True
                    ElseIf My.Application.CommandLineArgs.Item(I) = "--elab16m" And Not SetChipType Then
                        ComboChipType.SelectedItem = "eLab16m"
                        SetChipType = True
                    ElseIf My.Application.CommandLineArgs.Item(I) = "--browse" Then
                        ButtonBrowse_Click()
                    ElseIf My.Application.CommandLineArgs.Item(I) = "--noerrors" Then
                        NoErrors = True
                    End If
                Next
            Catch ex As Exception
            End Try
            If SetChipType Then
                AutoClose = True
                ButtonProgram_Click()
            End If
        End If
    End Sub

    Private Sub ButtonBrowse_Click() Handles ButtonBrowse.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBoxFile.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub ButtonProgram_Click() Handles ButtonProgram.Click
        Dim chip As String = ""
        Dim len As Integer = TextBoxFile.Text.Length
        Dim mpasm As String = My.Application.Info.DirectoryPath & "\ASM\MPASMWIN.EXE"
        Dim usbp As String = My.Application.Info.DirectoryPath & "\USBezChart.exe"
        Dim usechip As String = ComboChipType.SelectedItem
        If chip = Nothing Then
            chip = ""
        End If
        If TextBoxFile.Text.Length < 4 Then
            ShowMsg("Please enter a file name of a CoreChart Mobile or Assembly file to send to the chip.")
            Exit Sub
        End If
        Dim ext As String = TextBoxFile.Text.ToLower().Substring(TextBoxFile.Text.Length - 4)
        If Trim(TextBoxFile.Text) = "" Or Not My.Computer.FileSystem.FileExists(TextBoxFile.Text) Or Not (ext = ".usb" Or ext = ".asm") Then
            MsgBox("Please enter a file name of a CoreChart Mobile or Assembly file to send to the chip.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If TextBoxFile.Text.IndexOf("""") > 0 Or TextBoxFile.Text.IndexOf("'") > 0 Or TextBoxFile.Text.IndexOf("/") > 0 Then
            MsgBox("The file name of the CoreChart Mobile or Assembly file is invalid.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Select Case usechip
            Case "elab6"
                chip = "P12F675"
            Case "elab16m"
                chip = "P16F819"
            Case Else
                MsgBox("Please choose a circuit board from the drop down list.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
        End Select
        If Not My.Computer.FileSystem.FileExists(mpasm) Then
            MsgBox("MPASM was not found! Please reinstall Programmer.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If Not My.Computer.FileSystem.FileExists(usbp) Then
            MsgBox("USB Programmer was not found! Please reinstall Programmer.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim result As Integer = Run("""" & mpasm & """", "/q /" & chip & " """ & TextBoxFile.Text & """ /l /e /d_DEBUG=1")
        If result = 0 Then
            Dim result2 As Integer = Run("""" & usbp & """", "-t" & chip & " ""-l" & TextBoxFile.Text & """ -p")
            If result2 = 0 Then
                MsgBox("Error #" & result2.ToString() & " occurred while sending the file to the chip. The error was: " & result.ToString(), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Threading.Thread.Sleep(100)
                Exit Sub
            End If
        Else
            MsgBox("Error " & result.ToString() & " occurred while converting the file to binary.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Threading.Thread.Sleep(100)
            Exit Sub
        End If
        Me.Focus()
        DoAutoClose()
    End Sub

    Function Run(ByVal FileName As String, ByVal Parameters As String)
        Dim procID As Integer
        Dim newProc As Process
        newProc = Process.Start(FileName, Parameters)
        procID = newProc.Id
        newProc.WaitForExit()
        Dim procEC As Integer = -1
        If newProc.HasExited Then
            procEC = newProc.ExitCode
        End If
        Return procEC
    End Function

    Sub ShowMsg(ByVal TheMsg As String)
        If NoErrors Then
            Dim TheFile As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("C:\programmer.log", True)
            Dim DTime As DateTime = New DateTime()
            TheFile.WriteLine(DTime.Day & "/" & DTime.Month & "/" & DTime.Year & " " & DTime.Hour & ":" & DTime.Minute & ":" & DTime.Second & ":" & DTime.Millisecond & "   " & TheMsg)
        Else
            MsgBox(TheMsg, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If
    End Sub

    Sub DoAutoClose()
        Threading.Thread.Sleep(100)
        If AutoClose Then
            Me.Close()
        End If
    End Sub
End Class
