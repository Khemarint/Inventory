select * from Table_Images

INSERT INTO Table_Images(id, name, description, the_image)
VALUES (1, 'PC1', 'MSI', 
        (SELECT BulkColumn FROM Openrowset(Bulk 'D:\Picture\1.jpg', Single_Blob) as img));

ALTER TABLE Table_Images
ALTER COLUMN id smallint NULL;

DELETE FROM Table_Images WHERE id IS NULL;

ALTER TABLE Table_Images DROP COLUMN id;
ALTER TABLE Table_Images ADD id INT IDENTITY(1,1) PRIMARY KEY;

SELECT id, name, description, the_image FROM Table_Images;

SELECT * FROM table_images WHERE id = 1;