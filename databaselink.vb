Imports System.Data.OleDb
Module databaselink
    Public dbconnection As OleDbConnection ' Creates conection between access database and .net. It is a variable and its data type is Oledb connection 
    Public dbcommand As OleDbCommand       ' It instruct the database to perform specific task  
    Public dbadapter As OleDbDataAdapter   ' it creates a set of data so that we can perform Oledb command
    Public connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= banking.mdb"
    Public ds As New DataSet 'creates a new dataset
    Public datatable As New DataTable 'creates a new datatable

    Function loaddb(ByVal sql As String)
        'creates new dbconnection
        dbconnection = New OleDbConnection(connectionString)
        'creates new dbcommand
        dbcommand = New OleDbCommand(sql, dbconnection)
        'opens the dbconnection
        dbconnection.Open()
        'creates new dbadapter
        dbadapter = New OleDbDataAdapter(sql, dbconnection)
        'creates new ds(dataset)
        ds = New DataSet("datatable")
        'fills the dbadapter
        dbadapter.Fill(ds, "datatable")
        '  create new instance of table so that row can be accessed
        datatable = ds.Tables("datatable")
        'closes the dbconnection
        dbconnection.Close()
        Return datatable
    End Function
    Function encryption(ByVal text As String)
        'codes for encryption
        Dim a, b, r, t As String
        Dim c As Integer
        For i = 1 To Len(text)
            a = Asc(Mid(text, i, 1))
            c = a * 2
            r = Chr(5 + i)
            b = Chr(c)
            t = t & b & r
        Next
        'returns value of t
        Return t
    End Function
    Sub adddata(ByVal sql As String)
        'module for adding the new records
        Try
            'creates new dbconnection
            dbconnection = New OleDbConnection(connectionString)
            'opens the dbconnection
            dbconnection.Open()
            'creates new dbcommand
            dbcommand = New OleDbCommand(sql, dbconnection)
            'executes the command
            dbcommand.ExecuteNonQuery()
            'closes the dbconnection
            dbconnection.Close()
            MsgBox("Process completed successfully", MsgBoxStyle.Information, "SUCCESS")
        Catch exception As Exception
            MsgBox(exception.Message)
        End Try
    End Sub
    Sub delete(ByVal sql As String)
        'module for deletion of record
        'creates new dbconnection
        dbconnection = New OleDbConnection(connectionString)
        'opens the dbconnection
        dbconnection.Open()
        'creates new dbcommand
        dbcommand = New OleDbCommand(sql, dbconnection)
        'creates new dbadapter
        dbadapter = New OleDbDataAdapter
        ds = New DataSet
        'executes the command
        dbcommand.ExecuteNonQuery()
        'closes the dbconnection
        dbconnection.Close()
    End Sub
    Function updaterecord(ByVal sql As String)
        'module for updating a record
        Try
            'opens the dbconnection
            dbconnection.Open()
            'creates new dbcommand
            dbcommand = New OleDbCommand(sql, dbconnection)
            'executes the command
            dbcommand.ExecuteNonQuery()
            'closes the dbconnection
            dbconnection.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return (0)
    End Function

    Function id(ByVal sql As String)
        'module for autogeneration of account id,customer id and receipt id
        Dim dt As DataTable = loaddb(sql)
        Dim row As DataRow
        Dim accountid As Integer
        For Each row In dt.Rows
            If accountid < row(0) Then accountid = row(0)
        Next
        'add 1 to the existing account id
        Return (accountid + 1)
    End Function

    Sub txtboxreset(ByVal value As GroupBox)
        'clears all the textbox of the groupbox
        For Each Control As Control In value.Controls
            Select Case Control.GetType.ToString
                Case GetType(TextBox).ToString
                    Control.Text = String.Empty
            End Select
        Next
    End Sub
End Module
