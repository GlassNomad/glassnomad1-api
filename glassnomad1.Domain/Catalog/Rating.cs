namespace glassnomad1.Domain.Catalog;


public class Rating
{
    public int Id { get; set;}
    public int Stars {get; set;}
    public string? UserName {get; set;}
    public string? Review {get; set;}

public Rating(int stars, string userName, string review)
        {

             if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer between 1 and 5.");
            }

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null or empty.");
            }

            this.Stars = stars;
            this.UserName = userName;
            this.Review = review;

        }

}
   