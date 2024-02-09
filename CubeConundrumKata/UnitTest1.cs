namespace CubeConundrumKata;

/*
 * REGLAS DEL JUEGO:
 * Hay un número N1 de juegos, cada juego tiene un número N2 de puñados.
 * En cada puñado se sacan un número x,y,z de cubos de una bolsa,
 * siendo x = rojo, y = verde y z = azul.
 * La bolsa cuenta con un número limitado de cubos de cada color.
 * 
 * 1. Hay que saber qué juegos son posibles.
 *  Un juego es posible cuando puede contener el puñado del gnomo.
 * 2. Sumar los IDs de los juegos posibles.
 */

public class Tests
{
    [Test]
    public void gagsd()
    {
        var sut = new Game();

        var isGamePossible = sut.IsGamePossible(12,13,14);
        
        Assert.IsTrue(isGamePossible);
    }

}

public class Game
{
    public bool? IsGamePossible(int i, int i1, int i2)
    {
        return true;
    }
}