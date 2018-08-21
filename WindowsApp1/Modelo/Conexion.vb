Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApp1.Modelo
    Public Class Conexion
        Protected conexion As SqlConnection
        Protected comando As SqlCommand
        Protected lector As SqlDataReader
        Protected tabla As DataTable

        Protected Sub New()
            tabla = New DataTable()
        End Sub

        Protected Sub conetar()
            Dim url As String = "Data Source=.\SQLEXPRESS;Database=biblioteca;Integrated Security=True;"
            conexion = New SqlConnection(url)
            conexion.Open()
        End Sub

        Protected Sub desconectar()
            conexion.Close()
        End Sub
    End Class
End Namespace
