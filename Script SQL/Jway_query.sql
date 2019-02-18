create database JWork;

use JWork;

create table cage
(

	Num�ro int primary key,
	"Nombre d'�tage" int,
	"Quantit� total" int,
	"Poids de cage" float

);

create table �tage
(

	Id int primary key,
	Quantit� int,
	Cage int,
	"Poids d'�tage" float,
	"Quantit� maximale" int,
	constraint ck_etage_cage foreign key (Cage) references cage(Num�ro)

);

create table type
(

	Id int primary key identity,
	Nom varchar(255),
	"Date de registration" date,
	"Nombre de calories" float
);

create table categorie
(

	Id int primary key identity,
	Nom varchar(255),
	"Date de registration" date,
	Type int,
	constraint ck_categorie_type foreign key (type) references type(id)

)

create table produit
(

	Id int primary key,
	"Date d'�xpiration" date,
	"Date d'entr�e" date,
	"Date de sortie" date,
	Libelle varchar(255),
	Prix Float,
	Type int,
	Cat�gorie int,
	Cage int,
	Etage int,
	Poids float,
	Quantit� int,
	"Code � barre" image,
	constraint ck_produit_type foreign key (type) references type(Id),
	constraint ck_produit_categorie foreign key (Cat�gorie) references categorie(Id),
	constraint ck_produit_cage foreign key (Cage) references cage(Num�ro),
	constraint ck_produit_etage foreign key (Etage) references �tage(Id)

);

-- Table �tage

create trigger tr_insert_etage
on �tage
after insert
As
Begin

	update cage set "Nombre d'�tage" = "Nombre d'�tage" + 1 where Num�ro = ( select Cage from inserted )
	Update cage set "Poids de cage" = "Poids de cage" + ( select "Poids d'�tage" from inserted ) where Num�ro = ( select cage from inserted )
	update cage set "Quantit� total" = "Quantit� total" + ( select quantit� from inserted ) where Num�ro = ( select cage from inserted )

End

create trigger tr_delete_etage
on �tage
after delete
AS
BEGIN

	update cage set "Nombre d'�tage" = "Nombre d'�tage" - 1 where Num�ro = ( select cage from deleted )
	update cage set "Poids de cage" = "Poids de cage" - ( select "Poids d'�tage" from deleted ) where Num�ro = ( select cage from deleted )
	update cage set "Quantit� total" = "Quantit� total" - ( select quantit� from deleted ) where Num�ro = ( select cage from deleted )
	
End

create trigger tr_update_etage
on �tage
for update
As
BEGIN
	
	update cage set "Quantit� total" = "Quantit� total" - ( select quantit� from deleted ) where Num�ro = ( select cage from deleted )
	Update cage set "Poids de cage" = "Poids de cage" - ( select "Poids d'�tage" from  deleted ) where Num�ro = ( select cage from deleted )
	
	update cage set "Quantit� total" = "Quantit� total" + ( select quantit� from inserted ) where Num�ro = ( select cage from inserted )
	Update cage set "Poids de cage" = "Poids de cage" + ( select "Poids d'�tage" from inserted ) where Num�ro = ( select cage from inserted )
	
End

-- Table Produit

create trigger tr_insert_produit
on produit
for insert
as
begin

	declare @quantit�_exists as int
	declare @quantit�_ajouter as int
	declare @quantit�_maximale as int

	set @quantit�_exists = (select quantit� from �tage where Id = (select etage from inserted))
	set @quantit�_ajouter = ( select quantit� from inserted )
	set @quantit�_maximale = ( select "Quantit� maximale" from �tage where Id = (select etage from inserted) )

	if((@quantit�_ajouter + @quantit�_exists) > @quantit�_maximale)
		throw 51000, 'La quantit� ajouter est depasser la quantit� disponible', 1
	ELSE
		update �tage set Quantit� = Quantit� + ( select Quantit� from inserted ) where Id = ( select Etage from inserted )
		update �tage set "Poids d'�tage" = "Poids d'�tage" + (( select Poids from inserted ) * ( select Quantit� from inserted )) where Id = ( select Etage from inserted )

end

create trigger tr_update_produit
on produit
for update
as
begin

	declare @quantit�_exists as int
	declare @quantit�_ajouter as int
	declare @quantit�_maximale as int

	set @quantit�_exists = (select quantit� from �tage where Id = (select etage from inserted))
	set @quantit�_ajouter = ( select quantit� from inserted )
	set @quantit�_maximale = ( select "Quantit� maximale" from �tage where Id = (select etage from inserted) )

	if(@quantit�_ajouter > @quantit�_maximale)
		throw 51000, 'La quantit� ajouter est depasser la quantit� disponible', 1
	else	
		update �tage set Quantit� = Quantit� - ( select Quantit� from deleted ) where Id = ( select Etage from deleted )
		update �tage set "Poids d'�tage" = "Poids d'�tage" - (( select poids from deleted ) * ( select Quantit� from deleted )) where Id = ( select Etage from deleted )
	
		update �tage set Quantit� = Quantit� + ( select Quantit� from inserted ) where Id = ( select Etage from inserted )
		update �tage set "Poids d'�tage" = "Poids d'�tage" + (( select Poids from inserted ) * ( select Quantit� from inserted )) where Id = ( select Etage from inserted )
	
end

create trigger tr_delete_produit
on produit
after delete
AS
BEGIN

	update �tage set Quantit� = Quantit� - ( select Quantit� from deleted ) where Id = ( select Etage from deleted )
	update �tage set "Poids d'�tage" = "Poids d'�tage" - (( select poids from deleted ) * ( select Quantit� from deleted )) where Id = ( select Etage from deleted )
	
end