INSERT INTO Departments (Name, Manger) VALUES
('IT Department', 'Ahmed Mahmoud'),
('Engineering Department', 'Mohamed Ali'),
('HR Department', 'Fatma Hassan'),
('Finance Department', 'Hassan Ibrahim'),
('Marketing Department', 'Aya Khalil'),
('Sales Department', 'Youssef Mansour'),
('Research and Development Department', 'Nour Ahmed'),
('Customer Service Department', 'Sara Hussein'),
('Quality Assurance Department', 'Aliya Mahmoud'),
('Operations Department', 'Omar Abdelrahman'),
('Legal Department', 'Laila Mostafa'),
('Production Department', 'Kareem Abdelaziz'),
('Supply Chain Department', 'Nadia Hassan'),
('Logistics Department', 'Tarek Youssef'),
('Purchasing Department', 'Salma Hamed'),
('Design Department', 'Rania Emad'),
('Architecture Department', 'Ahmed Nabil'),
('Education Department', 'Sara Said'),
('Healthcare Department', 'Hassan Farouk'),
('Consulting Department', 'Yara Magdy'),
('Information Security Department', 'Ahmed Gamal'),
('Cybersecurity Department', 'Hala Salah'),
('Media Department', 'Karim Mostafa'),
('Entertainment Department', 'Nourhan Mahmoud'),
('Fashion Department', 'Mayar Ahmed'),
('Hospitality Department', 'Mohamed Hisham'),
('Food and Beverage Department', 'Rania Samir'),
('Agriculture Department', 'Mahmoud Ali'),
('Real Estate Department', 'Youssef Hassan'),
('Construction Department', 'Sara Abdelrahman'),
('Telecommunications Department', 'Nourhan Tarek'),
('Transportation Department', 'Ahmed Youssef'),
('Energy Department', 'Omar Ahmed'),
('Environmental Department', 'Nadia Hesham'),
('Non-profit Department', 'Aliya Mohamed'),
('Government Department', 'Hassan Ibrahim'),
('Education Department', 'Laila Farouk'),
('Technology Department', 'Mohamed Samir'),
('Software Development Department', 'Aya Ahmed'),
('Hardware Development Department', 'Karim Mahmoud'),
('Mobile Development Department', 'Rania Ali'),
('Web Development Department', 'Ahmed Farouk'),
('Database Administration Department', 'Sara Mahmoud'),
('Cloud Computing Department', 'Hassan Ahmed'),
('Network Administration Department', 'Nadia Mohamed'),
('System Administration Department', 'Ahmed Ali'),
('Project Management Department', 'Nourhan Hisham'),
('Product Management Department', 'Youssef Mahmoud');


