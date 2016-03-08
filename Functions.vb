Public Class Functions
  dim f(2) as sub
  public sub number(byval o as Ouput,byval t as string)
    o.AppendText=t
  end sub
  public sub add(byval op as string)
    op="+"
  end sub
  public sub setup()
    f(0)=number()
    
  end sub
End Class
