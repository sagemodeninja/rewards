using Microsoft.EntityFrameworkCore;
using RewardsApp.SQLite.Data;
using RewardsApp.SQLite.Utilities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RewardsApp.SQLite.Entities
{
    public class Card
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public GenericEntityStatus Status { get; set; }

        #region NAVIGATION PROPERTIES

        public Customer Customer { get; set; }

        #endregion NAVIGATION PROPERTIES

        public Card() { }

        public Card(string number)
        {
            Number = number;
        }

        public async Task Create()
        {
            await using RewardsAppContext context = new();
            context.Cards.Add(this);
            await context.SaveChangesAsync();
        }

        public async Task Update()
        {
            await using RewardsAppContext context = new();
            context.Cards.Update(this);
            await context.SaveChangesAsync();
        }

        public async Task Delete()
        {
            this.Status = GenericEntityStatus.Inactive;
            await this.Update();
        }

        public static async Task<List<Card>> GetAll()
        {
            await using RewardsAppContext context = new();
            return await context.Cards.Include(c => c.Customer)
                                      .Where(c => c.Status == GenericEntityStatus.Active)
                                      .ToListAsync();
        }

        public static async Task<Card> GetByNumber(string cardNumber)
        {
            await using RewardsAppContext context = new();

            return await context.Cards.Include(c => c.Customer)
                                      .FirstOrDefaultAsync(c => c.Number == cardNumber && c.Status == GenericEntityStatus.Active);
        }
    }
}
