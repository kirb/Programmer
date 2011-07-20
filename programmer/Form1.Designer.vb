<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.TableMain = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelFile = New System.Windows.Forms.Label()
        Me.TextBoxFile = New System.Windows.Forms.TextBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.LabelChip = New System.Windows.Forms.Label()
        Me.ComboChipType = New System.Windows.Forms.ComboBox()
        Me.ButtonProgram = New System.Windows.Forms.Button()
        Me.LabelVersion = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableMain
        '
        Me.TableMain.BackColor = System.Drawing.Color.Transparent
        Me.TableMain.ColumnCount = 3
        Me.TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableMain.Controls.Add(Me.LabelTitle, 0, 0)
        Me.TableMain.Controls.Add(Me.LabelFile, 0, 1)
        Me.TableMain.Controls.Add(Me.TextBoxFile, 1, 1)
        Me.TableMain.Controls.Add(Me.ButtonBrowse, 2, 1)
        Me.TableMain.Controls.Add(Me.LabelChip, 0, 2)
        Me.TableMain.Controls.Add(Me.ComboChipType, 1, 2)
        Me.TableMain.Controls.Add(Me.ButtonProgram, 0, 4)
        Me.TableMain.Controls.Add(Me.LabelVersion, 2, 0)
        Me.TableMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableMain.Location = New System.Drawing.Point(0, 0)
        Me.TableMain.Name = "TableMain"
        Me.TableMain.Padding = New System.Windows.Forms.Padding(12)
        Me.TableMain.RowCount = 5
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableMain.Size = New System.Drawing.Size(457, 201)
        Me.TableMain.TabIndex = 0
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.BackColor = System.Drawing.Color.Transparent
        Me.TableMain.SetColumnSpan(Me.LabelTitle, 2)
        Me.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelTitle.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(15, 12)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(334, 50)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Programmer"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelFile
        '
        Me.LabelFile.AutoSize = True
        Me.LabelFile.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelFile.Location = New System.Drawing.Point(39, 62)
        Me.LabelFile.Name = "LabelFile"
        Me.LabelFile.Size = New System.Drawing.Size(28, 33)
        Me.LabelFile.TabIndex = 1
        Me.LabelFile.Text = "&File:"
        Me.LabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBoxFile
        '
        Me.TextBoxFile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBoxFile.Location = New System.Drawing.Point(73, 65)
        Me.TextBoxFile.Name = "TextBoxFile"
        Me.TextBoxFile.Size = New System.Drawing.Size(276, 23)
        Me.TextBoxFile.TabIndex = 2
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonBrowse.Location = New System.Drawing.Point(355, 65)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(87, 27)
        Me.ButtonBrowse.TabIndex = 3
        Me.ButtonBrowse.Text = "&Browse..."
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'LabelChip
        '
        Me.LabelChip.AutoSize = True
        Me.LabelChip.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelChip.Location = New System.Drawing.Point(32, 95)
        Me.LabelChip.Name = "LabelChip"
        Me.LabelChip.Size = New System.Drawing.Size(35, 29)
        Me.LabelChip.TabIndex = 4
        Me.LabelChip.Text = "Chip:"
        Me.LabelChip.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ComboChipType
        '
        Me.TableMain.SetColumnSpan(Me.ComboChipType, 2)
        Me.ComboChipType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ComboChipType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboChipType.FormattingEnabled = True
        Me.ComboChipType.Items.AddRange(New Object() {"elab16m", "elab6"})
        Me.ComboChipType.Location = New System.Drawing.Point(73, 98)
        Me.ComboChipType.Name = "ComboChipType"
        Me.ComboChipType.Size = New System.Drawing.Size(369, 23)
        Me.ComboChipType.Sorted = True
        Me.ComboChipType.TabIndex = 5
        '
        'ButtonProgram
        '
        Me.TableMain.SetColumnSpan(Me.ButtonProgram, 3)
        Me.ButtonProgram.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonProgram.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonProgram.Location = New System.Drawing.Point(15, 159)
        Me.ButtonProgram.Name = "ButtonProgram"
        Me.ButtonProgram.Size = New System.Drawing.Size(427, 27)
        Me.ButtonProgram.TabIndex = 6
        Me.ButtonProgram.Text = "Program the Chip!"
        Me.ButtonProgram.UseVisualStyleBackColor = True
        '
        'LabelVersion
        '
        Me.LabelVersion.BackColor = System.Drawing.Color.Transparent
        Me.LabelVersion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelVersion.Location = New System.Drawing.Point(355, 12)
        Me.LabelVersion.Name = "LabelVersion"
        Me.LabelVersion.Size = New System.Drawing.Size(87, 50)
        Me.LabelVersion.TabIndex = 7
        Me.LabelVersion.Text = "Version Unknown"
        Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "*.usb"
        Me.OpenFileDialog1.Filter = "All Microchip Files (*.usb; *.asm)|*.usb; *.asm|CoreChart Mobile Files (*.usb)|*." & _
            "usb|Assembly Files (*.asm)|*.asm"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Choose a programming file - Programmer"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.programmer.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(457, 201)
        Me.Controls.Add(Me.TableMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(697, 456)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 225)
        Me.Name = "FormMain"
        Me.Text = "Programmer"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TableMain.ResumeLayout(False)
        Me.TableMain.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
    Friend WithEvents LabelFile As System.Windows.Forms.Label
    Friend WithEvents TextBoxFile As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents LabelChip As System.Windows.Forms.Label
    Friend WithEvents ComboChipType As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonProgram As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LabelVersion As System.Windows.Forms.Label

End Class
