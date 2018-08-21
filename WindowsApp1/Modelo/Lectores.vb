Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsFormsApp1.Modelo
    Public Class Lectores
        Private myVar As String
        Private myV As String
        Private myVar2 As String
        Private myVar3 As String
        Private myVar4 As String
        Private myVar5 As String
        Private myVar7 As String
        Private myVar6 As Integer

        Public Property idlectores As Integer
            Get
                Return myVar6
            End Get
            Set(ByVal value As Integer)
                myVar6 = value
            End Set
        End Property

        Public Property clave As String
            Get
                Return myVar7
            End Get
            Set(ByVal value As String)
                myVar7 = value
            End Set
        End Property

        Public Property direccion As String
            Get
                Return myVar3
            End Get
            Set(ByVal value As String)
                myVar3 = value
            End Set
        End Property

        Public Property apellido2 As String
            Get
                Return myVar4
            End Get
            Set(ByVal value As String)
                myVar4 = value
            End Set
        End Property

        Public Property apellido1 As String
            Get
                Return myVar2
            End Get
            Set(ByVal value As String)
                myVar2 = value
            End Set
        End Property

        Public Property nombre2 As String
            Get
                Return myVar5
            End Get
            Set(ByVal value As String)
                myVar5 = value
            End Set
        End Property

        Public Property nombre1 As String
            Get
                Return myV
            End Get
            Set(ByVal value As String)
                myV = value
            End Set
        End Property

        Public Property telefono As String
            Get
                Return myVar
            End Get
            Set(ByVal value As String)
                myVar = value
            End Set
        End Property
    End Class
End Namespace
