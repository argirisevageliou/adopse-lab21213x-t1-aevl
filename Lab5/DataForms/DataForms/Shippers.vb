Public Class Shippers

    Private Sub ShippersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShippersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ShippersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NorthwindDataSet)

    End Sub

    Private Sub Shippers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'NorthwindDataSet.Shippers' table. You can move, or remove it, as needed.
        Me.ShippersTableAdapter.Fill(Me.NorthwindDataSet.Shippers)

    End Sub
End Class