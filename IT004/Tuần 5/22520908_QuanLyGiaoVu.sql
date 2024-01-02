
/*   
9. 
        them    xoa   sua
lop     +       -      +
hv      -       +      +

10.
khoa    +       -       +
gv      -       -       +
        
15.
gday    -       -      +(denngay)
kqt     +       -      +(mahv,ngthi)
16.	Mỗi học kỳ của một năm học, một lớp chỉ được học tối đa 3 môn.
gday    +       -       +(hocky,malop)


18.	Trong quan hệ DIEUKIEN giá trị của thuộc tính MAMH và MAMH_TRUOC trong cùng một bộ không được giống nhau (“A”,”A”) 
và cũng không tồn tại hai bộ (“A”,”B”) và (“B”,”A”).
dk      +       -         +
19.	Các giáo viên có cùng học vị, học hàm, hệ số lương thì mức lương bằng nhau.
gv      +       -         +(hocvi,hocham,hsl,mucluong)





*/
-- 9.
CREATE TRIGGER C9 ON LOP 
FOR INSERT , UPDATE
AS BEGIN
        IF EXISTS (
                SELECT * FROM INSERTED I,HOCVIEN
                WHERE I.TRGLOP = HOCVIEN.MAHV

                AND HOCVIEN.MALOP = I.MALOP
        )
        BEGIN 
                PRINT 'THANH CONG'
        END
        ELSE 
        BEGIN 
                PRINT 'LOI: INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
END
GO

CREATE TRIGGER C9b ON HOCVIEN 
FOR UPDATE
AS BEGIN
        IF EXISTS (
                SELECT * FROM INSERTED I,LOP
                WHERE I.MAHV <> LOP .TRGLOP 

                AND LOP.MALOP = I.MALOP
        )
        BEGIN 
                PRINT 'SUA THANH CONG'
        END
        ELSE 
        BEGIN 
                PRINT 'LOI: MAHV KO HOP LE'
                ROLLBACK TRANSACTION
        END
END
GO

--10.

CREATE TRIGGER KHOA_TRGKHOA ON KHOA
FOR INSERT,UPDATE
AS 
BEGIN
        IF EXISTS (
                SELECT * FROM inserted I, GIAOVIEN
                WHERE I.MAKHOA = GIAOVIEN.MAKHOA
                AND I.TRGKHOA = GIAOVIEN.MAGV AND GIAOVIEN.HOCVI IN ('TS','PTS')
        )
        BEGIN
                PRINT 'THEM/SUA KLHOA THANH CONG'
        END
        ELSE
        BEGIN
                PRINT 'LOI: INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
END
GO
CREATE TRIGGER TRG_KHOAa ON GIAOVIEN
FOR UPDATE
AS 
BEGIN
        IF EXISTS (
                SELECT * FROM inserted I, KHOA
                WHERE KHOA.MAKHOA = I.MAKHOA
                AND KHOA.TRGKHOA = I.MAGV AND I.HOCVI IN ('TS','PTS')
        )
        BEGIN
              
                 PRINT 'LOI: INPUT KO HOP LE'
                 ROLLBACK TRANSACTION
        END
        ELSE
        BEGIN
                PRINT 'SUA GIAOVIEN THANH CONG'
                
        END
END
GO

--15.
CREATE TRIGGER TRG_UP_GIANGDAY ON GIANGDAY
FOR UPDATE
AS BEGIN
        IF EXISTS(
                SELECT * FROM inserted I , KETQUATHI KQT
                WHERE I.MAMH = KQT.MAMH
                AND KQT.NGTHI < I.DENNGAY
        )
        BEGIN
                PRINT 'LOI: INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
        ELSE
        BEGIN
                PRINT 'THANH CONG'
        END
END
GO
CREATE TRIGGER TRG_IN_UP_KQT ON KETQUATHI
FOR UPDATE,INSERT
AS BEGIN
        IF EXISTS(
                SELECT * FROM inserted I , GIANGDAY
                WHERE I.MAHV = GIANGDAY.MAMH
                AND I.NGTHI < GIANGDAY.DENNGAY
        )
        BEGIN
                PRINT 'LOI: INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
        ELSE
        BEGIN
                PRINT 'THANH CONG'
        END
