Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApp1.Modelo
    Public Class PerfilesDAO
        Inherits Conexion

        Private myVar As List(Of Perfiles)

        Public Sub New()
            ListaPerfiles = New List(Of Perfiles)()
        End Sub

        Public Property ListaPerfiles As List(Of Perfiles)
            Get
                Return myVar
            End Get
            Set(ByVal value As List(Of Perfiles))
                myVar = value
            End Set
        End Property

        Public Sub obtenerPerfiles()
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from perfiles"
            lector = comando.ExecuteReader()

            While lector.Read()
                Dim p As Perfiles = New Perfiles()
                p.idperfil = lector.GetInt32(0)
                p.descripcion = lector.GetString(1)
                ListaPerfiles.Add(p)
            End While

            desconectar()
        End Sub
    End Class
End Namespace
