using Bank_App_With_Team.Data;
using Bank_App_With_Team.DTO;
using Bank_App_With_Team.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Bank_App_With_Team.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardCustomerController : ControllerBase
    {
        BankDBContext _context { get; set; }    
        public CardCustomerController(BankDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCardCustomers()
        {
            var cc = await _context.CardCustomers.ToListAsync();
            return Ok(cc);
        }


        [HttpGet]
        public async Task<IActionResult> Get(int id) 
        {
            var result = await _context.CardCustomers.FindAsync(id);
            if (result == null )
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddCardCustomer(AddCardCustomerUIDTO cardcustomer)
        {
            Random rnd = new Random();
            var card = await _context.Cards.FindAsync(cardcustomer.CardId);
            var exyear = card.Expiereyear;
            string fullnumber = card.FirstEightNumber + "" + rnd.Next(10000000, 99999999);
            CardCustomer cc = new CardCustomer {FullNumber = Convert.ToInt64(fullnumber), CardId=cardcustomer.CardId, Cvv = cardcustomer.Cvv,
            CustomerId=cardcustomer.CustomerId,CreateDate=cardcustomer.CreateDate,ExpiereDate=cardcustomer.CreateDate.AddYears(exyear)};
            await _context.CardCustomers.AddAsync(cc);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCardCustomerUIDTO cardcustomer)
        {
            var cc = await _context.CardCustomers.FindAsync(cardcustomer.ID);
            if (cc == null)
                return NotFound();
            cc.FullNumber = cardcustomer.FullNumber;
            cc.Cvv = cardcustomer.Cvv;
            cc.ExpiereDate = cardcustomer.ExpiereDate;
            cc.IsActive = true;
            await _context.SaveChangesAsync();
            return Ok(cc);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id) 
        {
            var cc = await _context.CardCustomers.FindAsync(id);
            if (cc == null)
                return NotFound();
            cc.IsActive = false;
            await _context.SaveChangesAsync();
            return Ok(cc);
        }
    }
}
