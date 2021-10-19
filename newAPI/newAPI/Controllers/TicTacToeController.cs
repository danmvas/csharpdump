using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using newAPI.Model;
using newAPI.Services;

namespace newAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicTacToeController : ControllerBase
    {
        // post com estado do jogo onde vai estar preenchido ou nao 
        // get pra pegar onde q ta clicando
          
        // GET PLAYER
        [HttpGet("{player}")]
        public User GetPosPlayer(string id)
        {
            
        }
        
        // GET BOT
        [HttpGet("{bot}")]
        public IEnumerable<User> GetPosBot()
        {
            
        }

        // POST
        [HttpPost]
        public ActionResult Add(User user)
        {
            if (!CheckUsers.ExistentUsers(user.Id))
            {
                using var db = new Data.ApplicationContext();
                db.Users.Add(user);
                db.SaveChanges();
                return Ok();
            }

            return BadRequest();
        }

        // DELETE
        [HttpDelete]
        public ActionResult Delete()
        {

        }

        // ------------------------------------------------------------------------------------- 

        //                          FUNÇÕES DO BOT ABAIXO!

        // -------------------------------------------------------------------------------------

        readonly int[,] board = new int[3, 3];

        // a ser chamada no inicio de todo jogo pra poder limpar as casas
        void EmptyBoard()
        {
            for (int i = 0; i < 3; i++){
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = -1;
                }
            }
        }

        // verificacao se tá tudo preenchido ou se tem casa pra jogar
        Boolean ChecksFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == -1)
                        return false;
                }
            }

            return true;
        }

        Boolean ChecksWinner()
        {
            
        }

        void Minimax(board, depth, isMaximizingPlayer)
        {
            if (checksFull())
            {

            }

            else
            {
                if (depth == 0 || board)
            }
        }

        // 
        void BestMove()
        {
            // bot to make its turn
            double bestScore = double.NegativeInfinity;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i,j] == '')
                    {
                        board[i,j] = ApplicationId;
                        double score = minimax(board, 0, true);
                        board[i,j] = '';

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = { i, j };
                        }
                    }
                }
            }

            board[bestMove().i, bestMove().j] = ApplicationId;
            currentPlayer = human;
        }

    }
}
