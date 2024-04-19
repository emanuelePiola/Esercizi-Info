SELECT *
FROM Auto a
Where a.targa = 'GF237WT'

SELECT *
FROM Auto a
Where a.targa like '_%T'

SELECT *
FROM Auto a
Where a.prezzo between 100000 and 200000

SELECT *
FROM Auto a
Where colore in ('Red', 'Gray')