namespace Jeu_du_serpent.UniTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void MovingOnTheBoardIsValid()
    {
        Player player = new Player("TestPlayer");
        player.PlayerPosition = 0;

        int initialPosition = player.PlayerPosition;
        Gameboard.PlayGame(player);

        Assert.IsTrue(player.PlayerPosition > initialPosition);
    }


    [TestMethod]
    public void ReturningToSquare25IsValid()
    {
        Player player = new Player("TestPlayer");
        player.PlayerPosition = Gameboard.TotalSquares - 1;

        Gameboard.PlayGame(player);

        Assert.AreEqual(25, player.PlayerPosition);

    }

    [TestMethod]
    public void TrapSquareIsValid()
    {
        Player player = new Player("TestPlayer");
        player.PlayerPosition = 36;

        Gameboard.PlayGame(player);

        Assert.AreEqual(12, player.PlayerPosition);
    }

    [TestMethod]
    public void BonusSquareIsValid()
    {
        Player player = new Player("TestPlayer");
        player.PlayerPosition = 19;

        Gameboard.PlayGame(player);

        Assert.AreEqual(35, player.PlayerPosition);

    }

    [TestMethod]
    public void WinnerIsValid()
    {
        Player player = new Player("TestPlayer");
        player.PlayerPosition = Gameboard.TotalSquares -3;

        Gameboard.PlayGame(player);

        Assert.IsTrue(player.IsWinner);

    }
}
