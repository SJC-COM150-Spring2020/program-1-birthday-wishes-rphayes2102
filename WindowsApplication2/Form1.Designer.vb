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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.BackColor = System.Drawing.Color.Black
        Me.lstBox.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 23
        Me.lstBox.Location = New System.Drawing.Point(36, 123)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(296, 119)
        Me.lstBox.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(36, 59)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(126, 20)
        Me.txtName.TabIndex = 1
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Black
        Me.btnEnter.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnEnter.Location = New System.Drawing.Point(53, 85)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 32)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Location = New System.Drawing.Point(53, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 43)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Location = New System.Drawing.Point(220, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit "
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.BackColor = System.Drawing.Color.Black
        Me.lblOne.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblOne.Location = New System.Drawing.Point(53, 23)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(135, 18)
        Me.lblOne.TabIndex = 5
        Me.lblOne.Text = "Enter Your Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 370)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblOne As Label
End Class
