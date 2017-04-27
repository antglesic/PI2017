# Tim: r17015      S&M (Store and Manage)


###  O projektu

Na ovome projektu vezanog za kolegij "Programsko Inženjerstvo" ćemo razvijati programsko rješenje pod nazivom S&M (Store and Manage).
Aplikacija S&M će služiti za upravljanje skladištima lanca pekare Junior. 

S ovom aplikacijom ćemo omogućiti lakše vođenje
računa o stanjima na skladištu, potrošnji odnosno rashodovanju trenutnih sirovina koje se već nalaze na skladištu
što će kasnije rezultirati naručivanjem novih sirovina. 

Aplikacija će se izvršavati na lokalnoj razini,
a podaci o stanjima skladišta će se nalaziti na vanjskoj bazi podataka.

Sama aplikacija bi trebala omogućiti uvid u trenutna stanja kako vlasniku pekare, glavnom pekaru,
skladištaru tako i suradnicima s kojima se tvrtka nalazi pod ugovorom (dugogodišnji dobavljači). 

Također aplikacija će služiti kao komunikacijska poveznica između proizvođača pekarskih proizvoda i ostalih
dobavljača.

### Korisnički zahtjevi

„Store & Manage“ je desktop aplikacija koja pomaže poduzećima da lakše vode evidenciju svog poslovanja i stanje skladišta. Njena prvenstvena namjena je poduzećima kao što su pekare, točnije pekara „Junior“ u Varaždinu. 

Vlasnici pekara, kao i njihovi zaposlenici, mogu vodit evidenciju o stanju sirovina na skladištu, a isto tako i sve ulazne i izlazne transakcije, popraćene odgovarajućom dokumentacijom.

Za korištenje aplikacije je potrebno stolno ili prijenosno računalo, zajedno sa stabilnom internetskom vezom (nevažno bila ona žičana ili bežična). Svi podaci sustava se održavaju u bazi podataka, koja je locirana na udaljenom web-poslužitelju.

### Korištene tehnologije

|           Alati                   |
|:---------------------------------:|
|  Microsoft Visual Studio 2015     |
|  Microsoft Office                 |
|  MS SQL Server                    |
|  Microsoft Project 2016           |
|  Visual Paradigm Comunity Edition |
|  GitHub                           |


### Projektni plan

U projektnom planu ćemo prikazati detaljno opisane aktivnosti svakog člana tima, zajedno sa njihovim vremenima izrade i proračunom.
Za izradu aplikativnog rješenja smo odabrali vodopadni model, koji nam se činio prigodnim uzevši u obzir faze i korake za izradu, koji su slijedni, što znači da razvoj napreduje fazu po fazu. To znači da svaka faza prethodi drugoj, odnosno da je nemoguće započeti rad
na novoj fazi, dok prethodna faza još nije zaključena. 

Naš plan sadrži 5 faza, koje idu redom: 
1) Definiranje plana projekta (korisnički zahtjevi, izrada plana i proračuna)
2) Modeliranje i izrada dijagrama (5 različitih vrsta dijagrama)
3) Izrada aplikacije u .NET-u
4) Testiranje i pisanje korisničke dokumentacije
5) Isporuka i primjena

Na slici ispod ima prikazan model sa svih 5 faza našeg projekta.
![Vodopadni](http://i63.tinypic.com/33f9qc9.png)

### Projektni tim

Projektni tim se sastoji od tri člana. Svaki član svoj dio mora definirati i implementirati.

1. Silvio Đurić - Prijava u aplikaciju, modul obavještavanja o kritičnim količinama sirovina na skladištu, tjedna inventura sirovina na skladištu prema roku trajanja sirovina i otpis sirovina sa isteklim rokom

2. Mateo Kiđemet -  Dodavanje novih korisnika u aplikaciju i dodjeljivanje ovlasti, zaprimanje novih sirovina od dobavljača i kreiranje skl.primke na osnovu, izdavanje sirovina u proizvodnju i na temelju toga kreiranje izdatnice dobavljačeva računa/otpremnice

3. Antonio Glešić - Kreiranje i slanje zahtjevnice za izdavanje potrebne količine sirovina u proizvodnju, vođenje evidencije o stanju skladišta u obliku izvještaja, modul za komunikaciju odnosno razmjenu poruka između korisnika
 aplikacije

|   Raspored poslova po članovima tima  |
| Član          |  Opis posla   |
| :----------------------------:| 
| col 3 is      | right-aligned | 
| col 2 is      | centered      |   
| zebra stripes | are neat      |   
