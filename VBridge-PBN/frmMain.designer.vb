<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblCSV = New System.Windows.Forms.Label()
        Me.txtFilename = New System.Windows.Forms.TextBox()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.ofdMembersFile = New System.Windows.Forms.OpenFileDialog()
        Me.cmdRead = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.lblBoard = New System.Windows.Forms.Label()
        Me.cmbBoards = New System.Windows.Forms.ComboBox()
        Me.txtGift = New System.Windows.Forms.TextBox()
        Me.cmdLeegmaken = New System.Windows.Forms.Button()
        Me.cmdToon = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCSV
        '
        Me.lblCSV.AutoSize = True
        Me.lblCSV.Location = New System.Drawing.Point(12, 9)
        Me.lblCSV.Name = "lblCSV"
        Me.lblCSV.Size = New System.Drawing.Size(96, 13)
        Me.lblCSV.TabIndex = 0
        Me.lblCSV.Text = "Kies PBN-bestand:"
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(12, 25)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(291, 20)
        Me.txtFilename.TabIndex = 1
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(309, 23)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(75, 23)
        Me.cmdFile.TabIndex = 2
        Me.cmdFile.Text = "&Bladeren..."
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'ofdMembersFile
        '
        Me.ofdMembersFile.DefaultExt = "csv"
        Me.ofdMembersFile.Filter = "PBN-bestand|*.pbn"
        '
        'cmdRead
        '
        Me.cmdRead.Location = New System.Drawing.Point(12, 51)
        Me.cmdRead.Name = "cmdRead"
        Me.cmdRead.Size = New System.Drawing.Size(75, 23)
        Me.cmdRead.TabIndex = 3
        Me.cmdRead.Text = "&Inlezen"
        Me.cmdRead.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(309, 80)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 5
        Me.cmdClose.Text = "&Sluiten"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.LinkArea = New System.Windows.Forms.LinkArea(31, 52)
        Me.lblLink.Location = New System.Drawing.Point(12, 88)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(268, 17)
        Me.lblLink.TabIndex = 7
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "© 2013 - Martijn Verstraelen - Retiese BC Hartenvier"
        Me.lblLink.UseCompatibleTextRendering = True
        '
        'lblBoard
        '
        Me.lblBoard.AutoSize = True
        Me.lblBoard.Location = New System.Drawing.Point(12, 141)
        Me.lblBoard.Name = "lblBoard"
        Me.lblBoard.Size = New System.Drawing.Size(26, 13)
        Me.lblBoard.TabIndex = 8
        Me.lblBoard.Text = "Gift:"
        '
        'cmbBoards
        '
        Me.cmbBoards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoards.Enabled = False
        Me.cmbBoards.FormattingEnabled = True
        Me.cmbBoards.Location = New System.Drawing.Point(44, 138)
        Me.cmbBoards.Name = "cmbBoards"
        Me.cmbBoards.Size = New System.Drawing.Size(121, 21)
        Me.cmbBoards.TabIndex = 9
        '
        'txtGift
        '
        Me.txtGift.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGift.Location = New System.Drawing.Point(12, 165)
        Me.txtGift.Multiline = True
        Me.txtGift.Name = "txtGift"
        Me.txtGift.ReadOnly = True
        Me.txtGift.Size = New System.Drawing.Size(372, 204)
        Me.txtGift.TabIndex = 10
        '
        'cmdLeegmaken
        '
        Me.cmdLeegmaken.Location = New System.Drawing.Point(309, 136)
        Me.cmdLeegmaken.Name = "cmdLeegmaken"
        Me.cmdLeegmaken.Size = New System.Drawing.Size(75, 23)
        Me.cmdLeegmaken.TabIndex = 11
        Me.cmdLeegmaken.Text = "&Leegmaken"
        Me.cmdLeegmaken.UseVisualStyleBackColor = True
        '
        'cmdToon
        '
        Me.cmdToon.Location = New System.Drawing.Point(171, 136)
        Me.cmdToon.Name = "cmdToon"
        Me.cmdToon.Size = New System.Drawing.Size(75, 23)
        Me.cmdToon.TabIndex = 12
        Me.cmdToon.Text = "&Tonen"
        Me.cmdToon.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 382)
        Me.Controls.Add(Me.cmdToon)
        Me.Controls.Add(Me.cmdLeegmaken)
        Me.Controls.Add(Me.txtGift)
        Me.Controls.Add(Me.cmbBoards)
        Me.Controls.Add(Me.lblBoard)
        Me.Controls.Add(Me.lblLink)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdRead)
        Me.Controls.Add(Me.cmdFile)
        Me.Controls.Add(Me.txtFilename)
        Me.Controls.Add(Me.lblCSV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(402, 410)
        Me.MinimumSize = New System.Drawing.Size(402, 410)
        Me.Name = "frmMain"
        Me.Text = "PBN-lezer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCSV As System.Windows.Forms.Label
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Friend WithEvents ofdMembersFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmdRead As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents lblLink As System.Windows.Forms.LinkLabel
    Friend WithEvents lblBoard As System.Windows.Forms.Label
    Friend WithEvents cmbBoards As System.Windows.Forms.ComboBox
    Friend WithEvents txtGift As System.Windows.Forms.TextBox
    Friend WithEvents cmdLeegmaken As System.Windows.Forms.Button
    Friend WithEvents cmdToon As System.Windows.Forms.Button

End Class
