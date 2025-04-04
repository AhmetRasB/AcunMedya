-- 1. Books tablosundaki tüm kitapları listeleyen sorgu
SELECT * FROM Books;

-- 2. Yalnızca "Bilgisayar Bilimleri" kategorisindeki kitapları listeleyiniz
SELECT * FROM Books WHERE Category = 'Bilgisayar Bilimleri';

-- 3. 2020 ve sonrasında yayımlanan kitapları listeleyiniz
SELECT * FROM Books WHERE PublishYear >= 2020;

-- 4. Her kitabın ismini ve ait olduğu kategoriyi listeleyen sorgu
SELECT Title, Category FROM Books;

-- 5. Kitap alan öğrencilerin adını, soyadını ve kitap adını listeleyiniz
SELECT Students.FirstName, Students.LastName, Books.Title
FROM Borrowings
INNER JOIN Students ON Borrowings.StudentID = Students.StudentID
INNER JOIN Books ON Borrowings.BookID = Books.BookID;

-- 6. Her kitapla ilişkili yazarı ve yayın yılını listeleyiniz
SELECT Title, Author, PublishYear FROM Books;

-- 7. Hangi kullanıcı hangi kitabı ne zaman almış?
SELECT Students.FirstName, Students.LastName, Books.Title, Borrowings.BorrowDate
FROM Borrowings
INNER JOIN Students ON Borrowings.StudentID = Students.StudentID
INNER JOIN Books ON Borrowings.BookID = Books.BookID;

-- 8. Geri dönüş tarihi boş olan kitapların listesini ve kullanıcı bilgilerini getiriniz
SELECT Students.FirstName, Students.LastName, Books.Title, Borrowings.BorrowDate
FROM Borrowings
INNER JOIN Students ON Borrowings.StudentID = Students.StudentID
INNER JOIN Books ON Borrowings.BookID = Books.BookID
WHERE Borrowings.ReturnDate IS NULL;

-- 9. Her kategoriye ait kaç kitap olduğunu listeleyiniz
SELECT Category, COUNT(*) AS BookCount
FROM Books
GROUP BY Category;

-- 10. En çok kitap ödünç alan kullanıcıları, en fazla borç alandan az borç alana göre sıralayınız
SELECT Students.FirstName, Students.LastName, COUNT(*) AS BorrowCount
FROM Borrowings
INNER JOIN Students ON Borrowings.StudentID = Students.StudentID
GROUP BY Students.FirstName, Students.LastName
ORDER BY BorrowCount DESC;
