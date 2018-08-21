<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bienvanido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.usuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.añadirUnNuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.actualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.libroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.añadirLibroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.añdirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.actualizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.usuarioToolStripMenuItem, Me.libroToolStripMenuItem, Me.lectoresToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(744, 24)
        Me.menuStrip1.TabIndex = 8
        Me.menuStrip1.Text = "menuStrip1"
        '
        'usuarioToolStripMenuItem
        '
        Me.usuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.añadirUnNuevoUsuarioToolStripMenuItem, Me.actualizarToolStripMenuItem, Me.eliminarToolStripMenuItem})
        Me.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem"
        Me.usuarioToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.usuarioToolStripMenuItem.Text = "Usuario"
        '
        'añadirUnNuevoUsuarioToolStripMenuItem
        '
        Me.añadirUnNuevoUsuarioToolStripMenuItem.Name = "añadirUnNuevoUsuarioToolStripMenuItem"
        Me.añadirUnNuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.añadirUnNuevoUsuarioToolStripMenuItem.Text = "Añadir un nuevo usuario"
        '
        'actualizarToolStripMenuItem
        '
        Me.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem"
        Me.actualizarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.actualizarToolStripMenuItem.Text = "Actualizar"
        '
        'eliminarToolStripMenuItem
        '
        Me.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem"
        Me.eliminarToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.eliminarToolStripMenuItem.Text = "Eliminar"
        '
        'libroToolStripMenuItem
        '
        Me.libroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.añadirLibroToolStripMenuItem, Me.eliminarToolStripMenuItem2, Me.eliminarToolStripMenuItem3})
        Me.libroToolStripMenuItem.Name = "libroToolStripMenuItem"
        Me.libroToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.libroToolStripMenuItem.Text = "Libros"
        '
        'añadirLibroToolStripMenuItem
        '
        Me.añadirLibroToolStripMenuItem.Name = "añadirLibroToolStripMenuItem"
        Me.añadirLibroToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.añadirLibroToolStripMenuItem.Text = "Añadir Libro"
        '
        'eliminarToolStripMenuItem2
        '
        Me.eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2"
        Me.eliminarToolStripMenuItem2.Size = New System.Drawing.Size(152, 22)
        Me.eliminarToolStripMenuItem2.Text = "Actualizar"
        '
        'eliminarToolStripMenuItem3
        '
        Me.eliminarToolStripMenuItem3.Name = "eliminarToolStripMenuItem3"
        Me.eliminarToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.eliminarToolStripMenuItem3.Text = "Eliminar"
        '
        'lectoresToolStripMenuItem
        '
        Me.lectoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.añdirToolStripMenuItem, Me.actualizarToolStripMenuItem1, Me.eliminarToolStripMenuItem1})
        Me.lectoresToolStripMenuItem.Name = "lectoresToolStripMenuItem"
        Me.lectoresToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.lectoresToolStripMenuItem.Text = "Lectores"
        '
        'añdirToolStripMenuItem
        '
        Me.añdirToolStripMenuItem.Name = "añdirToolStripMenuItem"
        Me.añdirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.añdirToolStripMenuItem.Text = "Añadir"
        '
        'actualizarToolStripMenuItem1
        '
        Me.actualizarToolStripMenuItem1.Name = "actualizarToolStripMenuItem1"
        Me.actualizarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.actualizarToolStripMenuItem1.Text = "Actualizar"
        '
        'eliminarToolStripMenuItem1
        '
        Me.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1"
        Me.eliminarToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.eliminarToolStripMenuItem1.Text = "Eliminar"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(601, 580)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(97, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Cerrar Sessión"
        Me.button1.UseVisualStyleBackColor = True
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.pictureBox1)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Location = New System.Drawing.Point(12, 27)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(720, 547)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(266, 42)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(150, 142)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 4
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(6, 16)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(674, 23)
        Me.label1.TabIndex = 5
        Me.label1.Text = "SISTEMA DE BIBLIOTECA"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bienvanido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 606)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "Bienvanido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvanido"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents usuarioToolStripMenuItem As ToolStripMenuItem
    Private WithEvents añadirUnNuevoUsuarioToolStripMenuItem As ToolStripMenuItem
    Private WithEvents actualizarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem As ToolStripMenuItem
    Private WithEvents libroToolStripMenuItem As ToolStripMenuItem
    Private WithEvents añadirLibroToolStripMenuItem As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem3 As ToolStripMenuItem
    Private WithEvents lectoresToolStripMenuItem As ToolStripMenuItem
    Private WithEvents añdirToolStripMenuItem As ToolStripMenuItem
    Private WithEvents actualizarToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents eliminarToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents button1 As Button
    Private WithEvents groupBox1 As GroupBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
End Class
