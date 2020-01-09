Imports System.Data.SqlClient

Public Class Form1
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim Da As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim ds As New DataSet()
    Dim tabla As DataTable
    Dim fil As DataRow
    Dim cad As String = "SERVER=localhost;DATABASE=Medico;Integrated Security=true"
    Dim sql As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

 
    Private Sub CmbOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbOpciones.SelectedIndexChanged
        Select Case CmbOpciones.SelectedIndex
            Case 0
                ErrDatos.Clear()
                If ValidaEntrada(ErrDatos, GBox1) Then
                    Try
                        conn = New SqlConnection(cad)
                        sql = "INSERT INTO lineas (lincodigo,lindescripcion) VALUES(" & TxtCod.Text & ",'" & TxtDes.Text & "') "
                        cmd = New SqlCommand(sql, conn)
                        conn.Open()
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Registro Ingresado satisfactoriamente")
                        LimpiarTxt(TxtCod, TxtDes)
                    Catch ex As Exception
                        MessageBox.Show("Error en la Insercion Mensaje:--> " + ex.Message.ToString)
                    End Try
                    If conn IsNot Nothing Or conn.State <> ConnectionState.Closed Then
                        conn.Close()
                    End If
                Else
                    MessageBox.Show("No ha Ingresado Datos")
                End If
                

            Case 1
                LimpiarTxt(TxtCod, TxtDes)
                ErrDatos.Clear()
                Dim campos(1) As String
                Dim fila As Integer = 0
                conn = New SqlConnection(cad)
                conn.Open()
                cmd = New SqlCommand("SELECT lincodigo,lindescripcion FROM lineas", conn)
                dr = cmd.ExecuteReader()
                Dg.Rows.Clear()
                While dr.Read()
                    campos(0) = CStr(dr("lincodigo"))
                    campos(1) = CStr(dr("lindescripcion"))
                    Dg.Rows.Insert(fila, campos)
                    fila = fila + 1
                End While
                dr.Close()
                conn.Close()
            Case 2
                LimpiarTxt(TxtCod, TxtDes)
                ErrDatos.Clear()
                ds.Clear()
                conn = New SqlConnection(cad)
                conn.Open()

                cmd = New SqlCommand("SELECT lincodigo,lindescripcion FROM lineas", conn)
                Da = New SqlDataAdapter(cmd)
                Da.Fill(ds, "lineas")
                Da.Fill(ds, "Clases")
                conn.Close()
                Dg.Rows.Clear()

                tabla = ds.Tables("lineas")
                For Each Me.fil In tabla.Rows
                    Dg.Rows.Add(fil.Item("Lincodigo"), fil.Item("Lindescripcion"))
                Next

                tabla = ds.Tables("Clases")

                Dg2.DataSource = tabla

                LstDatos.DataSource = ds.Tables("Clases")
                LstDatos.DisplayMember = ds.Tables("Clases").Columns(1).ToString
                LstDatos.ValueMember = tabla.Columns("Lincodigo").ToString
        End Select
    End Sub

    Public Function ValidaEntrada(ByVal err As ErrorProvider, ByVal grp As GroupBox) As Boolean
        Dim er As Boolean = True
        For Each C In grp.Controls 'For que se lo utiliza para leer colecciones
            If TypeOf C Is TextBox And C.Text = "" Then 'TypeOf = tipo
                err.SetError(C, "No ha ingresado informacion en: " + C.Name)
                er = False
            End If
        Next
        Return er
    End Function

    Public Sub LimpiarTxt(ByVal txt1 As TextBox, ByVal txt2 As TextBox)
        txt1.Clear()
        txt2.Clear()
    End Sub

End Class
