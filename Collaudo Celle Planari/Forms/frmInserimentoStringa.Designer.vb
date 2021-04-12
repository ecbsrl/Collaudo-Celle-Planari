<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInserimentoStringa
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInserimentoStringa))
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnAnnulla = New System.Windows.Forms.Button()
        Me.tbValore = New System.Windows.Forms.TextBox()
        Me.labDescrizione = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOk.Location = New System.Drawing.Point(256, 80)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(5)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(100, 70)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnAnnulla
        '
        Me.btnAnnulla.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulla.Image = CType(resources.GetObject("btnAnnulla.Image"), System.Drawing.Image)
        Me.btnAnnulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnnulla.Location = New System.Drawing.Point(146, 80)
        Me.btnAnnulla.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(100, 70)
        Me.btnAnnulla.TabIndex = 6
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnnulla.UseVisualStyleBackColor = True
        '
        'tbValore
        '
        Me.tbValore.Location = New System.Drawing.Point(14, 44)
        Me.tbValore.Margin = New System.Windows.Forms.Padding(5)
        Me.tbValore.Name = "tbValore"
        Me.tbValore.Size = New System.Drawing.Size(466, 26)
        Me.tbValore.TabIndex = 5
        Me.tbValore.Text = "Valore"
        '
        'labDescrizione
        '
        Me.labDescrizione.Location = New System.Drawing.Point(14, 14)
        Me.labDescrizione.Margin = New System.Windows.Forms.Padding(5)
        Me.labDescrizione.Name = "labDescrizione"
        Me.labDescrizione.Size = New System.Drawing.Size(466, 20)
        Me.labDescrizione.TabIndex = 4
        Me.labDescrizione.Text = "Descrizione"
        Me.labDescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmInserimentoStringa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 162)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnAnnulla)
        Me.Controls.Add(Me.tbValore)
        Me.Controls.Add(Me.labDescrizione)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInserimentoStringa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inserimento stringa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents tbValore As System.Windows.Forms.TextBox
    Friend WithEvents labDescrizione As System.Windows.Forms.Label
End Class
