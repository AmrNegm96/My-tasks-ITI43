using Microsoft.AspNetCore.SignalR;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Hubs
{
    public class ProductHub : Hub
    {
        private readonly Context _context;

        public ProductHub(Context context)
        {
            _context = context;
        }
        public void buy(int id)
        {
            var prd = _context.Products.Find(id);
            if (prd != null)
            {
                if(prd.Quantity > 0)
                {
                    prd.Quantity--;
                    _context.SaveChanges();
                    Clients.All.SendAsync("UpdatePrdQuantity", prd.Quantity);
                }
            }
            
        }
        public void addReview(int id , string rvw)
        {
            var prd = _context.Products.Find(id);
            if (prd != null)
            {
                var review = new Review(){ Text= rvw , ProductId=id};
                _context.Reviews.Add(review);
                _context.SaveChanges();
                Clients.All.SendAsync("AddedReview", review.Text);
            }
        }
    }
}
