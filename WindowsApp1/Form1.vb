Imports System.Data.SqlClient
Imports WindowsApp1.WindowsFormsApp1.Modelo

Public Class Form1


    Private listaPerfiles As List(Of Perfiles)
    Private pdao As PerfilesDAO
    Private udao As UsuariosDAO
    Private b As New Bienvanido()


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        pdao = New PerfilesDAO()
        udao = New UsuariosDAO()
        addImagen()
        user.Text = "kata"
        clave.Text = "123456"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub


    Private Sub addImagen()
        pictureBox1.Image = Image.FromFile("recursos/log.png")

        Try
            pdao.obtenerPerfiles()
            listaPerfiles = pdao.ListaPerfiles

            For i As Integer = 0 To listaPerfiles.Count - 1
                comboBox1.Items.Add(listaPerfiles(i).descripcion)
            Next

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList

            If listaPerfiles.Count > 0 Then
                comboBox1.SelectedIndex = 0
            End If

            user.Focus()
        Catch e As SqlException
            MessageBox.Show(Me, "Error" & e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim u As Usuarios = New Usuarios()
        u.nombreusuario = user.Text
        u.clave = clave.Text
        u.idperfil = listaPerfiles(comboBox1.SelectedIndex).idperfil

        Try
            u = udao.login(u)

            If u IsNot Nothing Then

                If u.idperfil = 0 Then
                    MessageBox.Show(Me, "Error " & "No tienes este perfil asignado", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                    Return
                End If

                If u.clave IsNot Nothing Then
                    '     b As New Bienvanido()
                    '     b.FormClosed += New FormClosedEventHandler(eventoCerrar)
                    Me.Hide()
                    user.Clear()
                    clave.Clear()
                    b.Show()
                Else
                    MessageBox.Show(Me, "Error " & "Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                End If
            Else
                MessageBox.Show(Me, "Error " & "Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            End If

        Catch ex As SqlException
            MessageBox.Show(Me, "Error " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Close()

    End Sub

    Public Sub eventoCerrar(ByVal senser As Object, ByVal e As FormClosedEventArgs)
        Me.Show()
    End Sub
End Class



