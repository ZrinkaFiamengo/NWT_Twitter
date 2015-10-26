/*
 SQL querys for creating DB in MS-SQL
*/

create table Location(
	ID			int not null unique,
	Name		varchar(50) not null,
	Geo_width	float not null,
	Geo_height	float not null,

	primary key (ID)
); 

create table Users(
	ID			int not null unique,
	Name		varchar(20) not null,
	Surname		varchar(20) not null,
	Nickname	varchar(20) not null,
	Picture_URL	varchar(max),
	Location	int,

	primary key (ID),
	foreign key (Location) references Location(ID)
); 

create table Tweet(
	ID			int not null unique,
	Text		varchar(140) not null,
	Author		int not null

	primary key (ID),
	foreign key (Author) references Users(ID)
); 

create table Hashtag(
	ID		int not null unique,
	Text	varchar(139) not null,

	primary key (ID)
);

create table Comment(
	ID		int not null unique,
	Text	varchar(max) not null,
	Tweet	int,
	Author	int,

	primary key (ID),
	foreign key (Tweet)		references Tweet(ID),
	foreign key (Author)	references Users(ID)
);

create table FavouriteTweet(
	ID				int not null unique,
	User_favourite	int not null,		/*ovo je osoba koja klika favourite*/
	Tweet			int not null,

	primary key (ID),
	foreign key (User_favourite)	references Users(ID),
	foreign key (Tweet)				references Tweet(ID),
);

create table TweetHashtagConnection (
	ID		int not null unique,
	Tweet	int not null,
	Hashtag	int not null,

	primary key (ID),
	foreign key (Tweet)		references Tweet(ID),
	foreign key (Hashtag)	references Hashtag(ID),
);
