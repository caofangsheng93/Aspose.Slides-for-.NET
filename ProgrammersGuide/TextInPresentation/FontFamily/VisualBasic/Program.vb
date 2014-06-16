'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports System.Drawing
Imports Aspose.Slides.Export

Namespace FontFamily
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate Presentation Class
			Using pres As New Presentation()

				'Get first slide
				Dim sld As ISlide = pres.Slides(0)

				'Add an AutoShape of Rectangle type
				Dim ashp As IAutoShape = sld.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 50, 200, 50)

				'Remove any fill style associated with the AutoShape
				ashp.FillFormat.FillType = FillType.NoFill

				'Access the TextFrame associated with the AutoShape
				Dim tf As ITextFrame = ashp.TextFrame
				tf.Text = "Aspose TextBox"

				'Access the Portion associated with the TextFrame
				Dim port As IPortion = tf.Paragraphs(0).Portions(0)

				'Set the Font for the Portion
				port.PortionFormat.LatinFont = New FontData("Times New Roman")

				'Set Bold property of the Font
				port.PortionFormat.FontBold = NullableBool.True

				'Set Italic property of the Font
				port.PortionFormat.FontItalic = NullableBool.True

				'Set Underline property of the Font
				port.PortionFormat.FontUnderline = TextUnderlineType.Single

				'Set the Height of the Font
				port.PortionFormat.FontHeight = 25

				'Set the color of the Font
				port.PortionFormat.FillFormat.FillType = FillType.Solid
				port.PortionFormat.FillFormat.SolidFillColor.Color = Color.Blue

				'Write the presentation to disk
				pres.Save(dataDir & "pptxFont.pptx", SaveFormat.Pptx)
			End Using

		End Sub
	End Class
End Namespace