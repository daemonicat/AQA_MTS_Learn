namespace Interfaces;

public interface IExample
{
    // константа
    const int minSpeed = 0;
    
    // статическая переменная
    static int maxSpeed = 60;
    
    // метод
    void Move();
    
    // свойство
    string Name { get; set; }
}