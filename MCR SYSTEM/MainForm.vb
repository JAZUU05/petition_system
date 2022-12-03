Imports System.Data.SqlClient
Public Class MainForm
    Dim session As String

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles search.Click
        session = ""
        session = "search"
    End Sub

    Private Sub TYPEOFDOCUMENTSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub main_form(sender As Object, e As EventArgs) Handles MyBase.Load
        'add_new.Visible = False
        'search.Visible = False
        'help.Visible = False
        'LogInForm.ShowDialog()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Add_new_Click(sender As Object, e As EventArgs) Handles add_new.Click

    End Sub

    Private Sub PETITIONToolStripMenuItem_Click(sender As Object, e As EventArgs)

        With frmAddCCE
            .Label1.Text = "CCE-"
            .ShowDialog()
        End With

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DETAILEDSEARCHToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailedSearch.Click
        'With SearchForm

        '    .ShowDialog()
        'End With
    End Sub

    Private Sub PETITIONCCEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCCE.Click

        'With add1
        '    .txtPet.Text = "CCE-"
        '    frmSearchCCE.ShowDialog()
        'End With
        With Form3
            .type = "CCE"
        End With
        With frmSearchCCE

            .Label1.Text = "CCE"
            .ShowDialog()
        End With

    End Sub

    Private Sub PETITIONCFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchCF.Click
        With Form3
            .type = "CFN"
        End With
        With frmSearchCF
            .Label1.Text = "CFN"

            .ShowDialog()
        End With
    End Sub

    Private Sub FILEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FILEToolStripMenuItem.Click
        session = ""

        session = "file"
    End Sub

    Private Sub AddCF_Click(sender As Object, e As EventArgs)
        With frmAddCF
            .Label1.Text = "CF-"
            .ShowDialog()
        End With
    End Sub

    Private Sub LastEntered_Click(sender As Object, e As EventArgs)
        Recent.ShowDialog()
    End Sub


    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'con.Open()

        'sql = "SELECT * FROM login"

        'da = New SqlDataAdapter(sql, con)
        'dt = New DataTable
        'da.Fill(dt)


        'Dim myrpt As CrystalDecisions.CrystalReports.Engine.ReportDocument
        'myrpt = New CrystalReport2
        'viewdata()
        ''myrpt.Database.Tables("DataTable1").SetDataSource(dt)
        'myrpt.SetDataSource(dt)
        'Form2.CrystalReportViewer1.ReportSource = Nothing
        'Form2.CrystalReportViewer1.ReportSource = myrpt
        'Form2.ShowDialog()
        'Form2.Dispose()
        'con.Close()
        'da.Dispose()

    End Sub
    Sub viewdata()




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Form2.ShowDialog()


    End Sub

    Private Sub MainForm_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        'MsgBox("Sure", MsgBoxStyle.YesNo, "Ask")
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'MsgBox("Sure", MsgBoxStyle.YesNo, "Ask")
        'MsgBox("Sure", MsgBoxStyle.YesNo, "Ask")
        If MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.ExitThread()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        'MsgBox("Sure", MsgBoxStyle.YesNo, "Ask")
    End Sub

    Private Sub PETITIONToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PETITIONToolStripMenuItem.Click
        add1.ShowDialog()
    End Sub

    Private Sub HeadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeadToolStripMenuItem.Click
        List.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeToolStripMenuItem.Text = DateTime.Now.ToString("hh:mm:ss tt") ' tt with AM
        DATEToolStripMenuItem.Text = DateTime.Now.ToString("MMMM dd, yyyy")
    End Sub
End Class
