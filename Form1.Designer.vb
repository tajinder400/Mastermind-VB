<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMastermind = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdHard = New System.Windows.Forms.RadioButton()
        Me.rdMedium = New System.Windows.Forms.RadioButton()
        Me.rdEasy = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMastermind
        '
        Me.lblMastermind.AutoSize = True
        Me.lblMastermind.Location = New System.Drawing.Point(96, 21)
        Me.lblMastermind.Name = "lblMastermind"
        Me.lblMastermind.Size = New System.Drawing.Size(61, 13)
        Me.lblMastermind.TabIndex = 0
        Me.lblMastermind.Text = "Mastermind"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 202)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(94, 30)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(178, 202)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdHard)
        Me.GroupBox1.Controls.Add(Me.rdMedium)
        Me.GroupBox1.Controls.Add(Me.rdEasy)
        Me.GroupBox1.Location = New System.Drawing.Point(35, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Difficulty"
        '
        'rdHard
        '
        Me.rdHard.AutoSize = True
        Me.rdHard.Location = New System.Drawing.Point(7, 66)
        Me.rdHard.Name = "rdHard"
        Me.rdHard.Size = New System.Drawing.Size(48, 17)
        Me.rdHard.TabIndex = 2
        Me.rdHard.TabStop = True
        Me.rdHard.Text = "Hard"
        Me.rdHard.UseVisualStyleBackColor = True
        '
        'rdMedium
        '
        Me.rdMedium.AutoSize = True
        Me.rdMedium.Location = New System.Drawing.Point(7, 43)
        Me.rdMedium.Name = "rdMedium"
        Me.rdMedium.Size = New System.Drawing.Size(62, 17)
        Me.rdMedium.TabIndex = 1
        Me.rdMedium.TabStop = True
        Me.rdMedium.Text = "Medium"
        Me.rdMedium.UseVisualStyleBackColor = True
        '
        'rdEasy
        '
        Me.rdEasy.AutoSize = True
        Me.rdEasy.Location = New System.Drawing.Point(6, 19)
        Me.rdEasy.Name = "rdEasy"
        Me.rdEasy.Size = New System.Drawing.Size(48, 17)
        Me.rdEasy.TabIndex = 0
        Me.rdEasy.TabStop = True
        Me.rdEasy.Text = "Easy"
        Me.rdEasy.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblMastermind)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMastermind As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdHard As System.Windows.Forms.RadioButton
    Friend WithEvents rdMedium As System.Windows.Forms.RadioButton
    Friend WithEvents rdEasy As System.Windows.Forms.RadioButton

End Class
