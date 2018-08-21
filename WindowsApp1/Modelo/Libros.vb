Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace WindowsFormsApp1.Modelo
    Public Class Libros
        Private myVar2 As PictureBox
        Private myVar3 As String
        Private myVar4 As String
        Private myVar5 As String
        Private myVar7 As String
        Private myVar6 As Integer

        Public Property idlibro As Integer
            Get
                Return myVar6
            End Get
            Set(ByVal value As Integer)
                myVar6 = value
            End Set
        End Property

        Public Property titulo As String
            Get
                Return myVar7
            End Get
            Set(ByVal value As String)
                myVar7 = value
            End Set
        End Property

        Public Property autor As String
            Get
                Return myVar3
            End Get
            Set(ByVal value As String)
                myVar3 = value
            End Set
        End Property

        Public Property editorial As String
            Get
                Return myVar4
            End Get
            Set(ByVal value As String)
                myVar4 = value
            End Set
        End Property

        Public Property portada As PictureBox
            Get
                Return myVar2
            End Get
            Set(ByVal value As PictureBox)
                myVar2 = value
            End Set
        End Property
    End Class
End Namespace
