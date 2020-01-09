<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDes = New System.Windows.Forms.TextBox()
        Me.TxtCod = New System.Windows.Forms.TextBox()
        Me.CmbOpciones = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBox2 = New System.Windows.Forms.GroupBox()
        Me.Dg = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dg2 = New System.Windows.Forms.DataGridView()
        Me.LstDatos = New System.Windows.Forms.ListBox()
        Me.ErrDatos = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GBox1.SuspendLayout()
        Me.GBox2.SuspendLayout()
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GBox1.Controls.Add(Me.Label3)
        Me.GBox1.Controls.Add(Me.Label2)
        Me.GBox1.Controls.Add(Me.TxtDes)
        Me.GBox1.Controls.Add(Me.TxtCod)
        Me.GBox1.Location = New System.Drawing.Point(38, 36)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(762, 58)
        Me.GBox1.TabIndex = 26
        Me.GBox1.TabStop = False
        Me.GBox1.Text = "Datos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(37, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "CODIGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(386, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "DESCRIPCION"
        '
        'TxtDes
        '
        Me.TxtDes.Location = New System.Drawing.Point(532, 26)
        Me.TxtDes.Multiline = True
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.Size = New System.Drawing.Size(193, 20)
        Me.TxtDes.TabIndex = 27
        '
        'TxtCod
        '
        Me.TxtCod.Location = New System.Drawing.Point(199, 26)
        Me.TxtCod.Name = "TxtCod"
        Me.TxtCod.Size = New System.Drawing.Size(140, 20)
        Me.TxtCod.TabIndex = 26
        '
        'CmbOpciones
        '
        Me.CmbOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmbOpciones.FormattingEnabled = True
        Me.CmbOpciones.Items.AddRange(New Object() {"Insertar", "DataReader", "DataSet "})
        Me.CmbOpciones.Location = New System.Drawing.Point(238, 117)
        Me.CmbOpciones.Name = "CmbOpciones"
        Me.CmbOpciones.Size = New System.Drawing.Size(192, 21)
        Me.CmbOpciones.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(76, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "OPCIONES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(366, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ADO NET"
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.Color.Bisque
        Me.GBox2.Controls.Add(Me.Dg)
        Me.GBox2.Controls.Add(Me.Dg2)
        Me.GBox2.Controls.Add(Me.LstDatos)
        Me.GBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBox2.Location = New System.Drawing.Point(38, 188)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(762, 206)
        Me.GBox2.TabIndex = 36
        Me.GBox2.TabStop = False
        '
        'Dg
        '
        Me.Dg.AllowUserToAddRows = False
        Me.Dg.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion})
        Me.Dg.Location = New System.Drawing.Point(16, 34)
        Me.Dg.Name = "Dg"
        Me.Dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg.Size = New System.Drawing.Size(265, 150)
        Me.Dg.TabIndex = 22
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Dg2
        '
        Me.Dg2.AllowUserToAddRows = False
        Me.Dg2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Dg2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dg2.Location = New System.Drawing.Point(300, 34)
        Me.Dg2.Name = "Dg2"
        Me.Dg2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dg2.Size = New System.Drawing.Size(257, 150)
        Me.Dg2.TabIndex = 21
        '
        'LstDatos
        '
        Me.LstDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstDatos.FormattingEnabled = True
        Me.LstDatos.Location = New System.Drawing.Point(573, 37)
        Me.LstDatos.Name = "LstDatos"
        Me.LstDatos.Size = New System.Drawing.Size(181, 147)
        Me.LstDatos.TabIndex = 18
        '
        'ErrDatos
        '
        Me.ErrDatos.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(839, 395)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbOpciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GBox1.ResumeLayout(False)
        Me.GBox1.PerformLayout()
        Me.GBox2.ResumeLayout(False)
        CType(Me.Dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDes As System.Windows.Forms.TextBox
    Friend WithEvents TxtCod As System.Windows.Forms.TextBox
    Friend WithEvents CmbOpciones As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LstDatos As System.Windows.Forms.ListBox
    Friend WithEvents Dg2 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrDatos As System.Windows.Forms.ErrorProvider
    Friend WithEvents Dg As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
