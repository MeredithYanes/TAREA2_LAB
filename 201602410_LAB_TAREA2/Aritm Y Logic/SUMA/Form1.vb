Public Class Form1

    Private Sub CALCULARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        Ejecutar(ComboBox1.SelectedIndex)
    End Sub

    Private Sub CERRARToolStripMenuItem_Click_(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub LIMPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem.Click
        LIMPIAR_ENTRADAS()
    End Sub
End Class