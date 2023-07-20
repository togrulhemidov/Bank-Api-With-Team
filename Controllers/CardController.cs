using Bank_App_With_Team.Application.Model.DTO.Card;
using Bank_App_With_Team.Data;
using Bank_App_With_Team.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Bank_App_With_Team.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardController : ControllerBase
    {

        public BankDBContext _context { get; }
        public CardController(BankDBContext context)
        {
            _context = context;
        }



        [HttpGet]
        public async Task<ActionResult> GetCards()
        {
            var cardList = await _context.Cards.ToListAsync();
            return Ok(cardList);

        }



        [HttpPost]
         public async Task<IActionResult>AddCard(AddCardUIDTO card)
         {
            Random random = new Random();
            Card cardEntity = new()
            { BankId = card.BankId,
                FirstEightNumber = random.Next(10000000, 99999999),
                CashBack = card.CashBack,
                Expiereyear = card.Expiereyear,
                IsActive = true
            };
            await _context.Cards.AddAsync(cardEntity);
            await _context.SaveChangesAsync();
            return Ok(card);
         }



        [HttpPost]
        public async Task<IActionResult> UpdateCard( UpdateCardUIDTO card)
        {  
            

          
            var cardEntity=await _context.Cards.FindAsync(card.id);
            if (cardEntity is null)
            {
                return NotFound();
            }
            cardEntity.id = card.id;
            cardEntity.BankId = card.BankId;
            cardEntity.FirstEightNumber = card.FirstEightNumber;
            cardEntity.CashBack = card.CashBack;
            card.Expiereyear = card.Expiereyear;
            await _context.SaveChangesAsync();
            return Ok();
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteCard(int Id)
        {
            var deleteEntity = await _context.Cards.Where(m=>m.id ==Id).FirstOrDefaultAsync();
            if (deleteEntity is null)
            {
                return NotFound();
            }

           deleteEntity.IsActive = false;
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
