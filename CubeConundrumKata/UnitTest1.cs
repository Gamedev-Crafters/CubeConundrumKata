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
    public void Is_Handful_Possible()
    {
        var sut = new Handful(3,4,5);

        var result = sut.IsPossible(12,13,14);
        
        Assert.IsTrue(result);
    }

    [Test]
    public void Handful_Is_Not_Possible()
    {
        var sut = new Handful(43,4,5);

        var result = sut.IsPossible(12,13,14);
        
        Assert.IsFalse(result);
    }
    
    [Test]
    public void Is_Game_Possible()
    {
        var sut = new Game(new List<Handful>());

        var result = sut.IsPossible(12,13,14);
        
        Assert.IsTrue(result);
    }
    [Test]
    public void Game_Is_Not_Possible()
    {
        var sut = new Game(new List<Handful>());

        var result = sut.IsPossible(12,13,14);
        
        Assert.IsFalse(result);
    }

}

public class Game
{
    private readonly List<Handful> _handfuls;

    public Game(List<Handful> handfuls)
    {
        _handfuls = handfuls;
    }

    public bool IsPossible(int redCubesInBag, int greenCubesInBag, int blueCubesInBag)
    {
        foreach (var handful in _handfuls)
        {
            if (handful.IsPossible(redCubesInBag,greenCubesInBag,blueCubesInBag))
                continue;
            return false;
        }

        return true;
    }
}

public class Handful
{
    private int red_cubes;
    private int green_cubes;
    private int blue_cubes;

    public Handful(int redCubes, int greenCubes, int blueCubes)
    {
        red_cubes = redCubes;
        green_cubes = greenCubes;
        blue_cubes = blueCubes;
    }

    public bool IsPossible(int redCubesInBag, int greenCubesInBag, int blueCubesInBag)
    {
        return redCubesInBag >= red_cubes && greenCubesInBag >= green_cubes && blueCubesInBag >= blue_cubes;
    }
}