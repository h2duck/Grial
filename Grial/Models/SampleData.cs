﻿using System.Collections.Generic;
using System.Linq;

namespace UXDivers.Artina.Grial
{
	public static class SampleData
	{
		public static string[] Names = {
			"Pat Davies", 		
			"Janis Spector",  	
			"Regina Joplin", 		
			"Jaco Morrison",  	
			"Margaret Whites", 	
			"Skyler Harrisson",  
			"Al Pastorius", 		
		};

		public static List<string> SocialImageGalleryItems = new List<string>() { 
			"social_album_1.jpg",
			"social_album_2.jpg",
			"social_album_3.jpg",	
			"social_album_4.jpg",
			"social_album_5.jpg",
			"social_album_6.jpg", 
			"social_album_7.jpg",
			"social_album_8.jpg",
			"social_album_9.jpg"
		};

		public static List<string> ArticlesImagesList = new List<string>() { 
			"article_image_0.jpg",
			"article_image_1.jpg",
			"article_image_2.jpg",
			"article_image_3.jpg",
			"article_image_4.jpg",
			"article_image_5.jpg"
		};

		public static List<string> UsersImagesList = new List<string>() { 
			"friend_thumbnail_27.jpg",
			"friend_thumbnail_31.jpg",
			"friend_thumbnail_34.jpg",
			"friend_thumbnail_55.jpg",
			"friend_thumbnail_71.jpg",
			"friend_thumbnail_75.jpg",
			"friend_thumbnail_93.jpg",
		};

		public static List<string> DashboardImagesList = new List<string>() { 
			"dashboard_thumbnail_0.jpg",
			"dashboard_thumbnail_1.jpg",
			"dashboard_thumbnail_2.jpg",
			"dashboard_thumbnail_3.jpg",
			"dashboard_thumbnail_4.jpg",
			"dashboard_thumbnail_5.jpg",
			"dashboard_thumbnail_6.jpg",
			"dashboard_thumbnail_7.jpg",
			"dashboard_thumbnail_8.jpg",
		};

		public static List<string> ProductsImagesList = new List<string>() { 
			"product_item_0.jpg",
			"product_item_1.jpg",
			"product_item_2.jpg",
			"product_item_3.jpg",
			"product_item_4.jpg",
			"product_item_5.jpg",
			"product_item_6.jpg",
			"product_item_7.jpg",
		};

		public static List<User> Users = new List<User> {
			new User( Names[0], UsersImagesList[0] ),
			new User( Names[1], UsersImagesList[1] ),
			new User( Names[2], UsersImagesList[2] ),
			new User( Names[3], UsersImagesList[3] ),
			new User( Names[4], UsersImagesList[4] ),
			new User( Names[5], UsersImagesList[5] ),
			new User( Names[6], UsersImagesList[6] ),
		};

		public static List<User> Friends = Users;


		public static List <Post> Posts = new List<Post> {

			new Post {
				Title 			= "The face of Wild Nature",
				Body 			= "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent et aliquet nunc. \nSed ultricies sed augue sit amet maximus. In vel tellus sed ipsum volutpat venenatis et sit amet diam. Suspendisse feugiat mollis nibh, in facilisis diam convallis sit amet. \n\nMaecenas lectus turpis, rhoncus et est at, lacinia placerat urna. Praesent malesuada consectetur justo, scelerisque fermentum enim lobortis ullamcorper. Duis commodo sit amet ligula vitae luctus. Nulla commodo ipsum a lorem efficitur luctus.",
				Section			= "NATURE",
				Author 			= "UXDIVERS",
				Avatar 			= SampleData.Friends[3].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[0],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[3].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",
			},
			new Post {
				Title 			= "Upercut to glory",
				Body 			= "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
				Section			= "SPORTS",
				Author 			= SampleData.Friends[0].Name,
				Avatar 			= SampleData.Friends[0].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[1],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[0].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",

			},
			new Post {
				Title 			= "Street and its influence on design",
				Body 			= "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
				Section			= "DESIGN",
				Author 			= SampleData.Friends[2].Name,
				Avatar 			= SampleData.Friends[2].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[2],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[2].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",

			},
			new Post {
				Title 			= "The time for new adventures",
				Body 			= "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
				Section			= "TRAVEL",
				Author 			= "UXDIVERS",
				Avatar 			= SampleData.Friends[1].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[3],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[1].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",

			},
			new Post {
				Title 			= "Shooting like pros, learn how",
				Body 			= "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
				Section			= "FREE TIME",
				Author 			= SampleData.Friends[4].Name,
				Avatar 			= SampleData.Friends[4].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[4],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[0].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",

			},

			new Post {
				Title 			= "The search for healthy food begins",
				Body 			= "In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors. This is how we design a great article sample.",
				Section			= "HEALTH",
				Author 			= SampleData.Friends[5].Name,
				Avatar 			= SampleData.Friends[5].Avatar,
				BackgroundImage = SampleData.ArticlesImagesList[5],
				Quote 			= "Donec euismod nulla et sem lobortis ultrices. Cras id imperdiet metus. Sed congue luctus arcu.",
				QuoteAuthor 	= SampleData.Friends[5].Name,
				When 			= "JUN 15, 2015",
				Likes 			= "92",
				Followers		= "2K",

			},
		};

