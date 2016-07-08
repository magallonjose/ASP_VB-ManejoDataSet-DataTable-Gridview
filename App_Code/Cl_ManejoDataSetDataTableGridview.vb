Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.VisualBasic

Public Class Cl_ManejoDataSetDataTableGridview
    Public Function listar() As Data.DataSet
        Dim cadena, query_sql As String
        Dim conexion As SqlConnection
        Dim adaptador As SqlDataAdapter
        Dim datos As DataSet

        cadena = ConfigurationManager.ConnectionStrings("baseConnectionString").ToString

        conexion = New SqlConnection(cadena)

        conexion.Open()

        query_sql = "select top(10) productid, productname, supplierid, categoryid from products"

        adaptador = New SqlDataAdapter(query_sql, conexion)

        datos = New DataSet()

        adaptador.Fill(datos)

        conexion.Close()

        Return datos

    End Function
End Class
