<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCCE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCCE))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCCESearchDeath = New System.Windows.Forms.Button()
        Me.btnCCESearchMarriage = New System.Windows.Forms.Button()
        Me.btnCCESearchBirth = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnCCESearchDeath)
        Me.Panel1.Controls.Add(Me.btnCCESearchMarriage)
        Me.Panel1.Controls.Add(Me.btnCCESearchBirth)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 261)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(142, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'btnCCESearchDeath
        '
        Me.btnCCESearchDeath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCCESearchDeath.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCCESearchDeath.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCCESearchDeath.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCCESearchDeath.Location = New System.Drawing.Point(83, 170)
        Me.btnCCESearchDeath.Name = "btnCCESearchDeath"
        Me.btnCCESearchDeath.Size = New System.Drawing.Size(170, 40)
        Me.btnCCESearchDeath.TabIndex = 11
        Me.btnCCESearchDeath.Text = "DEATH"
        Me.btnCCESearchDeath.UseVisualStyleBackColor = False
        '
        'btnCCESearchMarriage
        '
        Me.btnCCESearchMarriage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCCESearchMarriage.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCCESearchMarriage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCCESearchMarriage.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCCESearchMarriage.Location = New System.Drawing.Point(83, 105)
        Me.btnCCESearchMarriage.Name = "btnCCESearchMarriage"
        Me.btnCCESearchMarriage.Size = New System.Drawing.Size(170, 40)
        Me.btnCCESearchMarriage.TabIndex = 10
        Me.btnCCESearchMarriage.Text = "MARRIAGE"
        Me.btnCCESearchMarriage.UseVisualStyleBackColor = False
        '
        'btnCCESearchBirth
        '
        Me.btnCCESearchBirth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCCESearchBirth.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCCESearchBirth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCCESearchBirth.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCCESearchBirth.Location = New System.Drawing.Point(83, 44)
        Me.btnCCESearchBirth.Name = "btnCCESearchBirth"
        Me.btnCCESearchBirth.Size = New System.Drawing.Size(170, 40)
        Me.btnCCESearchBirth.TabIndex = 9
        Me.btnCCESearchBirth.Text = "LIVE BIRTH"
        Me.btnCCESearchBirth.UseVisualStyleBackColor = False
        '
        'frmSearchCCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(341, 261)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchCCE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEARCH PETITION CCE"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCCESearchMarriage As Button
    Friend WithEvents btnCCESearchBirth As Button
    Friend WithEvents btnCCESearchDeath As Button
    Friend WithEvents Label1 As Label
End Class