END
GO
--16.
CREATE trigger TRG_IN_UP_GD_HOCKY ON GIANGDAY
FOR INSERT,UPDATE
AS 
BEGIN
        IF (
                SELECT COUNT(MALOP) FROM
                (
                        SELECT * FROM GIANGDAY GD 
                        UNION 
                        SELECT * FROM INSERTED I 
                ) AS TEP 
                GROUP BY MAMH,HOCKY,MALOP
        ) > 3
        BEGIN
                
            PRINT 'THEM/SUA KHONG THANH CONG'
            ROLLBACK TRANSACTION 
        
        END
        ELSE 
        BEGIN 
            PRINT 'THANH CONG'
        END 
END
GO
--17.
CREATE TRIGGER TRG_IN_SISO ON LOP
FOR INSERT
AS 
BEGIN
      UPDATE LOP
	  SET SISO=0
	  FROM LOP JOIN INSERTED I ON I.MALOP= LOP.MALOP
      PRINT 'DA CAP NHAT SI SO LOP'
END
GO
CREATE TRIGGER TRG_IN_UP_LOP ON LOP
FOR UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT * from inserted I
        WHERE I.SISO!= (
				  SELECT COUNT(HV.MAHV) FROM HOCVIEN HV WHERE HV.MALOP=I.MALOP
				  )
    ) 
        
    BEGIN
        PRINT 'SUA KO HOP LE'
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
        PRINT 'CAP NHAT THANH CONG'  -- Clearer success message
    END
END
GO


CREATE TRIGGER TRG_IN_DEL_UP_SISO ON HOCVIEN
FOR INSERT, DELETE, UPDATE
AS
BEGIN
        UPDATE LOP
		SET SISO = (SELECT COUNT(HV.MAHV) FROM HOCVIEN HV WHERE HV.MALOP= LOP.MALOP)
		FROM INSERTED I, DELETED DEL, LOP
		WHERE I.MALOP = LOP.MALOP OR DEL.MALOP=LOP.MALOP
		PRINT 'CAP NHAT SISO THANH CONG'
END
GO

--19.
CREATE TRIGGER TRG_GIANGVIEN_HOCHAM ON GIAOVIEN
FOR INSERT,UPDATE
AS 
BEGIN
        IF EXISTS (
                SELECT * FROM inserted I , GIAOVIEN
                WHERE I.HOCHAM = GIAOVIEN.HOCHAM
                        AND I.HOCVI = GIAOVIEN.HOCVI
                        AND I.HESO = GIAOVIEN.HESO
                        AND I.MUCLUONG <> GIAOVIEN.MUCLUONG
        )
        BEGIN
                PRINT 'INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
        ELSE
        BEGIN
                PRINT 'THEM/SUA THANH CONG'
        END
END
GO

GO
--18.
CREATE TRIGGER TRG_MONHOC ON DIEUKIEN
FOR INSERT, UPDATE
AS 
BEGIN
    IF EXISTS (
        SELECT 1 
        FROM inserted I
        WHERE 
            I.MAMH <> I.MAMH_TRUOC  -- Add your comparison logic here
            AND NOT EXISTS (
                SELECT 1 
                FROM DIEUKIEN D
                WHERE D.MAMH = I.MAMH_TRUOC
            )
    )
    BEGIN
        PRINT 'ERROR: MAMH AND MAMH_TRUOC ARE INVALID'
        ROLLBACK TRANSACTION
    END
    ELSE
    BEGIN
        PRINT 'SUCCESSFUL INSERT/UPDATE'
    END
END
GO
--20.	Học viên chỉ được thi lại (lần thi >1) khi điểm của lần thi trước đó dưới 5.
--+   -    +


CREATE TRIGGER TRGUP_THILAI ON KETQUATHI
FOR UPDATE, INSERT
AS
BEGIN
  IF EXISTS (
    SELECT * FROM inserted I, KETQUATHI KQT
    WHERE I.MAMH = KQT.MAMH AND I.MAHV = KQT.MAHV
    AND I.LANTHI > KQT.LANTHI
    AND KQT.DIEM >= 5
    AND NOT EXISTS (
      SELECT *
      FROM KETQUATHI
      WHERE MAHV = I.MAHV
      AND MAMH = I.MAMH
      AND LANTHI > I.LANTHI
    )
  )
  BEGIN
    PRINT 'LOI: KHONG HOP LE'
    ROLLBACK TRANSACTION
  END
  ELSE
  BEGIN
    PRINT 'THEM/SUA THANH CONG'
  END
