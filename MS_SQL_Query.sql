/*
 SQL querys for creating DB in MS-SQL
*/

create database Twitter

create table Location(
	ID			int				not null primary key identity,
	Name		varchar(50)		not null,
	Geo_width	float			not null,
	Geo_height	float			not null
)

create table Users(
	Id			int 			not null primary key identity,
	Name		nvarchar(20)	not null,
	Surname		nvarchar(20)	not null,
	Nickname	nvarchar(20)	not null,
	Picture_URL	nvarchar(max),
		
	Location	int			references Location(ID)
)

create table Tweet(
	ID			int				not null primary key identity,
	Text		varchar(140)	not null,

	Author		int				not null references Users(Id)
)

create table Hashtag(
	ID			int				not null primary key identity,
	Text		nvarchar(139)	not null
)

create table Comment(
	ID			int				not null primary key identity,
	Text		nvarchar(max)	not null,

	Tweet		int				references Tweet(ID),
	Author		int				references Users(ID)
)

create table FavouriteTweet(
	Id				int			not null primary key identity,
	
	User_favourite	int			not null references Users(Id),		/*ovo je osoba koja klika favourite*/
	Tweet			int			not null references Tweet(ID)
)

create table TweetHashtagConnection (
	ID			int				not null primary key identity,
	Tweet	int					not null references Tweet(ID),
	Hashtag	int					not null references Hashtag(ID)
)
