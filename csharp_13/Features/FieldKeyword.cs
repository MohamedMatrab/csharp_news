namespace csharp_13.Features;

public class FieldKeyword
{
    // field keyword
   public string field = "Explicit Field"; // Potential conflict

   public string Property
   {
       get => this.field;  // Refers to the explicit field
       set => @field = value; //Refers to token, we use @ to avoids confusion 
   }
}