		public static List<Message> Messages = new List<Message> {
			new Message( 
				Friends[5], 
				7, 
				true,
				"July 7",
				"Hey check this out!", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				true
			),

			new Message( 
				Friends[1], 
				3, 
				false,
				"Yesterday",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				true
			),

			new Message( 
				Friends[2], 
				1, 
				true,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				false
			),

			new Message( 
				Friends[3], 
				2, 
				true,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				false,
				false
			),

			new Message( 
				Friends[4], 
				10, 
				false,
				"3 minutes ago",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				false
			),

			new Message( 
				Friends[0], 
				5, 
				false,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				true
			),

			new Message( 
				Friends[6], 
				7, 
				false,
				"July 7",
				"Artina is awesome...you'll love it", 
				"In connection with this appellative of 'Whalebone whales,' it is of great leap of yer happiness leadership colors.", 
				true,
				false
			),

		};

		public static List<Message> Comments = Messages.GetRange( (Messages.Count() / 2), (Messages.Count() / 2));	

		public static List<User> SmallUserList = Users.GetRange( 0, 2);	

		public static List<Post> SmallPostList = Posts.GetRange( 0, 1);	

		public static List<ChatMessage> ChatMessagesList = new List<ChatMessage> {
			new ChatMessage (
				Friends [5],
				"July 7",
				"Hey buddy :), what's up? I'm currently working on this amazing stuff called Grial. Have you heard about it? You shoud give it a try....it really rocks!!!!!."
			),
			new ChatMessage (
				Friends [5],
				"July 7",
				"You should give it a try!"
			),
			new ChatMessage (
				Friends [1],
				"July 7",
				"Wooow! Didn't know this exist!! Really cool stuff!"
			),

			new ChatMessage (
				Friends [1],
				"July 7",
				"I was wondering if something like this existed. This will save hundred of hours. I rather be skateboarding with my friends instead of compiling every little visual change." +
				"Thanks for sharing!"
			),

			new ChatMessage (
				Friends [5],
				"July 7",
				"No problem! I hope you can find it useful. It really makes the difference to me."
			),

			new ChatMessage (
				Friends [1],
				"July 7",
				"Ok thanks and thanks again!! This is really awesome"
			),

			new ChatMessage (
				Friends [5],
				"July 7",
				"Indeed."
			),

			new ChatMessage (
				Friends [1],
				"July 7",
				"C u later tonight at Gillian Japi party, right?"
			),

			new ChatMessage (
				Friends [5],
				"July 7",
				"For sure! See you later :)"
			),
		};


		public static List <Product> Products = new List<Product> {
			new Product {
				Name 			= "Logo Tee",
				Description 	= "Cotton/ploy blend lends for ultimate comfort.",
				Image 			= SampleData.ProductsImagesList[0],
				Price 			= "$39",
				ThumbnailHeight  = "100"
			},

			new Product {
				Name 			= "Big Logo Shirt",
				Description 	= "This Logo UA Tech T-Shirt is built with a system that wicks away sweat to keep your little one dry and comfortable.",
				Image 			= SampleData.ProductsImagesList[1],
				Price 			= "$29",
				ThumbnailHeight  = "100"
			},

			new Product {
				Name 			= "Classic Tee",
				Description 	= "The V-Neck Embroidered T-Shirt keeps you looking fresh with its simple yet classic look. 100% cotton. Imported.",
				Image 			= SampleData.ProductsImagesList[2],
				Price 			= "$39",
				ThumbnailHeight  = "100"
			},

			new Product {
				Name 			= "Loose Fit Tee",
				Description 	= "Our newest swim tees with a much looser fit than traditional rash guard for yet more comfort and versatility, is well known for great fit, function and colors.",
				Image 			= SampleData.ProductsImagesList[3],
				Price 			= "$29",
				ThumbnailHeight  = "100"
			},

			new Product {
				Name 			= "Cotton Tee",
				Description 	= "Standard fit tee shirt, graphic printed with soft hand ink",
				Image 			= SampleData.ProductsImagesList[4],
				Price 			= "$29",
				ThumbnailHeight = "100"
			},

			new Product {
				Name 			= "Sports Tee",
				Description 	= "Comfortable fit whilst the flat-seam construction helps to minimise chafing and they also feature side panels, enhancing your range of movement.",
				Image 			= SampleData.ProductsImagesList[5],
				Price 			= "$39",
				ThumbnailHeight  = "100"
			},

			new Product {
				Name 			= "Classic T-Shirt",
				Description 	= "All you need for a comfort day.",
				Image 			= SampleData.ProductsImagesList[6],
				Price 			= "$29",
				ThumbnailHeight = "100"
			},

			new Product {
				Name 			= "Product name 8",
				Description 	= "The long sleeves provide extra coverage and warmth and the sweat-wicking Dri-FIT fabric keeps you comfortable. The lightweight layer contours to your body and strategic mesh panels increase airflow. 92% polyester, 8% spandex.",
				Image 			= SampleData.ProductsImagesList[7],
				Price 			= "$29",
				ThumbnailHeight = "100"
			}
		};
	}
}