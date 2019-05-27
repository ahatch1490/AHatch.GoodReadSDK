using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AHatch.GoodReadsSDK.Client;

namespace AHatch.GoodReadsSDK
{
    public class ShelfService
    {
        private readonly IClientContext _clientContext; 
        public ShelfService(IClientContext clientContext)
        {
            _clientContext = clientContext;
        }

        public async Task<Response<GoodreadsResponse>> GetShelf()
        {
            var builder = new UrlBuilder.UrlBuilder($"{_clientContext.Host}/review/list/{_clientContext.UserId}.xml?key={_clientContext.ApiKey}");
            var response = await _clientContext.GetAsync<GoodreadsResponse>(builder.GetUrl());
            return response;
        }
    }



   

    public class Response<T>
    {
        public T Item { get; set; }
    }
    
       /* 
    Licensed under the Apache License, Version 2.0
    
    http://www.apache.org/licenses/LICENSE-2.0
    */


	[XmlRoot(ElementName="Request")]
	public class Request {
		[XmlElement(ElementName="authentication")]
		public string Authentication { get; set; }
		[XmlElement(ElementName="key")]
		public string Key { get; set; }
		[XmlElement(ElementName="method")]
		public string Method { get; set; }
	}

	[XmlRoot(ElementName="shelf")]
	public class Shelf {
		[XmlAttribute(AttributeName="exclusive")]
		public string Exclusive { get; set; }
		[XmlAttribute(AttributeName="id")]
		public string Id { get; set; }
		[XmlAttribute(AttributeName="name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName="sortable")]
		public string Sortable { get; set; }
		[XmlAttribute(AttributeName="review_shelf_id")]
		public string ReviewShelfId { get; set; }
	}

	[XmlRoot(ElementName="id")]
	public class Id {
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="isbn")]
	public class Isbn {
		[XmlAttribute(AttributeName="nil")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName="isbn13")]
	public class Isbn13 {
		[XmlAttribute(AttributeName="nil")]
		public string Nil { get; set; }
	}

	[XmlRoot(ElementName="text_reviews_count")]
	public class TextReviewsCount {
		[XmlAttribute(AttributeName="type")]
		public string Type { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="description")]
	public class Description {
		[XmlElement(ElementName="br")]
		public List<string> Br { get; set; }
		[XmlElement(ElementName="b")]
		public B B { get; set; }
		[XmlElement(ElementName="i")]
		public List<I> I { get; set; }
	}

