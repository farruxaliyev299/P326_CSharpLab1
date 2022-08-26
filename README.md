1)Tapsiriq

IPrintableFile - interface-i var
 - FileName
 - Print() - metodu hansı faylı print etdiyini bildirir.

IPrintableFile-ı implement etmiş Excel, Word, Pdf classları var.

Excel :
 - ColumnCount
 - RowCount
property-lərini daxil etmədən Excel obyekti yaratmaq olmasın.

Word :
 - WordCount
property-sini daxil etmədən Word obyekti yaratmaq olmasın.

Pdf :
 - PageCount
property-sini daxil etmədən Pdf obyekti yaratmaq olmasın.

PrintFile - class-ı var. Bu class-ın Print() metodu Word, Excel, Pdf tipindən obyekt tələb edir.
Bu classdan instance alaraq yaratdığınız obyekti Print() metodunu işə salaraq ekrana "FileName printed" yazılsın


2)Tapşırıq:

 Book class
 - No
 - Name
 - AuthorName
 - Genre (genre enum tipində)
 - Price

Library class
 - Books  - Book listi
 - FilterByPrice() - min və max dəyərləri qəbul edib o araqlıqda qiymətə sahib booklardan ibarət siyahı qaytarır
 - FilterByGenre() - Genre deyeri qəbul edib genre dəyəri o olan booklardan ibarət siyahı qaytarır
 - FİndBookByNo() - nömrə dəyəri qəbul edir və No dəyəti o olan book obyektini tapıq qaytarmağa çalışır,
		 tapmasa null qaytarır

Hər bir bookobyektinin nomresi o book obyekti neçənci yaranan bookdursa o olur.
Misalçün 5-ci yaranan book obyktinin nömrəsi 5 olur.
