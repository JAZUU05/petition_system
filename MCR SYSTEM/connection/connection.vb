Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost; port=3306 ;user=root ;password=;database=db_petition")
        'Return New SqlConnection("Data Source=JAZZUU\SQLSERVER;Initial Catalog=db_petition;Integrated Security=True")

    End Function
    Public con As MySqlConnection = mysqldb()

End Module
