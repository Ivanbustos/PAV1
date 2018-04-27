<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_abm_alumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_abm_alumno))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.cnt_sexo = New System.Windows.Forms.Panel()
        Me.Opt_masculino = New System.Windows.Forms.RadioButton()
        Me.opt_Femenino = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nro = New System.Windows.Forms.TextBox()
        Me.chk_actividad = New System.Windows.Forms.CheckBox()
        Me.chk_casado = New System.Windows.Forms.CheckBox()
        Me.chk_hijos = New System.Windows.Forms.CheckBox()
        Me.txt_cant_hijos = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_carrera = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.txt_documento = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gridAlumnos = New System.Windows.Forms.DataGridView()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chk_borrar_alumno = New System.Windows.Forms.CheckBox()
        Me.cnt_sexo.SuspendLayout()
        CType(Me.gridAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombres"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha Nacmiento"
        '
        'txt_fecha
        '
        Me.txt_fecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fecha.Location = New System.Drawing.Point(107, 72)
        Me.txt_fecha.Mask = "00/00/0000"
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(68, 20)
        Me.txt_fecha.TabIndex = 2
        Me.txt_fecha.ValidatingType = GetType(Date)
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(107, 30)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(272, 20)
        Me.txt_apellido.TabIndex = 0
        '
        'txt_nombres
        '
        Me.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombres.Location = New System.Drawing.Point(107, 51)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(272, 20)
        Me.txt_nombres.TabIndex = 1
        '
        'cnt_sexo
        '
        Me.cnt_sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cnt_sexo.Controls.Add(Me.Opt_masculino)
        Me.cnt_sexo.Controls.Add(Me.opt_Femenino)
        Me.cnt_sexo.Location = New System.Drawing.Point(107, 98)
        Me.cnt_sexo.Name = "cnt_sexo"
        Me.cnt_sexo.Size = New System.Drawing.Size(100, 63)
        Me.cnt_sexo.TabIndex = 3
        '
        'Opt_masculino
        '
        Me.Opt_masculino.AutoSize = True
        Me.Opt_masculino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Opt_masculino.Location = New System.Drawing.Point(13, 35)
        Me.Opt_masculino.Name = "Opt_masculino"
        Me.Opt_masculino.Size = New System.Drawing.Size(72, 17)
        Me.Opt_masculino.TabIndex = 1
        Me.Opt_masculino.TabStop = True
        Me.Opt_masculino.Text = "Masculino"
        Me.Opt_masculino.UseVisualStyleBackColor = True
        '
        'opt_Femenino
        '
        Me.opt_Femenino.AutoSize = True
        Me.opt_Femenino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opt_Femenino.Location = New System.Drawing.Point(13, 12)
        Me.opt_Femenino.Name = "opt_Femenino"
        Me.opt_Femenino.Size = New System.Drawing.Size(70, 17)
        Me.opt_Femenino.TabIndex = 0
        Me.opt_Femenino.TabStop = True
        Me.opt_Femenino.Text = "Femenino"
        Me.opt_Femenino.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Documento"
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(107, 171)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(272, 21)
        Me.cmb_tipo_documento.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Calle"
        '
        'txt_calle
        '
        Me.txt_calle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_calle.Location = New System.Drawing.Point(107, 224)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(272, 20)
        Me.txt_calle.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(78, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nro"
        '
        'txt_nro
        '
        Me.txt_nro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nro.Location = New System.Drawing.Point(108, 250)
        Me.txt_nro.Name = "txt_nro"
        Me.txt_nro.Size = New System.Drawing.Size(68, 20)
        Me.txt_nro.TabIndex = 7
        '
        'chk_actividad
        '
        Me.chk_actividad.AutoSize = True
        Me.chk_actividad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_actividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_actividad.Location = New System.Drawing.Point(181, 264)
        Me.chk_actividad.Name = "chk_actividad"
        Me.chk_actividad.Size = New System.Drawing.Size(67, 17)
        Me.chk_actividad.TabIndex = 8
        Me.chk_actividad.Text = "Actividad"
        Me.chk_actividad.UseVisualStyleBackColor = True
        '
        'chk_casado
        '
        Me.chk_casado.AutoSize = True
        Me.chk_casado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_casado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_casado.Location = New System.Drawing.Point(189, 287)
        Me.chk_casado.Name = "chk_casado"
        Me.chk_casado.Size = New System.Drawing.Size(59, 17)
        Me.chk_casado.TabIndex = 9
        Me.chk_casado.Text = "Casado"
        Me.chk_casado.UseVisualStyleBackColor = True
        '
        'chk_hijos
        '
        Me.chk_hijos.AutoSize = True
        Me.chk_hijos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chk_hijos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_hijos.Location = New System.Drawing.Point(202, 309)
        Me.chk_hijos.Name = "chk_hijos"
        Me.chk_hijos.Size = New System.Drawing.Size(46, 17)
        Me.chk_hijos.TabIndex = 10
        Me.chk_hijos.Text = "Hijos"
        Me.chk_hijos.UseVisualStyleBackColor = True
        '
        'txt_cant_hijos
        '
        Me.txt_cant_hijos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cant_hijos.Location = New System.Drawing.Point(313, 306)
        Me.txt_cant_hijos.Name = "txt_cant_hijos"
        Me.txt_cant_hijos.Size = New System.Drawing.Size(42, 20)
        Me.txt_cant_hijos.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(258, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad"
        '
        'cmb_carrera
        '
        Me.cmb_carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_carrera.FormattingEnabled = True
        Me.cmb_carrera.Items.AddRange(New Object() {"Ingeniería en Sistemas de Información", "Lic. en Informática", "Analista de Sistemas", "Técnico en Programación"})
        Me.cmb_carrera.Location = New System.Drawing.Point(107, 343)
        Me.cmb_carrera.Name = "cmb_carrera"
        Me.cmb_carrera.Size = New System.Drawing.Size(272, 21)
        Me.cmb_carrera.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Carrera"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(383, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Alumnos Ingresados"
        '
        'cmd_buscar
        '
        Me.cmd_buscar.AutoSize = True
        Me.cmd_buscar.Enabled = False
        Me.cmd_buscar.Image = CType(resources.GetObject("cmd_buscar.Image"), System.Drawing.Image)
        Me.cmd_buscar.Location = New System.Drawing.Point(201, 384)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(38, 38)
        Me.cmd_buscar.TabIndex = 16
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.AutoSize = True
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(784, 384)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(38, 38)
        Me.cmd_salir.TabIndex = 17
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.AutoSize = True
        Me.cmd_grabar.Image = CType(resources.GetObject("cmd_grabar.Image"), System.Drawing.Image)
        Me.cmd_grabar.Location = New System.Drawing.Point(63, 384)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(38, 38)
        Me.cmd_grabar.TabIndex = 14
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.AutoSize = True
        Me.cmd_nuevo.Image = CType(resources.GetObject("cmd_nuevo.Image"), System.Drawing.Image)
        Me.cmd_nuevo.Location = New System.Drawing.Point(18, 384)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(38, 38)
        Me.cmd_nuevo.TabIndex = 13
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.AutoSize = True
        Me.cmd_cancelar.Enabled = False
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(107, 384)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(47, 38)
        Me.cmd_cancelar.TabIndex = 15
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'txt_documento
        '
        Me.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento.Location = New System.Drawing.Point(107, 198)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(272, 20)
        Me.txt_documento.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Documento"
        '
        'gridAlumnos
        '
        Me.gridAlumnos.AllowUserToAddRows = False
        Me.gridAlumnos.AllowUserToDeleteRows = False
        Me.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.apellido, Me.nombres, Me.documento, Me.tipo_doc, Me.id_tipo_documento})
        Me.gridAlumnos.Location = New System.Drawing.Point(386, 30)
        Me.gridAlumnos.Name = "gridAlumnos"
        Me.gridAlumnos.ReadOnly = True
        Me.gridAlumnos.Size = New System.Drawing.Size(436, 334)
        Me.gridAlumnos.TabIndex = 23
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 150
        '
        'nombres
        '
        Me.nombres.HeaderText = "Nombres"
        Me.nombres.Name = "nombres"
        Me.nombres.ReadOnly = True
        '
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        Me.documento.Width = 70
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Documento"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Width = 50
        '
        'id_tipo_documento
        '
        Me.id_tipo_documento.HeaderText = "td"
        Me.id_tipo_documento.Name = "id_tipo_documento"
        Me.id_tipo_documento.ReadOnly = True
        Me.id_tipo_documento.Visible = False
        '
        'chk_borrar_alumno
        '
        Me.chk_borrar_alumno.AutoSize = True
        Me.chk_borrar_alumno.Location = New System.Drawing.Point(386, 370)
        Me.chk_borrar_alumno.Name = "chk_borrar_alumno"
        Me.chk_borrar_alumno.Size = New System.Drawing.Size(92, 17)
        Me.chk_borrar_alumno.TabIndex = 24
        Me.chk_borrar_alumno.Text = "Borrar Alumno"
        Me.chk_borrar_alumno.UseVisualStyleBackColor = True
        '
        'frm_abm_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 428)
        Me.Controls.Add(Me.chk_borrar_alumno)
        Me.Controls.Add(Me.gridAlumnos)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmd_buscar)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmb_carrera)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_cant_hijos)
        Me.Controls.Add(Me.chk_hijos)
        Me.Controls.Add(Me.chk_casado)
        Me.Controls.Add(Me.chk_actividad)
        Me.Controls.Add(Me.cmb_tipo_documento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cnt_sexo)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.txt_nro)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.txt_fecha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_abm_alumno"
        Me.Text = "Alta de Alumnos"
        Me.cnt_sexo.ResumeLayout(False)
        Me.cnt_sexo.PerformLayout()
        CType(Me.gridAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents cnt_sexo As System.Windows.Forms.Panel
    Friend WithEvents Opt_masculino As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Femenino As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nro As System.Windows.Forms.TextBox
    Friend WithEvents chk_actividad As System.Windows.Forms.CheckBox
    Friend WithEvents chk_casado As System.Windows.Forms.CheckBox
    Friend WithEvents chk_hijos As System.Windows.Forms.CheckBox
    Friend WithEvents txt_cant_hijos As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_carrera As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_buscar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gridAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents chk_borrar_alumno As System.Windows.Forms.CheckBox
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
