using System.Numerics;
using Tic_Tac_Toe;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Matker = "X";
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Matker = "O";
            Game game = new Game(playerOne, playerTwo);
            Board board = new Board();
            board.GameBoard[0, 0] = "X";
            board.GameBoard[0, 1] = "X";
            board.GameBoard[0, 2] = "X";
            // Act
            bool hasWinner = game.CheckForWinner(board);
            // Assert
            Assert.Equal(hasWinner, true);


        }
        [Fact]
        public void Test2()
        {

            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Matker = "X";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Matker = "O";
            playerTwo.IsTurn = false;
            Game game = new Game(playerOne, playerTwo);

            // Act
            game.SwitchPlayer();
            bool hasChange = playerOne.IsTurn == false && playerTwo.IsTurn == true;
            // Assert
            Assert.Equal(hasChange, true);


        }
        [Fact]
        public void Test3()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Matker = "X";

            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Matker = "O";
            Game game = new Game(playerOne, playerTwo);


            // Act
            var postion = Player.PositionForNumber(1);

            int[] expected = new int[] { 0, 0 };
            int[] actual = new int[] { postion.Row, postion.Column };
            // Assert
            Assert.Equal(expected, actual);


        }
        [Fact]
        public void Test4()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Matker = "X";
            playerOne.IsTurn = true;
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Matker = "O";
            Game game = new Game(playerOne, playerTwo);


            // Act
            var player = game.NextPlayer();


            // Assert
            Assert.Equal(player, playerOne);


        }
    }
}