Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.SqlClient
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApp1.Modelo
    Public Class UsuariosDAO
        Inherits Conexion

        Public Function login(ByVal u As Usuarios) As Usuarios
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select nombre1,nombre2,apellido1,apellido2,direccion from usuarios where nombreusuario=@user and clave=@clave and idperfil=@perfil"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            comando.Parameters.AddWithValue("@clave", u.clave)
            comando.Parameters.AddWithValue("@perfil", u.idperfil)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                Dim i As Integer = 0
                u.nombre1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.direccion = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                desconectar()
                Return u
            End If

            lector.Close()
            comando = Nothing
            comando = conexion.CreateCommand()
            comando.CommandText = "select nombre1,nombre2,apellido1,apellido2,direccion from usuarios where nombreusuario=@user and clave=@clave"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            comando.Parameters.AddWithValue("@clave", u.clave)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                Dim i As Integer = 0
                u.idperfil = 0
                u.nombre1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.direccion = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                desconectar()
                Return u
            End If

            lector.Close()
            comando = Nothing
            comando = conexion.CreateCommand()
            comando.CommandText = "select nombre1,nombre2,apellido1,apellido2,direccion from usuarios where nombreusuario=@user"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                Dim i As Integer = 0
                u.clave = Nothing
                u.nombre1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.direccion = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                desconectar()
                Return u
            Else
                u = Nothing
                desconectar()
                Return u
            End If
        End Function

        Public Function ObtenerUsuario(ByVal nu As String) As Usuarios
            Dim u As Usuarios = Nothing
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from usuarios where nombreusuario=@user"
            comando.Parameters.AddWithValue("@user", nu)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                u = New Usuarios()
                Dim i As Integer = 0
                u.nombreusuario = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.clave = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.nombre2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido1 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.apellido2 = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.direccion = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.idperfil = lector.GetInt32(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                desconectar()
            End If

            Return u
        End Function

        Public Function obtenerRegistros(ByVal busca As String) As DataTable
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from usuarios where nombreusuario like @nomb or apellido1 like @ape"
            comando.Parameters.AddWithValue("@nomb", busca & "%")
            comando.Parameters.AddWithValue("@ape", busca & "%")
            lector = comando.ExecuteReader()
            tabla.Load(lector)
            desconectar()
            lector.Close()
            Return tabla
        End Function

        Public Sub registrarUsuario(ByVal u As Usuarios)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " INSERT INTO usuarios values(@user,@clave,@n1,@n2,@a1,@a2,@dir,@perfil)"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            comando.Parameters.AddWithValue("@clave", u.clave)
            comando.Parameters.AddWithValue("@n1", u.nombre1)
            comando.Parameters.AddWithValue("@n2", u.nombre2)
            comando.Parameters.AddWithValue("@a1", u.apellido1)
            comando.Parameters.AddWithValue("@a2", u.apellido2)
            comando.Parameters.AddWithValue("@dir", u.direccion)
            comando.Parameters.AddWithValue("@perfil", u.idperfil)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub actualizarUsuario(ByVal u As Usuarios)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " update usuarios set clave=@clave, nombre1=@n1, nombre2=@n2,apellido1=@a1,apellido2=@a2,direccion=@dir,idperfil=@perfil where nombreusuario=@user"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            comando.Parameters.AddWithValue("@clave", u.clave)
            comando.Parameters.AddWithValue("@n1", u.nombre1)
            comando.Parameters.AddWithValue("@n2", u.nombre2)
            comando.Parameters.AddWithValue("@a1", u.apellido1)
            comando.Parameters.AddWithValue("@a2", u.apellido2)
            comando.Parameters.AddWithValue("@dir", u.direccion)
            comando.Parameters.AddWithValue("@perfil", u.idperfil)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub eliminarrUsuario(ByVal u As Usuarios)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " delete from usuarios  where nombreusuario=@user"
            comando.Parameters.AddWithValue("@user", u.nombreusuario)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub
    End Class
End Namespace
