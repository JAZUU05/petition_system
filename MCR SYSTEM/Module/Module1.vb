Imports MySql.Data.MySqlClient
Module Module1
    'Public con As MySqlConnection = mysqldb()
    Public dt As New DataTable
    Public da As New mySqlDataAdapter
    Public cmd As New MySqlCommand
    Public sql As String
    Public GLOBALid As Integer = Nothing
    Dim ds As New DataSet


    Public Sub reportsAll(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New MySqlDataAdapter(sql, con)
            da.Fill(ds)

            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\reports\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                .Displaytoolbar = True
                .DisplayStatusbar = True
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With

        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        Finally
            con.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub loaddtg(ByVal DataGrid As DataGridView, ByVal query As String)
        'Try

        '    con.Open()
        '    da = New SqlDataAdapter(query, con)
        '    dt = New DataTable
        '    da.Fill(dt)

        '    DataGrid.DataSource = dt




        'Catch ex As Exception

        'End Try
        'con.Close()
        'da.Dispose()

        Try

            con.Open()
            da = New MySqlDataAdapter(query, con)
            dt = New DataTable
            da.Fill(dt)

            DataGrid.DataSource = dt



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
        'dt.Dispose()

        Dim sql1 As String = "SELECT COUNT(petition_id) as TOTAL FROM petition_record WHERE type_doc = '" & SearchForm.type & "'"
        Try
            con.Open()
            With cmd
                .CommandText = sql1
                .Connection = con
                'Dim count As Int32 = CType(.ExecuteScalar(), Int32)
                'Me.Text = "TOTAL NUMBER OF RECORDS " + String.Format("{0}", count)
                SearchForm.Text = "TOTAL NUMBER OF RECORDS " + dt.Rows.Count.ToString()

            End With



            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
