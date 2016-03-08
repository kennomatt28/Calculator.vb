Public Class Form
  dim f() as sub
  dim tb as new Output
  Private Sub Form1_Load(Byval sender as object, byval e as eventargs) handles base.load
    tb.location= new point(20,20)
    tb.font=new font("Arial",20)
    tb.Size=new size(me.width-40,40)
    me.controls.add(tb)
  end sub
  
End Class
