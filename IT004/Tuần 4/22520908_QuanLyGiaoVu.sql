--19.
SELECT MAKHOA,TENKHOA FROM KHOA
WHERE MAKHOA IN 
(
	SELECT TOP 1 WITH TIES MAKHOA FROM KHOA
	ORDER BY NGTLAP ASC
)
--20
SELECT COUNT(MAGV) FROM GIAOVIEN
WHERE HOCHAM IN ('GS','PGS')
--21.
SELECT MAKHOA, HOCVI, COUNT(HOCVI) SL FROM GIAOVIEN 
GROUP BY MAKHOA, HOCVI
ORDER BY MAKHOA
--22.
SELECT MAMH,KQUA,COUNT(KQUA) KQ FROM KETQUATHI
GROUP BY MAMH,KQUA
ORDER BY MAMH ASC

--23.	Tìm giáo viên (mã giáo viên, họ tên) là giáo viên chủ nhiệm của một lớp, đồng thời dạy cho lớp đó ít nhất một môn học.
SELECT MAGV, HOTEN FROM GIAOVIEN
WHERE MAGV IN 
(
	SELECT MAGV FROM GIANGDAY INNER JOIN LOP ON GIANGDAY.MAGV=LOP.MAGVCN
	WHERE LOP.MALOP = GIANGDAY.MALOP
)
--24.	Tìm họ tên lớp trưởng của lớp có sỉ số cao nhất.
SELECT HO,TEN FROM HOCVIEN
WHERE MAHV IN 
(
	SELECT TRGLOP FROM LOP 
	WHERE SISO IN 
	(
		SELECT TOP 1 WITH TIES SISO FROM LOP
		ORDER BY SISO DESC
	)
)
--25.	* Tìm họ tên những LOPTRG thi không đạt quá 3 môn (mỗi môn đều thi không đạt ở tất cả các lần thi).
--26.	Tìm học viên (mã học viên, họ tên) có số môn đạt điểm 9, 10 nhiều nhất.
SELECT MAHV, HO, TEN 
FROM HOCVIEN
WHERE MAHV IN 
(
    SELECT TOP 1 WITH TIES MAHV
    FROM (
        SELECT MAHV, COUNT(DIEM) AS DiemCount 
        FROM KETQUATHI
        WHERE DIEM BETWEEN 9 AND 10
        GROUP BY MAHV
    ) SubqueryAlias
    ORDER BY DiemCount DESC
)


--27.	Trong từng lớp, tìm học viên (mã học viên, họ tên) có số môn đạt điểm 9, 10 nhiều nhất.



--28.	Trong từng học kỳ của từng năm, mỗi giáo viên phân công dạy bao nhiêu môn học, bao nhiêu lớp.
SELECT MAGV,HOCKY,NAM ,COUNT(MALOP) AS SOLOP, COUNT(MAMH) AS SOMON FROM GIANGDAY
GROUP BY MAGV,HOCKY,NAM
ORDER BY HOCKY ASC 
--29.	Trong từng học kỳ của từng năm, tìm giáo viên (mã giáo viên, họ tên) giảng dạy nhiều nhất.
SELECT GIANGDAY.MAGV , HOTEN FROM GIAOVIEN JOIN GIANGDAY ON GIAOVIEN.MAGV= GIANGDAY.MAGV
GROUP BY GIANGDAY.MAGV,GIAOVIEN.HOTEN,GIANGDAY.HOCKY,GIANGDAY.NAM
HAVING COUNT( GIANGDAY.MAMH) >= ALL 
									(
										SELECT COUNT(MAMH) FROM GIANGDAY GD1
										WHERE GIANGDAY.NAM = GD1.NAM AND GIANGDAY.HOCKY=GD1.HOCKY
										GROUP BY GD1.MAGV,GD1.NAM,GD1.HOCKY
									)
--30.	Tìm môn học (mã môn học, tên môn học) có nhiều học viên thi không đạt (ở lần thi thứ 1) nhất.
--31.	Tìm học viên (mã học viên, họ tên) thi môn nào cũng đạt (chỉ xét lần thi thứ 1).
--32.	* Tìm học viên (mã học viên, họ tên) thi môn nào cũng đạt (chỉ xét lần thi sau cùng).
--33.	* Tìm học viên (mã học viên, họ tên) đã thi tất cả các môn và đều đạt (chỉ xét lần thi thứ 1).
--34.	* Tìm học viên (mã học viên, họ tên) đã thi tất cả các môn và đều đạt (chỉ xét lần thi sau cùng).
--35.	** Tìm học viên (mã học viên, họ tên) có điểm thi cao nhất trong từng môn (lấy điểm ở lần thi sau cùng).
