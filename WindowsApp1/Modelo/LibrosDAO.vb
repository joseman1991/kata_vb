
Imports System.IO


Namespace WindowsFormsApp1.Modelo
    Public Class LibrosDAO
        Inherits Conexion

        Public Function ObtenerLibro(ByVal nu As String) As Libros
            Dim u As Libros = Nothing
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select * from Libros where idLibro=@user"
            comando.Parameters.AddWithValue("@user", nu)
            lector = comando.ExecuteReader()

            If lector.Read() Then
                u = New Libros()
                Dim i As Integer = 0
                u.idlibro = lector.GetInt32(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.titulo = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.editorial = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                u.autor = lector.GetString(Math.Min(System.Threading.Interlocked.Increment(i), i - 1))
                Dim imgData As Byte() = CType(lector.GetValue(Math.Min(System.Threading.Interlocked.Increment(i), i - 1)), Byte())
                Dim newImage As Image = Nothing

                Using ms As MemoryStream = New MemoryStream(imgData, 0, imgData.Length)
                    ms.Write(imgData, 0, imgData.Length)
                    newImage = Image.FromStream(ms, True)

                    Dim folder As String = Path.Combine(Application.StartupPath, "temp")
                    Dim fileName As String = Path.Combine(folder, u.idlibro & ".jpg")
                    If (Not File.Exists(fileName)) Then
                        File.Delete(fileName)
                        newImage.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    End If
                    newImage = Image.FromFile(fileName)
                End Using

                u.portada = New System.Windows.Forms.PictureBox()
                u.portada.Image = newImage
            End If

            desconectar()
            Return u
        End Function

        Public Function idLibros() As Integer
            Dim id As Integer = 1
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select max(idLibro) from Libros"
            lector = comando.ExecuteReader()

            If lector.Read() Then
                id = lector.GetInt32(0)
            End If

            desconectar()
            Return id + 1
        End Function

        Public Function obtenerRegistros(ByVal busca As String) As DataTable
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = "select idlibro,nombre,editorial,autor from Libros where nombre like @nomb or autor like @ape"
            comando.Parameters.AddWithValue("@nomb", busca & "%")
            comando.Parameters.AddWithValue("@ape", busca & "%")
            lector = comando.ExecuteReader()
            tabla.Load(lector)
            desconectar()
            lector.Close()
            Return tabla
        End Function

        Public Sub registrarLibro(ByVal u As Libros)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " INSERT INTO Libros values(@user,@n1,@n2,@a1,@dir)"
            comando.Parameters.AddWithValue("@user", u.idlibro)
            comando.Parameters.AddWithValue("@n1", u.titulo)
            comando.Parameters.AddWithValue("@n2", u.editorial)
            comando.Parameters.AddWithValue("@a1", u.autor)
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
            u.portada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            comando.Parameters.AddWithValue("@dir", ms.GetBuffer())
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub actualizarLibro(ByVal u As Libros)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " update Libros set  nombre=@n2,editorial=@a1,autor=@a2,foto=@dir where idlibro=@n1"
            comando.Parameters.AddWithValue("@n1", u.idlibro)
            comando.Parameters.AddWithValue("@n2", u.titulo)
            comando.Parameters.AddWithValue("@a1", u.editorial)
            comando.Parameters.AddWithValue("@a2", u.autor)
            Dim ms As System.IO.MemoryStream = New System.IO.MemoryStream()
            u.portada.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            comando.Parameters.AddWithValue("@dir", ms.GetBuffer())
            comando.ExecuteNonQuery()
            desconectar()
        End Sub

        Public Sub eliminarrLibro(ByVal u As Libros)
            conetar()
            comando = conexion.CreateCommand()
            comando.CommandText = " delete from Libros  where idLibro=@user"
            comando.Parameters.AddWithValue("@user", u.idlibro)
            comando.ExecuteNonQuery()
            desconectar()
        End Sub
    End Class
End Namespace
