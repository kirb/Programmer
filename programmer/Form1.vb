Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Application.CommandLineArgs.Count > 0 Then
            If My.Computer.FileSystem.FileExists(My.Application.CommandLineArgs.Item(0)) Then
                TextBox1.Text = My.Application.CommandLineArgs.Item(0)
                TextBox1.Enabled = False
                Button1.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim chip As String = ""
        Dim len As Integer = TextBox1.Text.Length
        Dim mpasm As String = My.Application.Info.DirectoryPath & "\ASM\MPASMWIN.EXE"
        Dim usbp As String = My.Application.Info.DirectoryPath & "\USBezChart.exe"
        Dim usechip As String = ComboBox1.SelectedItem
        If chip = Nothing Then
            chip = ""
        End If
        If TextBox1.Text.Length < 4 Then
            MsgBox("Please enter a file name of a CoreChart Mobile or Assembly file to send to the chip.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim ext As String = TextBox1.Text.ToLower().Substring(TextBox1.Text.Length - 4)
        If Trim(TextBox1.Text) = "" Or Not My.Computer.FileSystem.FileExists(TextBox1.Text) Or Not (ext = ".usb" Or ext = ".asm") Then
            MsgBox("Please enter a file name of a CoreChart Mobile or Assembly file to send to the chip.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If TextBox1.Text.IndexOf("""") > 0 Or TextBox1.Text.IndexOf("'") > 0 Or TextBox1.Text.IndexOf("/") > 0 Then
            MsgBox("The file name of the CoreChart Mobile or Assembly file is invalid.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Select Case usechip
            Case "elab6"
                chip = "P16F819"
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
        Dim result As Integer = Run("""" & mpasm & """", "/q /" & chip & " """ & TextBox1.Text & """ /l /e /d_DEBUG=1")
        If result = 0 Then
            Dim result2 As Integer = Run("""" & usbp & """", "-t" & chip & " ""-l" & TextBox1.Text & """ -p")
            If result2 = 0 Then
                MsgBox("An error occurred while sending the file to the chip. The error was: " & result.ToString(), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        Else
            MsgBox("An error occurred while converting the file to binary. The error was: " & result.ToString(), MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
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
End Class
