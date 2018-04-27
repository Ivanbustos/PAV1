<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ABM_3K6_2018
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ABM_3K6_2018))
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_doc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_sexo = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_estado_civil = New System.Windows.Forms.ComboBox()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_grabar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chk_borrar = New System.Windows.Forms.CheckBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cantidad.Location = New System.Drawing.Point(411, 145)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(16, 16)
        Me.lbl_cantidad.TabIndex = 50
        Me.lbl_cantidad.Text = "0"
        '
        'grid1
        '
        Me.grid1.AllowUserToAddRows = False
        Me.grid1.AllowUserToDeleteRows = False
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.apellido, Me.tipo_doc, Me.documento, Me.id_tipo_documento})
        Me.grid1.Location = New System.Drawing.Point(18, 169)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(463, 143)
        Me.grid1.TabIndex = 48
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombres"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 150
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 120
        '
        'tipo_doc
        '
        Me.tipo_doc.HeaderText = "Tipo Doc"
        Me.tipo_doc.Name = "tipo_doc"
        Me.tipo_doc.ReadOnly = True
        Me.tipo_doc.Width = 50
        '
        'documento
        '
        Me.documento.HeaderText = "Documento"
        Me.documento.Name = "documento"
        Me.documento.ReadOnly = True
        Me.documento.Width = 70
        '
        'id_tipo_documento
        '
        Me.id_tipo_documento.HeaderText = "id_tipo_documento"
        Me.id_tipo_documento.Name = "id_tipo_documento"
        Me.id_tipo_documento.ReadOnly = True
        Me.id_tipo_documento.Visible = False
        '
        'txt_sexo
        '
        Me.txt_sexo.Location = New System.Drawing.Point(124, 116)
        Me.txt_sexo.Mask = "L"
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(16, 20)
        Me.txt_sexo.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(74, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Sexo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(49, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Estado Civil"
        '
        'cmb_estado_civil
        '
        Me.cmb_estado_civil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado_civil.FormattingEnabled = True
        Me.cmb_estado_civil.Location = New System.Drawing.Point(124, 142)
        Me.cmb_estado_civil.Name = "cmb_estado_civil"
        Me.cmb_estado_civil.Size = New System.Drawing.Size(121, 21)
        Me.cmb_estado_civil.TabIndex = 37
        '
        'txt_documento
        '
        Me.txt_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_documento.Location = New System.Drawing.Point(124, 90)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(57, 20)
        Me.txt_documento.TabIndex = 35
        '
        'txt_nombres
        '
        Me.txt_nombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nombres.Location = New System.Drawing.Point(124, 34)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(337, 20)
        Me.txt_nombres.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(62, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Nombres"
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(124, 63)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_documento.TabIndex = 34
        '
        'txt_apellido
        '
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_apellido.Location = New System.Drawing.Point(124, 12)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(337, 20)
        Me.txt_apellido.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(49, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Documento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(25, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Tipo Documento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(67, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Apellido"
        '
        'cmd_salir
        '
        Me.cmd_salir.Image = CType(resources.GetObject("cmd_salir.Image"), System.Drawing.Image)
        Me.cmd_salir.Location = New System.Drawing.Point(447, 318)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(40, 44)
        Me.cmd_salir.TabIndex = 41
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = CType(resources.GetObject("cmd_cancelar.Image"), System.Drawing.Image)
        Me.cmd_cancelar.Location = New System.Drawing.Point(114, 318)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(40, 44)
        Me.cmd_cancelar.TabIndex = 40
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_grabar
        '
        Me.cmd_grabar.Image = CType(resources.GetObject("cmd_grabar.Image"), System.Drawing.Image)
        Me.cmd_grabar.Location = New System.Drawing.Point(68, 318)
        Me.cmd_grabar.Name = "cmd_grabar"
        Me.cmd_grabar.Size = New System.Drawing.Size(40, 44)
        Me.cmd_grabar.TabIndex = 39
        Me.cmd_grabar.UseVisualStyleBackColor = True
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Image = CType(resources.GetObject("cmd_nuevo.Image"), System.Drawing.Image)
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 318)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(40, 44)
        Me.cmd_nuevo.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.cmd_nuevo, "Nuevo registro")
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'chk_borrar
        '
        Me.chk_borrar.AutoSize = True
        Me.chk_borrar.Location = New System.Drawing.Point(237, 318)
        Me.chk_borrar.Name = "chk_borrar"
        Me.chk_borrar.Size = New System.Drawing.Size(96, 17)
        Me.chk_borrar.TabIndex = 51
        Me.chk_borrar.Text = "Borrar Registro"
        Me.chk_borrar.UseVisualStyleBackColor = True
        '
        'FRM_ABM_3K6_2018
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 371)
        Me.Controls.Add(Me.chk_borrar)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_cancelar)
        Me.Controls.Add(Me.cmd_grabar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.txt_sexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmb_estado_civil)
        Me.Controls.Add(Me.txt_documento)
        Me.Controls.Add(Me.txt_nombres)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_tipo_documento)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_ABM_3K6_2018"
        Me.Text = "FRM_ABM_3K6_2018"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_doc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmd_grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents txt_sexo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_estado_civil As System.Windows.Forms.ComboBox
    Friend WithEvents txt_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_nombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chk_borrar As System.Windows.Forms.CheckBox
End Class
