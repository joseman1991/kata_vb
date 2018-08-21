Public Class Bienvanido


    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        addImagen()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub addImagen()
        pictureBox1.ImageLocation = "recursos/libro.png"

    End Sub
    Private Sub Bienvanido_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Close()
    End Sub


    Private Sub añadirUnNuevoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles añadirUnNuevoUsuarioToolStripMenuItem.Click
        Dim user As Usuario = New Usuario()
        user.ShowDialog()
    End Sub

    Private Sub actualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles actualizarToolStripMenuItem.Click
        Dim user As Usuario = New Usuario
        user.opcion = 1
        user.ShowDialog()
    End Sub

    Private Sub eliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem.Click
        Dim user As Usuario = New Usuario
        user.opcion = 2
        user.ShowDialog()
    End Sub

    Private Sub añadirLibroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles añadirLibroToolStripMenuItem.Click
        Dim l As libro = New libro
        l.inicializarCodigo
        l.ShowDialog()
    End Sub

    Private Sub eliminarToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem3.Click
        Dim l As New libro()
        l.opcion = 2
        l.ShowDialog()
    End Sub

    Private Sub eliminarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem2.Click
        Dim l As libro = New libro
        l.opcion = 1
        l.ShowDialog()
    End Sub

    Private Sub añdirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles añdirToolStripMenuItem.Click
        Dim lector As Lector = New Lector
        lector.inicializarCodigo
        lector.ShowDialog()
    End Sub

    Private Sub actualizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles actualizarToolStripMenuItem1.Click
        Dim lector As Lector = New Lector
        lector.opcion = 1
        lector.ShowDialog()
    End Sub

    Private Sub eliminarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles eliminarToolStripMenuItem1.Click
        Dim lector As Lector = New Lector
        lector.opcion = 2
        lector.ShowDialog()
    End Sub
End Class