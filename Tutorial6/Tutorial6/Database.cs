using Tutorial6.Models;

namespace Tutorial6;

public static class Database
{
    public static List<Test> Tests = new List<Test>()
    {
        new Test() { Id = 1, Name = "Test1" },
        new Test() { Id = 2, Name = "Test2" },
        new Test() { Id = 3, Name = "Test3" }
    };

    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal() { Id = 1, Name = "Garfield", Category = "Cat", Weight = 10, Color = "orange" },
        new Animal() { Id = 2, Name = "Bella", Category = "Dog", Weight = 25, Color = "brown" },
        new Animal() { Id = 3, Name = "Chirpy", Category = "Bird", Weight = 0.5, Color = "yellow" },
        new Animal() { Id = 4, Name = "Nemo", Category = "Fish", Weight = 0.2, Color = "orange-white" },
        new Animal() { Id = 5, Name = "Thumper", Category = "Rabbit", Weight = 2.5, Color = "gray" },
        new Animal() { Id = 6, Name = "Zazu", Category = "Bird", Weight = 1.1, Color = "blue-red" },
        new Animal() { Id = 7, Name = "Shadow", Category = "Cat", Weight = 9.5, Color = "black" },
        new Animal() { Id = 8, Name = "Luna", Category = "Dog", Weight = 30, Color = "gray" },
        new Animal() { Id = 9, Name = "Bella", Category = "Rabbit", Weight = 2.3, Color = "white" }, 
        new Animal() { Id = 10, Name = "Sunny", Category = "Bird", Weight = 0.6, Color = "yellow" } 
    };


}