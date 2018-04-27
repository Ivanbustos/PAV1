Public Class frm_abm_alumno
    Enum tipo_accion
        alta
        modificacion
    End Enum
    Enum validacion
        correcto
        incorrecto
    End Enum

    Dim sexo_selec As String = "F"
    Dim accion As tipo_accion = tipo_accion.alta

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=DESKTOP-F7ELM1L;Initial Catalog=_BD_Alumnos;Integrated Security=SSPI"

    Private Function leer_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecutar_sql("select * from " & nombre_tabla)
    End Function
    Private Function ejecutar_sql(ByVal comando_sql As String) As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim comando As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        comando.Connection = conexion
        comando.CommandType = CommandType.Text
        comando.CommandText = comando_sql
        If comando_sql.ToUpper.IndexOf("SELECT") = -1 Then
            comando.ExecuteNonQuery()
        Else
            tabla.Load(comando.ExecuteReader())
        End If
        Return tabla
    End Function
    Private Sub cargar_grilla()
        Dim sql As String
        sql = "SELECT a.Apellido, a.Nombres, td.n_tipo_documento, a.nro_documento, a.id_tipo_documento"
        'sql &= ", a.sexo, a.calle, a.nro_calle, a.actividad, a.casado, a.hijos, a.cantidad_hijos"
        'sql &= ", a.id_carrera"
        sql &= " FROM Alumnos a JOIN tipos_documento td ON a.id_tipo_documento = td.id_tipo_documento"
        Dim tabla As New DataTable

        tabla = ejecutar_sql(sql)

        Dim cont As Integer
        Me.gridAlumnos.Rows.Clear()
        For cont = 0 To tabla.Rows.Count - 1
            Me.gridAlumnos.Rows.Add(tabla.Rows(cont)(0), tabla.Rows(cont)(1) _
                                    , tabla.Rows(cont)(2), tabla.Rows(cont)(3) _
                                    , tabla.Rows(cont)(4))
        Next

    End Sub
    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable, pk As String, desc As String)
        combo.DataSource = tabla
        combo.DisplayMember = desc
        combo.ValueMember = pk

    End Sub
    Private Sub cargar_combos(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_tipo_documento, leer_tabla("tipos_documento"), "id_tipo_documento", "n_tipo_documento")
        cargar_combo(cmb_carrera, leer_tabla("carreras"), "id_carrera", "n_carrera")
        cargar_grilla()
    End Sub
    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.accion = tipo_accion.alta
        Dim txt As Object
        For Each txt In Me.Controls
            If txt.GetType.Name = "TextBox" Or txt.GetType.Name = "MaskedTextBox" Then
                txt.Text = ""

            End If
        Next
        Me.cmb_carrera.SelectedIndex = -1
        Me.cmb_tipo_documento.SelectedIndex = -1
        Me.txt_apellido.Focus()

    End Sub

    Private Sub sexo_seleccionado()
        Dim selec_fem = Me.opt_Femenino.Checked()
        If selec_fem = False Then
            sexo_selec = "M"
        End If
    End Sub


    Private Sub txt_fecha_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_fecha.MaskInputRejected

    End Sub
    Private Function validar()
        Dim txt As Object
        For Each txt In Me.Controls
            If txt.GetType.Name = "TextBox" Or txt.GetType.Name = "MaskedTextBox" Then
                If txt.Text = "" Then
                    Return validacion.incorrecto
                    Me.txt_apellido.Focus()
                End If
            End If
        Next
        Return validacion.correcto
    End Function
    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        If Me.validar() = validacion.correcto Then
            insertar_registro()
        End If
        cargar_grilla()
    End Sub

    Private Sub insertar_registro()
        Dim registro As String = ""
        registro = "INSERT INTO Alumnos ("
        registro &= " id_tipo_documento, nro_documento, Apellido, Nombres, "
        registro &= "sexo, calle, nro_calle, actividad, casado, hijos, "
        registro &= "cantidad_hijos, id_carrera ) VALUES ("
        registro &= Me.cmb_tipo_documento.SelectedValue & ", "
        'registro &= Me.txt_fecha.Text.Trim & ", "
        registro &= Me.txt_documento.Text.Trim & ", '"
        registro &= Me.txt_apellido.Text.Trim & "', '"
        registro &= Me.txt_nombres.Text.Trim & "', '"
        registro &= Me.sexo_selec & "', '"
        registro &= Me.txt_calle.Text.Trim & "', "
        registro &= Me.txt_nro.Text.Trim & ", '"
        registro &= Me.chk_actividad.Checked & "', '"
        registro &= Me.chk_casado.Checked & "', '"
        registro &= Me.chk_hijos.Checked & "', "
        registro &= Me.txt_cant_hijos.Text.Trim & ", "
        registro &= Me.cmb_carrera.SelectedValue & " )"
        Me.ejecutar_sql(registro)
        MsgBox("El Registro se a guardado correctamente ", MsgBoxStyle.Critical, "Registro Guardado")
    End Sub
End Class
