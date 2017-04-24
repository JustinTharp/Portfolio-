--1
SELECT *
FROM LGDEPARTMENT  

--2
SELECT PROD_DESCRIPT, PROD_TYPE, PROD_BASE, PROD_CATEGORY, PROD_PRICE
FROM LGPRODUCT
WHERE PROD_BASE = 'water' AND
PROD_CATEGORY = 'sealer'

--3
SELECT EMP_FNAME, EMP_LNAME, EMP_EMAIL
FROM LGEMPLOYEE
WHERE EMP_HIREDATE > '2001-JAN-1' AND
EMP_HIREDATE < '2010-DEC-31'
ORDER BY EMP_LNAME, EMP_FNAME

--4
SELECT EMP_FNAME, EMP_LNAME, EMP_PHONE, EMP_TITLE, DEPT_NUM
FROM LGEMPLOYEE
WHERE DEPT_NUM = 300 OR
EMP_TITLE = 'CLERK I'
ORDER BY EMP_LNAME, EMP_FNAME

--5
SELECT E.EMP_NUM, E.EMP_LNAME, E.EMP_FNAME, H.SAL_FROM, H.SAL_END, H.SAL_AMOUNT
FROM LGEMPLOYEE E INNER JOIN LGSALARY_HISTORY H 
ON E.EMP_NUM = H.EMP_NUM
WHERE E.EMP_NUM = 83731 OR
		E.EMP_NUM = 83745 OR 
		E.EMP_NUM = 84039
ORDER BY E.EMP_NUM, H.SAL_FROM

--6
SELECT C.CUST_FNAME, C.CUST_LNAME, C.CUST_STREET, C.CUST_CITY, C.CUST_STATE, C.CUST_ZIP
FROM LGCUSTOMER C INNER JOIN LGINVOICE I ON C.CUST_CODE = I.CUST_CODE
					INNER JOIN LGLINE L ON I.INV_NUM = L.INV_NUM
					INNER JOIN LGPRODUCT P ON L.PROD_SKU = P.PROD_SKU
WHERE P.BRAND_ID = 23 
					(SELECT * 
					FROM LGINVOICE
					WHERE INV_DATE > '2013-JUL-15' AND INV_DATE < '2013-JUL-31'
					)


--7
SELECT E.EMP_NUM, E.EMP_LNAME, E.EMP_EMAIL, E.EMP_TITLE, D.DEPT_NAME
FROM LGEMPLOYEE E INNER JOIN LGDEPARTMENT D ON E.DEPT_NUM = D.DEPT_NUM
WHERE E.EMP_TITLE LIKE '%ASSOCIATE'
ORDER BY D.DEPT_NAME, E.EMP_TITLE

--8
SELECT B.BRAND_NAME, COUNT(P.PROD_SKU)
FROM LGBRAND B INNER JOIN LGPRODUCT P
ON B.BRAND_ID = P.BRAND_ID
ORDER BY B.BRAND_NAME

--9
SELECT COUNT(*)
FROM LGPRODUCT
WHERE PROD_CATEGORY IN (SELECT PROD_BASE
						FROM LGPRODUCT
						WHERE PROD_BASE = 'WATER'
						)

--10
SELECT PROD_BASE, PROD_TYPE, COUNT(PROD_SKU)
FROM LGPRODUCT

--11
SELECT P.BRAND_ID, SUM(PROD_QOH)
FROM LGPRODUCT P INNER JOIN LGBRAND B
ON P.BRAND_ID = B.BRAND_ID
ORDER BY B.BRAND_ID

--12
SELECT B.BRAND_NAME, AVG(PROD_PRICE)
FROM LGBRAND B INNER JOIN LGPRODUCT P
ON B.BRAND_ID = P.BRAND_ID
GROUP BY B.BRAND_NAME

