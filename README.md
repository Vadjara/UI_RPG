# UI_RPG

OOP Principu Lietojums Sp?l?
Sp?l? ir izmantoti ?etri galvenie objektorient?t?s programm??anas principi: manto?ana, enkapsul?cija, polimorfisms un abstrakcija.

1. Manto?ana
Manto?ana tika izmantota, lai izveidotu kop?gas funkcijas un ?pa??bas b?zes klas?s, no kur?m v?l?k tika mantotas sp?l?t?ja un pretinieka klases. Piem?ram, klase Character satur kop?gas ?pa??bas, k? dz?v?bas un uzbrukuma metode, kuras tiek izmantotas gan Player, gan Enemy klas?s.

2. Enkapsul?cija
Enkapsul?cija pal?dz?ja nodro?in?t datu aizsardz?bu, pasl?pjot main?gos un ?aujot tiem piek??t tikai caur metod?m. Piem?ram, sp?l?t?ja dz?v?bas tiek pasl?ptas, un piek?uve tiek veikta, izmantojot getterus un setterus, kas nodro?ina, ka dati tiek main?ti tikai v?lamaj? veid?. T?pat ActiveWeapon getter ?auj piek??t sp?l?t?ja akt?vajam iero?im, bet nepie?auj t? tie?u modific??anu.

3. Polimorfisms
Polimorfisms ?auj izmantot vienas un t?s pa?as funkcijas da??d?m klas?m, piem?ram, Attack() metode tiek p?rdefin?ta gan sp?l?t?jam, gan pretiniekam, ?aujot katram objektiem darboties p?c savas lo?ikas.

4. Abstrakcija (Abstraction)
Abstrakcija tika izmantota, lai pasl?ptu sare???tas ?steno?anas deta?as aiz vienk?r??m saskarn?m. Piem?ram, Weapon ir abstrakta klase, kas defin? kop?gas funkcijas, k? GetDamage() un ApplyEffect(), bet katrs konkr?tais iero?u tips to ?steno sav? veid?. Tas ?auj viegli pievienot jaunus iero?us, nemainot p?r?jo sp?les lo?iku.

?stenotie papildus uzdevumi

1. 2 da??di pretinieki ar at??ir?giem uzbrukumiem. Pirmais pretinieks ir Berserk skelets, kuram ar katru raundu pieaug damage par 1 punktu. Otrs pretinieks ir Mage, kur? sit ar ma?iju. 
2. Burvest?bas sp?l?t?jam (buffs un healing). Sp?l? ir pievienota Heal poga, kura re?ener?jas 3 raundus, p?c k? to var atk?rtoti izmantot un t? atjauno 20 dz?v?bas.

Sp?l? ir ielikta background m?zika, v?l?jos ar? piesl?gt ska?as uz Attack, heal pog?m, bet diem??l nek?d?gi nestr?d?ja, pat ar pal?dz?bu no visu zino?? chatgpt, es tikai boj?ju kodu, p?c k? n?c?s daudz ko dz?st, lai vismaz nepazaud?t to kas str?d?ja.

Par sp?li kopum?
Sp?l? darbojas caur UI sl?ni. Uz ekr?na ir redzama statistika k? sp?l?t?ja, t? ar? pretinieka. Sp?l?t?js ir sp?j?gs iesl?gt un izsl?gt vairogu, k? ar? vairogs l?zt p?c 3 raundiem. Nospie?ot pogu attack, tiek veikts sp?l?t?ja uzbrukums un p?c tam autom?tiski uzbr?k pretinieks. Ja pretinieks nomirst, to nomaina jauns pretinieks p?c random principa, var gad?ties ar? c?n?ties vair?kas reizes ar vienu un to pa?u pretinieku. Ja nomirst sp?l?t?js, tad sp?le beidzas, par?d?s GameOver panelis ar Restar pogu.
