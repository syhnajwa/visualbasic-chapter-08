﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDanceBand
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
        Me.mnuDanceBand = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.lstSongs = New System.Windows.Forms.ListBox()
        Me.mnuDanceBand.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuDanceBand
        '
        Me.mnuDanceBand.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mnuDanceBand.Location = New System.Drawing.Point(0, 0)
        Me.mnuDanceBand.Name = "mnuDanceBand"
        Me.mnuDanceBand.Size = New System.Drawing.Size(800, 24)
        Me.mnuDanceBand.TabIndex = 0
        Me.mnuDanceBand.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(164, 22)
        Me.mnuDisplay.Text = "Display Song Set "
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(164, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(164, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(313, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(174, 33)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Dance Band"
        '
        'cboGenre
        '
        Me.cboGenre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Location = New System.Drawing.Point(310, 71)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(180, 32)
        Me.cboGenre.TabIndex = 2
        Me.cboGenre.Text = "Select Genre"
        '
        'lstSongs
        '
        Me.lstSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSongs.FormattingEnabled = True
        Me.lstSongs.ItemHeight = 24
        Me.lstSongs.Location = New System.Drawing.Point(185, 122)
        Me.lstSongs.Name = "lstSongs"
        Me.lstSongs.Size = New System.Drawing.Size(434, 316)
        Me.lstSongs.TabIndex = 3
        Me.lstSongs.Visible = False
        '
        'frmDanceBand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dance_Band.My.Resources.Resources._5819184201_df0392f0e7_b
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstSongs)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.mnuDanceBand)
        Me.MainMenuStrip = Me.mnuDanceBand
        Me.Name = "frmDanceBand"
        Me.Text = "Dance Band "
        Me.mnuDanceBand.ResumeLayout(False)
        Me.mnuDanceBand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuDanceBand As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents lstSongs As ListBox
End Class
