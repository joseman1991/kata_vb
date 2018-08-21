Imports System.Data.SqlClient
Imports WindowsApp1.WindowsFormsApp1.Modelo

Public Class Usuario

    Private myVar As Integer

    Private listaPerfiles As List(Of Perfiles)

    Private pdao As PerfilesDAO

    Private udao As UsuariosDAO


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        opcion = 0
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.pdao = New PerfilesDAO
        Me.udao = New UsuariosDAO
        addImagen()
    End Sub

    Private Sub addImagen()
        pictureBox1.Image = Image.FromFile("recursos/log.png")
        Try
            Me.pdao.obtenerPerfiles()
            Me.listaPerfiles = Me.pdao.ListaPerfiles
            Dim i As Integer = 0
            Do While (i < Me.listaPerfiles.Count)
                idp.Items.Add(Me.listaPerfiles(i).descripcion)
                i = (i + 1)
            Loop

            idp.DropDownStyle = ComboBoxStyle.DropDownList
            If (Me.listaPerfiles.Count > 0) Then
                idp.SelectedIndex = 0
            End If

            dataGridView1.DataSource = Me.udao.obtenerRegistros("")
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            n1.Focus()
        Catch e As SqlException
            MessageBox.Show(Me, ("Error" + e.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Property opcion As Integer
        Get
            Return Me.myVar
        End Get
        Set
            If (Value > 0) Then
                lblbusca.Show()
                busca.Show()

                If (Value = 1) Then
                    button1.Text = "Actualizar"
                    label1.Text = "Actualizar Usuario"

                Else
                    button1.Text = "Eliminar"
                    label1.Text = "Eliminar Usuario"
                End If

                nu.Enabled = False
            End If

            Me.myVar = Value
        End Set
    End Property


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim u As Usuarios = New Usuarios
        u.clave = clave.Text
        u.nombreusuario = nu.Text
        u.nombre1 = n1.Text
        u.nombre2 = n2.Text
        u.apellido1 = a1.Text
        u.apellido2 = n2.Text
        u.direccion = dir.Text
        u.idperfil = Me.listaPerfiles(idp.SelectedIndex).idperfil
        Try
            Select Case (Me.opcion)
                Case 0
                    Me.udao.registrarUsuario(u)
                    MessageBox.Show(Me, "Usuario registrado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 1
                    Me.udao.actualizarUsuario(u)
                    MessageBox.Show(Me, "Usuario actualizado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Me.udao.eliminarrUsuario(u)
                    MessageBox.Show(Me, "Usuario eliminado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            Dim dt As DataTable = CType(dataGridView1.DataSource, DataTable)
            dt.Clear()
            dataGridView1.DataSource = Me.udao.obtenerRegistros("")
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As SqlException
            MessageBox.Show(Me, ("Error" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
    End Sub

    Private Sub dataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dataGridView1.CellMouseClick
        If (Me.opcion > 0) Then
            Dim valor As String = dataGridView1.Rows(dataGridView1.CurrentRow.Index).Cells(0).Value.ToString
            Dim u As Usuarios = Me.udao.ObtenerUsuario(valor)
            clave.Text = u.clave
            nu.Text = u.nombreusuario
            n1.Text = u.nombre1
            n2.Text = u.nombre2
            a1.Text = u.apellido1
            a2.Text = u.apellido2
            dir.Text = u.direccion
            Dim i As Integer = 0
            Do While (i < idp.Items.Count)
                If (Me.listaPerfiles(i).idperfil = u.idperfil) Then
                    idp.SelectedItem = Me.listaPerfiles(i).descripcion
                End If

                i = (i + 1)
            Loop

        End If
    End Sub

    Private Sub busca_KeyUp(sender As Object, e As KeyEventArgs) Handles busca.KeyUp
        Try
            Dim dt As DataTable = CType(dataGridView1.DataSource, DataTable)
            dt.Clear()
            dataGridView1.DataSource = Me.udao.obtenerRegistros(busca.Text)
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As SqlException
            MessageBox.Show(Me, ("Error" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class