--13
SELECT D.DEPT_NUM, EMP_HIREDATE
FROM LGDEPARTMENT D INNER JOIN LGEMPLOYEE E
ON D.DEPT_NUM = E.DEPT_NUM
WHERE EMP_HIREDATE = (SELECT MAX(EMP_HIREDATE)
						FROM LGEMPLOYEE
						)
ORDER BY D.DEPT_NUM

--14
SELECT E.EMP_NUM, EMP_FNAME, EMP_LNAME, SAL_AMOUNT
FROM LGEMPLOYEE E INNER JOIN LGSALARY_HISTORY S
ON E.EMP_NUM = S.EMP_NUM
WHERE SAL_AMOUNT = (SELECT MAX(SAL_AMOUNT)
					FROM LGSALARY_HISTORY
					)
					AND DEPT_NUM = 200
ORDER BY SAL_AMOUNT

--15
SELECT C.CUST_CODE,C.CUST_FNAME,C.CUST_LNAME,SUM(INV_TOTAL)
FROM LGCUSTOMER C INNER JOIN LGINVOICE I
ON C.CUST_CODE = I.CUST_CODE
HAVING SUM(INV_TOTAL) > 1500
ORDER BY INV_TOTAL

--16
SELECT D.DEPT_NUM, D.DEPT_NAME, D.DEPT_PHONE, E.EMP_NUM, EMP_LNAME
FROM LGDEPARTMENT D INNER JOIN LGEMPLOYEE E
ON D.DEPT_NUM = E.DEPT_NUM
WHERE EMP_TITLE LIKE '%MANAGER'
ORDER BY D.DEPT_NAME

--17
SELECT V.VEND_ID, V.VEND_NAME, B.BRAND_NAME, SUM(P.PROD_QOH)
FROM LGVENDOR V INNER JOIN LGSUPPLIES S ON V.VEND_ID = S.VEND_ID 
				INNER JOIN LGPRODUCT P ON S.PROD_SKU = P.PROD_SKU
				INNER JOIN LGBRAND B ON P.BRAND_ID = B.BRAND_ID
ORDER BY V.VEND_NAME, B.BRAND_NAME

--18
SELECT E.EMP_NUM, E.EMP_LNAME, E.EMP_FNAME, SUM(I.INV_TOTAL)
FROM LGEMPLOYEE E INNER JOIN LGINVOICE I
ON E.EMP_NUM = I.EMPLOYEE_ID
WHERE I.INV_TOTAL IS NOT NULL
ORDER BY E.EMP_LNAME, E.EMP_FNAME

--19
SELECT AVG(PROD_PRICE)
FROM LGPRODUCT
WHERE PROD_PRICE = (SELECT MAX(PROD_PRICE)
					FROM LGPRODUCT
					)

--20
SELECT B.BRAND_ID, B.BRAND_NAME, B.BRAND_TYPE, AVG(PROD_PRICE)
FROM LGBRAND B INNER JOIN LGPRODUCT P
ON B.BRAND_ID = P.BRAND_ID
WHERE PROD_PRICE = (SELECT MAX(PROD_PRICE)
					FROM LGPRODUCT
					)

--21
SELECT EMP_FNAME + ' ' + EMP_LNAME, D.DEPT_NAME, D.DEPT_PHONE, EMP_FNAME + ' ' + EMP_LNAME, 
		CUST_FNAME + ' ' + CUST_LNAME, I.INV_DATE, I.INV_TOTAL
FROM LGDEPARTMENT D INNER JOIN LGEMPLOYEE E ON D.DEPT_NUM = E.DEPT_NUM
					INNER JOIN LGINVOICE I ON E.EMP_NUM = I.EMPLOYEE_ID
					INNER JOIN LGCUSTOMER C ON I.CUST_CODE = C.CUST_CODE
WHERE EMP_TITLE LIKE '%MANAGER' AND
		CUST_LNAME = 'HAGAN' AND 
		INV_DATE = '2011-MAY-18'