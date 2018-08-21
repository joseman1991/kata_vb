Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApp1.Modelo
    Public Class Perfiles
        Private myVar As Integer
        Private myVar2 As String

        Public Property descripcion As String
            Get
                Return myVar2
            End Get
            Set(ByVal value As String)
                myVar2 = value
            End Set
        End Property

        Public Property idperfil As Integer
            Get
                Return myVar
            End Get
            Set(ByVal value As Integer)
                myVar = value
            End Set
        End Property
    End Class
End Namespace
