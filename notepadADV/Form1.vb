Public Class NotepadADV

    Private Sub NewFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFileToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        RichTextBox1.LoadFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveFileToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        RichTextBox1.SaveFile(SaveFileDialog1.FileName)
        MsgBox("Your file has been saved.")

    End Sub

    Private Sub ExitNotepadADVToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitNotepadADVToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoOperationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoOperationToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub FontFormattingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontFormattingToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub ColorFormattingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorFormattingToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub YesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesToolStripMenuItem.Click
        RichTextBox1.SelectionBullet = True
    End Sub

    Private Sub NoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoToolStripMenuItem.Click
        RichTextBox1.SelectionBullet = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.ZoomFactor = 2
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        RichTextBox1.ZoomFactor = 4
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        RichTextBox1.ZoomFactor = 8
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        RichTextBox1.ZoomFactor = 10
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("NotepadADV is a simple rich text formatter developed by Bedanta Dey. Inspired by Microsoft Notepad.", "About NotepadADV", MessageBoxButtons.OK)
    End Sub

    Private Sub FormatToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormatToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("Why can't I open my saved files? - Because they are saved in no format. While saving, please append the file name with `.rtf`. | Why is there no help section? - I am working on it!", "Frequently Asked Questions", MessageBoxButtons.OK)
    End Sub
End Class