END
GO
-- 21.	Ngày thi của lần thi sau phải lớn hơn ngày thi của lần thi trước (cùng học viên, cùng môn học).
CREATE TRIGGER TRGUPngthi_THILAI ON KETQUATHI
FOR UPDATE, INSERT
AS
BEGIN
  IF EXISTS (
    SELECT * FROM inserted I, KETQUATHI KQT
    WHERE I.MAMH = KQT.MAMH AND I.MAHV = KQT.MAHV
    AND I.LANTHI > KQT.LANTHI
    AND I.NGTHI > KQT.NGTHI
    AND NOT EXISTS (
      SELECT *
      FROM KETQUATHI
      WHERE MAHV = I.MAHV
      AND MAMH = I.MAMH
      AND LANTHI > I.LANTHI
    )
  )
  BEGIN
    PRINT 'LOI: KHONG HOP LE'
    ROLLBACK TRANSACTION
  END
  ELSE
  BEGIN
    PRINT 'THEM/SUA THANH CONG'
  END
END
GO
-- 22.	Khi phân công giảng dạy một môn học, phải xét đến thứ tự trước sau giữa các môn học 
-- (sau khi học xong những môn học phải học trước mới được học những môn liền sau).

/*
giangday +  -  + 
dieukien -  -  +
*/

CREATE TRIGGER trg_in on GIANGDAY
FOR UPDATE,INSERT
AS BEGIN
        IF EXISTS(
                SELECT * FROM inserted I ,DIEUKIEN,GIANGDAY
                WHERE I.MAMH = DIEUKIEN.MAMH AND GIANGDAY.MAMH = DIEUKIEN.MAMH_TRUOC AND GIANGDAY.MALOP = I.MALOP
                AND I.TUNGAY < GIANGDAY.DENNGAY
        )
        BEGIN 
                PRINT 'LOI: INPUT KO HOP LE'
                ROLLBACK TRANSACTION
        END
        ELSE 
        BEGIN
                PRINT 'THANH CONG'
        END
END
GO

-- 23.	Giáo viên chỉ được phân công dạy những môn thuộc khoa giáo viên đó phụ trách.
/*
monhoc   -     -    +
giangday  +     -   +
giaovien  -     -   +
*/

CREATE TRIGGER TRG_UP_MH ON MONHOC
FOR UPDATE
AS 
BEGIN
	IF EXISTS (
		SELECT * FROM inserted I, GIANGDAY,GIAOVIEN
		WHERE I.MAMH = GIANGDAY.MAMH AND GIANGDAY.MAGV = GIAOVIEN.MAGV AND I.MAKHOA <> GIAOVIEN.MAKHOA
	)
	BEGIN
		PRINT 'LOI: KHONG HOP LE'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		PRINT 'SUA THANH CONG'
	END
END
GO

CREATE TRIGGER TRG_UP_GV ON GIAOVIEN
FOR UPDATE
AS 
BEGIN
	IF EXISTS (
		SELECT * FROM inserted I, GIANGDAY,MONHOC
		WHERE MONHOC.MAMH = GIANGDAY.MAMH AND GIANGDAY.MAGV = I.MAGV AND I.MAKHOA <> MONHOC.MAKHOA
	)
	BEGIN
		PRINT 'LOI: KHONG HOP LE'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		PRINT 'SUA THANH CONG'
	END
END
GO

CREATE TRIGGER TRG_UP_IN_GV_MH ON GIANGDAY
FOR UPDATE,INSERT
AS 
BEGIN
	IF EXISTS (
		SELECT * FROM inserted I, GIAOVIEN,MONHOC
		WHERE I.MAGV = GIAOVIEN.MAGV AND I.MAMH = MONHOC.MAMH AND MONHOC.MAKHOA <> GIAOVIEN.MAKHOA
	)
	BEGIN
		PRINT 'LOI: KHONG HOP LE'
		ROLLBACK TRANSACTION
	END
	ELSE
	BEGIN
		PRINT 'SUA THANH CONG'
	END
END
GO

