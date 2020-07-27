namespace Liskov_Substitution.Library
{
    public interface IManaged : IEmployee
    {
         IEmployee Manager { get; set; }
         void AssignManager(IEmployee manager); 
    }
}