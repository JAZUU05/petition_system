<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCF))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCFAddDeath = New System.Windows.Forms.Button()
        Me.btnCFAddMarriage = New System.Windows.Forms.Button()
        Me.btnCFAddBirth = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCFAddDeath)
        Me.Panel1.Controls.Add(Me.btnCFAddMarriage)
        Me.Panel1.Controls.Add(Me.btnCFAddBirth)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 261)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnCFAddDeath
        '
        Me.btnCFAddDeath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCFAddDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCFAddDeath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCFAddDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCFAddDeath.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCFAddDeath.Location = New System.Drawing.Point(83, 170)
        Me.btnCFAddDeath.Name = "btnCFAddDeath"
        Me.btnCFAddDeath.Size = New System.Drawing.Size(170, 40)
        Me.btnCFAddDeath.TabIndex = 11
        Me.btnCFAddDeath.Text = "DEATH"
        Me.btnCFAddDeath.UseVisualStyleBackColor = False
        '
        'btnCFAddMarriage
        '
        Me.btnCFAddMarriage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCFAddMarriage.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCFAddMarriage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCFAddMarriage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCFAddMarriage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCFAddMarriage.Location = New System.Drawing.Point(83, 105)
        Me.btnCFAddMarriage.Name = "btnCFAddMarriage"
        Me.btnCFAddMarriage.Size = New System.Drawing.Size(170, 40)
        Me.btnCFAddMarriage.TabIndex = 10
        Me.btnCFAddMarriage.Text = " MARRIAGE"
        Me.btnCFAddMarriage.UseVisualStyleBackColor = False
        '
        'btnCFAddBirth
        '
        Me.btnCFAddBirth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCFAddBirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCFAddBirth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCFAddBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCFAddBirth.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCFAddBirth.Location = New System.Drawing.Point(83, 44)
        Me.btnCFAddBirth.Name = "btnCFAddBirth"
        Me.btnCFAddBirth.Size = New System.Drawing.Size(170, 40)
        Me.btnCFAddBirth.TabIndex = 9
        Me.btnCFAddBirth.Text = "LIVE BIRTH"
        Me.btnCFAddBirth.UseVisualStyleBackColor = False
        '
        'frmAddCF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddCF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD PETITION CF"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCFAddMarriage As Button
    Friend WithEvents btnCFAddBirth As Button
    Friend WithEvents btnCFAddDeath As Button
    Friend WithEvents Label1 As Label
End Class
