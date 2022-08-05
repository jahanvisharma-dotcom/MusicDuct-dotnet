using System.Collections.Generic;
using System.Linq;
using WebStore.Core.Entities;
using WebStore.Core.Interfaces;

namespace WebStore.Infrastructure.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
                new Product {ProductId = 1, Name="Yamaha S6X Grand Piano", Price=89200, ShortDescription="Piano", LongDescription="The MPG100 Digital Mini-Size Baby Grand Piano from Kurzweil is an 88-note, fully-weighted, graded hammer-action keyboard with 500 preset sound selections. Featuring pianos, electric pianos, organs, and orchestral instruments, the MPG100 also offers 200 styles, which can be used to provide fully orchestrated backing arrangements including rhythm, bass, and chord accompaniment.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="/Images/Tea/keyboard1.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="/Images/Tea/keyboard1.jpg"},
                new Product {ProductId = 2, Name="Kanha Scale Bamboo Flute", Price=3950, ShortDescription="Flute", LongDescription="We utilize some of the finest natural medium bamboo to create these flutes that reveal the best of natural sound./nAbout this item Material: Assam Bamboo Color: Beige and Red /n Product Dimensions : 76 cmx2.7 cmx2.7 cm Thread Colour-Blue and Red Package Contents: 1 Piece Flute With Cover	", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="/Images/Tea/woodwing1.jpg", InStock=true, IsProductOfTheWeek=false, ImageThumbnailUrl="/Images/Tea/woodwing1.jpg"},
                new Product {ProductId = 3, Name="Ibanez 6 String Electric Guitar", Price=20520, ShortDescription="Guitar", LongDescription="A guitar doesn't have to cost a bundle to sound good. The GIO series developed for players who want Ibanez in a more affordable package. Ibanez GRGA120QA Features GRGA Maple neck Quilted Maple Art Grain top/Poplar body Treated New Zealand Pine fretboard with White dot inlay Jumbo frets Infinity R (H) neck pickup Infinity R (H) bridge pickup T102 bridge Black hardwar", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="/Images/Tea/ibgrga120qbb (1).jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="/Images/Tea/ibgrga120qbb (1).jpg"},
                new Product {ProductId = 4, Name="Kadence Acoustic Violin With Bow", Price=8700, ShortDescription="Violin", LongDescription="About this item 4/4 (Full Size) Acoustic Violin Solid Spruce top : Solid Maple side and back Ebony pegs, chin rest and fingerboard, Brazilwood bow with white horsehair. Lightweight foam fitting soft case, High quality rosin. 1 year warranty against manufacturer's defects. Tail Piece : Wittner Ultra Pegs : Ebony Strings : Kadence Bow: Horse Hair Model no. : KAD-V-001BL", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="/Images/Tea/aa.jpg", InStock=true, IsProductOfTheWeek=true, ImageThumbnailUrl="/Images/Tea/aa.jpg"}
            };

        public IEnumerable<Product> ProductsOfTheWeek { get; }

        public Product GetProductById(int productId)
        {
            return AllProducts.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}