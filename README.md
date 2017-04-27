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

#### Raspored poslova po članu tima

| Član          |          Opis posla   |
|---------------|:---------------------:| 
| Silvio Đurić  | Izrada era modela, dorada dokumentacije, izrada dijagrama aktivnosti, izrada dijagrama slijeda, implemetnacija baze podataka / grafičkog sučelja, ostalih klasa, testiranje aplikacije  | 
| Mateo Kiđemet    |  Izrada dijagrama aktivnosti, izrada dijagrama slijeda, implemetnacija baze podataka / grafičkog sučelja, dorada dokumentacije, izrada korisničke dokumentacije    |   
| Antonio Glešić | Izrada projektnog plana i proračuna, izrada dijagrama klasa, izrada dijagrama slijeda, implemetnacija baze podataka / grafičkog sučelja, testiranje aplikacije  |   


### Izrada plana

Plan projekta izrađen je u Microsoft Project 2016 alatu. Svrha njega je prikazati korištene resurse, radnje,
aktivnosti te uvid u vremenski raspon projekta zajedno s financijskim elementima.

Sljedeće slike prikazuju zadatke vezane za određenog člana tima te detaljno prikazuju aktivnosti kojima isti
pridonosi projektu.

![Silvio](http://i68.tinypic.com/nsw8p.png)


![Mateo](http://i65.tinypic.com/2h6yty0.png)


![Antonio](http://i68.tinypic.com/v8pyxx.png)



###Gantogram

Gantogram nam grafički predočava utrošene resurse i provedene faze od samog početka projekta pa sve do kraja.

![Gantogram](http://i64.tinypic.com/2rm2hya.png)



### Proračun projekta

U Microsoft Projectu 2016 smo izračunali približnu vrijednost projekta na temelju utrošenih resursa, 
odnosno njihovih radnih sati. Tako smo dobili cijenu posebno za svakog člana tima te istovremeno i
za cjelokupni projekt, koju prikazujemo na sljedećim slikama. 
(Cost je ukupna cijena, a Actual Cost se odnosi na dosad odrađen posao, odnosno postotak projekta.)

![Proračun](http://i63.tinypic.com/6puq6u.png)


![Statistika](http://i65.tinypic.com/24bujj6.png)



### Ponuda naručitelju
 
  ** Autor ponude: Mateo Kiđemet **

PEKARNA JUNIOR<br>
Zagrebačka ul. 37<br>
42000 Varaždin<br>
Republika Hrvatska<br>
<br>
S&M<br>
Trakošćanska 11<br>
42000 Varaždin<br>
Republika Hrvatska<br>



Poštovani, 
na temelju vašeg natječaja objavljenog u oglasu, realizirano je aplikativno rješenje koje će vam 
pomoći pri vođenju stanja vaših sirovina na skladištu te kreiranju dokumenata vezanih za sve
transakcije, vezane za skladište sirovina, koje se događaju tokom vašeg poslovanja.
Razmotrili smo vaše zahtjeve te smo prema njima napravili projektni plan u kojemu smo
obuhvatili sve faze projekta. Izrada projekta započinje 2016. godine, a u istoj godini i završava,
pod uvjetom da sve ide prema planu. 
Aktivnosti planirane prema projektu su:
*  Definiranje projektnog plana
*  Modeliranje i izrada dijagrama
*  Izrada aplikacije u .NET-u
*  Testiranje aplikacije i pisanje dokumentacije
*  Isporuka i primjena


Ukupni trošak aplikacije će biti 45 270,00kn, a troškovi s raspodjeljeni ovako:
1. Izrađivanje plana 12 600,00kn
2. Modeliranje 8 190,00kn
3. Realizacija 21 510,00kn
4. Ukupni trošak 2 970,00kn

*U cijenu nije uračunat PDV. U prilogu se nalazi detaljan projektni plan. Nadamo se da ćete biti zadovoljni
našom ponudom te se unaprijed veselimo suradnji i očekujemo brz odgovor.

Lijep pozdrav, S&M Tim
