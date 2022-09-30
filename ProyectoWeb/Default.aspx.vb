Imports CnSistemas

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Dim ObjPersonas As New CnPersonas

    Dim OdDataset As New DataSet



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        OdDataset = ObjPersonas.TraerTodos()

        GdvPersonas.DataSource = OdDataset
        GdvPersonas.DataBind()




    End Sub

    Protected Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click

    End Sub
End Class