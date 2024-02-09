namespace CubeConundrumKata;

/*
 * 1. Número N1 de juegos, cada juego tiene un número N2 de puñados.
 * 2. En cada puñado se sacan un número x,y,z de cubos de una bolsa,
 *  siendo x = rojo, y = verde y z = azul.
 * 3. La bolsa cuenta con un número limitado de cubos de cada color.
 * 4. Hay que saber qué juegos son posibles.
 *  Un juego es posible cuando puede contener el puñado del gnomo.
 * 5. Por último, sumar los IDs de los juegos posibles.
 */

public class Tests
{
    [Test]
    public void Grab_Cubes()
    {
        var sut = new Bag();

        var hand = sut.GrabCubes();
        
        Assert.IsNotEmpty(hand);
    }

    [Test]
    public void Add_Cubes()
    {
        var sut = new Bag();

        sut.AddCube("");
        
    }
}

public class Bag
{
    private List<string> _cubes;

    public Bag()
    {
        _cubes = new List<string>();
        _cubes.Add("");
    }
    
    public List<string> GrabCubes()
    {
        return _cubes;
    }

    public void AddCube(string cube)
    {
        _cubes.Add(cube);
    }
}