Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CSAudioRecorderSample
    Friend Class Core
        Public Shared Function InputBox(ByVal title As String, ByVal promptText As String, ByRef value As String) As DialogResult
            Dim form As Form = New Form()
            Dim label As Label = New Label()
            Dim textBox As System.Windows.Forms.TextBox = New System.Windows.Forms.TextBox()
            Dim buttonOk As Button = New Button()
            Dim buttonCancel As Button = New Button()
            form.Text = title
            label.Text = promptText
            textBox.Text = value
            buttonOk.Text = "OK"
            buttonCancel.Text = "Cancel"
            buttonOk.DialogResult = DialogResult.OK
            buttonCancel.DialogResult = DialogResult.Cancel
            label.SetBounds(9, 20, 372, 13)
            textBox.SetBounds(12, 36, 372, 20)
            buttonOk.SetBounds(228, 72, 75, 23)
            buttonCancel.SetBounds(309, 72, 75, 23)
            label.AutoSize = True
            textBox.Anchor = textBox.Anchor Or AnchorStyles.Right
            buttonOk.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            buttonCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
            form.ClientSize = New Size(396, 107)
            form.Controls.AddRange(New Control() {label, textBox, buttonOk, buttonCancel})
            form.ClientSize = New Size(Math.Max(300, label.Right + 10), form.ClientSize.Height)
            form.FormBorderStyle = FormBorderStyle.FixedDialog
            form.StartPosition = FormStartPosition.CenterScreen
            form.MinimizeBox = False
            form.MaximizeBox = False
            form.AcceptButton = buttonOk
            form.CancelButton = buttonCancel
            Dim dialogResult As DialogResult = form.ShowDialog()
            value = textBox.Text
            Return dialogResult
        End Function

        Public Shared Function Switch(Of T)(ByVal array As List(Of T), ByVal index1 As Integer, ByVal index2 As Integer) As List(Of T)
            Dim aux = array(index1)
            array(index1) = array(index2)
            array(index2) = aux
            Return array
        End Function

        Public Shared Function GetMineType(ByVal image As Image) As String
            Dim format As ImageFormat = image.RawFormat
            Dim codec As ImageCodecInfo = ImageCodecInfo.GetImageDecoders().First(Function(c) c.FormatID = format.Guid)
            Return codec.MimeType
        End Function
    End Class
End Namespace
