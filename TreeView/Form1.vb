Public Class Form1
    ' this variable allows you to use all those images in image lists one by one
    Dim i As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = (i + 1) Mod 2 'this two is the number of images inserted in image list but this command allows the loop through those images
        Dim note As String
        note = InputBox("Enter a node name") ' to initialize a input box
        ' to add notes into treeview box using this command TreeView1.Nodes.Add(note, note)

        'add select function into tree view after adding
        If TreeView1.SelectedNode Is Nothing Then
            TreeView1.Nodes.Add(note, note, i, i) 'keys passing note as an argument,text as string
            'the above code allows adding subnotes. o for image index and 1 is for selected image index

        Else
            TreeView1.SelectedNode.Nodes.Add(note, note, i, i) 'for selection in treeview to allow selection
        End If

    End Sub
End Class
