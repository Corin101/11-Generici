TipskiNesigurneKolekcije
------------------------
Ne-generičke kolekcije definirane su tako da rukuju s tipom System.Object.
To znači da u takvu kolekciju možemo dodati bilo koji tip podatka a da
prevoditelj na to ne prijavi pogrešku. Takva neujednačenost objekata 
u kolekciji može izazvati pogreške tijekom izvođenja.


GenerickeKolekcije
-------------------
Generičke kolekcije osiguravaju tipsku sigurnost: prevoditelj će prijaviti
pogrešku pokušamo li u kolekciju dodati objekt neodgovarajućeg tipa


GenerickeKolekcijeSRazlicitimTipovima
-------------------------------------
Trebamo li u kolekciju pohraniti objekte različitog tipa, najsigurnije 
je složiti ih u hijerarhiju klasa sa zajedničkim baznim tipom, a kolekciju 
definirati tako da sadrži reference na objekte baznog tipa.


GenerickeKolekcijeSRazlicitimParametrima
----------------------------------------
Iako mogu biti ista vrsta generičke kolekcije, ako su parametri tipa 
različiti, prevoditelj će generirati potpuno različite, međusobno
nekompatibilne tipove.