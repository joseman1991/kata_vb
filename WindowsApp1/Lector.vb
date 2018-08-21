Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports WindowsApp1.WindowsFormsApp1.Modelo

Public Class Lector
    Private myVar As Integer

    Private udao As LectoresDAO

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        opcion = 0
        InitializeComponent()
        Me.udao = New LectoresDAO
        Me.addImagen
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
                    label1.Text = "Actualizar Lector"

                Else
                    button1.Text = "Eliminar"
                    label1.Text = "Eliminar Lector"

                End If

                nu.Enabled = False
            End If

            Me.myVar = Value
        End Set
    End Property

    Private Sub addImagen()
        pictureBox1.Image = Image.FromFile("recursos/lector.png")
        Try
            dataGridView1.DataSource = Me.udao.obtenerRegistros("")
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
            n1.Focus()
        Catch e As SqlException
            MessageBox.Show(Me, ("Error" + e.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub inicializarCodigo()
        Try
            nu.Text = Me.udao.idlectores.ToString
        Catch ex As SqlNullValueException
            nu.Text = "1"
        End Try

    End Sub
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim u As Lectores = New Lectores
        u.idlectores = Integer.Parse(nu.Text)
        u.nombre1 = n1.Text
        u.nombre2 = n2.Text
        u.apellido1 = a1.Text
        u.apellido2 = n2.Text
        u.direccion = dir.Text
        u.telefono = textBox1.Text
        Try
            Select Case (Me.opcion)
                Case 0
                    Me.udao.registrarLector(u)
                    MessageBox.Show(Me, "Lector registrado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.inicializarCodigo()
                Case 1
                    Me.udao.actualizarLector(u)
                    MessageBox.Show(Me, "Lector actualizado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Me.udao.eliminarrLector(u)
                    MessageBox.Show(Me, "Lector eliminado", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Select

            Dim dt As DataTable = CType(dataGridView1.DataSource, DataTable)
            If (Not (dt) Is Nothing) Then
                dt.Clear()
            End If

            dataGridView1.DataSource = Me.udao.obtenerRegistros("")
            Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As SqlException
            MessageBox.Show(Me, ("Error" + ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Close()
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

    Private Sub dataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles dataGridView1.MouseClick
        If (Me.opcion > 0) Then
            Dim valor As String = dataGridView1.Rows(dataGridView1.CurrentRow.Index).Cells(0).Value.ToString
            Dim u As Lectores = Me.udao.ObtenerLector(valor)
            nu.Text = u.idlectores.ToString
            n1.Text = u.nombre1
            n2.Text = u.nombre2
            a1.Text = u.apellido1
            a2.Text = u.apellido2
            dir.Text = u.direccion
            textBox1.Text = u.telefono
        End If
    End Sub
End Class