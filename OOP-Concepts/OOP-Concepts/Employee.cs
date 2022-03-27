namespace OOP_Concepts
{
   public abstract class Employee : IPay
   {
      public int Id { get; set; }
      public string FirstName { get; set; }
      public string LastName { get; set; }
      public Date BirthDate { get; set; }
      public Date HiringDate { get; set; }
      public bool IsActive { get; set; }

      public abstract decimal GetValueToPay();

      public override string ToString()
      {
         return $"  {Id} - {FirstName} {LastName}" +
         $"\n\tBirth...................: {$"{BirthDate}",20}" +
         $"\n\tHiring..................: {$"{HiringDate}",20}" +
         $"\n\tIs active...............: {$"{IsActive}",20}";
      }
   }
}