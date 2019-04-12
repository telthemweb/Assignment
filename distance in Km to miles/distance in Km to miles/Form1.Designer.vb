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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMile = New System.Windows.Forms.Label()
        Me.lblKilo = New System.Windows.Forms.Label()
        Me.cboUnit = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 89)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(124, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DISTANCE CONVETOR"
        '
        'txtUnity
        '
        Me.txtUnity.BackColor = System.Drawing.Color.Silver
        Me.txtUnity.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnity.Location = New System.Drawing.Point(240, 226)
        Me.txtUnity.Name = "txtUnity"
        Me.txtUnity.Size = New System.Drawing.Size(125, 44)
        Me.txtUnity.TabIndex = 1
        Me.txtUnity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(151, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(304, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your distance"
        '
        'lblMile
        '
        Me.lblMile.AutoSize = True
        Me.lblMile.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMile.ForeColor = System.Drawing.Color.White
        Me.lblMile.Location = New System.Drawing.Point(195, 352)
        Me.lblMile.Name = "lblMile"
        Me.lblMile.Size = New System.Drawing.Size(0, 37)
        Me.lblMile.TabIndex = 2
        '
        'lblKilo
        '
        Me.lblKilo.AutoSize = True
        Me.lblKilo.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKilo.ForeColor = System.Drawing.Color.Maroon
        Me.lblKilo.Location = New System.Drawing.Point(151, 297)
        Me.lblKilo.Name = "lblKilo"
        Me.lblKilo.Size = New System.Drawing.Size(321, 37)
        Me.lblKilo.TabIndex = 4
        Me.lblKilo.Text = "0000000000000000"
        '
        'cboUnit
        '
        Me.cboUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnit.FormattingEnabled = True
        Me.cboUnit.Items.AddRange(New Object() {"Kilometers", "Miles"})
        Me.cboUnit.Location = New System.Drawing.Point(158, 139)
        Me.cboUnit.Name = "cboUnit"
        Me.cboUnit.Size = New System.Drawing.Size(297, 32)
        Me.cboUnit.TabIndex = 6
        Me.cboUnit.Text = "Choose Unit"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(512, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(629, 450)
        Me.Controls.Add(Me.cboUnit)
        Me.Controls.Add(Me.lblKilo)
        Me.Controls.Add(Me.lblMile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUnity)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUnity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMile As Label
    Friend WithEvents lblKilo As Label
    Friend WithEvents cboUnit As ComboBox
    Friend WithEvents Button1 As Button
End Class
