Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports WindowsApp1.WindowsFormsApp1.Modelo

Public Class libro

    Private myVar As Integer
    Private udao As LibrosDAO = New LibrosDAO
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.addImagen()
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
                    button3.Text = "Actualizar"
                    label1.Text = "Actualizar Libro"

                Else
                    button3.Text = "Eliminar"
                    label1.Text = "Eliminar Libro"
                End If

                nu.Enabled = False
            End If

            Me.myVar = Value
        End Set
    End Property

    Private Sub addImagen()
        pictureBox1.Image = Image.FromFile("recursos/sin_portada.png")
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
            nu.Text = Me.udao.idLibros.ToString
        Catch ex As SqlNullValueException
            nu.Text = "1"
        End Try

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim u As Libros = New Libros
        u.idlibro = Integer.Parse(nu.Text)
        u.titulo = n1.Text
        u.editorial = n2.Text
        u.autor = a1.Text
        u.portada = New PictureBox
        u.portada.Image = pictureBox1.Image
        Try
            Select Case (Me.opcion)
                Case 0
                    Me.udao.registrarLibro(u)
                    MessageBox.Show(Me, "Libro registrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.inicializarCodigo()
                Case 1
                    Me.udao.actualizarLibro(u)
                    MessageBox.Show(Me, "Libro actualizado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 2
                    Me.udao.eliminarrLibro(u)
                    MessageBox.Show(Me, "Libro eliminado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' Se crea el OpenFileDialog
        Dim dialog As OpenFileDialog = New OpenFileDialog
        ' Se muestra al usuario esperando una acciÉn
        Dim result As DialogResult = dialog.ShowDialog
        ' Si seleccionÉ un archivo (asumiendo que es una imagen lo que seleccionÉ)
        ' la mostramos en el PictureBox de la inferfaz
        If (result = DialogResult.OK) Then
            pictureBox1.Image = Image.FromFile(dialog.FileName)
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

    Private Sub dataGridView1_DoubleClick(sender As Object, e As EventArgs)

    End Sub

    Private Sub dataGridView1_Click(sender As Object, e As EventArgs) Handles dataGridView1.Click
        If (Me.opcion > 0) Then
            Dim valor As String = dataGridView1.Rows(dataGridView1.CurrentRow.Index).Cells(0).Value.ToString
            If (Not (valor) Is Nothing) Then
                Dim u As Libros = Me.udao.ObtenerLibro(valor)
                nu.Text = u.idlibro.ToString
                n1.Text = u.titulo
                n2.Text = u.editorial
                a1.Text = u.autor
                pictureBox1.Image = u.portada.Image
            End If
        End If
    End Sub
End Class