	[XmlRoot(ElementName="image_url")]
	public class ImageUrl {
		[XmlAttribute(AttributeName="nophoto")]
		public string NoPhoto { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="small_image_url")]
	public class SmallImageUrl {
		[XmlAttribute(AttributeName="nophoto")]
		public string NoPhoto { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName="author")]
	public class Author {
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="name")]
		public string Name { get; set; }
		[XmlElement(ElementName="role")]
		public string Role { get; set; }
		[XmlElement(ElementName="image_url")]
		public ImageUrl ImageUrl { get; set; }
		[XmlElement(ElementName="small_image_url")]
		public SmallImageUrl SmallImageUrl { get; set; }
		[XmlElement(ElementName="link")]
		public string Link { get; set; }
		[XmlElement(ElementName="average_rating")]
		public string AverageRating { get; set; }
		[XmlElement(ElementName="ratings_count")]
		public string RatingsCount { get; set; }
		[XmlElement(ElementName="text_reviews_count")]
		public string TextReviewsCount { get; set; }
	}

	[XmlRoot(ElementName="authors")]
	public class Authors {
		[XmlElement(ElementName="author")]
		public Author Author { get; set; }
	}

	[XmlRoot(ElementName="work")]
	public class Work {
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="uri")]
		public string Uri { get; set; }
	}

	[XmlRoot(ElementName="book")]
	public class Book {
		[XmlElement(ElementName="id")]
		public Id Id { get; set; }
		[XmlElement(ElementName="isbn")]
		public Isbn Isbn { get; set; }
		[XmlElement(ElementName="isbn13")]
		public Isbn13 Isbn13 { get; set; }
		[XmlElement(ElementName="text_reviews_count")]
		public TextReviewsCount Text_reviews_count { get; set; }
		[XmlElement(ElementName="uri")]
		public string Uri { get; set; }
		[XmlElement(ElementName="title")]
		public string Title { get; set; }
		[XmlElement(ElementName="title_without_series")]
		public string TitleWithoutSeries { get; set; }
		[XmlElement(ElementName="image_url")]
		public string ImageUrl { get; set; }
		[XmlElement(ElementName="small_image_url")]
		public string SmallImageUrl { get; set; }
		[XmlElement(ElementName="large_image_url")]
		public string LargeImageUrl { get; set; }
		[XmlElement(ElementName="link")]
		public string Link { get; set; }
		[XmlElement(ElementName="num_pages")]
		public string NumPages { get; set; }
		[XmlElement(ElementName="format")]
		public string Format { get; set; }
		[XmlElement(ElementName="edition_information")]
		public string EditionInformation { get; set; }
		[XmlElement(ElementName="publisher")]
		public string Publisher { get; set; }
		[XmlElement(ElementName="publication_day")]
		public string PublicationDay { get; set; }
		[XmlElement(ElementName="publication_year")]
		public string PublicationYear { get; set; }
		[XmlElement(ElementName="publication_month")]
		public string PublicationMonth { get; set; }
		[XmlElement(ElementName="average_rating")]
		public string AverageRating { get; set; }
		[XmlElement(ElementName="ratings_count")]
		public string RatingsCount { get; set; }
		[XmlElement(ElementName="description")]
		public Description Description { get; set; }
		[XmlElement(ElementName="authors")]
		public Authors Authors { get; set; }
		[XmlElement(ElementName="published")]
		public string Published { get; set; }
		[XmlElement(ElementName="work")]
		public Work Work { get; set; }
	}

	[XmlRoot(ElementName="shelves")]
	public class Shelves {
		[XmlElement(ElementName="shelf")]
		public List<Shelf> Shelf { get; set; }
	}

	[XmlRoot(ElementName="review")]
	public class Review {
		[XmlElement(ElementName="id")]
		public string Id { get; set; }
		[XmlElement(ElementName="book")]
		public Book Book { get; set; }
		[XmlElement(ElementName="rating")]
		public string Rating { get; set; }
		[XmlElement(ElementName="votes")]
		public string Votes { get; set; }
		[XmlElement(ElementName="spoiler_flag")]
		public string Spoiler_flag { get; set; }
		[XmlElement(ElementName="spoilers_state")]
		public string Spoilers_state { get; set; }
		[XmlElement(ElementName="shelves")]
		public Shelves Shelves { get; set; }
		[XmlElement(ElementName="recommended_for")]
		public string Recommended_for { get; set; }
		[XmlElement(ElementName="recommended_by")]
		public string Recommended_by { get; set; }
		[XmlElement(ElementName="started_at")]
		public string Started_at { get; set; }
		[XmlElement(ElementName="read_at")]
		public string Read_at { get; set; }
		[XmlElement(ElementName="date_added")]
		public string Date_added { get; set; }
		[XmlElement(ElementName="date_updated")]
		public string Date_updated { get; set; }
		[XmlElement(ElementName="read_count")]
		public string Read_count { get; set; }
		[XmlElement(ElementName="body")]
		public string Body { get; set; }
		[XmlElement(ElementName="comments_count")]
		public string Comments_count { get; set; }
		[XmlElement(ElementName="url")]
		public string Url { get; set; }
		[XmlElement(ElementName="link")]
		public string Link { get; set; }
		[XmlElement(ElementName="owned")]
		public string Owned { get; set; }
	}

	[XmlRoot(ElementName="b")]
	public class B {
		[XmlElement(ElementName="i")]
		public string I { get; set; }
	}

	[XmlRoot(ElementName="i")]
	public class I {
		[XmlElement(ElementName="b")]
		public string B { get; set; }
	}

	[XmlRoot(ElementName="reviews")]
	public class Reviews {
		[XmlElement(ElementName="review")]
		public List<Review> Review { get; set; }
		[XmlAttribute(AttributeName="start")]
		public string Start { get; set; }
		[XmlAttribute(AttributeName="end")]
		public string End { get; set; }
		[XmlAttribute(AttributeName="total")]
		public string Total { get; set; }
	}

	[XmlRoot(ElementName="GoodreadsResponse")]
	public class GoodreadsResponse {
		[XmlElement(ElementName="Request")]
		public Request Request { get; set; }
		[XmlElement(ElementName="shelf")]
		public Shelf Shelf { get; set; }
		[XmlElement(ElementName="reviews")]
		public Reviews Reviews { get; set; }
	}

}
