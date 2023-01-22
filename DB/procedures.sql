use project01;

DELIMITER $$

CREATE PROCEDURE IF NOT EXISTS insert_(IN NAME_ VARCHAR(216)) 
BEGIN
	INSERT INTO Department.dept_(name_) VALUE(NAME_);
END$$


DELIMITER $$

CREATE PROCEDURE IF NOT EXISTS delete_(IN NAME_p VARCHAR(216))
BEGIN
	DELETE FROM Department.dept_ WHERE name_ = NAME_p;

END$$


DELIMITER $$

CREATE PROCEDURE IF NOT EXISTS find_name(IN id_ int, OUT Name_p VARCHAR(216), OUT Date_created_ DATE)
BEGIN
	SELECT date_created,name_ into Date_created_,name_p FROM Department.dept_ WHERE id_ = id;
END$$

