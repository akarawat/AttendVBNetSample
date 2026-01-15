Imports System.Data.SqlClient
Imports System.Configuration

Public Class DBClass

    Private ReadOnly ConnStr As String

    Public Sub New()
        ConnStr = ConfigurationManager.ConnectionStrings("BT_HR").ConnectionString
    End Sub

    Private Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnStr)
    End Function

    '★ ExecuteNonQuery
    Public Function ExecuteNonQuery(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Integer
        Dim affected As Integer = 0
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                affected = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return affected
    End Function

    '★ ExecuteScalar
    Public Function ExecuteScalar(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As Object
        Dim result As Object = Nothing
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                result = cmd.ExecuteScalar()
            End Using
        End Using
        Return result
    End Function

    '★ SELECT → DataTable
    Public Function GetDataTable(query As String, Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(query, conn)
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Using r = cmd.ExecuteReader()
                    dt.Load(r)
                End Using
            End Using
        End Using
        Return dt
    End Function

    '★ Exec Stored Procedure → DataTable
    Public Function ExecSPToTable(spName As String, Optional parameters As List(Of SqlParameter) = Nothing) As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(spName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                If parameters IsNot Nothing Then
                    cmd.Parameters.AddRange(parameters.ToArray())
                End If
                Using r = cmd.ExecuteReader()
                    dt.Load(r)
                End Using
            End Using
        End Using
        Return dt
    End Function
    Public Function ExecSP(spName As String, parameters As List(Of SqlParameter)) As Integer
        Dim rows As Integer = 0
        Using conn = GetConnection()
            conn.Open()
            Using cmd As New SqlCommand(spName, conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddRange(parameters.ToArray())
                rows = cmd.ExecuteNonQuery()
            End Using
        End Using
        Return rows
    End Function

End Class
