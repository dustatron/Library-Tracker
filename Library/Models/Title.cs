using System.Collections.Generic;

namespace Library.Models
{
  public class Title
  {
    public Title()
    {
      this.Authors = new HashSet<Book>();
      this.Patrons = new HashSet<Checkout>();
    }

    public int TitleId { get; set; }
    public int BookId { get; set; }

    public int PatronId { get; set; }
    public string BookName { get; set; }
    public int Quantity { get; set; }
    public virtual ApplicationUser User { get; set; }

    public ICollection<Book> Authors { get; }
    public ICollection<Checkout> Patrons { get; }
  }
}