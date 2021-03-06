# Tim: r17015      S&M (Store and Manage)

### Korisnička dokumentacija (user manual)

Dobro došli u korisničku dokumentaciju Store and Manage aplikacije. Svrha ove dokumentacije je odgovoriti na sva pitanja korisnika vezana uz korištenje Store and Manage aplikacije. U nastavku ćete vidjeti sve prikaze korisničkog sučelja koji su vezani uz aplikaciju. Nadamo se da će vam naša korisnička dokumentacija olakšati korištenje aplikacije, S&M Tim.

#### Prijava 

Svi korisnici koji su registrirani u našoj bazi podataka imaju pravo pristupiti korištenju aplikacije. Kako bi to učinili potrebno je obaviti kratku i jednostavnu prijavu. Forma za prijavu sadrži korisničko ime te lozinku. Svaki registrirani korisnik je svoje ime i lozinku dobio na svoj službeni mail tvrtke. U slučaju gubitka lozinke ili zaborava korisničkog imena potrebno je poslati email korisničkoj podršci naše aplikacije kako bismo vam što prije omogućili ponovni pristup.

![Prijava](http://oi66.tinypic.com/b6ddlk.jpg)

#### Glavni pekar: Kreiranje zahtjevnice

Jedna od mogućnosti koju korisnik koji je prijavljen kao glavni pekar ima je kreiranje zahtjevnice na osnovu koje će kasnije vlasnik kreirati narudžbenicu. Kod ove forme možemo primijetiti nekoliko funkcionalnosti, prva bitna funkcionalnost je dodavanje sirovina putem combo-boxa, dovoljan je klik na combo-box kako bi nam se otvorio popis svih sirovina koje trenutno koristimo u poslovanju. Kada odaberemo jednu od sirovina potrebno je unijeti količinu koja nam je potrebna te nakon toga dodati sirovinu na popis koji će se proslijediti vlasniku. Nakon završetka unosa sirovina u listu, listu prosljeđujemo vlasniku klikom na gumb pošalji.

![Glavni pekar zahtjevnica](http://oi67.tinypic.com/x5e3it.jpg)

#### Vlasnik: Kreiranje narudžbenice

Vlasnik ima pristup svim mogućnostima koje aplikacija sadrži. Mogućnost kreiranje narudžbenice se direktno odnosi na vlasnikovo zaduženje u poslovanju te je stoga čini jednom od glavnih mogućnosti u vlasničkom pogledu aplikacije. Kako bi kreirao narudžbenicu vlasnik mora odabrati dobavljača iz drop-down menija te odabrati datum kada se narudžbenica kreira. Nakon odabira dobavljača te datuma potrebno je na osnovu primljene zahtjevnice dodati proizvode te njihovu količinu u listu koja će kada su svi proizvodi dodani imati mogućnost kreiranja te na kraju slanja iz popisa narudžbenica.

![Vlasnik narudžbenica](http://oi68.tinypic.com/2lyixz.jpg)

#### Vlasnik: Popis narudžbenica

Slanje/otkazivanje narudžbenica se vrši kroz popis narudžbenica, u popisu se nalaze sve narudžbenica koje je vlasnik već prije kreirao. U ovoj formi vlasnik ima tri mogućnosti kada odabere jednu od kreiranih narudžbenica, prva mogućnost je pregled detalja narudžbenice kako bi se uvjerio da je sve uredu, druga mogućnost je konačni korak a to je slanje narudžbenice dobavljaču koji je naznačen na samome dokumentu te na kraju imamo mogućnost otkazivanja narudžbenice koja se može iskoristiti u roku od 3 sata nakon slanja narudžbenice (sva otkazivanja izvan roka je potrebno izvršiti direktnim slanjem emaila dobavljaču kojemu je poslana narudžbenica).

![Vlasnik popis narudžbenica](http://oi64.tinypic.com/312wi2p.jpg)


#### Vlasnik: Djelatnici

Vlasnik ima najveće ovlasti te slično kao administrator, može dodavati nove djelatnike, odnosno korisnike u aplikaciju.
Svakom korisniku unosi vrijednosti pod atribute kao što su ime, prezime, kontakt, korisničko ime i lozinka, a na kraju 
mora još i definirati ovlasti, odnosno tip korisnika za novog djelatnika. Uz dodavanje novog korisnika, na ovoj formi
se nalazi i popis trenutnih korisnika te ih može odabrati i mijenjati ovlasti koje su im dodijeljene, bilo greškom krive
ovlasti dodijeljene ili je korisnik promoviran i slično. Na slici ispod imamo prikaz kako izgleda forma koju vlasnik
koristi za iznad navedene funkcionalnosti.


![Vlasnik_Djelatnici](http://i67.tinypic.com/29wajkn.png)



#### Korisnik: Stanje skladišta

Svaki korisnik naše aplikacije ima mogućnost za pregledavanje stanja sirovina na skladištu, a istovremeno i ažuriranje
podataka istih. Funkcionalnost ove forme smo zamislili kao padajući izbornik sa popisom sirovina te kako korisnik odabere
željenu sirovinu, na listi će se prikazati svi atributi vezani za tu sirovinu i njihove vrijednosti u tom trenutku. To bi
služilo za pregledavanje stanja na skladištu, a kako je lista atributa prikazana u listboxu, može se odabrati određeni atribut
te nam to omogućava ažuriranje, odnosno izmjenu podataka, što bi olakšalo evidenciju novih stanja sirovina na skladištu.
Na slici ispod možemo vidjeti prikaz ove forme kako smo je zamislili prema ovim funkcionalnostima koje nudi.

![Korisnik_Skladište](http://i66.tinypic.com/i6dzys.png)



#### Korisnik: Poruke

Slično kao i funkcionalnost pregledavanja stanja skladišta, svaki korisnik ima i mogućnost razmjene poruka sa drugim korisnicima
aplikacije. Kod ove funkcionalnosti, korisnik ima popis svih zaprimljenih poruka u listboxu te odabirom na određenu poruku, u 
okviru za čitanje poruka mu se ispisuje tekst te poruke. Ispod te funkcionalnosti za čitanje primljenih poruka, nalazi se funkcionalnost
za pisanje i slanje poruka. U padajućem izborniku se nalazi popis svih korisnika aplikacije te odabirom na određenog, njemu se šalje
poruka. Uz to, korisnik još unosi Naslov poruke i ispod toga u Tijelo poruke unosi cijelu poruku te pritiskom na dugme se poruka
šalje odabranom korisniku. Ova funkcionalnost je prikazana na slici ispod, u obliku kakvog smo mi zamislili.

![Korisnik_Poruke](http://i64.tinypic.com/kloqg.png)



#### Vlasnik: Djelatnici popis

Vlasnik kao korisnik koji ima mogućnost pristupa svim dijelovima aplikacije će isto tako moći pristupiti i popisu svih djelatnika. Iz popisa vlasnik ima mogućnost odabrati jednog djelatnika te vidjeti detaljne informacije o tome djelatniku. Na formi djelatnici detaljno ćemo objasniti koje će sve to mogućnosti imati vlasnik pri detaljnom prikazu djelatnika.

![Vlasnik djelatnici popis](http://oi67.tinypic.com/29m8tix.jpg)



#### Vlasnik Djelatnici detaljno

U prethodnoj formi je opisan pregled popisa svih djelatnika te smo rekli da ćemo kada odaberemo određenog djelatnika moći vidjeti nekakve detalje i raditi promjene na ovlastima te informacijama toga djelatnika. Iz dropboxa možemo odabrati poziciju na kojoj djelatnik radi (ako radi na više pozicija), kada je djelatnik prikazan imamo tri gubma, prvi gumb nam služi za izmjene informacija o određenom djelatniku, drugi gumb nam služi za izmjene ovlasti djelatnika te treći gumb služi za slanje direktne poruke odabranom djelatniku.

![Vlasnik djelatnici detaljno](http://oi66.tinypic.com/24bkj6a.jpg)




#### Skladištar: Računi/otpremnice popis

Skladištar sa svoje pozicije ima obavezu kreiranja primke na osnovu određenih računa odnosno otpremnica. Kada skladištar otoru ovaj pogled on će moći vidjeti popis svih računa odnosno otpremnica te na osnovu odabira jednog od dokumenata će imati mogućnost kriranja primke što ćemo vidjeti na idućoj formi. Sama forma je jednostavna te se sastoji od jednog dropdown menija iz kojega filtiramo otpremnice/račune prema dobavljačima, ako ništa nije odabrano vidimo sve račune/otpremince prema datumu pristizanja.

![Skladištar racuni/otpremince popis](http://oi66.tinypic.com/jadnv5.jpg)



#### Skladištar: Računi/otpremnice detaljno

U opisu prethodne forme smo rekli da na osnovu određenog računa kreiramo novu primku. U pregledu ove forme možemo vidjeti popis svih sirovina koje su pristigle prema računu te nam se otvaraju dvije mogućnosti, prva primanje tih sirovina na skladište te kreiranje primjke ili druga mogućnost "Greška" koja nam omogućava da dobavljaču prijavimo grešku na računu odnosno pristiglim sirovinama

![Skladištar racuni/otpremince detaljno](http://oi67.tinypic.com/1zcipfm.jpg)
