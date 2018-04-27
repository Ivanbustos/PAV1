Public Class FRM_ABM_3K6_2018
    Enum tipo_accion
        alta
        modificacion
    End Enum
    Enum estado_validacion
        _correcta
        _error
    End Enum
    Enum estado_busqueda
        encotre
        no_encontre
    End Enum
    Dim accion As tipo_accion = tipo_accion.alta
    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=maquis;User ID=avisuales1;Initial Catalog=_BD_PERSONAS;password=avisuales1"
    'Dim cadena_conexion As String = "Provider=SQLOLEDB;Data Source=LENOVO-510-LUIS\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=_BD_PERSONAS;password=avisuales1"
    Private Function leo_tabla(ByVal nombre_tabla As String) As DataTable
        Return ejecutar_sql("select * from " & nombre_tabla)
    End Function
    Private Function ejecutar_sql(ByVal comando_sql As String) As DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable
        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = comando_sql
        If comando_sql.ToUpper.IndexOf("SELECT") = -1 Then
            cmd.ExecuteNonQuery()
        Else
            tabla.Load(cmd.ExecuteReader())
        End If

        conexion.Close()
        Return tabla
    End Function

    Private Sub cargar_grilla()
        Dim sql As String = ""
        Dim tabla As New DataTable

        sql &= "SELECT nombre, apellido, n_tipo_documento, nro_documento "
        sql &= ", p.id_tipo_documento "
        sql &= "FROM personas p join tipos_documento tp "
        sql &= "              ON p.id_tipo_documento = tp.id_tipo_documento "

        tabla = ejecutar_sql(sql)

        Dim c As Integer
        Me.grid1.Rows.Clear()

        For c = 0 To tabla.Rows.Count - 1
            Me.grid1.Rows.Add(tabla.Rows(c)(0), tabla.Rows(c)(1) _
                              , tabla.Rows(c)(2), tabla.Rows(c)(3) _
                              , tabla.Rows(c)(4))
        Next

    End Sub

    Private Sub cargar_combo(ByRef combo As ComboBox, ByRef tabla As DataTable _
                             , pk As String, descripcion As String)

        combo.DataSource = tabla
        combo.DisplayMember = descripcion
        combo.ValueMember = pk

    End Sub

    Private Sub FRM_ABM_3K6_2018_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_combo(cmb_tipo_documento, leo_tabla("tipos_documento"), "id_tipo_documento", "n_tipo_documento")
        cargar_combo(cmb_estado_civil, leo_tabla("tipos_estado_civil"), "id_estado_civil", "n_estado_civil")
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
        Me.cmb_tipo_documento.SelectedIndex = -1
        Me.txt_apellido.Focus()

    End Sub

    Private Sub cmd_grabar_Click(sender As Object, e As EventArgs) Handles cmd_grabar.Click
        ' VALIDAR DATOS VACIOS
        If Me.validacion() = estado_validacion._correcta Then
            If accion = tipo_accion.alta Then
                ' VALIDAR EXISTENCIA DE DATOS 
                If buscar_persona() = estado_busqueda.encotre Then
                    MsgBox("Esta Persona ya existe en BD")
                    Exit Sub
                Else
                    'ACCION = ALTA ==> INSERT DE SQL
                    Me.insertar_registro()
                End If
            Else
                ' ACCION = MODIFICAR ==> UPDATE DE SQL
                Me.modificar_registro()
            End If
        End If

        ' ENVIAR UN MENSAJE AL OPERADOR QUE SE GRABO CORRECTAMENTE
        MsgBox("Se grabó correctamente", MsgBoxStyle.Exclamation, "Mensaje")

        ' RECARGAR LA GRILLA
        Me.cargar_grilla()
        ' ACCION <= MODIFICAR
    End Sub
    Private Sub modificar_registro()
        Dim sql_modificar As String = ""
        sql_modificar = "UPDATE personas "
        sql_modificar &= "SET apellido = '" & Me.txt_apellido.Text.Trim & "'"
        sql_modificar &= ", nombre = '" & Me.txt_nombres.Text.Trim & "'"
        sql_modificar &= ", sexo = '" & Me.txt_sexo.Text.Trim & "'"
        sql_modificar &= ", id_estado_civil = " & Me.cmb_estado_civil.SelectedValue
        sql_modificar &= " WHERE nro_documento = " & Me.txt_documento.Text.Trim
        sql_modificar &= " AND id_tipo_documento = " & Me.cmb_tipo_documento.SelectedValue

        Me.ejecutar_sql(sql_modificar)

    End Sub
    Private Sub insertar_registro()
        Dim sql_insertar As String = ""
        sql_insertar = "INSERT INTO personas ("
        sql_insertar &= "nro_documento"
        sql_insertar &= ", id_tipo_documento"
        sql_insertar &= ", apellido, nombre, sexo "
        sql_insertar &= ", id_estado_civil) VALUES ("
        sql_insertar &= Me.txt_documento.Text.Trim
        sql_insertar &= ", " & Me.cmb_tipo_documento.SelectedValue
        sql_insertar &= ", '" & Me.txt_apellido.Text.Trim & "'"
        sql_insertar &= ", '" & Me.txt_nombres.Text.Trim & "'"
        sql_insertar &= ", '" & Me.txt_sexo.Text.Trim & "'"
        sql_insertar &= ", " & Me.cmb_estado_civil.SelectedValue & ")"

        Me.ejecutar_sql(sql_insertar)

    End Sub
    Private Function buscar_persona() As estado_busqueda
        Dim sql As String = ""
        sql = "SELECT * FROM personas "
        sql &= " WHERE nro_documento = " & Me.txt_documento.Text.Trim
        sql &= " AND id_tipo_documento = " & Me.cmb_tipo_documento.SelectedValue
        Dim tabla As New DataTable
        tabla = Me.ejecutar_sql(sql)
        If tabla.Rows.Count = 0 Then
            Return estado_busqueda.no_encontre
        Else
            Return estado_busqueda.encotre
        End If
    End Function
    Private Function validacion() As estado_validacion
        If Me.txt_apellido.Text = "" Then
            MsgBox("El apellido esta vacio", MsgBoxStyle.Critical, "Error de valicion")
            Me.txt_apellido.Focus()
            Return estado_validacion._error
        End If
        If Me.txt_nombres.Text = "" Then
            MsgBox("El nombre esta vacio", MsgBoxStyle.Critical, "Error de valicion")
            Me.txt_nombres.Focus()
            Return estado_validacion._error
        End If
        If Me.txt_documento.Text = "" Then
            MsgBox("El documento esta vacio", MsgBoxStyle.Critical, "Error de valicion")
            Me.txt_documento.Focus()
            Return estado_validacion._error
        End If
        If Me.txt_sexo.Text = "" Then
            MsgBox("El sexo esta vacio", MsgBoxStyle.Critical, "Error de valicion")
            Me.txt_sexo.Focus()
            Return estado_validacion._error
        End If
        If Me.cmb_tipo_documento.SelectedIndex = -1 Then
            MsgBox("El tipo de documento esta vacio", MsgBoxStyle.Critical, "Error de valicion")
            Me.cmb_tipo_documento.Focus()
            Return estado_validacion._error
        End If
        Return estado_validacion._correcta
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim sql As String = "select count(*) from personas"
        Dim tabla As DataTable
        tabla = Me.ejecutar_sql(sql)
        Me.lbl_cantidad.Text = tabla.Rows(0)(0)
    End Sub

    Private Sub grid1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellDoubleClick
        Dim sql As String = ""
        sql = "SELECT * FROM personas "
        sql &= " WHERE nro_documento = " & Me.grid1.CurrentRow.Cells(3).Value
        sql &= " AND id_tipo_documento = " & Me.grid1.CurrentRow.Cells(4).Value

        Dim tabla As New DataTable
        tabla = Me.ejecutar_sql(sql)
        If Me._chk_borrar.Checked = True Then
            If MessageBox.Show("Está seguro que desea borrar a: " & Chr(13) _
                             & tabla.Rows(0)("apellido").ToString.Trim & ", " _
                             & tabla.Rows(0)("nombre").ToString.Trim & " " _
                             & Chr(13) & "cuyo documento es: " _
                             & tabla.Rows(0)("nro_documento"), "Importante", MessageBoxButtons.YesNo _
                             , MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Dim sql_borrar As String = ""
                sql_borrar = "DELETE FROM personas "
                sql_borrar &= " WHERE nro_documento = " & Me.grid1.CurrentRow.Cells(3).Value
                sql_borrar &= " AND id_tipo_documento = " & Me.grid1.CurrentRow.Cells(4).Value
                Me.ejecutar_sql(sql_borrar)
                Me.cargar_grilla()
            End If
            Exit Sub
        End If
        If tabla.Rows.Count = 1 Then
            Me.txt_apellido.Text = tabla.Rows(0)("apellido")
            Me.txt_nombres.Text = tabla.Rows(0)("nombre")
            Me.txt_documento.Text = tabla.Rows(0)("nro_documento")
            Me.txt_sexo.Text = tabla.Rows(0)("sexo")
            Me.cmb_tipo_documento.SelectedValue = tabla.Rows(0)("id_tipo_documento")
            Me.cmb_estado_civil.SelectedValue = tabla.Rows(0)("id_estado_civil")
            Me.txt_documento.Enabled = False
            Me.cmb_tipo_documento.Enabled = False
            Me.accion = tipo_accion.modificacion
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_borrar.CheckedChanged

    End Sub
End Class