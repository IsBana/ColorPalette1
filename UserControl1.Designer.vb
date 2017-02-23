<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorPalette
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.ColorBox1 = New System.Windows.Forms.Button()
        Me.ColorBox2 = New System.Windows.Forms.Button()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.TrackBarBlue = New System.Windows.Forms.TrackBar()
        Me.TrackBarRed = New System.Windows.Forms.TrackBar()
        Me.TrackBarGreen = New System.Windows.Forms.TrackBar()
        Me.ImageRed = New System.Windows.Forms.PictureBox()
        Me.ImageGreen = New System.Windows.Forms.PictureBox()
        Me.ImageBlue = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtARGB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColorBox1
        '
        Me.ColorBox1.BackColor = System.Drawing.Color.Black
        Me.ColorBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorBox1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.ColorBox1.Location = New System.Drawing.Point(34, 37)
        Me.ColorBox1.Name = "ColorBox1"
        Me.ColorBox1.Size = New System.Drawing.Size(50, 50)
        Me.ColorBox1.TabIndex = 1
        Me.ColorBox1.UseVisualStyleBackColor = False
        '
        'ColorBox2
        '
        Me.ColorBox2.BackColor = System.Drawing.Color.White
        Me.ColorBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorBox2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.ColorBox2.Location = New System.Drawing.Point(14, 15)
        Me.ColorBox2.Name = "ColorBox2"
        Me.ColorBox2.Size = New System.Drawing.Size(50, 50)
        Me.ColorBox2.TabIndex = 2
        Me.ColorBox2.UseVisualStyleBackColor = False
        '
        'txtG
        '
        Me.txtG.BackColor = System.Drawing.SystemColors.Control
        Me.txtG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtG.ForeColor = Me.ForeColor
        Me.txtG.Location = New System.Drawing.Point(362, 77)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(40, 20)
        Me.txtG.TabIndex = 8
        Me.txtG.Text = "0"
        Me.txtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtR
        '
        Me.txtR.BackColor = System.Drawing.SystemColors.Control
        Me.txtR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtR.ForeColor = Me.ForeColor
        Me.txtR.Location = New System.Drawing.Point(362, 24)
        Me.txtR.Name = "txtR"
        Me.txtR.Size = New System.Drawing.Size(40, 20)
        Me.txtR.TabIndex = 7
        Me.txtR.Text = "0"
        Me.txtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtB
        '
        Me.txtB.BackColor = System.Drawing.SystemColors.Control
        Me.txtB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtB.ForeColor = Me.ForeColor
        Me.txtB.Location = New System.Drawing.Point(362, 130)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(40, 20)
        Me.txtB.TabIndex = 9
        Me.txtB.Text = "0"
        Me.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TrackBarBlue
        '
        Me.TrackBarBlue.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarBlue.Location = New System.Drawing.Point(10, 112)
        Me.TrackBarBlue.Maximum = 255
        Me.TrackBarBlue.Name = "TrackBarBlue"
        Me.TrackBarBlue.Size = New System.Drawing.Size(347, 45)
        Me.TrackBarBlue.TabIndex = 2
        Me.TrackBarBlue.TickFrequency = 0
        '
        'TrackBarRed
        '
        Me.TrackBarRed.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarRed.Location = New System.Drawing.Point(10, 6)
        Me.TrackBarRed.Maximum = 255
        Me.TrackBarRed.Name = "TrackBarRed"
        Me.TrackBarRed.Size = New System.Drawing.Size(350, 45)
        Me.TrackBarRed.TabIndex = 0
        Me.TrackBarRed.TickFrequency = 0
        Me.TrackBarRed.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'TrackBarGreen
        '
        Me.TrackBarGreen.BackColor = System.Drawing.SystemColors.Control
        Me.TrackBarGreen.Location = New System.Drawing.Point(10, 59)
        Me.TrackBarGreen.Maximum = 255
        Me.TrackBarGreen.Name = "TrackBarGreen"
        Me.TrackBarGreen.Size = New System.Drawing.Size(347, 45)
        Me.TrackBarGreen.TabIndex = 1
        Me.TrackBarGreen.TickFrequency = 0
        '
        'ImageRed
        '
        Me.ImageRed.BackColor = System.Drawing.Color.Transparent
        Me.ImageRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageRed.Location = New System.Drawing.Point(21, 26)
        Me.ImageRed.Name = "ImageRed"
        Me.ImageRed.Size = New System.Drawing.Size(330, 26)
        Me.ImageRed.TabIndex = 10
        Me.ImageRed.TabStop = False
        '
        'ImageGreen
        '
        Me.ImageGreen.BackColor = System.Drawing.Color.Transparent
        Me.ImageGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageGreen.Location = New System.Drawing.Point(21, 79)
        Me.ImageGreen.Name = "ImageGreen"
        Me.ImageGreen.Size = New System.Drawing.Size(330, 26)
        Me.ImageGreen.TabIndex = 11
        Me.ImageGreen.TabStop = False
        '
        'ImageBlue
        '
        Me.ImageBlue.BackColor = System.Drawing.Color.Transparent
        Me.ImageBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ImageBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageBlue.Location = New System.Drawing.Point(21, 131)
        Me.ImageBlue.Name = "ImageBlue"
        Me.ImageBlue.Size = New System.Drawing.Size(330, 26)
        Me.ImageBlue.TabIndex = 12
        Me.ImageBlue.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ImageBlue)
        Me.Panel1.Controls.Add(Me.ImageGreen)
        Me.Panel1.Controls.Add(Me.ImageRed)
        Me.Panel1.Controls.Add(Me.txtR)
        Me.Panel1.Controls.Add(Me.txtB)
        Me.Panel1.Controls.Add(Me.txtG)
        Me.Panel1.Controls.Add(Me.TrackBarGreen)
        Me.Panel1.Controls.Add(Me.TrackBarRed)
        Me.Panel1.Controls.Add(Me.TrackBarBlue)
        Me.Panel1.Location = New System.Drawing.Point(118, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 169)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ColorBox1)
        Me.Panel2.Controls.Add(Me.ColorBox2)
        Me.Panel2.Location = New System.Drawing.Point(9, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(100, 100)
        Me.Panel2.TabIndex = 14
        '
        'txtARGB
        '
        Me.txtARGB.Location = New System.Drawing.Point(27, 139)
        Me.txtARGB.Name = "txtARGB"
        Me.txtARGB.Size = New System.Drawing.Size(70, 20)
        Me.txtARGB.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "#"
        '
        'ColorPalette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtARGB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "ColorPalette"
        Me.Size = New System.Drawing.Size(550, 185)
        CType(Me.TrackBarBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBarGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorBox1 As System.Windows.Forms.Button
    Friend WithEvents ColorBox2 As System.Windows.Forms.Button
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents txtR As System.Windows.Forms.TextBox
    Friend WithEvents txtB As System.Windows.Forms.TextBox
    Friend WithEvents TrackBarBlue As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarRed As System.Windows.Forms.TrackBar
    Friend WithEvents TrackBarGreen As System.Windows.Forms.TrackBar
    Friend WithEvents ImageRed As System.Windows.Forms.PictureBox
    Friend WithEvents ImageGreen As System.Windows.Forms.PictureBox
    Friend WithEvents ImageBlue As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtARGB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
