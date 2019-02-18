create database JWork;

use JWork;

create table cage
(

	Numéro int primary key,
	"Nombre d'étage" int,
	"Quantité total" int,
	"Poids de cage" float

);

create table étage
(

	Id int primary key,
	Quantité int,
	Cage int,
	"Poids d'étage" float,
	"Quantité maximale" int,
	constraint ck_etage_cage foreign key (Cage) references cage(Numéro)

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
	"Date d'éxpiration" date,
	"Date d'entrée" date,
	"Date de sortie" date,
	Libelle varchar(255),
	Prix Float,
	Type int,
	Catégorie int,
	Cage int,
	Etage int,
	Poids float,
	Quantité int,
	"Code à barre" image,
	constraint ck_produit_type foreign key (type) references type(Id),
	constraint ck_produit_categorie foreign key (Catégorie) references categorie(Id),
	constraint ck_produit_cage foreign key (Cage) references cage(Numéro),
	constraint ck_produit_etage foreign key (Etage) references étage(Id)

);

-- Table étage

create trigger tr_insert_etage
on étage
after insert
As
Begin

	update cage set "Nombre d'étage" = "Nombre d'étage" + 1 where Numéro = ( select Cage from inserted )
	Update cage set "Poids de cage" = "Poids de cage" + ( select "Poids d'étage" from inserted ) where Numéro = ( select cage from inserted )
	update cage set "Quantité total" = "Quantité total" + ( select quantité from inserted ) where Numéro = ( select cage from inserted )

End

create trigger tr_delete_etage
on étage
after delete
AS
BEGIN

	update cage set "Nombre d'étage" = "Nombre d'étage" - 1 where Numéro = ( select cage from deleted )
	update cage set "Poids de cage" = "Poids de cage" - ( select "Poids d'étage" from deleted ) where Numéro = ( select cage from deleted )
	update cage set "Quantité total" = "Quantité total" - ( select quantité from deleted ) where Numéro = ( select cage from deleted )
	
End

create trigger tr_update_etage
on étage
for update
As
BEGIN
	
	update cage set "Quantité total" = "Quantité total" - ( select quantité from deleted ) where Numéro = ( select cage from deleted )
	Update cage set "Poids de cage" = "Poids de cage" - ( select "Poids d'étage" from  deleted ) where Numéro = ( select cage from deleted )
	
	update cage set "Quantité total" = "Quantité total" + ( select quantité from inserted ) where Numéro = ( select cage from inserted )
	Update cage set "Poids de cage" = "Poids de cage" + ( select "Poids d'étage" from inserted ) where Numéro = ( select cage from inserted )
	
End

-- Table Produit

create trigger tr_insert_produit
on produit
for insert
as
begin

	declare @quantité_exists as int
	declare @quantité_ajouter as int
	declare @quantité_maximale as int

	set @quantité_exists = (select quantité from étage where Id = (select etage from inserted))
	set @quantité_ajouter = ( select quantité from inserted )
	set @quantité_maximale = ( select "Quantité maximale" from étage where Id = (select etage from inserted) )

	if((@quantité_ajouter + @quantité_exists) > @quantité_maximale)
		throw 51000, 'La quantité ajouter est depasser la quantité disponible', 1
	ELSE
		update étage set Quantité = Quantité + ( select Quantité from inserted ) where Id = ( select Etage from inserted )
		update étage set "Poids d'étage" = "Poids d'étage" + (( select Poids from inserted ) * ( select Quantité from inserted )) where Id = ( select Etage from inserted )

end

create trigger tr_update_produit
on produit
for update
as
begin

	declare @quantité_exists as int
	declare @quantité_ajouter as int
	declare @quantité_maximale as int

	set @quantité_exists = (select quantité from étage where Id = (select etage from inserted))
	set @quantité_ajouter = ( select quantité from inserted )
	set @quantité_maximale = ( select "Quantité maximale" from étage where Id = (select etage from inserted) )

	if(@quantité_ajouter > @quantité_maximale)
		throw 51000, 'La quantité ajouter est depasser la quantité disponible', 1
	else	
		update étage set Quantité = Quantité - ( select Quantité from deleted ) where Id = ( select Etage from deleted )
		update étage set "Poids d'étage" = "Poids d'étage" - (( select poids from deleted ) * ( select Quantité from deleted )) where Id = ( select Etage from deleted )
	
		update étage set Quantité = Quantité + ( select Quantité from inserted ) where Id = ( select Etage from inserted )
		update étage set "Poids d'étage" = "Poids d'étage" + (( select Poids from inserted ) * ( select Quantité from inserted )) where Id = ( select Etage from inserted )
	
end

create trigger tr_delete_produit
on produit
after delete
AS
BEGIN

	update étage set Quantité = Quantité - ( select Quantité from deleted ) where Id = ( select Etage from deleted )
	update étage set "Poids d'étage" = "Poids d'étage" - (( select poids from deleted ) * ( select Quantité from deleted )) where Id = ( select Etage from deleted )
	
end