Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApp1.Modelo
    Public Class LectoresDAO
        Inherits Conexion

        Public Function ObtenerLector(ByVal nu As String) As Lectores
            Dim u As Lectores = Nothing
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from Lectores where idlectores=@user"
            comando.Parameters.AddWithValue("@user", nu)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                u = New Lectores()
                Dim i As Integer = 0
                u.idlectores = lector.GetInt32(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.direccion = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.telefono = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                desconectar()
            End If

            Return u
        End Function

        Public Function idlectores() As Integer
            Dim id As Integer = 1
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select max(idlectores) from Lectores"
            lector = comando.ExecuteReader()

            If lector.Read() Then
                id = lector.GetInt32(0)
            End If

            desconectar()
            Return id + 1
        End Function

        Public Function obtenerRegistros(ByVal busca As String) As DataTable
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from Lectores where nombre1 like @nomb or apellido1 like @ape"
            comando.Parameters.AddWithValue("@nomb", busca & "%")
            comando.Parameters.AddWithValue("@ape", busca & "%")
            lector = comando.ExecuteReader()
            tabla.Load(lector)
            desconectar()
            lector.Close()
            Return tabla
        End Function

        Public Sub registrarLector(ByVal u As Lectores)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " INSERT INTO Lectores values(@user,@n1,@n2,@a1,@a2,@dir,@perfil)"
            comando.Parameters.AddWithValue("@user", u.idlectores)
            comando.Parameters.AddWithValue("@n1", u.nombre1)
            comando.Parameters.AddWithValue("@n2", u.nombre2)
            comando.Parameters.AddWithValue("@a1", u.apellido1)
            comando.Parameters.AddWithValue("@a2", u.apellido2)
            comando.Parameters.AddWithValue("@dir", u.direccion)
            comando.Parameters.AddWithValue("@perfil", u.telefono)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub actualizarLector(ByVal u As Lectores)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " update Lectores set  nombre1=@n1, nombre2=@n2,apellido1=@a1,apellido2=@a2,direccion=@dir,telefono=@telefono where idlectores=@user"
            comando.Parameters.AddWithValue("@user", u.idlectores)
            comando.Parameters.AddWithValue("@n1", u.nombre1)
            comando.Parameters.AddWithValue("@n2", u.nombre2)
            comando.Parameters.AddWithValue("@a1", u.apellido1)
            comando.Parameters.AddWithValue("@a2", u.apellido2)
            comando.Parameters.AddWithValue("@dir", u.direccion)
            comando.Parameters.AddWithValue("@telefono", u.telefono)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub eliminarrLector(ByVal u As Lectores)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " delete from Lectores  where idlectores=@user"
            comando.Parameters.AddWithValue("@user", u.idlectores)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub
    End Class
End Namespace
