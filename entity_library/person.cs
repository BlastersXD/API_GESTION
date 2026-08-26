 public class Person
{
   private long id = 0;
   private string name = "";

   private long age = 0;
   private string? dni;

   public long Id
   {
       get { return id; }
       set { id = value; }
   }
   public string Name
   {
       get { return name; }
       set { name = value; }
   }

   public long Age
   {
       get { return age; }
       set { age = value; }
   }
   public string? Dni
   {
       get { return dni; }
       set { dni = value; }
   }
}
