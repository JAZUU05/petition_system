Imports MySql.Data.MySqlClient
Module connection
    Public Function mysqldb() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=db_petition")
        'Return New SqlConnection("Data Source=JAZZUU\SQLSERVER;Initial Catalog=db_petition;Integrated Security=True")

    End Function
    Public con As MySqlConnection = mysqldb()

End Module
