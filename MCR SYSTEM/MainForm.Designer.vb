<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.PETITIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.search = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailedSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCCE = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchCF = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 450)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AllowDrop = True
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.search, Me.TimeToolStripMenuItem, Me.DATEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(796, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add_new, Me.HeadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'add_new
        '
        Me.add_new.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PETITIONToolStripMenuItem})
        Me.add_new.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_new.Name = "add_new"
        Me.add_new.Size = New System.Drawing.Size(231, 24)
        Me.add_new.Text = "Add New Document"
        '
        'PETITIONToolStripMenuItem
        '
        Me.PETITIONToolStripMenuItem.Name = "PETITIONToolStripMenuItem"
        Me.PETITIONToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.PETITIONToolStripMenuItem.Text = "PETITION"
        '
        'HeadToolStripMenuItem
        '
        Me.HeadToolStripMenuItem.Name = "HeadToolStripMenuItem"
        Me.HeadToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HeadToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.HeadToolStripMenuItem.Text = "Head"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(231, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'search
        '
        Me.search.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailedSearch})
        Me.search.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(90, 24)
        Me.search.Text = "SEARCH"
        '
        'DetailedSearch
        '
        Me.DetailedSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchCCE, Me.SearchCF})
        Me.DetailedSearch.Font = New System.Drawing.Font("Century Schoolbook", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailedSearch.Name = "DetailedSearch"
        Me.DetailedSearch.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.DetailedSearch.Size = New System.Drawing.Size(197, 24)
        Me.DetailedSearch.Text = "SEARCH"
        '
        'SearchCCE
        '
        Me.SearchCCE.Name = "SearchCCE"
        Me.SearchCCE.Size = New System.Drawing.Size(202, 24)
        Me.SearchCCE.Text = "PETITION CCE"
        '
        'SearchCF
        '
        Me.SearchCF.Name = "SearchCF"
        Me.SearchCF.Size = New System.Drawing.Size(202, 24)
        Me.SearchCF.Text = "PETITION CFN"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TimeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.TimeToolStripMenuItem.Text = "TIME"
        '
        'DATEToolStripMenuItem
        '
        Me.DATEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DATEToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATEToolStripMenuItem.Name = "DATEToolStripMenuItem"
        Me.DATEToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.DATEToolStripMenuItem.Text = "DATE"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PETITION SYSTEM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents add_new As ToolStripMenuItem
    Friend WithEvents search As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetailedSearch As ToolStripMenuItem
    Friend WithEvents SearchCCE As ToolStripMenuItem
    Friend WithEvents SearchCF As ToolStripMenuItem
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PETITIONToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HeadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DATEToolStripMenuItem As ToolStripMenuItem
End Class
