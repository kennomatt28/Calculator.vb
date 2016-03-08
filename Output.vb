Public Class Output
  Inherits Textbox
  Dim t as string
  Public text as property
    Get 
      return t
    End Get
    Set(byval value as string)
      t=value
    End Set
  End property
End Class
