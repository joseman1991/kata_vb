<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblbusca = New System.Windows.Forms.Label()
        Me.busca = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.idp = New System.Windows.Forms.ComboBox()
        Me.a2 = New System.Windows.Forms.TextBox()
        Me.dir = New System.Windows.Forms.TextBox()
        Me.a1 = New System.Windows.Forms.TextBox()
        Me.clave = New System.Windows.Forms.TextBox()
        Me.nu = New System.Windows.Forms.TextBox()
        Me.n2 = New System.Windows.Forms.TextBox()
        Me.n1 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label7 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label9 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.groupBox1.SuspendLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.lblbusca)
        Me.groupBox1.Controls.Add(Me.busca)
        Me.groupBox1.Controls.Add(Me.dataGridView1)
        Me.groupBox1.Controls.Add(Me.idp)
        Me.groupBox1.Controls.Add(Me.a2)
        Me.groupBox1.Controls.Add(Me.dir)
        Me.groupBox1.Controls.Add(Me.a1)
        Me.groupBox1.Controls.Add(Me.clave)
        Me.groupBox1.Controls.Add(Me.nu)
        Me.groupBox1.Controls.Add(Me.n2)
        Me.groupBox1.Controls.Add(Me.n1)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.label9)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.label8)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Location = New System.Drawing.Point(2, 183)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(704, 428)
        Me.groupBox1.TabIndex = 9
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Datos"
        '
        'lblbusca
        '
        Me.lblbusca.AutoSize = True
        Me.lblbusca.Location = New System.Drawing.Point(7, 29)
        Me.lblbusca.Name = "lblbusca"
        Me.lblbusca.Size = New System.Drawing.Size(143, 13)
        Me.lblbusca.TabIndex = 102
        Me.lblbusca.Text = "Buscar por apellido o usuario"
        Me.lblbusca.Visible = False
        '
        'busca
        '
        Me.busca.Location = New System.Drawing.Point(156, 26)
        Me.busca.Name = "busca"
        Me.busca.Size = New System.Drawing.Size(539, 20)
        Me.busca.TabIndex = 101
        Me.busca.Visible = False
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(6, 197)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(689, 225)
        Me.dataGridView1.TabIndex = 100
        '
        'idp
        '
        Me.idp.FormattingEnabled = True
        Me.idp.Location = New System.Drawing.Point(452, 164)
        Me.idp.Name = "idp"
        Me.idp.Size = New System.Drawing.Size(145, 21)
        Me.idp.TabIndex = 7
        '
        'a2
        '
        Me.a2.Location = New System.Drawing.Point(452, 138)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(145, 20)
        Me.a2.TabIndex = 5
        '
        'dir
        '
        Me.dir.Location = New System.Drawing.Point(188, 164)
        Me.dir.Name = "dir"
        Me.dir.Size = New System.Drawing.Size(145, 20)
        Me.dir.TabIndex = 6
        '
        'a1
        '
        Me.a1.Location = New System.Drawing.Point(188, 138)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(145, 20)
        Me.a1.TabIndex = 4
        '
        'clave
        '
        Me.clave.Location = New System.Drawing.Point(452, 74)
        Me.clave.Name = "clave"
        Me.clave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.clave.Size = New System.Drawing.Size(145, 20)
        Me.clave.TabIndex = 1
        '
        'nu
        '
        Me.nu.Location = New System.Drawing.Point(188, 74)
        Me.nu.Name = "nu"
        Me.nu.Size = New System.Drawing.Size(145, 20)
        Me.nu.TabIndex = 0
        '
        'n2
        '
        Me.n2.Location = New System.Drawing.Point(452, 109)
        Me.n2.Name = "n2"
        Me.n2.Size = New System.Drawing.Size(145, 20)
        Me.n2.TabIndex = 3
        '
        'n1
        '
        Me.n1.Location = New System.Drawing.Point(188, 109)
        Me.n1.Name = "n1"
        Me.n1.Size = New System.Drawing.Size(145, 20)
        Me.n1.TabIndex = 2
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(356, 141)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(90, 13)
        Me.label5.TabIndex = 0
        Me.label5.Text = "Segundo Apellido"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(356, 167)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(30, 13)
        Me.label7.TabIndex = 0
        Me.label7.Text = "Perfil"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(86, 171)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(52, 13)
        Me.label6.TabIndex = 0
        Me.label6.Text = "Dirección"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(86, 145)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(76, 13)
        Me.label4.TabIndex = 0
        Me.label4.Text = "Primer Apellido"
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.Location = New System.Drawing.Point(356, 77)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(34, 13)
        Me.label9.TabIndex = 0
        Me.label9.Text = "Clave"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(356, 112)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(90, 13)
        Me.label3.TabIndex = 0
        Me.label3.Text = "Segundo Nombre"
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(86, 77)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(98, 13)
        Me.label8.TabIndex = 0
        Me.label8.Text = "Nombre de Usuario"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(86, 112)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 13)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Primer Nombre"
        '
        'pictureBox1
        '
        Me.pictureBox1.Location = New System.Drawing.Point(285, 35)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(132, 142)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox1.TabIndex = 8
        Me.pictureBox1.TabStop = False
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(2, 0)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(704, 23)
        Me.label1.TabIndex = 7
        Me.label1.Text = "REGISTRO DE USUARIO"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(540, 624)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Cerrar"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(621, 624)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Insertar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 659)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label1)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents groupBox1 As GroupBox
    Private WithEvents lblbusca As Label
    Private WithEvents busca As TextBox
    Private WithEvents dataGridView1 As DataGridView
    Private WithEvents idp As ComboBox
    Private WithEvents a2 As TextBox
    Private WithEvents dir As TextBox
    Private WithEvents a1 As TextBox
    Private WithEvents clave As TextBox
    Private WithEvents nu As TextBox
    Private WithEvents n2 As TextBox
    Private WithEvents n1 As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label7 As Label
    Private WithEvents label6 As Label
    Private WithEvents label4 As Label
    Private WithEvents label9 As Label
    Private WithEvents label3 As Label
    Private WithEvents label8 As Label
    Private WithEvents label2 As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
End Class
