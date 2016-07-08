
Imports System.Data

Partial Class ManejoDataSetGridview
    Inherits System.Web.UI.Page
    Public DS As New Data.DataSet

    Protected Sub btnMostrarProductos_Click(sender As Object, e As EventArgs) Handles btnMostrarProductos.Click

        Dim obj As New Cl_ManejoDataSetDataTableGridview
        DS = obj.listar()
        gvProductos.DataSource = DS
        gvProductos.DataBind()

        lbl1.Visible = True
        'Recorrer Gridview, identificar y resaltar en color
        For i = 1 To gvProductos.Rows.Count - 1
            If gvProductos.Rows(i).Cells(2).Text = "2" Then
                gvProductos.Rows(i).BackColor = Drawing.Color.Yellow
            End If
        Next

        'Creacion de una tabla
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn() {New DataColumn("Id Producto", GetType(String)),
                                               New DataColumn("Nombre Producto", GetType(String)),
                                               New DataColumn("ID Proveedor", GetType(String)),
                                               New DataColumn("ID Categoria", GetType(String))})
        lbl2.Visible = True
        'Recorrer Dataset y agregar datos a el Datatable
        For x = 1 To DS.Tables(0).Rows.Count - 1
            If DS.Tables(0).Rows(x).Item(2).ToString = "2" Then
                dt.Rows.Add(DS.Tables(0).Rows(x).Item(0).ToString, DS.Tables(0).Rows(x).Item(1).ToString, DS.Tables(0).Rows(x).Item(2).ToString, DS.Tables(0).Rows(x).Item(3).ToString)
            End If
        Next

        gvProductosCategoria2.DataSource = dt
        gvProductosCategoria2.DataBind()

    End Sub
End Class
