Sub CopyandPaste()

'Copy and Paste from a WorkBook to another Workbook

Workbooks("Test").Worksheets("Plan1").Range("A:F").Copy
Workbooks("GitHub").Worksheets("Plan1").Range("A1").PasteSpecial xlPasteValues


    
End Sub