--================================================-
INSERT INTO Course (Name, Degree, MinDegree, CrsHours, DepartmentID) VALUES
('Introduction to Software Engineering', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Object-Oriented Programming with Java', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Web Development Fundamentals', 75, 55, 90, FLOOR(RAND() * 48) + 1),
('Database Design and Implementation', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Testing and Quality Assurance', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Mobile App Development with React Native', 85, 65, 115, FLOOR(RAND() * 48) + 1),
('Algorithm Design and Analysis', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Cybersecurity Fundamentals', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Cloud Computing Technologies', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Project Management', 80, 60, 100, FLOOR(RAND() * 48) + 1),
-- continue for the remaining courses
('Software Engineering for Mobile Devices', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Real-Time Systems', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Engineering for Embedded Systems', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Configuration Management', 75, 55, 95, FLOOR(RAND() * 48) + 1),
('Formal Methods in Software Engineering', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Empirical Software Engineering', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Model-Driven Engineering', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Software Engineering for Web Applications', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Mobile and Cloud Computing', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Reuse', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Reliability Engineering', 85, 65, 115, FLOOR(RAND() * 48) + 1),
('Formal Languages and Automata Theory', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Design and Architecture', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Software Metrics and Measurement', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Software Engineering Tools and Environments', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Software Quality Management', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Cost Estimation', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Performance Engineering', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Testing Techniques', 75, 55, 95, FLOOR(RAND() * 48) + 1),
('Software Verification and Validation', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Software Maintenance and Evolution', 85, 65, 120, FLOOR(RAND() * 48) + 1);


INSERT INTO Course (Name, Degree, MinDegree, CrsHours, DepartmentID) VALUES
('Software Engineering for IoT', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Secure Software Engineering', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Maintenance and Evolution', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Natural Language Processing', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Engineering for Cyber-Physical Systems', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Software Product Lines', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Software Development for Mobile Devices', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Real-Time Systems', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Engineering for Embedded Systems', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Configuration Management', 75, 55, 95, FLOOR(RAND() * 48) + 1),
('Formal Methods in Software Engineering', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Empirical Software Engineering', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Model-Driven Engineering', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Software Engineering for Web Applications', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Mobile and Cloud Computing', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Reuse', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Reliability Engineering', 85, 65, 115, FLOOR(RAND() * 48) + 1),
('Formal Languages and Automata Theory', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Design and Architecture', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Software Metrics and Measurement', 85, 65, 120, FLOOR(RAND() * 48) + 1),
('Software Engineering Tools and Environments', 90, 70, 130, FLOOR(RAND() * 48) + 1),
('Software Quality Management', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Cost Estimation', 85, 65, 110, FLOOR(RAND() * 48) + 1),
('Software Performance Engineering', 80, 60, 105, FLOOR(RAND() * 48) + 1),
('Software Testing Techniques', 75, 55, 95, FLOOR(RAND() * 48) + 1),
('Software Verification and Validation', 80, 60, 100, FLOOR(RAND() * 48) + 1),
('Software Maintenance and Evolution', 85, 65, 120, FLOOR(RAND() * 48) + 1);




--========================================================
INSERT INTO Trainees (Name, Address, Degree, DepartmentID, Image) VALUES
('Ahmed Mohamed', 'Cairo, Egypt', 80, 1, 'm_1.jpg'),
('Fatma Ali', 'Alexandria, Egypt', 85, 2, 'm_2.jpg'),
('Youssef Ibrahim', 'Luxor, Egypt', 90, 3, 'm_3.jpg'),
('Sara Hassan', 'Aswan, Egypt', 75, 4, 'm_4.jpg'),
('Ali Mahmoud', 'Giza, Egypt', 82, 5, 'm_5.jpg'),
('Mohamed Abdelaziz', 'Sharm El Sheikh, Egypt', 87, 6, 'm_6.jpg'),
('Elena Petrova', 'Moscow, Russia', 88, 7, 'm_7.jpg'),
('Juan Lopez', 'Madrid, Spain', 83, 8, 'm_1.jpg'),
('Amira Hassan', 'Beirut, Lebanon', 79, 9, 'm_2.jpg'),
('Hassan Ali', 'Karachi, Pakistan', 76, 10, 'm_3.jpg'),
('Lina Al-Masry', 'Damascus, Syria', 81, 11, 'm_4.jpg'),
('Ibrahim Ahmed', 'Khartoum, Sudan', 86, 12, 'm_5.jpg'),
('Nadia Haddad', 'Algiers, Algeria', 89, 13, 'm_6.jpg'),
('John Smith', 'New York, USA', 73, 14, 'm_7.jpg'),
('Emily Johnson', 'London, UK', 91, 15, 'm_1.jpg'),
('Amina Mohamed', 'Nairobi, Kenya', 77, 16, 'm_2.jpg'),
('Carlos Ruiz', 'Buenos Aires, Argentina', 92, 17, 'm_3.jpg'),
('Sophia Garcia', 'Mexico City, Mexico', 78, 18, 'm_4.jpg'),
('Mohammed Khan', 'Lahore, Pakistan', 84, 19, 'm_5.jpg'),
('Habiba Said', 'Cairo, Egypt', 80, 20, 'm_6.jpg'),
('Maria Antoniou', 'Athens, Greece', 90, 22, 'm_1.jpg'),
('Ahmed Amir', 'Baghdad, Iraq', 75, 23, 'm_2.jpg'),
('Anna Kuznetsova', 'St. Petersburg, Russia', 82, 24, 'm_3.jpg'),
('Yusuf Khan', 'Mumbai, India', 87, 25, 'm_4.jpg'),
('Chen Wei', 'Shanghai, China', 88, 26, 'm_5.jpg'),
('Nadia Ali', 'Tehran, Iran', 83, 27, 'm_6.jpg'),
('Luis Hernandez', 'Caracas, Venezuela', 89, 28, 'm_7.jpg'),
('Aya Naguib', 'Cairo, Egypt', 91, 29, 'm_1.jpg'),
('Hassan Al-Farsi', 'Riyadh, Saudi Arabia', 79, 30, 'm_2.jpg'),
('Katya Ivanova', 'Moscow, Russia', 76, 31, 'm_3.jpg'),
('Yunus Demir', 'Istanbul, Turkey', 81, 32, 'm_4.jpg'),
('Fatima Al-Said', 'Amman, Jordan', 86, 33, 'm_5.jpg'),
('Jose Martinez', 'Barcelona, Spain', 92, 34, 'm_6.jpg'),
('Rania Mahmoud', 'Cairo, Egypt', 73, 35, 'm_7.jpg'),
('Mark Johnson', 'Sydney, Australia', 85, 36, 'm_1.jpg'),
('Amina Abadi', 'Casablanca, Morocco', 80, 37, 'm_2.jpg'),
('Ali Hassan', 'Kuwait City, Kuwait', 89, 38, 'm_3.jpg'),
('Laura Rodriguez', 'Bogota, Colombia', 77, 39, 'm_4.jpg'),
('Mohammed Abdel-Rahman', 'Cairo, Egypt', 84, 40, 'm_5.jpg'),
('Jasmine Lee', 'Seoul, South Korea', 91, 41, 'm_6.jpg'),
('Vladimir Petrov', 'St. Petersburg, Russia', 78, 42, 'm_7.jpg'),
('Ramy Ahmed', 'Cairo, Egypt', 86, 43, 'm_1.jpg'),
('Julia Kim', 'Tokyo, Japan', 92, 44, 'm_2.jpg'),
('Yassin Moussa', 'Algiers, Algeria', 75, 45, 'm_3.jpg'),
('Karim Nassar', 'Beirut, Lebanon', 83, 46, 'm_4.jpg'),
('Helena Costa', 'Lisbon, Portugal', 87, 47, 'm_5.jpg'),
('Khaled Abdel-Aziz', 'Cairo, Egypt', 90, 48, 'm_6.jpg'),
('Maria Garcia', 'Madrid, Spain', 80, 1, 'm_1.jpg'),
('Mohammed Ahmed', 'Cairo, Egypt', 85, 2, 'm_2.jpg'),
('Jamil Ali', 'Baghdad, Iraq', 90, 3, 'm_3.jpg'),
('Lara Khalil', 'Beirut, Lebanon', 75, 4, 'm_4.jpg'),
('David Johnson', 'New York, USA', 82, 5, 'm_5.jpg'),
('Yara Said', 'Damascus, Syria', 87, 6, 'm_6.jpg'),
('Mikhail Ivanov', 'Moscow, Russia', 78, 7, 'm_7.jpg'),
('Amr Abdel-Rahman', 'Cairo, Egypt', 83, 8, 'm_1.jpg'),
('Nour Abdullah', 'Riyadh, Saudi Arabia', 79, 9, 'm_2.jpg'),
('Selma Ates', 'Istanbul, Turkey', 76, 10, 'm_3.jpg'),
('Pablo Sanchez', 'Buenos Aires, Argentina', 81, 11, 'm_4.jpg'),
('Layla Hassan', 'Tehran, Iran', 86, 12, 'm_5.jpg'),
('Rafael Garcia', 'Mexico City, Mexico', 89, 13, 'm_6.jpg'),
('Giovanni Rossi', 'Rome, Italy', 73, 14, 'm_7.jpg'),
('Sophia Georgiou', 'Athens, Greece', 91, 15, 'm_1.jpg'),
('Omar Al-Masri', 'Gaza City, Palestine', 77, 16, 'm_2.jpg'),
('Leila Ahmed', 'Cairo, Egypt', 92, 17, 'm_3.jpg'),
('Ali Al-Farsi', 'Muscat, Oman', 78, 18, 'm_4.jpg'),
('Aya Khaled', 'Cairo, Egypt', 84, 19, 'm_5.jpg'),
('Daniel Lee', 'Seoul, South Korea', 80, 20, 'm_6.jpg'),
('Sofia Oliveira', 'Rio de Janeiro, Brazil', 85, 21, 'm_7.jpg'),
('Omar Said', 'Cairo, Egypt', 90, 22, 'm_1.jpg'),
('Yara Ibrahim', 'Tripoli, Libya', 75, 23, 'm_2.jpg'),
('Amr Abdallah', 'Alexandria, Egypt', 82, 24, 'm_3.jpg'),
('Fatima Zainab', 'Cairo, Egypt', 87, 25, 'm_4.jpg'),
('Ricardo Santos', 'Sao Paulo, Brazil', 88, 26, 'm_5.jpg'),
('Hassan Ali', 'Cairo, Egypt', 83, 27, 'm_6.jpg'),
('Leila Amin', 'Cairo, Egypt', 89, 28, 'm_7.jpg'),
('Elena Markova', 'Moscow, Russia', 91, 29, 'm_1.jpg'),
('Mohammed Abdul-Hadi', 'Cairo, Egypt', 79, 30, 'm_2.jpg'),
('Mariam Khalifa', 'Dubai, UAE', 76, 31, 'm_3.jpg'),
('Cristina Garcia', 'Madrid, Spain', 81, 32, 'm_4.jpg'),
('Khaled Al-Masri', 'Aleppo, Syria', 86, 33, 'm_5.jpg'),
('Nadia Rizk', 'Cairo, Egypt', 92, 34, 'm_6.jpg'),
('Emad Nassar', 'Gaza City, Palestine', 73, 35, 'm_7.jpg'),
('Maria Papadopoulos', 'Athens, Greece', 85, 36, 'm_1.jpg'),
('Omar Ibrahim', 'Cairo, Egypt', 80, 37, 'm_2.jpg'),
('Yasmin Ali', 'Alexandria, Egypt', 89, 38, 'm_3.jpg'),
('Hassan Ahmed', 'Cairo, Egypt', 77, 39, 'm_4.jpg'),
('Mona El-Sayed', 'Luxor, Egypt', 84, 40, 'm_5.jpg'),
('Carlos Fernandez', 'Bogota, Colombia', 91, 41, 'm_6.jpg'),
('Sophie Laurent', 'Paris, France', 78, 42, 'm_7.jpg'),
('Layla Khalil', 'Cairo, Egypt', 86, 43, 'm_1.jpg'),
('Omar Al-Din', 'Cairo, Egypt', 92, 44, 'm_2.jpg'),
('Yara Hamed', 'Alexandria, Egypt', 75, 45, 'm_3.jpg'),
('Daniel Rodriguez', 'Barcelona, Spain', 83, 46, 'm_4.jpg'),
('Sofia Costa', 'Lisbon, Portugal', 87, 47, 'm_5.jpg'),
('Khalid Al-Awad', 'Cairo, Egypt', 90, 48, 'm_6.jpg');



ALTER TABLE Instructors
DROP COLUMN crs_id
--=======================================================
INSERT INTO Instructors (Name, Address, Salary, CourseID, DepartmentID, Image)
VALUES
('Ahmed Smith', 'New York, USA', 5000, 1, 1, '1.jpg'),
('Emily Johnson', 'Los Angeles, USA', 5500, 2, 2, '2.jpg'),
('Mohamed Brown', 'Cairo, Egypt', 4500, 3, 3, '3.jpg'),
('Olivia Davis', 'Alexandria, Egypt', 4800, 4, 4, '4.jpg'),
('Amir Williams', 'Luxor, Egypt', 5200, 5, 5, '5.jpg'),
('Liam Jones', 'Aswan, Egypt', 4900, 6, 6, '6.jpg'),
('Sophia Garcia', 'Giza, Egypt', 5100, 7, 7, '7.jpg'),
('Emma Martinez', 'Sharm El Sheikh, Egypt', 5300, 8, 8, '8.jpg'),
('Noah Robinson', 'Hurghada, Egypt', 4600, 9, 9, '9.jpg'),
('Isabella Young', 'Marsa Alam, Egypt', 4700, 10, 10, '10.jpg'),
('Logan Lee', 'Dahab, Egypt', 5400, 11, 11, '1.jpg'),
('Mia Turner', 'El Gouna, Egypt', 4900, 12, 12, '2.jpg'),
('James Moore', 'Suez, Egypt', 5000, 13, 13, '3.jpg'),
('Charlotte Hill', 'Ismailia, Egypt', 4800, 14, 14, '4.jpg'),
('Elijah King', 'Fayoum, Egypt', 4700, 15, 15, '5.jpg'),
('Amelia Scott', 'Beni Suef, Egypt', 5200, 16, 16, '6.jpg'),
('Aiden Green', 'Minya, Egypt', 5100, 17, 17, '7.jpg'),
('Avery Perez', 'Assiut, Egypt', 4600, 18, 18, '8.jpg'),
('Evelyn Hall', 'Sohag, Egypt', 5300, 19, 19, '9.jpg'),
('Alexander Adams', 'Qena, Egypt', 4500, 20, 20, '10.jpg'),
('Mason Campbell', 'Luxor, Egypt', 4700, 21, 21, '1.jpg'),
('Harper Mitchell', 'Aswan, Egypt', 5200, 22, 22, '2.jpg'),
('Scarlett Roberts', 'Giza, Egypt', 5100, 23, 23, '3.jpg'),
('Sebastian Carter', 'Cairo, Egypt', 5000, 24, 24, '4.jpg'),
('Ella Foster', 'Alexandria, Egypt', 4900, 25, 25, '5.jpg'),
('Jack Gray', 'Luxor, Egypt', 5400, 26, 26, '6.jpg'),
('Lily Evans', 'Aswan, Egypt', 4800, 27, 27, '7.jpg'),
('Grayson Diaz', 'Giza, Egypt', 4600, 28, 28, '8.jpg'),
('Chloe Stewart', 'Cairo, Egypt', 4700, 29, 29, '9.jpg'),
('Daniel Rogers', 'Alexandria, Egypt', 5100, 30, 30, '10.jpg'),
('Zoey Hayes', 'Luxor, Egypt', 4900, 31, 31, '1.jpg'),
('Carter Rivera', 'Aswan, Egypt', 5000, 32, 32, '2.jpg'),
('Penelope Russell', 'Giza, Egypt', 5200, 33, 33, '3.jpg'),
('Luke Collins', 'Cairo, Egypt', 5300, 34, 34, '4.jpg'),
('Hannah Bell', 'Alexandria, Egypt', 4600, 35, 35, '5.jpg'),
('Michael Ward', 'Luxor, Egypt', 4800, 36, 36, '6.jpg'),
('Leah Bryant', 'Aswan, Egypt', 5100, 37, 37, '7.jpg'),
('William Long', 'Giza, Egypt', 4700, 38, 38, '8.jpg'),
('Grace Watson', 'Cairo, Egypt', 4900, 39, 39, '9.jpg'),
('Henry Ramirez', 'Alexandria, Egypt', 5000, 40, 40, '10.jpg'),
('Nora Foster', 'Luxor, Egypt', 4600, 41, 41, '1.jpg'),
('Jackson Reed', 'Aswan, Egypt', 5200, 42, 42, '2.jpg'),
('Aria Coleman', 'Giza, Egypt', 4700, 43, 43, '3.jpg'),
('Owen Hughes', 'Cairo, Egypt', 4800, 44, 44, '4.jpg'),
('Layla Patterson', 'Alexandria, Egypt', 5100, 45, 45, '5.jpg'),
('Wyatt Bryant', 'Luxor, Egypt', 5300, 46, 46, '6.jpg'),
('Nova Warren', 'Aswan, Egypt', 4900, 47, 47, '7.jpg'),
('Christian Griffin', 'Giza, Egypt', 5000, 48, 48, '8.jpg'),
('Elizabeth Gray', 'Cairo, Egypt', 5400, 1, 1, '9.jpg'),
('Lucas Lopez', 'Los Angeles, USA', 4700, 2, 2, '10.jpg'),
('Alyssa Mitchell', 'Cairo, Egypt', 5100, 3, 3, '1.jpg'),
('Aidan Perez', 'New York, USA', 5000, 4, 4, '2.jpg'),
('Natalie James', 'Cairo, Egypt', 4900, 5, 5, '3.jpg'),
('Gabriel Thompson', 'Los Angeles, USA', 5300, 6, 6, '4.jpg'),
('Zoe Diaz', 'Cairo, Egypt', 4800, 7, 7, '5.jpg'),
('Christopher Harris', 'New York, USA', 5400, 8, 8, '6.jpg'),
('Ava Watson', 'Cairo, Egypt', 5000, 9, 9, '7.jpg'),
('Adrian Mitchell', 'Los Angeles, USA', 4700, 10, 10, '8.jpg'),
('Samantha Martinez', 'Cairo, Egypt', 5200, 11, 11, '9.jpg'),
('Jonathan Turner', 'New York, USA', 5100, 12, 12, '10.jpg'),
('Madison Rodriguez', 'Cairo, Egypt', 4600, 13, 13, '1.jpg'),
('Nicholas Carter', 'Los Angeles, USA', 4900, 14, 14, '2.jpg'),
('Avery Morgan', 'Cairo, Egypt', 4800, 15, 15, '3.jpg'),
('Brooklyn Powell', 'New York, USA', 4700, 16, 16, '4.jpg'),
('Evan Coleman', 'Cairo, Egypt', 5200, 17, 17, '5.jpg'),
('Nevaeh Wood', 'Los Angeles, USA', 5300, 18, 18, '6.jpg'),
('Justin Rivera', 'Cairo, Egypt', 5400, 19, 19, '7.jpg'),
('Kylie Reed', 'New York, USA', 4600, 20, 20, '8.jpg'),
('Caleb Howard', 'Cairo, Egypt', 5000, 21, 21, '9.jpg'),
('Haley Perez', 'Los Angeles, USA', 4900, 22, 22, '10.jpg'),
('Kevin Mitchell', 'Cairo, Egypt', 4800, 23, 23, '1.jpg'),
('Lillian Turner', 'New York, USA', 5300, 24, 24, '2.jpg'),
('Gavin Bell', 'Cairo, Egypt', 5100, 25, 25, '3.jpg'),
('Faith Davis', 'Los Angeles, USA', 5200, 26, 26, '4.jpg'),
('Jordan Rodriguez', 'Cairo, Egypt', 5000, 27, 27, '5.jpg'),
('Trinity King', 'New York, USA', 5400, 28, 28, '6.jpg'),
('Blake Howard', 'Cairo, Egypt', 4700, 29, 29, '7.jpg'),
('Aubrey Gonzalez', 'Los Angeles, USA', 4800, 30, 30, '8.jpg'),
('Robert Ramirez', 'Cairo, Egypt', 4900, 31, 31, '9.jpg'),
('Maya Torres', 'New York, USA', 4600, 32, 32, '10.jpg'),
('Coleman Peterson', 'Cairo, Egypt', 5100, 33, 33, '1.jpg'),
('Brianna James', 'Los Angeles, USA', 5300, 34, 34, '2.jpg'),
('Carson Foster', 'Cairo, Egypt', 5200, 35, 35, '3.jpg'),
('Savannah Griffin', 'New York, USA', 4800, 36, 36, '4.jpg'),
('Nolan Rivera', 'Cairo, Egypt', 4700, 37, 37, '5.jpg'),
('Reagan Watson', 'Los Angeles, USA', 4900, 38, 38, '6.jpg'),
('Giovanni Bryant', 'Cairo, Egypt', 5000, 39, 39, '7.jpg'),
('Jocelyn Bell', 'New York, USA', 5100, 40, 40, '8.jpg'),
('Eliana Scott', 'Cairo, Egypt', 5400, 41, 41, '9.jpg'),
('Nicolas Hayes', 'Los Angeles, USA', 4600, 42, 42, '10.jpg'),
('Annabelle Foster', 'Cairo, Egypt', 4700, 43, 43, '1.jpg'),
('Emmett Rivera', 'New York, USA', 5300, 44, 44, '2.jpg'),
('Hailey Bryant', 'Cairo, Egypt', 5200, 45, 45, '3.jpg'),
('William Hayes', 'Los Angeles, USA', 4900, 46, 46, '4.jpg'),
('Penelope Russell', 'Cairo, Egypt', 4800, 47, 47, '5.jpg'),
('Grayson Diaz', 'New York, USA', 5100, 48, 48, '6.jpg');

--===========================================================
INSERT INTO CrsResults (Degree, CourseID, TraineeID)
VALUES
(71, 1, 50),
(80, 2, 51),
(92, 3, 52),
(77, 4, 53),
(84, 5, 54),
(94, 6, 55),
(76, 7, 56),
(89, 8, 57),
(66, 9, 58),
(81, 10, 59),
(90, 11, 60),
(83, 12, 61),
(68, 13, 62),
(74, 14, 63),
(95, 15, 64),
(69, 16, 65),
(96, 17, 66),
(62, 18, 67),
(97, 19, 68),
(57, 20, 69),
(98, 21, 70),
(59, 22, 71),
(99, 23, 72),
(60, 24, 73),
(100, 25, 74),
(63, 26, 75),
(54, 27, 76),
(101, 28, 77),
(56, 29, 78),
(102, 30, 79),
(55, 31, 80),
(103, 32, 81),
(58, 33, 82),
(104, 34, 83),
(53, 35, 84),
(105, 36, 85),
(52, 37, 86),
(106, 38, 87),
(49, 39, 88),
(107, 40, 89),
(48, 41, 90),
(108, 42, 91),
(47, 43, 92),
(109, 44, 93),
(46, 45, 94),
(110, 46, 95),
(45, 47, 96),
(111, 48, 97),
(44, 49, 98),
(112, 50, 99),
(43, 51, 100),
(113, 52, 101),
(42, 53, 102),
(114, 54, 103),
(41, 55, 104),
(115, 56, 105),
(40, 57, 106),
(116, 58, 107),
(39, 1, 108),
(117, 2, 109),
(38, 3, 110),
(118, 4, 111),
(37, 5, 112),
(119, 6, 113),
(36, 7, 114),
(120, 8, 115),
(35, 9, 116),
(121, 10, 117),
(34, 11, 118),
(122, 12, 119),
(33, 13, 120),
(123, 14, 121),
(32, 15, 122),
(124, 16, 123),
(31, 17, 124),
(125, 18, 125),
(30, 19, 126),
(126, 20, 127),
(29, 21, 128),
(127, 22, 129),
(28, 23, 130),
(128, 24, 131),
(27, 25, 132),
(129, 26, 133),
(26, 27, 134),
(130, 28, 135),
(25, 29, 136),
(131, 30, 137),
(24, 31, 138),
(132, 32, 139),
(23, 33, 140),
(133, 34, 141),
(22, 35, 142),
(134, 36, 143),
(21, 37, 144),
(135, 38, 135),
(20, 39, 136),
(136, 40, 137),
(19, 41, 138),
(137, 42, 139),
(18, 43, 130),
(138, 44, 141),
(17, 45, 132),
(139, 46, 133),
(16, 47, 134),
(140, 48, 135),
(15, 49, 136),
(141, 50, 137),
(14, 51, 138),
(142, 52, 139),
(13, 53, 140),
(143, 54, 141),
(12, 55, 142),
(144, 56, 143),
(11, 57, 144),
(145, 58, 144);


--===========================================================

select * from Departments

select * from Course