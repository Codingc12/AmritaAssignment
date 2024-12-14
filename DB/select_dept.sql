USE project01;
DROP PROCEDURE IF EXISTS select_dept;
DELIMITER $$
CREATE PROCEDURE select_dept(IN DEPT_NAME_ VARCHAR(216))

BEGIN
	
    DECLARE DEPT_ID INT DEFAULT 0;
    DECLARE DEPT_NAME VARCHAR(216) DEFAULT '';
    DECLARE DATE_CREATED DATE DEFAULT CURDATE();
	SELECT name_,id,date_created INTO DEPT_NAME, DEPT_ID, DATE_CREATED FROM Department.dept_ where name_ = DEPT_NAME_;
    
    SELECT DEPT_NAME,DATE_CREATED,DEPT_ID;
END

$$
