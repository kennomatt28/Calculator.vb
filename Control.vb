Public Class Control
 Inherits Button

 dim text as string
 dim name as string
 public metext as property
  Get
   return text
  End Get
  Set(Byval value as string)
    text=value
    name=value
  End Set
 end property
End Class
